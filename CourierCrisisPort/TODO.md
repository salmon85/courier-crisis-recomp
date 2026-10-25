# Courier Crisis port — issue status

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [x] Main-menu selection forcing Start — fixed by the same BIOS C0 table fix
- [x] Pause menu — confirmed not broken; no pause-menu changes needed
- [x] In-level stopwatch frozen at ~2.70 s / never starts after restart
- [x] Draw-buffer deadlock during rapid menu transitions (`func_80012928`)
- [x] "Camera" flashing to other angles during a level
- [x] Music

## Camera flashing

The flash was not the camera: the display was being flipped to a stale
framebuffer. The draw-buffer deadlock workaround pumped `func_80075CEC`
(which calls `PutDispEnv`) every 4096 spins, which fires during normal
one-frame waits as well. It now only steps in after 250 ms of continuous
waiting, so normal frames never flip the display. Verified with 60 fps
captures: no repeated/frozen frames.

## Music — current findings

- No CD-DA tracks in the image (single data track) and every sector is
  Mode2/Form1 data (submode 0x08), so the runtime XA decoder is not the
  path this game uses.
- The frontend and level currently play only SPU-voice effects/engine
  (14 voices, steady ~79 Hz engine tone); no music.
- The game's music module requests track 114 through `func_8008217C`,
  initialises the CD player (`func_800810C4`, Setmode 0x80) and issues
  ReadS at LBA 40915 (inside `COURIER/MUSIC1/BIGDRI08.BIN`).
- However its state word at `0x800B58F0` is 0 at every sample; it never
  reaches the streaming states, so no music data is consumed or sent to
  the SPU. Next step is to find what resets the state immediately after
  `func_800810C4` sets it to 1 (candidates: the per-frame music update
  `func_80081A8C`, `func_8007FAF0`, or the CD data-ready/ready callback
  ordering in `func_80081B54`).

## Music — progress after the sector-delivery fix (`RecompOne ad75b89`)

- The music module now reaches state 4 and its reader is serviced (46 sector
  reads vs 10 before), but the track position still does not advance and no
  music reaches the SPU yet.
- Remaining lead: the per-sector data callback (`func_80081E28` at 0x80081E28)
  still is not advancing the ring (`func_80081080`), so the stream stays at
  LBA 40915. Also verify whether the boss speech uses the same ring.

## Music — resolved

The missing consumer was the libspu `SpuSt` streaming engine at `0x80092xxx`,
not a recompilation gap. It starts from `func_80080C04` → `func_800809B8` →
`SpuStTransfer(4, 3)`, sends two `0x400`-byte priming blocks from the buffer at
`GP[0x308]`, then parks in SpuSt state `0x32` waiting for the SPU IRQ.

The runtime did not emulate the SPU IRQ:

- the IRQ address register (`0x1F801DA4`) was ignored,
- the IRQ-pending bit in SPUSTAT (`0x1F801DAE` bit 6) was masked out,
- nothing raised IRQ9 when a voice read ADPCM data at the IRQ address.

Therefore `func_80092558` (the IRQ refill handler) never ran, `func_800803E8`
never re-pointed the voices at the RAM rings, and `_spu_t(3, ...)` never issued
another DMA. The CD reader kept filling the ring read side while the DMA side
stayed on block 0.

`RecompOne.Runtime/Hardware/Spu.cs` now stores the IRQ address, tracks the
pending flag, and raises IRQ9 when a voice's current ADPCM address reaches the
IRQ address. Verified with the rolling demo: the demo starts (`GP[0x300] == 2`),
music state reaches 3/4, `ch4` DMA fetches every `0x400`-byte block from the two
`0xC000` rings, the SPU music buffer contents change continuously, and the music
voices run in ADSR Sustain at full volume.

A second runtime issue only appears on the normal boot path (intro movie, then
`LoadExec` of `GAME.EXE`). The boot executable uses libcd's stream ring
(`StSetRing`/`StSetStream`) for the movie and does not tear it down before
`LoadExec`. `LibCdStream` state is global, so the music module's `ReadS` was
intercepted by the still-active movie stream: `GP[0x300]` reached 2 and the
music state reached 3, but the CD-ready callback `func_80081B54` never ran, the
ring write pointer stayed 0, and the SPU played only the priming block.
`LibCd.Detach` now calls `LibCdStream.Reset()` when a new executable is loaded.

The initial stereo stream still had a rapid repeating stutter (the two ring
pointers drifting apart). The music module's ready callback registers a
per-sector `CdDataCallback` and consumes the sector with `CdGetSector`; the
ready-only pump did not deliver that data callback for the same sector, so the
producer pointer (`stream+8`) lagged the DMA consumer pointer (`stream+0xC`),
and SpuSt replayed stale blocks. `LibCd.PumpReady` now delivers the data
callback before advancing the position, and pumps several sectors per frame
instead of one. With this, the ring occupancy stays near full (22–23 of 24
blocks) and the captured music no longer contains repeated 40 ms blocks.


Two address corrections:

- The music stream state is `0x800AA710` (`0x800B0000 - 0x58F0`), not
  `0x800B58F0`.
- The S_PLAY store is at `0x80081C54` inside `func_80081B54`; `0x80081C48` is
  the instruction `sll v0, v0, 4`, not a function entry.

## Europe disc support

- [x] Boot the EU executable (`SLES_003.26`) and `GAME.EXE`
- [x] Extra BMG logo FMV and language selector
- [x] Draw-buffer wait at the EU address
- [x] Frontend music selection: USA playlist by default, EU playlist with `--EU`
- [x] EU recompiled code and dispatch tables coexist with the USA build

The EU build uses `config/funcmaps/eu/` and `config/Courier_Crisis_EU.json`.
`mainOverlay` keeps the EU dispatch tables (`main_eu`/`game_eu`) separate from
the USA tables (`main`/`game`).

## EU attract-demo crash

- [ ] EU demo 7 (roughly USA demo 3) can crash after several minutes.
- The EU build runs at 50 Hz; the recorded demo inputs desync from the USA
  sequence (EU demo 2 has no USA equivalent, EU demo 3 is USA demo 2). The
  desynced demo corrupts the audio voice list and then faults while walking it.
- Starting a game before the attract loop reaches that demo avoids it.
