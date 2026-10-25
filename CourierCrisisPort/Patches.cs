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
    /// 0x80066E74 (USA): initialise the frontend's music state. Playlist 0 is
    /// the USA selection; <c>--EU</c> selects the EU playlist (6).
    /// </summary>
    public static void MusicSelectPre(CpuContext c, IMemory m)
    {
        _musicSelectContext = c.A0;
    }

    public static void MusicSelectPost(CpuContext c, IMemory m)
    {
        if (_musicSelectContext == 0u) return;

        var selection = PortOptions.UseEuMusic ? 6u : 0u;
        m.WriteU32(_musicSelectContext + 0x378u, selection);
        _forceMusicScene = true;

        // The USA disc also carries the shorter EU frontend playlist as
        // playlist 6. Replace the USA 45-track list with the EU list when the
        // user asks for the EU music selection.
        if (!PortOptions.UseEuMusic) return;

        const uint playlist6 = 0x80099BD0u;
        const uint playlist6Count = 0x80099CCCu;
        var tracks = EuPlaylist6;
        for (var i = 0; i < tracks.Length; i++)
            m.WriteU32(playlist6 + (uint)i * 4u, tracks[i]);
        m.WriteU16(playlist6Count, (ushort)tracks.Length);
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

        m.WriteU32(0x800AD514u, PortOptions.UseEuMusic ? 6u : 0u);
    }

    private static readonly uint[] EuPlaylist6 =
    [
        0x416, 0x419, 0x41C, 0x41B, 0x234, 0x23C, 0x41D, 0x23E, 0x235, 0x240,
        0x41E, 0x242, 0x236, 0x415, 0x237, 0x417, 0x239, 0x23B, 0x41A, 0x23D,
        0x23F, 0x41F, 0x420, 0x421, 0x243, 0x241, 0x238, 0x418, 0x23A, 0x422
    ];
}
