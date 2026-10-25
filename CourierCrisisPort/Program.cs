using RecompOne.Runtime.Config;
using RecompOne.Runtime.Memory;
using Recompiled;

// Use the disc passed on the command line, otherwise the first disc found next
// to this port folder.
var explicitCue = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal));
var cue = explicitCue ?? FindDefaultCue();
if (cue == null)
{
    Console.Error.WriteLine("disc cue not found");
    Console.Error.WriteLine("usage: CourierCrisis [path/to/game.cue] [--direct] [--EU]");
    return 1;
}

cue = Path.GetFullPath(cue);
if (!File.Exists(cue))
{
    Console.Error.WriteLine($"disc cue not found: {cue}");
    Console.Error.WriteLine("usage: CourierCrisis [path/to/game.cue] [--direct] [--EU]");
    return 1;
}

var direct = args.Any(a => a.Equals("--direct", StringComparison.OrdinalIgnoreCase));
var euMusic = args.Any(a => a.Equals("--EU", StringComparison.OrdinalIgnoreCase));

Settings.System.DiscPath = cue;
PortOptions.UseEuMusic = euMusic;

// Courier Crisis predates the DualShock; its PAD buffer is only four bytes.
Settings.System.Input[0].Kind = PadKind.Digital;
Settings.System.Input[1].Kind = PadKind.Digital;

RecompOne.Runtime.Runtime.Run(() =>
{
    var memory = new PSMemory();
    Entry.Run(memory, cue, "Courier Crisis", direct);
});

return 0;

static string? FindDefaultCue()
{
    var root = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));
    string[] names =
    [
        "Courier Crisis (USA).cue",
        "Courier Crisis - The Saga of the Modern Fatalist (Europe) (En,Fr,De,It).cue"
    ];

    foreach (var name in names)
    {
        var path = Path.Combine(root, name);
        if (File.Exists(path)) return path;
    }

    return null;
}
