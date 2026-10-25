using System.Text;
using RecompOne.Runtime.Cdrom;
using RecompOne.Runtime.Config;
using RecompOne.Runtime.Memory;
using Recompiled;

// Use the disc passed on the command line, otherwise the first disc found next
// to this port folder.
var explicitCue = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal));
var cue = explicitCue ?? FindDefaultCue();
if (cue == null)
{
    Console.Error.WriteLine("USA disc cue not found");
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

if (IsEuropeanCue(cue))
{
    Console.Error.WriteLine("European discs are not supported on this branch.");
    Console.Error.WriteLine("The EU port and 60 Hz/demo fixes are archived in branch eu-support-archive.");
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

static bool IsEuropeanCue(string cue)
{
    try
    {
        using var fs = DiscFs.Open(cue);
        var text = Encoding.ASCII.GetString(fs.ReadFile("SYSTEM.CNF"));
        return text.Contains("SLES", StringComparison.OrdinalIgnoreCase) ||
               text.Contains("SCES", StringComparison.OrdinalIgnoreCase) ||
               text.Contains("SLED", StringComparison.OrdinalIgnoreCase) ||
               text.Contains("SCED", StringComparison.OrdinalIgnoreCase) ||
               fs.Exists("SLES_003.26");
    }
    catch
    {
        return false;
    }
}

static string? FindDefaultCue()
{
    var root = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));
    const string name = "Courier Crisis (USA).cue";

    var path = Path.Combine(root, name);
    return File.Exists(path) ? path : null;
}
