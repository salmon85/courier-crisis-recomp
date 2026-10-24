using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;

namespace CourierCrisis;

/// <summary>
/// Replacement routines for game functions that need a small amount of port
/// glue. They are wired up through the "patches" section of
/// config/Courier_Crisis.json, so they survive recompilation.
/// </summary>
public static class Patches
{
    private const uint AcquireDrawBuffer = 0x80075A80u;
    private const uint ReleaseDisplay = 0x80075CECu;

    /// <summary>
    /// 0x80012928: wait until a draw buffer is free.
    ///
    /// The original spins on func_80075A80, which only looks at the buffer
    /// selected by GP+0xAD8. That buffer is recycled by func_80075CEC, which
    /// normally runs from the VBlank handler and only frees a buffer after a
    /// display flip has been pending for two frames. During rapid state
    /// transitions the main loop can reach this wait before the release has
    /// run, and because the loop never returns to VSync the pending flip is
    /// never acknowledged, so the game hangs here forever.
    ///
    /// Pump the display release while waiting; the release itself still does
    /// all of the original bookkeeping.
    /// </summary>
    public static void WaitDrawBuffer(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        var sp = c.SP - 0x18u;
        c.SP = sp;
        mem.WriteU32(sp + 0x10u, c.RA);

        var spins = 0;
        while (true)
        {
            RecompOne.Runtime.Interrupts.Poll(c, m);
            c.RA = 0x80012938u;
            Dispatcher.Call(c, m, AcquireDrawBuffer);
            if (c.V0 != 0u) break;

            // Roughly once per millisecond of spinning, run the display
            // release task so a pending flip can complete.
            if (++spins < 4096) continue;
            spins = 0;
            c.RA = 0x80075C1Cu;
            Dispatcher.Call(c, m, ReleaseDisplay);
        }

        c.RA = mem.ReadU32(sp + 0x10u);
        c.SP = sp + 0x18u;
    }
}
