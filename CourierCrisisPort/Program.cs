using RecompOne.Runtime.Cdrom;
using RecompOne.Runtime.Config;
using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;
using Recompiled;

// Use the disc passed on the command line, otherwise the one next to this port folder.
var cue = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal))
    ?? Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Courier Crisis (USA).cue"));
cue = Path.GetFullPath(cue);

if (!File.Exists(cue))
{
    Console.Error.WriteLine($"disc cue not found: {cue}");
    Console.Error.WriteLine("usage: CourierCrisis [path/to/game.cue] [--direct]");
    return 1;
}

Settings.System.DiscPath = cue;

// Courier Crisis predates the DualShock; its PAD buffer is only four bytes.
Settings.System.Input[0].Kind = PadKind.Digital;
Settings.System.Input[1].Kind = PadKind.Digital;

if (args.Contains("--direct"))
{
    // Development shortcut: boot GAME.EXE directly, skipping the boot executable's
    // logo and intro movies. The normal (default) path plays the full intro.
    RecompOne.Runtime.Runtime.Run(() =>
    {
        RecompOne.Runtime.Runtime.Initialize("Courier Crisis");
        RecompOne.Runtime.Runtime.WaitForValidDisc();
        using var fs = DiscFs.Open(cue);
        var memory = new PSMemory();
        var cd = new CdController(fs, memory);
        memory.SetCd(cd);
        Dispatcher.Register("main", new MainDispatchTable());
        Dispatcher.Register("game", new GameDispatchTable());

        // The boot executable preloads MASTER.BIN at 0x80180000 as the file index.
        var master = fs.ReadFile("MASTER.BIN");
        for (var i = 0; i < master.Length; i++) memory.WriteU8(0x80180004u + (uint)i, master[i]);
        memory.WriteU32(0x80180000u, (uint)master.Length);

        cd.LoadToMemory("GAME.EXE", 0x80010000u, 0x800, 0x9D800);
        Dispatcher.Load("game");
        var c = new CpuContext
        {
            GP = 0u,
            SP = 0x801FFF00u,
            FP = 0x801FFF00u,
            RA = 0u
        };
        RecompOne.Runtime.Runtime.SetContext(c, memory);
        RecompOne.Runtime.Bios.Bios.Init(memory);
        Dispatcher.Call(c, memory, 0x80086334u);
    });

    return 0;
}

RecompOne.Runtime.Runtime.Run(() =>
{
    var memory = new PSMemory();
    Entry.Run(memory, cue, "Courier Crisis");
});

return 0;
