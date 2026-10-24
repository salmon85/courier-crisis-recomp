# Courier Crisis (USA) — RecompOne C# port

Native C# port of the PlayStation 1 game **Courier Crisis (USA, SLUS-00442)**,
produced with the [RecompOne](https://github.com/BlackLabelHQ/RecompOne) static
recompiler.

- `CourierCrisisPort/` — the port itself (config, recompiled C# entry point,
  project file). See `CourierCrisisPort/README.md`.
- `RecompOne/` — the recompiler/runtime checkout (its own git repository). The
  three required runtime fixes are committed there and mirrored in
  `CourierCrisisPort/RecompOne-runtime-fixes.patch`.

The game disc (`.bin`/`.cue`) and the recompiled `generated/` output are not
committed. Put your own disc next to this folder and regenerate:

```bash
dotnet RecompOne/RecompOne.Recompiler/bin/Release/net10.0/recompone.dll \
    CourierCrisisPort/config/Courier_Crisis.json
cd CourierCrisisPort
dotnet build CourierCrisis.csproj -c Release
dotnet bin/Release/net10.0/CourierCrisis.dll "/path/to/Courier Crisis (USA).cue"
```
