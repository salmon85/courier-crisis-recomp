# Courier Crisis (PS1) — RecompOne port

A static recompilation of **Courier Crisis (USA, SLUS-00442)** into C# using
[RecompOne](https://github.com/BlackLabelHQ/RecompOne), plus the runtime fixes
needed to make the game actually reach and run gameplay.

## Requirements

- .NET 10 SDK (the port targets `net10.0`)
- Your own copy of `Courier Crisis (USA).bin` / `.cue`
- `RecompOne` checked out next to this folder (`../RecompOne`)

## Layout

```
CourierCrisisPort/
  config/
    Courier_Crisis.json       recompiler configuration
    funcmaps/                 generated function maps (main + GAME.EXE overlay)
  generated/                  recompiled C# (derived from the disc; do not commit)
  Program.cs                  entry point
  CourierCrisis.csproj        references RecompOne.Runtime
```

The boot executable (`SLUS_004.42`) is recompiled as the `main` image and
`GAME.EXE` (loaded with `LoadExec`) as the `game` overlay.

## Recompiling

```bash
export DOTNET_ROOT=/path/to/dotnet10
export PATH="$DOTNET_ROOT:$PATH"

dotnet build RecompOne/RecompOne.Recompiler/RecompOne.Recompiler.csproj -c Release
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis.json
```

## Building and running

```bash
cd CourierCrisisPort
dotnet build CourierCrisis.csproj -c Release
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/Courier Crisis (USA).cue"
```

The game plays the boot logo and intro movie, then loads `GAME.EXE` and runs
the frontend/demo. `--direct` boots `GAME.EXE` immediately (skipping the intro)
for faster iteration:

```bash
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/game.cue" --direct
```

## Runtime fixes

The following changes were required in RecompOne (`../RecompOne`). They are
generic fixes, not game-specific hacks beyond the pad-buffer layout:

1. **Digital pad buffer size** (`RecompOne.Runtime/Bios/BiosB.cs`)
   `PadRead` always wrote four analog-stick bytes after the 4-byte button word.
   Courier Crisis stores its IntRP chain node immediately after its 4-byte PAD
   buffer, so the extra bytes corrupted the interrupt chain. The analog bytes
   are now only written when the configured pad is actually analog.

2. **DrawSync completion callback** (`RecompOne.Recompiler/CodeGen/SdkPatches.cs`,
   `RecompOne.Runtime/sdk/LibGpu.cs`)
   `DrawSyncCallback` is now HLE'd, and the registered callback is invoked when
   GPU work completes (`DrawOTag`/`DrawPrim`) and on `DrawSync(0)`. Courier
   Crisis uses this callback to release its double-buffered draw buffers; without
   it the game spins forever waiting for a free buffer.

3. **BIOS C0 table / memory card cleanup** (`RecompOne.Runtime/Bios/BiosB.cs`)
   `B0(0x56)` (`GetC0Table`) was returning zero. PsyQ libcard's `_ExitCard`
   dereferences `C0Table[6]` (the exception handler) and patches its card hook,
   so saving crashed while writing through a null-derived pointer. The runtime
   now provides the real low-RAM C0 layout at `0x674` and a writable stand-in
   exception handler at `0xC80`.

4. Both PAD ports are configured as `PadKind.Digital` in `Program.cs`, matching
   the era of the game.

5. **SPU IRQ / SpuSt streaming** (`RecompOne.Runtime/Hardware/Spu.cs`)
   The SPU now models the IRQ address register (`0x1F801DA4`), the SPUSTAT
   IRQ-pending bit, and IRQ9 generation when a voice reads ADPCM data at the
   IRQ address. Courier Crisis's CD music uses the libspu `SpuSt` streaming
   engine, which parks in SpuSt state `0x32` after the first priming transfer
   without this interrupt; `SpuStTransfer` never re-points the voices at the
   two 24-block RAM rings. With the IRQ in place the engine refills the SPU
   buffers from the rings and music plays.

6. **CD streaming state across `LoadExec`** (`RecompOne.Runtime/sdk/LibCd.cs`)
   The boot executable uses libcd's stream ring (`StSetRing`/`StSetStream`) for
   the intro movie and never tears it down before loading `GAME.EXE`. Because
   the runtime's `LibCdStream` state is global, the music module's later `ReadS`
   was being intercepted by the still-active movie stream, so the CD-ready
   callback (`func_80081B54`) never ran and the music ring stayed empty.
   `LibCd.Detach` now resets the stream state when a new executable is loaded.

7. **CD per-sector data callbacks / stream pacing** (`RecompOne.Runtime/sdk/LibCd.cs`)
   When a ready callback registers a data callback and consumes the sector with
   `CdGetSector` (as Courier Crisis's music module does), the data callback is
   now delivered for that same sector before the position advances. Without
   this, the ring producer pointer (`stream+8`) fell behind the DMA consumer
   pointer (`stream+0xC`) and the SpuSt engine replayed stale blocks. The
   ready-only pump also delivers several sectors per frame instead of one, so
   the 24-block music rings stay full at 30–60 fps.

`config/Courier_Crisis_debug.json` is a diagnostic variant that emits a
per-function trace; expect it to run much slower and produce a large log.

The runtime fixes are also saved as `RecompOne-runtime-fixes.patch` so they can
be re-applied if RecompOne is updated or re-cloned.

## Known issues

- The in-level stopwatch can stop after ~2.7 seconds (the display freezes while
  the game keeps running). The same freeze is visible in attract/demo races, so
  it is not tied to saved progress.
- Some frontend selections (e.g. the BACK option) can start a level instead of
  returning to the previous screen. The state dispatch table and the pad button
  mapping have been verified as intact; the remaining cause is in the frontend
  state logic.
- The on-screen target arrow can point the wrong way until the player moves;
  distant targets are worse. This appears to be in the same frontend/gameplay
  state logic.
- A draw-buffer wait can deadlock during rapid menu transitions (the game waits
  in `func_80012928` for a buffer that was acquired but never submitted).
- Loading the results screen after finishing a level is slow.

## Notes

- `generated/` contains code derived from the game disc. Regenerate it from your
  own disc; do not redistribute it.
- The port uses RecompOne's OpenGL backend. On headless machines use
  `SDL_VIDEODRIVER=dummy` only for smoke tests; screenshots require a real or
  virtual X display.
