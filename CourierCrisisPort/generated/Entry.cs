using RecompOne.Runtime.Cdrom;
using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;
using BiosKernel = RecompOne.Runtime.Bios.Bios;

namespace Recompiled;

public static class Entry
{
    public static void Run(IMemory m, string? cuePath = null, string? title = null)
    {
        RecompOne.Runtime.Runtime.Initialize(title ?? "Courier_Crisis");
        RecompOne.Runtime.Runtime.WaitForValidDisc();
        using var fs = DiscFs.Open(cuePath ?? RecompOne.Runtime.Runtime.CdPath);
        var cd = new CdController(fs, m);
        m.SetCd(cd);
        Dispatcher.Register("main", new MainDispatchTable());
        Dispatcher.Register("game", new GameDispatchTable());
        RecompOne.Runtime.Modding.ModLoader.LoadAll();
        cd.LoadToMemory("SLUS_004.42", 0x801C0000u, 0x800, 147456);
        Dispatcher.Load("main");
        var c = new CpuContext();
        c.GP = 0x00000000u;
        c.SP = 0x801FFFF0u;
        c.FP = c.SP;
        c.RA = 0u;
        RecompOne.Runtime.Runtime.SetContext(c, m);
        BiosKernel.Init(m);
        Dispatcher.Call(c, m, 0x801C0BB8u);
    }
}
