namespace CourierCrisis.Shared;

/// <summary>
/// Per-user writable folder for settings, memory cards, mods and the generated
/// cue cache. The game and launcher both use it so a double-clicked AppImage
/// never tries to write inside its read-only mount.
/// </summary>
public static class AppPaths
{
    public static string DataDir { get; } = ResolveDataDir();

    public static string CacheDir => Path.Combine(DataDir, "cache");

    public static void EnsureDataDir()
    {
        Directory.CreateDirectory(DataDir);
    }

    public static void UseDataDirAsCurrent()
    {
        EnsureDataDir();
        Directory.SetCurrentDirectory(DataDir);
    }

    private static string ResolveDataDir()
    {
        var overridden = Environment.GetEnvironmentVariable("COURIER_CRISIS_DATA_DIR");
        if (!string.IsNullOrWhiteSpace(overridden))
            return Path.GetFullPath(overridden);

        var root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        if (string.IsNullOrWhiteSpace(root))
            root = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        if (string.IsNullOrWhiteSpace(root))
            root = AppContext.BaseDirectory;

        return Path.Combine(root, "CourierCrisis");
    }
}
