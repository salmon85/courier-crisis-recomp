using System.Text;
using RecompOne.Runtime;
using RecompOne.Runtime.Cdrom;
using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;
using BiosKernel = RecompOne.Runtime.Bios.Bios;

namespace Recompiled;

/// <summary>
/// USA-only boot options. The European disc is not supported; the EU music
/// selection remains available for the USA disc via <c>--EU</c>.
/// </summary>
public static class PortOptions
{
    public static bool UseEuMusic { get; set; }
}

/// <summary>
/// Boots the USA executable. European discs are rejected; the EU port and the
/// 60 Hz/demo fixes live on the archived <c>eu-support-archive</c> branch.
/// </summary>
public static class Entry
{
    private const string UsBootExe = "SLUS_004.42";
    private const string EuBootExe = "SLES_003.26";

    public static void Run(IMemory m, string? cuePath = null, string? title = null, bool direct = false)
    {
        Runtime.Initialize(title ?? "Courier Crisis");
        Runtime.WaitForValidDisc();

        using var fs = DiscFs.Open(cuePath ?? Runtime.CdPath);
        var cd = new CdController(fs, m);
        m.SetCd(cd);

        RejectEuropeanDisc(fs);
        RegisterOverlays();
        RecompOne.Runtime.Modding.ModLoader.LoadAll();

        if (direct)
            RunDirect(m, fs, cd);
        else
            RunNormal(m, fs, cd);
    }

    private static void RunNormal(IMemory m, DiscFs fs, CdController cd)
    {
        var exe = PsxExeInfo.Read(fs, UsBootExe);

        cd.LoadToMemory(UsBootExe, exe.Destination, 0x800, (int)exe.TextSize);
        Dispatcher.Load("main");

        var c = new CpuContext
        {
            GP = exe.InitialGp,
            SP = exe.InitialSp != 0 ? exe.InitialSp + exe.SpOffset : 0x801FFFF0u,
            FP = 0,
            RA = 0
        };
        c.FP = c.SP;

        Runtime.SetContext(c, m);
        BiosKernel.Init(m);
        Dispatcher.Call(c, m, exe.InitialPc);
    }

    private static void RunDirect(IMemory m, DiscFs fs, CdController cd)
    {
        var exe = PsxExeInfo.Read(fs, "GAME.EXE");

        // The boot executable preloads MASTER.BIN at 0x80180000 as the file index.
        var master = fs.ReadFile("MASTER.BIN");
        for (var i = 0; i < master.Length; i++)
            m.WriteU8(0x80180004u + (uint)i, master[i]);
        m.WriteU32(0x80180000u, (uint)master.Length);

        cd.LoadToMemory("GAME.EXE", 0x80010000u, 0x800, (int)exe.TextSize);
        Dispatcher.Load("game");

        var c = new CpuContext
        {
            GP = 0u,
            SP = 0x801FFF00u,
            FP = 0x801FFF00u,
            RA = 0u
        };

        Runtime.SetContext(c, m);
        BiosKernel.Init(m);
        Dispatcher.Call(c, m, exe.InitialPc);
    }

    private static void RejectEuropeanDisc(DiscFs fs)
    {
        var european = false;
        try
        {
            var text = Encoding.ASCII.GetString(fs.ReadFile("SYSTEM.CNF"));
            european = text.Contains("SLES", StringComparison.OrdinalIgnoreCase) ||
                       text.Contains("SCES", StringComparison.OrdinalIgnoreCase) ||
                       text.Contains("SLED", StringComparison.OrdinalIgnoreCase) ||
                       text.Contains("SCED", StringComparison.OrdinalIgnoreCase);
        }
        catch
        {
            // Fall back to the boot executable name below.
        }

        if (!european)
            european = fs.Exists(EuBootExe);

        if (european)
            throw new NotSupportedException(
                "European discs are not supported on this branch. " +
                "The EU port and 60 Hz/demo fixes are archived in branch eu-support-archive.");
    }

    private static void RegisterOverlays()
    {
#if HAS_US
        Dispatcher.Register("main", new MainDispatchTable());
        Dispatcher.Register("game", new GameDispatchTable());
#else
        throw new NotSupportedException(
            "USA recompiled code is missing. Run the recompiler with " +
            "CourierCrisisPort/config/Courier_Crisis.json first.");
#endif
    }
}

internal readonly record struct PsxExeInfo(
    uint InitialPc,
    uint InitialGp,
    uint Destination,
    uint TextSize,
    uint InitialSp,
    uint SpOffset)
{
    public static PsxExeInfo Read(DiscFs fs, string name)
    {
        var data = fs.ReadFile(name);
        if (data.Length < 0x800 || Encoding.ASCII.GetString(data, 0, 8) != "PS-X EXE")
            throw new InvalidDataException($"{name} is not a PS-X EXE");

        return new PsxExeInfo(
            ReadU32(data, 0x10),
            ReadU32(data, 0x14),
            ReadU32(data, 0x18),
            ReadU32(data, 0x1C),
            ReadU32(data, 0x30),
            ReadU32(data, 0x34));
    }

    private static uint ReadU32(byte[] data, int offset)
    {
        return (uint)(data[offset] |
                      (data[offset + 1] << 8) |
                      (data[offset + 2] << 16) |
                      (data[offset + 3] << 24));
    }
}
