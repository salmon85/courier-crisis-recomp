using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;
using Recompiled;

namespace CourierCrisis;

/// <summary>
/// Replacement routines for game functions that need a small amount of port
/// glue. They are wired up through the "patches" section of the recompiler
/// configs, so they survive recompilation.
/// </summary>
public static class Patches
{
    private const uint AcquireDrawBuffer = 0x80075A80u;
    private const uint ReleaseDisplay = 0x80075CECu;

    private static uint _musicSelectContext;
    private static bool _forceMusicScene;

    /// <summary>
    /// 0x80012928 (USA): wait until a draw buffer is free.
    ///
    /// The original spins on AcquireDrawBuffer, which only looks at the buffer
    /// selected by GP+0xAD8. That buffer is recycled by ReleaseDisplay, which
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

        // Waiting for the next VBlank (a few milliseconds) is normal, so only
        // step in once the wait is clearly abnormal. Otherwise pumping the
        // release here would flip the display mid-frame and show stale VRAM.
        var start = RecompOne.Runtime.Interrupts.ClockMs;
        var lastPump = start;
        while (true)
        {
            RecompOne.Runtime.Interrupts.Poll(c, m);
            c.RA = 0x80012938u;
            Dispatcher.Call(c, m, AcquireDrawBuffer);
            if (c.V0 != 0u) break;

            var now = RecompOne.Runtime.Interrupts.ClockMs;
            if (now - start < 250.0 || now - lastPump < 250.0) continue;
            lastPump = now;
            c.RA = 0x80075C1Cu;
            Dispatcher.Call(c, m, ReleaseDisplay);
        }

        c.RA = mem.ReadU32(sp + 0x10u);
        c.SP = sp + 0x18u;
    }

    /// <summary>
    /// 0x80066E74 (USA): initialise the frontend's music state. The USA build's
    /// default selection is playlist 0; remember the object pointer so the post
    /// hook can enforce that selection.
    /// </summary>
    public static void MusicSelectPre(CpuContext c, IMemory m)
    {
        _musicSelectContext = c.A0;
    }

    public static void MusicSelectPost(CpuContext c, IMemory m)
    {
        if (_musicSelectContext == 0u) return;

        m.WriteU32(_musicSelectContext + 0x378u, 0u);
        _forceMusicScene = true;
    }

    /// <summary>
    /// 0x80066530 (USA): copy the scene's music index to the module-global used
    /// by the playlist start routine. The frontend call immediately follows
    /// MusicSelectPost, so override just that one copy.
    /// </summary>
    public static void MusicScenePost(CpuContext c, IMemory m)
    {
        if (!_forceMusicScene) return;
        _forceMusicScene = false;

        m.WriteU32(0x800AD514u, 0u);
    }
}
