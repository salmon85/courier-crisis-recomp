using System.Text;
using RecompOne.Runtime.Cdrom;

namespace CourierCrisis.Shared;

/// <summary>
/// Rejects discs the USA recompilation cannot boot. GAME.EXE must start at LBA
/// 97 because the generated game overlay is registered at LBA 98.
/// </summary>
public static class DiscValidation
{
    // GAME.EXE starts at LBA 97; its 0x800-byte PS-X header occupies the first
    // sector, so the recompiled overlay is registered at LBA 98.
    public const int GameExeLba = 97;

    public static string? Validate(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
            return "Select your Courier Crisis (USA) disc image.";

        string cue;
        try
        {
            cue = DiscSource.Resolve(path);
        }
        catch (Exception e)
        {
            return e.Message;
        }

        try
        {
            using var fs = DiscFs.Open(cue);

            if (!fs.Exists("SYSTEM.CNF"))
                return "Not a PlayStation disc image (SYSTEM.CNF is missing).";

            var cnf = Encoding.ASCII.GetString(fs.ReadFile("SYSTEM.CNF"));
            if (IsEuropean(cnf, fs))
                return "European discs are not supported. Use the USA disc (SLUS-00442).";

            if (!fs.Exists("SLUS_004.42"))
                return "This is not Courier Crisis (USA) (SLUS-00442).";

            if (!fs.Exists("GAME.EXE"))
                return "GAME.EXE is missing from the disc.";

            if (!fs.Exists("MASTER.BIN"))
                return "MASTER.BIN is missing from the disc.";

            if (!fs.Locate("GAME.EXE", out var lba, out _))
                return "GAME.EXE is missing from the disc.";

            if (lba != GameExeLba)
                return $"Unsupported disc layout: GAME.EXE is at LBA {lba}, expected {GameExeLba}. " +
                       "Use a 1:1 USA cue/bin or chd dump.";

            return null;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    private static bool IsEuropean(string cnf, DiscFs fs)
    {
        return cnf.Contains("SLES", StringComparison.OrdinalIgnoreCase) ||
               cnf.Contains("SCES", StringComparison.OrdinalIgnoreCase) ||
               cnf.Contains("SLED", StringComparison.OrdinalIgnoreCase) ||
               cnf.Contains("SCED", StringComparison.OrdinalIgnoreCase) ||
               fs.Exists("SLES_003.26");
    }
}
