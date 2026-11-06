using CourierCrisis.Shared;
using RecompOne.Runtime.Config;
using RecompOne.Runtime.Memory;
using Recompiled;

// Keep settings, memory cards and mods out of the app folder: AppImage mounts
// are read-only and a desktop launch may have an unrelated working directory.
AppPaths.UseDataDirAsCurrent();
RecompOne.Runtime.Runtime.DiscValidator = DiscValidation.Validate;

var explicitPath = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal));
var direct = args.Any(a => a.Equals("--direct", StringComparison.OrdinalIgnoreCase));
var euMusic = args.Any(a => a.Equals("--EU", StringComparison.OrdinalIgnoreCase));

string? cue = null;
if (explicitPath != null)
{
    var problem = DiscValidation.Validate(explicitPath);
    if (problem != null)
    {
        Console.Error.WriteLine(problem);
        Console.Error.WriteLine("usage: CourierCrisis [path/to/game.bin|.cue|.chd] [--direct] [--EU]");
        return 1;
    }

    cue = DiscSource.Resolve(explicitPath);
}
else
{
    cue = FindDefaultCue();
    if (cue != null && DiscValidation.Validate(cue) != null)
        cue = null;
}

if (cue != null)
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
    foreach (var dir in new[] { AppContext.BaseDirectory, Directory.GetCurrentDirectory() })
    {
        var path = Path.Combine(dir, "Courier Crisis (USA).cue");
        if (File.Exists(path)) return path;
    }

    return null;
}
