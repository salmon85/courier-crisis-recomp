# Courier Crisis port — issue status

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [x] Main-menu selection forcing Start — fixed by the same BIOS C0 table fix
- [x] Pause menu — confirmed not broken; no pause-menu changes needed
- [x] In-level stopwatch frozen at ~2.70 s / never starts after restart
- [x] Draw-buffer deadlock during rapid menu transitions (`func_80012928`)
- [x] "Camera" flashing to other angles during a level
- [ ] Music

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
