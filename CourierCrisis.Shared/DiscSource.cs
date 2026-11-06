using System.Security.Cryptography;
using System.Text;

namespace CourierCrisis.Shared;

/// <summary>
/// Turns a user-selected disc file into something the runtime can open.
/// Raw 2352-byte .bin dumps without a cue sheet get a generated single-track
/// cue that points at the absolute .bin path.
/// </summary>
public static class DiscSource
{
    public static string Resolve(string path)
    {
        var full = Path.GetFullPath(path);
        if (!File.Exists(full))
            throw new FileNotFoundException($"Disc image not found: {full}", full);

        var extension = Path.GetExtension(full);
        if (extension.Equals(".cue", StringComparison.OrdinalIgnoreCase) ||
            extension.Equals(".chd", StringComparison.OrdinalIgnoreCase))
            return full;

        if (!extension.Equals(".bin", StringComparison.OrdinalIgnoreCase))
            throw new NotSupportedException("Select a .bin, .cue or .chd disc image.");

        var siblingCue = Path.ChangeExtension(full, ".cue");
        if (File.Exists(siblingCue)) return siblingCue;

        if (!IsRaw2352(full))
            throw new NotSupportedException(
                "This .bin is not a raw 2352-byte PS1 dump. Use the .cue or .chd instead.");

        if (full.Contains('"') || full.Contains('\n') || full.Contains('\r'))
            throw new NotSupportedException("The disc path contains characters the cue sheet cannot represent.");

        AppPaths.EnsureDataDir();
        Directory.CreateDirectory(AppPaths.CacheDir);

        var name = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(full)))[..16].ToLowerInvariant();
        var cuePath = Path.Combine(AppPaths.CacheDir, name + ".cue");
        File.WriteAllText(cuePath,
            $"FILE \"{full}\" BINARY\n  TRACK 01 MODE2/2352\n    INDEX 01 00:00:00\n");
        return cuePath;
    }

    private static bool IsRaw2352(string path)
    {
        using var stream = File.OpenRead(path);
        Span<byte> sync = stackalloc byte[12];
        if (stream.Read(sync) != sync.Length) return false;

        ReadOnlySpan<byte> expected = [0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00];
        return sync.SequenceEqual(expected);
    }
}
