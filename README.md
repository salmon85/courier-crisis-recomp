# Courier Crisis (USA) — RecompOne C# port

Native C# port of the PlayStation 1 game **Courier Crisis (USA, SLUS-00442)**,
produced with the [RecompOne](https://github.com/BlackLabelHQ/RecompOne) static
recompiler.

- `CourierCrisisPort/` — the port itself (configs, recompiled C# entry point,
  project file, boot glue). See `CourierCrisisPort/README.md`.
- `CourierCrisisLauncher/` — cross-platform launcher: disc picker, EU music
  checkbox and Launch button.
- `CourierCrisis.Shared/` — disc path/validation and per-user data-dir helpers
  shared by the game and launcher.
- `RecompOne/` — the recompiler/runtime, included as a git submodule
  ([salmon85/RecompOne](https://github.com/salmon85/RecompOne)).

## Play a release

Download the latest release from the GitHub releases page:

- **Windows:** `CourierCrisis-windows-x64.zip`
- **Linux:** `CourierCrisis-linux-x86_64.AppImage`

If FUSE is not available on your system, run the AppImage with
`--appimage-extract-and-run`.

Run the launcher, select your own **Courier Crisis (USA)** disc image
(`.bin`, `.cue` or `.chd`), tick **Use European music selection** if you want
the EU frontend playlist, and press **Launch**.

The disc is required at runtime. No BIOS or other Sony files are needed. Raw
`.bin` dumps must use 2352-byte sectors; if a matching `.cue` sits next to the
`.bin`, it is used automatically.

Settings, memory cards, mods and the generated cue cache live in:

- Windows: `%LOCALAPPDATA%\CourierCrisis`
- Linux: `~/.local/share/CourierCrisis`

Set `COURIER_CRISIS_DATA_DIR` to override that folder. The launcher forwards
extra flags to the game: `--direct` skips the intro and boots `GAME.EXE`
immediately; `--EU` is equivalent to ticking the checkbox.

## Build

Requires the .NET 10 SDK and the submodule:

```bash
git clone --recursive https://github.com/salmon85/courier-crisis-recomp.git
# or, in an existing clone:
git submodule update --init --recursive

dotnet publish CourierCrisisPort/CourierCrisis.csproj -c Release -r linux-x64 --self-contained true -o publish/linux-x64
dotnet publish CourierCrisisLauncher/CourierCrisisLauncher.csproj -c Release -r linux-x64 --self-contained true -o publish/linux-x64
```

The recompiled `CourierCrisisPort/generated/` output is committed so CI can
build releases without the disc. To regenerate it from your own disc:

```bash
dotnet build RecompOne/RecompOne.Recompiler/RecompOne.Recompiler.csproj -c Release
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis.json
```

## Branches

The European port and its 60 Hz/PAL and attract-demo fixes are archived in the
`eu-support-archive` branch (and the earlier `eu-demos-60hz` branch). The
mainline supports the USA disc only; the USA disc's European frontend music
playlist is still available with `--EU`.

## Legal

`CourierCrisisPort/generated/` contains code derived from the game disc. It is
committed here only so the project can build release binaries; the release does
not include the disc, and you must supply your own copy to play. Do not
redistribute the disc image. If you are not comfortable with the recompiled
code being distributed, build from source after regenerating `generated/` from
your own disc.
