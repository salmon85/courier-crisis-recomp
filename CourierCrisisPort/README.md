# Courier Crisis (PS1) — RecompOne port

A static recompilation of **Courier Crisis (USA, SLUS-00442)** and **Courier
Crisis (Europe, SLES-00326)** into C# using
[RecompOne](https://github.com/BlackLabelHQ/RecompOne), plus the runtime fixes
needed to make the game actually reach and run gameplay.

## Requirements

- .NET 10 SDK (the port targets `net10.0`)
- Your own copy of either `Courier Crisis (USA).bin` / `.cue` or
  `Courier Crisis - The Saga of the Modern Fatalist (Europe) (En,Fr,De,It).bin`
  / `.cue`
- `RecompOne` initialized as a submodule next to this folder (`../RecompOne`):
  `git submodule update --init --recursive` from the repository root

## Layout

```
CourierCrisisPort/
  config/
    Courier_Crisis.json       USA recompiler configuration
    Courier_Crisis_EU.json    Europe recompiler configuration
    funcmaps/                 USA function maps (main + GAME.EXE overlay)
    funcmaps/eu/              Europe function maps (main + GAME.EXE overlay)
  generated/                  recompiled C# (derived from the disc; do not commit)
  generated/eu/               recompiled Europe C# (do not commit)
  BootEntry.cs                region detection and boot loader
  Patches.cs                  draw-buffer wait and music-selection glue
  Program.cs                  entry point
  CourierCrisis.csproj        references RecompOne.Runtime
```

The boot executable is recompiled as the main image and `GAME.EXE` (loaded with
`LoadExec`) as the overlay. The USA and EU builds use different class names and
dispatch tables, so both can be compiled into the same executable.

## Recompiling

```bash
export DOTNET_ROOT=/path/to/dotnet10
export PATH="$DOTNET_ROOT:$PATH"

dotnet build RecompOne/RecompOne.Recompiler/RecompOne.Recompiler.csproj -c Release

# USA
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis.json

# Europe
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis_EU.json
```

Generate only the region(s) whose discs you own. The project checks for
`generated/main.cs` and `generated/eu/main_eu.cs` and enables the matching
region at compile time.

## Building and running

```bash
cd CourierCrisisPort
dotnet build CourierCrisis.csproj -c Release
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/Courier Crisis (USA).cue"
dotnet bin/Release/net10.0/CourierCrisis.dll \
    "/path/to/Courier Crisis - The Saga of the Modern Fatalist (Europe) (En,Fr,De,It).cue"
```

The region is detected from `SYSTEM.CNF`, so either cue can be passed to the
same build. The game plays the boot logo and intro movie(s), then loads
`GAME.EXE` and runs the frontend/demo.

`--direct` boots `GAME.EXE` immediately (skipping the intro) for faster
iteration:

```bash
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/game.cue" --direct
```

### Europe

The EU version adds an extra BMG logo FMV before the usual intro and shows a
language selector before the main menu. Both are part of the recompiled EU
executable and work normally.

The EU disc also ships a different frontend music selection. By default the port
uses the **USA music selection for both regions**, so the EU frontend plays the
same track as the USA version (using the EU disc's copy of that file). Pass
`--EU` to use the **EU music selection for both regions** instead:

```bash
# USA track selection (default), even with the EU disc
dotnet bin/Release/net10.0/CourierCrisis.dll "Courier Crisis ... (Europe).cue"

# EU track selection, with either disc
dotnet bin/Release/net10.0/CourierCrisis.dll "Courier Crisis ... (Europe).cue" --EU
dotnet bin/Release/net10.0/CourierCrisis.dll "Courier Crisis (USA).cue" --EU
```

In-level music already uses the same track list in both versions; the switched
selection is the frontend playlist.

### Demo timing / physics scale

The EU build keeps PAL video mode (so the picture is not cropped) but runs the
game at 60 Hz. The PAL executable stores a 1.2x (16.16 fixed-point) movement
scale in its level parameters; at 60 Hz that makes the recorded demos move too
fast. The port replaces that scale with the USA value (1.0) while running at
60 Hz, so demo movement matches the 60 Hz build.

Pass `--50` to use the authentic PAL 50 Hz frame rate and keep the original 1.2
scale. This is mainly useful for comparison; the original EU attract-demo crash
can still occur in that mode.

```bash
dotnet bin/Release/net10.0/CourierCrisis.dll "Courier Crisis ... (Europe).cue" --50
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

   The IRQ must be asserted once per crossing, when the voice is reading the
   block at the IRQ address. An earlier version checked both the previous and
   next addresses, which raised IRQ9 twice per crossing. That made the SpuSt
   engine refill twice as fast, so music played fast and streamed voice
   samples were cut off. The check now happens once, before the block is
   decoded.

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

8. **Configurable main overlay name** (`RecompOne.Recompiler`)
   The recompiler's `mainOverlay` config option lets the EU build register
   `main_eu`/`game_eu` dispatch tables alongside the USA `main`/`game` tables in
   the same executable.

`config/Courier_Crisis_debug.json` is a diagnostic variant of the USA config
that emits a per-function trace; expect it to run much slower and produce a
large log.

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
- With `--50`, the original PAL attract-demo timing can still crash after
  several demos. The default 60 Hz mode with demo resampling is the supported
  path.

## Notes

- `generated/` contains code derived from the game disc. Regenerate it from your
  own disc; do not redistribute it.
- The port uses RecompOne's OpenGL backend. On headless machines use
  `SDL_VIDEODRIVER=dummy` only for smoke tests; screenshots require a real or
  virtual X display.
