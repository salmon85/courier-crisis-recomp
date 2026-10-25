# Courier Crisis (USA/Europe) — RecompOne C# port

Native C# port of the PlayStation 1 game **Courier Crisis**, covering both
**USA (SLUS-00442)** and **Europe (SLES-00326)**, produced with the
[RecompOne](https://github.com/BlackLabelHQ/RecompOne) static recompiler.

- `CourierCrisisPort/` — the port itself (configs, recompiled C# entry point,
  project file, region glue). See `CourierCrisisPort/README.md`.
- `RecompOne/` — the recompiler/runtime, included as a git submodule
  ([salmon85/RecompOne](https://github.com/salmon85/RecompOne)). The runtime
  fixes are committed there and mirrored in
  `CourierCrisisPort/RecompOne-runtime-fixes.patch`.

Clone with the submodule:

```bash
git clone --recursive https://github.com/salmon85/courier-crisis-recomp.git
# or, in an existing clone:
git submodule update --init --recursive
```

The game disc (`.bin`/`.cue`) and the recompiled `generated/` output are not
committed. Put your own disc(s) next to this folder and regenerate. The USA and
EU disc use different executables, so generate each region you want to play:

```bash
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis.json
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis_EU.json
cd CourierCrisisPort
dotnet build CourierCrisis.csproj -c Release
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/Courier Crisis (USA).cue"
dotnet bin/Release/net10.0/CourierCrisis.dll \
    "/path/to/Courier Crisis - The Saga of the Modern Fatalist (Europe) (En,Fr,De,It).cue"
```

The disc region is detected automatically from `SYSTEM.CNF`, so the same build
can be pointed at either cue. If only one region's recompiled code is present,
the other region reports a clear "recompiled code is missing" message.

Both regions default to the USA music selection. Pass `--EU` to use the
European frontend music selection instead:

```bash
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/game.cue" --EU
```
