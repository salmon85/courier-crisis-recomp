# Courier Crisis (USA) — RecompOne C# port

Native C# port of the PlayStation 1 game **Courier Crisis (USA, SLUS-00442)**,
produced with the [RecompOne](https://github.com/BlackLabelHQ/RecompOne) static
recompiler.

- `CourierCrisisPort/` — the port itself (configs, recompiled C# entry point,
  project file, boot glue). See `CourierCrisisPort/README.md`.
- `RecompOne/` — the recompiler/runtime, included as a git submodule
  ([salmon85/RecompOne](https://github.com/salmon85/RecompOne)).

The European port and its 60 Hz/PAL and attract-demo fixes are archived in the
`eu-support-archive` branch (and the earlier `eu-demos-60hz` branch). The
mainline supports the USA disc only.

Clone with the submodule:

```bash
git clone --recursive https://github.com/salmon85/courier-crisis-recomp.git
# or, in an existing clone:
git submodule update --init --recursive
```

The game disc (`.bin`/`.cue`) and the recompiled `generated/` output are not
committed. Put your own USA disc next to this folder and regenerate:

```bash
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis.json
cd CourierCrisisPort
dotnet build CourierCrisis.csproj -c Release
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/Courier Crisis (USA).cue"
```

Pass `--direct` to skip the intro and boot `GAME.EXE` immediately.
