using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;

namespace Recompiled;

public static partial class Courier_Crisis_main
{
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C0BB0(CpuContext c, IMemory m)
    {
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C0BB8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801E0000u;
        c.V0 = c.V0 + 0x1458u;
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x5388u;
        L801C0BC8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU32(c.V0, 0u);
        c.V0 = c.V0 + 0x4u;
        c.At = c.V0 < c.V1 ? 1u : 0u;
        if (c.At != 0u) {
            goto L801C0BC8;
        }
        c.V0 = 0x00000004u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xC64u;
        c.A0 = c.A0 + c.V0;
        c.V0 = mem.ReadU32(c.A0);
        c.T0 = 0x80000000u;
        c.SP = c.V0 | c.T0;
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x5388u;
        c.A0 = c.A0 << 3;
        c.A0 = c.A0 >> 3;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x1C70u));
        c.A1 = c.V0 - c.V1;
        c.A1 = c.A1 - c.A0;
        c.A0 = c.A0 | c.T0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1458u), c.RA);
        c.GP = 0x801E0000u;
        c.GP = c.GP + 0x1450u;
        c.FP = c.SP;
        c.A0 = c.A0 + 0x4u;
        c.RA = 0x801C0C4Cu;
        Courier_Crisis_main.func_801C1F84(c, m);
        c.RA = 0x801E0000u;
        c.RA = mem.ReadU32((c.RA + 0x1458u));
        c.RA = 0x801C0C60u;
        Courier_Crisis_main.func_801C1618(c, m);
        Bios.Break(c, m);
        Courier_Crisis_main.func_801C0C74(c, m);
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C0C74(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A0 << 3;
        mem.WriteU32((c.SP + 0x24u), c.RA);
        mem.WriteU32((c.SP + 0x20u), c.S2);
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A1 = (uint)(short)mem.ReadU16((c.At + 0x14D8u));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A2 = (uint)(short)mem.ReadU16((c.At + 0x14DAu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A3 = (uint)(short)mem.ReadU16((c.At + 0x14DCu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.V0 = (uint)(short)mem.ReadU16((c.At + 0x14DEu));
        c.S2 = 0x801E0000u;
        c.S2 = c.S2 + 0x150Cu;
        c.A0 = c.S2;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C0CD0u;
        Courier_Crisis_main.SetDefDispEnv_main(c, m);
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A1 = (uint)(short)mem.ReadU16((c.At + 0x14D8u));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A2 = (uint)(short)mem.ReadU16((c.At + 0x14DAu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A3 = (uint)(short)mem.ReadU16((c.At + 0x14DCu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.V0 = (uint)(short)mem.ReadU16((c.At + 0x14DEu));
        c.S1 = 0x801E0000u;
        c.S1 = c.S1 + 0x1520u;
        c.A0 = c.S1;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C0D14u;
        Courier_Crisis_main.SetDefDrawEnv_main(c, m);
        c.A0 = c.S2;
        c.RA = 0x801C0D1Cu;
        Courier_Crisis_main.PutDispEnv_main(c, m);
        c.A0 = c.S1;
        c.RA = 0x801C0D24u;
        Courier_Crisis_main.PutDrawEnv_main(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C0D2Cu;
        Courier_Crisis_main.SetDispMask_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S2 = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C0D48(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x48u;
        mem.WriteU32((c.SP + 0x38u), c.S2);
        c.S2 = 0x80180000u;
        c.A0 = c.SP + 0x10u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x0u;
        mem.WriteU32((c.SP + 0x3Cu), c.S3);
        c.S3 = 0u | 0x0080u;
        mem.WriteU32((c.SP + 0x40u), c.RA);
        mem.WriteU32((c.SP + 0x34u), c.S1);
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.RA = 0x801C0D78u;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            c.S1 = 0u;
            goto L801C0DA0;
        }
        c.S1 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C0D90u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801C0E18;
        L801C0D98: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0u | 0x0001u;
        goto L801C0E18;
        L801C0DA0: ;
        c.V0 = mem.ReadU32((c.SP + 0x14u));
        mem.WriteU32(c.S2, c.V0);
        c.S2 = 0x80180000u;
        c.S2 = c.S2 | 0x0004u;
        L801C0DB4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x14u));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x10u;
        c.A2 = c.SP + 0x28u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C0DD0u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A0 = c.S0;
        c.A1 = c.S2;
        c.A2 = c.S3;
        c.RA = 0x801C0DE0u;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C0DE4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C0DECu;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C0E04;
        }
        c.A0 = 0u;
        c.RA = 0x801C0DFCu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C0DE4;
        L801C0E04: ;
        if (c.V0 == 0u) {
            c.S1 = c.S1 + 0x1u;
            goto L801C0D98;
        }
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801C0DB4;
        }
        c.V0 = 0u;
        L801C0E18: ;
        c.RA = mem.ReadU32((c.SP + 0x40u));
        c.S3 = mem.ReadU32((c.SP + 0x3Cu));
        c.S2 = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x48u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C0E38(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x48u;
        c.A1 = c.A0;
        c.A0 = c.SP + 0x10u;
        mem.WriteU32((c.SP + 0x3Cu), c.S3);
        c.S3 = 0u | 0x0080u;
        mem.WriteU32((c.SP + 0x40u), c.RA);
        mem.WriteU32((c.SP + 0x38u), c.S2);
        mem.WriteU32((c.SP + 0x34u), c.S1);
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.RA = 0x801C0E60u;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            c.S1 = 0u;
            goto L801C0E80;
        }
        c.S1 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C0E78u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801C0F38;
        L801C0E80: ;
        c.S2 = 0x801E0000u;
        c.S2 = c.S2 + 0x14F8u;
        L801C0E88: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x14u));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x10u;
        c.A2 = c.SP + 0x28u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C0EA4u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A1 = mem.ReadU32((c.GP + 0x2Cu));
        c.A0 = c.S0;
        c.A2 = c.S3;
        c.RA = 0x801C0EB4u;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C0EB8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C0EC0u;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C0ED8;
        }
        c.A0 = 0u;
        c.RA = 0x801C0ED0u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C0EB8;
        L801C0ED8: ;
        if (c.V0 != 0u) {
            goto L801C0F28;
        }
        c.A0 = mem.ReadU32((c.GP + 0x2Cu));
        c.RA = 0x801C0EECu;
        Courier_Crisis_main.OpenTIM_main(c, m);
        c.A0 = c.S2;
        c.RA = 0x801C0EF4u;
        Courier_Crisis_main.ReadTIM_main(c, m);
        if (c.V0 == 0u) {
            goto L801C0F20;
        }
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        if (c.A1 == 0u) {
            c.V0 = 0u | 0x0001u;
            goto L801C0F38;
        }
        c.V0 = 0u | 0x0001u;
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.RA = 0x801C0F20u;
        Courier_Crisis_main.LoadImage_main(c, m);
        L801C0F20: ;
        c.V0 = 0u | 0x0001u;
        goto L801C0F38;
        L801C0F28: ;
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801C0E88;
        }
        c.V0 = 0u;
        L801C0F38: ;
        c.RA = mem.ReadU32((c.SP + 0x40u));
        c.S3 = mem.ReadU32((c.SP + 0x3Cu));
        c.S2 = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x48u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C0F58(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x14D4u));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801E0000u;
        c.S0 = c.S0 + 0x14ECu;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.S0 - 0x20u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S1;
        c.A1 = mem.ReadU32(c.V0);
        c.A0 = c.S0;
        c.RA = 0x801C0F90u;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x14D4u));
        c.V0 = mem.ReadU16(c.S0);
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU16((c.A1 + 0x14F0u));
        c.A2 = 0x801E0000u;
        c.A2 = mem.ReadU32((c.A2 + 0x14E8u));
        c.A3 = c.V1 < 0x00000001u ? 1u : 0u;
        c.V0 = c.V0 + c.A1;
        c.A0 = c.A2 << 3;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14D4u), c.A3);
        mem.WriteU16(c.S0, (ushort)c.V0);
        c.At = 0x801E0000u;
        c.At = c.At + c.A0;
        c.V1 = (uint)(short)mem.ReadU16((c.At + 0x14D8u));
        c.At = 0x801E0000u;
        c.At = c.At + c.A0;
        c.A0 = (uint)(short)mem.ReadU16((c.At + 0x14DCu));
        c.V0 = c.V0 << 16;
        c.V0 = (uint)((int)c.V0 >> 16);
        c.V1 = c.V1 + c.A0;
        c.V0 = (int)c.V0 < (int)c.V1 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.A1 = c.A1 << 16;
            goto L801C102C;
        }
        c.A1 = c.A1 << 16;
        c.V0 = 0x801E0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 + 0x14F2u));
        c.A1 = (uint)((int)c.A1 >> 16);
        { var _r = (long)(int)c.A1 * (int)c.V0; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.V0 = c.A3 << 2;
        c.V0 = c.V0 + c.S1;
        c.A0 = mem.ReadU32(c.V0);
        c.A1 = c.LO;
        c.V0 = c.A1 >> 31;
        c.A1 = c.A1 + c.V0;
        c.A1 = (uint)((int)c.A1 >> 1);
        c.RA = 0x801C1024u;
        Courier_Crisis_main.DecDCTout(c, m);
        goto L801C1070;
        L801C102C: ;
        c.V0 = 0u | 0x0001u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14F4u), c.V0);
        c.V0 = c.A2 < 0x00000001u ? 1u : 0u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14E8u), c.V0);
        c.V0 = c.V0 << 3;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.V1 = mem.ReadU16((c.At + 0x14D8u));
        mem.WriteU16(c.S0, (ushort)c.V1);
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU16((c.At + 0x14DAu));
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14EEu), (ushort)c.V0);
        L801C1070: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1088(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x30u;
        mem.WriteU32((c.SP + 0x24u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x28u), c.S2);
        c.S2 = 0x00800000u;
        mem.WriteU32((c.SP + 0x2Cu), c.RA);
        mem.WriteU32((c.SP + 0x20u), c.S0);
        c.S0 = 0x00800000u;
        L801C10A8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = c.SP + 0x10u;
        L801C10AC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = c.SP + 0x14u;
        c.RA = 0x801C10B4u;
        Courier_Crisis_main.StGetNext(c, m);
        if (c.V0 == 0u) {
            c.S0 = c.S0 - 0x1u;
            goto L801C10CC;
        }
        c.S0 = c.S0 - 0x1u;
        if (c.S0 != 0u) {
            c.A0 = c.SP + 0x10u;
            goto L801C10AC;
        }
        c.A0 = c.SP + 0x10u;
        c.S0 = 0u;
        goto L801C1178;
        L801C10CC: ;
        c.A0 = mem.ReadU32((c.SP + 0x14u));
        c.V1 = mem.ReadU32((c.GP + 0x28u));
        c.V0 = mem.ReadU32((c.A0 + 0x8u));
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0u | 0x0001u;
            goto L801C10EC;
        }
        c.V0 = 0u | 0x0001u;
        mem.WriteU32((c.GP + 0x1Cu), c.V0);
        L801C10EC: ;
        c.V1 = mem.ReadU16((c.A0 + 0x10u));
        c.V0 = mem.ReadU32(c.GP);
        if (c.V0 != c.V1) {
            goto L801C1114;
        }
        c.V1 = mem.ReadU16((c.A0 + 0x12u));
        c.V0 = mem.ReadU32((c.GP + 0x4u));
        if (c.V0 == c.V1) {
            goto L801C1158;
        }
        L801C1114: ;
        c.A0 = c.SP + 0x18u;
        c.A1 = 0u;
        c.V0 = 0u | 0x0400u;
        mem.WriteU16((c.SP + 0x1Cu), (ushort)c.V0);
        c.V0 = 0u | 0x0200u;
        c.A2 = 0u;
        c.A3 = 0u;
        mem.WriteU16((c.SP + 0x18u), (ushort)0u);
        mem.WriteU16((c.SP + 0x1Au), (ushort)0u);
        mem.WriteU16((c.SP + 0x1Eu), (ushort)c.V0);
        c.RA = 0x801C1140u;
        Courier_Crisis_main.ClearImage_main(c, m);
        c.V0 = mem.ReadU32((c.SP + 0x14u));
        c.V1 = mem.ReadU16((c.V0 + 0x10u));
        c.V0 = mem.ReadU16((c.V0 + 0x12u));
        mem.WriteU32(c.GP, c.V1);
        mem.WriteU32((c.GP + 0x4u), c.V0);
        L801C1158: ;
        c.V1 = mem.ReadU16(c.GP);
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.V0 = mem.ReadU16((c.GP + 0x4u));
        mem.WriteU16((c.S1 + 0x24u), (ushort)c.V1);
        mem.WriteU16((c.S1 + 0x1Cu), (ushort)c.V1);
        mem.WriteU16((c.S1 + 0x26u), (ushort)c.V0);
        mem.WriteU16((c.S1 + 0x1Eu), (ushort)c.V0);
        mem.WriteU16((c.S1 + 0x32u), (ushort)c.V0);
        L801C1178: ;
        if (c.S0 == 0u) {
            c.S2 = c.S2 - 0x1u;
            goto L801C11B4;
        }
        c.S2 = c.S2 - 0x1u;
        c.V0 = mem.ReadU32((c.S1 + 0x8u));
        c.V0 = c.V0 < 0x00000001u ? 1u : 0u;
        mem.WriteU32((c.S1 + 0x8u), c.V0);
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S1;
        c.A1 = mem.ReadU32(c.V0);
        c.A0 = c.S0;
        c.RA = 0x801C11A4u;
        Courier_Crisis_main.DecDCTvlc(c, m);
        c.A0 = c.S0;
        c.RA = 0x801C11ACu;
        Courier_Crisis_main.StFreeRing(c, m);
        c.V0 = 0u;
        goto L801C11C0;
        L801C11B4: ;
        if (c.S2 != 0u) {
            c.S0 = 0x00800000u;
            goto L801C10A8;
        }
        c.S0 = 0x00800000u;
        c.V0 = 0xFFFFFFFFu;
        L801C11C0: ;
        c.RA = mem.ReadU32((c.SP + 0x2Cu));
        c.S2 = mem.ReadU32((c.SP + 0x28u));
        c.S1 = mem.ReadU32((c.SP + 0x24u));
        c.S0 = mem.ReadU32((c.SP + 0x20u));
        c.SP = c.SP + 0x30u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C11DC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x78u;
        c.V0 = c.A0;
        mem.WriteU32((c.SP + 0x60u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x6Cu), c.S3);
        c.S3 = 0u | 0x0001u;
        mem.WriteU32((c.SP + 0x70u), c.S4);
        c.S4 = mem.ReadU32((c.SP + 0x88u));
        c.A0 = c.SP + 0x38u;
        c.A3 = c.A3 - 0x1u;
        mem.WriteU32((c.SP + 0x74u), c.RA);
        mem.WriteU32((c.SP + 0x68u), c.S2);
        mem.WriteU32((c.SP + 0x64u), c.S1);
        mem.WriteU32((c.GP + 0x28u), c.A3);
        c.A1 = c.V0;
        c.RA = 0x801C121Cu;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            c.V1 = 0u | 0x00F0u;
            goto L801C123C;
        }
        c.V1 = 0u | 0x00F0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C1234u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801C153C;
        L801C123C: ;
        c.A2 = mem.ReadU8((c.SP + 0x38u));
        c.A3 = mem.ReadU8((c.SP + 0x39u));
        c.T0 = mem.ReadU8((c.SP + 0x3Au));
        c.A1 = mem.ReadU32((c.GP + 0xCu));
        c.V0 = 0u | 0x0100u;
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14E2u), (ushort)c.V0);
        c.V0 = 0u | 0x0010u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14C0u), c.S0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14C8u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14E8u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14D4u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14F4u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14D8u), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14DAu), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14DEu), (ushort)c.V1);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14E0u), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14E6u), (ushort)c.V1);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14ECu), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14EEu), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14F0u), (ushort)c.V0);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14F2u), (ushort)c.V1);
        c.V1 = c.A1 << 4;
        c.V1 = c.V1 - c.A1;
        c.V1 = c.V1 << 5;
        c.V0 = c.S0 + c.V1;
        mem.WriteU32((c.GP + 0x18u), c.V0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14C4u), c.V0);
        c.V0 = c.V0 + c.V1;
        c.V1 = c.V0 + 0x3C00u;
        mem.WriteU32((c.GP + 0x18u), c.V0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14CCu), c.V0);
        c.V0 = c.V0 + 0x7800u;
        mem.WriteU8((c.GP + 0x14u), (byte)c.A2);
        mem.WriteU8((c.GP + 0x15u), (byte)c.A3);
        mem.WriteU8((c.GP + 0x16u), (byte)c.T0);
        mem.WriteU32((c.GP + 0x18u), c.V1);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14D0u), c.V1);
        mem.WriteU32((c.GP + 0x18u), c.V0);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14DCu), (ushort)c.A1);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14E4u), (ushort)c.A1);
        mem.WriteU32((c.GP + 0x24u), c.V0);
        c.A0 = 0u;
        c.RA = 0x801C1338u;
        Courier_Crisis_main.DecDCTReset(c, m);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xF58u;
        mem.WriteU32((c.GP + 0x1Cu), 0u);
        c.RA = 0x801C134Cu;
        Courier_Crisis_main.DecDCToutCallback(c, m);
        c.A0 = mem.ReadU32((c.GP + 0x24u));
        c.A1 = 0u | 0x001Fu;
        c.RA = 0x801C1358u;
        Courier_Crisis_main.StSetRing(c, m);
        c.A0 = 0u;
        c.A1 = 0u | 0x0001u;
        c.A2 = 0xFFFFFFFFu;
        c.A3 = 0u;
        mem.WriteU32((c.SP + 0x10u), 0u);
        c.RA = 0x801C1370u;
        Courier_Crisis_main.StSetStream(c, m);
        c.A0 = 0u | 0x0015u;
        L801C1374: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x1464u;
        c.A2 = 0u;
        c.RA = 0x801C1384u;
        Courier_Crisis_main.CdControl_main(c, m);
        if (c.V0 == 0u) {
            c.A0 = 0u | 0x0015u;
            goto L801C1374;
        }
        c.A0 = 0u | 0x0015u;
        L801C138C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u | 0x01C0u;
        c.RA = 0x801C1394u;
        Courier_Crisis_main.CdRead2(c, m);
        if (c.V0 == 0u) {
            goto L801C138C;
        }
        c.S0 = 0x801E0000u;
        c.S0 = c.S0 + 0x14C0u;
        c.A0 = c.S0;
        c.RA = 0x801C13ACu;
        Courier_Crisis_main.func_801C1088(c, m);
        c.S1 = c.SP + 0x58u;
        c.S2 = 0u | 0x0001u;
        L801C13B4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x14C8u));
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S0;
        c.A0 = mem.ReadU32(c.V0);
        c.A1 = 0u | 0x0002u;
        c.RA = 0x801C13D4u;
        Courier_Crisis_main.DecDCTin(c, m);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x30u));
        c.V0 = (uint)(short)mem.ReadU16((c.S0 + 0x32u));
        { var _r = (long)(int)c.A1 * (int)c.V0; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x14D4u));
        c.V0 = c.V0 << 2;
        c.V0 = c.S0 + c.V0;
        c.A0 = mem.ReadU32((c.V0 + 0xCu));
        c.A1 = c.LO;
        c.V0 = c.A1 >> 31;
        c.A1 = c.A1 + c.V0;
        c.A1 = (uint)((int)c.A1 >> 1);
        c.RA = 0x801C1410u;
        Courier_Crisis_main.DecDCTout(c, m);
        c.A0 = c.S0;
        c.RA = 0x801C1418u;
        Courier_Crisis_main.func_801C1088(c, m);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x14F4u));
        c.V0 = 0x00800000u;
        mem.WriteU32((c.SP + 0x58u), c.V0);
        if (c.V1 != 0u) {
            goto L801C14AC;
        }
        L801C1430: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.S1);
        c.V0 = c.V0 - 0x1u;
        mem.WriteU32(c.S1, c.V0);
        c.V0 = mem.ReadU32(c.S1);
        if (c.V0 != 0u) {
            goto L801C1498;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x20u;
        c.RA = 0x801C1460u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x14E8u));
        mem.WriteU32((c.S0 + 0x34u), c.S2);
        c.V0 = c.V0 < 0x00000001u ? 1u : 0u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14E8u), c.V0);
        c.V0 = c.V0 << 3;
        c.V0 = c.S0 + c.V0;
        c.V1 = mem.ReadU16((c.V0 + 0x18u));
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14ECu), (ushort)c.V1);
        c.V0 = mem.ReadU16((c.V0 + 0x1Au));
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14EEu), (ushort)c.V0);
        L801C1498: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x14F4u));
        if (c.V0 == 0u) {
            goto L801C1430;
        }
        L801C14AC: ;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14F4u), 0u);
        c.A0 = 0u;
        c.RA = 0x801C14BCu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x14E8u));
        c.A0 = c.A0 < 0x00000001u ? 1u : 0u;
        c.RA = 0x801C14CCu;
        Courier_Crisis_main.func_801C0C74(c, m);
        c.V0 = mem.ReadU32((c.GP + 0x1Cu));
        if (c.V0 == c.S2) {
            goto L801C14F8;
        }
        if (c.S4 == 0u) {
            goto L801C13B4;
        }
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C14ECu;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 == 0u) {
            goto L801C13B4;
        }
        c.S3 = 0u;
        L801C14F8: ;
        c.V0 = 0u | 0x0080u;
        mem.WriteU8((c.SP + 0x50u), (byte)c.V0);
        c.A0 = 0u | 0x000Eu;
        c.A1 = c.SP + 0x50u;
        c.A2 = 0u;
        c.RA = 0x801C1510u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1518u;
        Courier_Crisis_main.DecDCToutCallback(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1520u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1528u;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        c.A0 = 0u | 0x0009u;
        c.A1 = 0u;
        c.A2 = 0u;
        c.RA = 0x801C1538u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.V0 = c.S3;
        L801C153C: ;
        c.RA = mem.ReadU32((c.SP + 0x74u));
        c.S4 = mem.ReadU32((c.SP + 0x70u));
        c.S3 = mem.ReadU32((c.SP + 0x6Cu));
        c.S2 = mem.ReadU32((c.SP + 0x68u));
        c.S1 = mem.ReadU32((c.SP + 0x64u));
        c.S0 = mem.ReadU32((c.SP + 0x60u));
        c.SP = c.SP + 0x78u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1560(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.V0 = c.A0 << 4;
        c.V0 = c.V0 - c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.V0 << 2;
        if ((int)c.S0 <= 0) {
            mem.WriteU32((c.SP + 0x14u), c.RA);
            goto L801C1590;
        }
        mem.WriteU32((c.SP + 0x14u), c.RA);
        L801C157C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1584u;
        Courier_Crisis_main.VSync_main(c, m);
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            goto L801C157C;
        }
        L801C1590: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C15A4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.V0 = c.A0 << 4;
        c.V0 = c.V0 - c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.V0 << 2;
        if ((int)c.S0 <= 0) {
            mem.WriteU32((c.SP + 0x14u), c.RA);
            goto L801C15E4;
        }
        mem.WriteU32((c.SP + 0x14u), c.RA);
        L801C15C0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C15C8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C15D0u;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 != 0u) {
            goto L801C15E4;
        }
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            goto L801C15C0;
        }
        L801C15E4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C15ECu;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 == 0u) {
            goto L801C1604;
        }
        c.A0 = 0u;
        c.RA = 0x801C15FCu;
        Courier_Crisis_main.VSync_main(c, m);
        goto L801C15E4;
        L801C1604: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1618(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x80u;
        mem.WriteU32((c.SP + 0x78u), c.RA);
        mem.WriteU32((c.SP + 0x74u), c.S3);
        mem.WriteU32((c.SP + 0x70u), c.S2);
        mem.WriteU32((c.SP + 0x6Cu), c.S1);
        mem.WriteU32((c.SP + 0x68u), c.S0);
        c.RA = 0x801C1634u;
        Courier_Crisis_main.func_801C0BB0(c, m);
        c.S2 = 0u | 0x0080u;
        c.RA = 0x801C163Cu;
        Courier_Crisis_main.ResetCallback_main(c, m);
        c.RA = 0x801C1644u;
        Courier_Crisis_main.CdInit_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C164Cu;
        Courier_Crisis_main.func_801C32F0(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1654u;
        Courier_Crisis_main.PadInit_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C165Cu;
        Courier_Crisis_main.ResetGraph_main(c, m);
        c.RA = 0x801C1664u;
        Courier_Crisis_main.InitGeom_main(c, m);
        c.A0 = 0u | 0x00A0u;
        c.A1 = 0u | 0x00A0u;
        c.RA = 0x801C1670u;
        Courier_Crisis_main.SetGeomOffset_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1678u;
        Courier_Crisis_main.SetGraphDebug_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1680u;
        Courier_Crisis_main.SetDispMask_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1688u;
        Courier_Crisis_main.VSync_main(c, m);
        c.RA = 0x801C1690u;
        Courier_Crisis_main.SpuInit_main(c, m);
        c.A0 = 0u | 0x3FFFu;
        c.A1 = 0u | 0x3FFFu;
        c.RA = 0x801C169Cu;
        Courier_Crisis_main.SpuSetCommonMasterVolume(c, m);
        c.A0 = 0u | 0x3FFFu;
        c.A1 = 0u | 0x3FFFu;
        c.RA = 0x801C16A8u;
        Courier_Crisis_main.SpuSetCommonCDVolume(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C16B0u;
        Courier_Crisis_main.SpuSetCommonCDMix(c, m);
        c.A0 = 0u | 0x000Cu;
        c.A1 = 0u;
        c.S0 = c.SP + 0x40u;
        c.A2 = c.S0;
        c.V0 = 0u | 0x007Fu;
        mem.WriteU8((c.SP + 0x38u), (byte)c.V0);
        mem.WriteU8((c.SP + 0x39u), (byte)c.V0);
        mem.WriteU8((c.SP + 0x3Au), (byte)c.V0);
        mem.WriteU8((c.SP + 0x3Bu), (byte)c.V0);
        c.RA = 0x801C16D8u;
        Courier_Crisis_main.CdControl_main(c, m);
        c.A0 = 0u | 0x000Du;
        c.A1 = 0u;
        c.A2 = c.S0;
        c.RA = 0x801C16E8u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A0 = c.SP + 0x38u;
        c.RA = 0x801C16F0u;
        Courier_Crisis_main.CdMix_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C16F8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1700u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1708u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x14D8u;
        c.A1 = 0u;
        c.A2 = 0u;
        c.V0 = 0x80010000u;
        c.V1 = 0u | 0x0140u;
        mem.WriteU32((c.GP + 0x2Cu), c.V0);
        c.V0 = 0u | 0x00F0u;
        mem.WriteU32((c.GP + 0xCu), c.V1);
        mem.WriteU32((c.GP + 0x10u), c.V0);
        mem.WriteU16(c.A0, (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14DAu), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14DCu), (ushort)c.V1);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x14DEu), (ushort)c.V0);
        c.A3 = 0u;
        c.RA = 0x801C1754u;
        Courier_Crisis_main.ClearImage_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C175Cu;
        Courier_Crisis_main.func_801C0C74(c, m);
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x38u;
        c.A0 = c.SP + 0x48u;
        c.RA = 0x801C176Cu;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            c.S1 = 0u;
            goto L801C178C;
        }
        c.S1 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C1784u;
        Courier_Crisis_main.func_801C87FC(c, m);
        goto L801C1844;
        L801C178C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x4Cu));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x48u;
        c.A2 = c.SP + 0x60u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C17A8u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A1 = mem.ReadU32((c.GP + 0x2Cu));
        c.A0 = c.S0;
        c.A2 = c.S2;
        c.RA = 0x801C17B8u;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C17BC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C17C4u;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C17DC;
        }
        c.A0 = 0u;
        c.RA = 0x801C17D4u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C17BC;
        L801C17DC: ;
        if (c.V0 != 0u) {
            goto L801C1834;
        }
        c.A0 = mem.ReadU32((c.GP + 0x2Cu));
        c.RA = 0x801C17F0u;
        Courier_Crisis_main.OpenTIM_main(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x14F8u;
        c.RA = 0x801C1800u;
        Courier_Crisis_main.ReadTIM_main(c, m);
        if (c.V0 == 0u) {
            goto L801C1844;
        }
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        if (c.A1 == 0u) {
            goto L801C1844;
        }
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.RA = 0x801C182Cu;
        Courier_Crisis_main.LoadImage_main(c, m);
        goto L801C1844;
        L801C1834: ;
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C178C;
        }
        L801C1844: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1504u));
        mem.WriteU16(c.V0, (ushort)0u);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1504u));
        c.V0 = 0u | 0x0100u;
        mem.WriteU16((c.V1 + 0x2u), (ushort)c.V0);
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        c.S0 = 0u | 0x0078u;
        c.RA = 0x801C187Cu;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1884u;
        Courier_Crisis_main.func_801C0C74(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C188Cu;
        Courier_Crisis_main.SetDispMask_main(c, m);
        L801C188C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1894u;
        Courier_Crisis_main.VSync_main(c, m);
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            goto L801C188C;
        }
        c.S0 = 0u | 0x00F0u;
        L801C18A4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C18ACu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C18B4u;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 != 0u) {
            goto L801C18C8;
        }
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            goto L801C18A4;
        }
        L801C18C8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C18D0u;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 == 0u) {
            c.V0 = 0u | 0x0001u;
            goto L801C18E8;
        }
        c.V0 = 0u | 0x0001u;
        c.A0 = 0u;
        c.RA = 0x801C18E0u;
        Courier_Crisis_main.VSync_main(c, m);
        goto L801C18C8;
        L801C18E8: ;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x58u;
        c.A1 = 0x80010000u;
        c.A2 = 0u;
        c.A3 = 0u | 0x0059u;
        c.RA = 0x801C1904u;
        Courier_Crisis_main.func_801C11DC(c, m);
        c.A0 = c.SP + 0x48u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x74u;
        c.S2 = 0u | 0x0080u;
        c.RA = 0x801C1918u;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            c.S1 = 0u;
            goto L801C1938;
        }
        c.S1 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C1930u;
        Courier_Crisis_main.func_801C87FC(c, m);
        goto L801C19F0;
        L801C1938: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x4Cu));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x48u;
        c.A2 = c.SP + 0x60u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C1954u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A1 = mem.ReadU32((c.GP + 0x2Cu));
        c.A0 = c.S0;
        c.A2 = c.S2;
        c.RA = 0x801C1964u;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C1968: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C1970u;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C1988;
        }
        c.A0 = 0u;
        c.RA = 0x801C1980u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C1968;
        L801C1988: ;
        if (c.V0 != 0u) {
            goto L801C19E0;
        }
        c.A0 = mem.ReadU32((c.GP + 0x2Cu));
        c.RA = 0x801C199Cu;
        Courier_Crisis_main.OpenTIM_main(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x14F8u;
        c.RA = 0x801C19ACu;
        Courier_Crisis_main.ReadTIM_main(c, m);
        if (c.V0 == 0u) {
            goto L801C19F0;
        }
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        if (c.A1 == 0u) {
            goto L801C19F0;
        }
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.RA = 0x801C19D8u;
        Courier_Crisis_main.LoadImage_main(c, m);
        goto L801C19F0;
        L801C19E0: ;
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C1938;
        }
        L801C19F0: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1504u));
        mem.WriteU16(c.V0, (ushort)0u);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1504u));
        c.V0 = 0u | 0x0100u;
        mem.WriteU16((c.V1 + 0x2u), (ushort)c.V0);
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        c.S0 = 0u | 0x003Cu;
        c.RA = 0x801C1A28u;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1A30u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1A38u;
        Courier_Crisis_main.func_801C0C74(c, m);
        L801C1A38: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1A40u;
        Courier_Crisis_main.VSync_main(c, m);
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            c.V0 = 0u | 0x0001u;
            goto L801C1A38;
        }
        c.V0 = 0u | 0x0001u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x90u;
        c.A1 = 0x80010000u;
        c.A2 = 0u;
        c.A3 = 0u | 0x01ACu;
        c.RA = 0x801C1A68u;
        Courier_Crisis_main.func_801C11DC(c, m);
        c.A0 = c.SP + 0x48u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0xB0u;
        c.S2 = 0u | 0x0080u;
        c.RA = 0x801C1A7Cu;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            goto L801C1A9C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C1A94u;
        Courier_Crisis_main.func_801C87FC(c, m);
        goto L801C1B58;
        L801C1A9C: ;
        c.S1 = 0u;
        L801C1AA0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x4Cu));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x48u;
        c.A2 = c.SP + 0x60u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C1ABCu;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A1 = mem.ReadU32((c.GP + 0x2Cu));
        c.A0 = c.S0;
        c.A2 = c.S2;
        c.RA = 0x801C1ACCu;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C1AD0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C1AD8u;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C1AF0;
        }
        c.A0 = 0u;
        c.RA = 0x801C1AE8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C1AD0;
        L801C1AF0: ;
        if (c.V0 != 0u) {
            goto L801C1B48;
        }
        c.A0 = mem.ReadU32((c.GP + 0x2Cu));
        c.RA = 0x801C1B04u;
        Courier_Crisis_main.OpenTIM_main(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x14F8u;
        c.RA = 0x801C1B14u;
        Courier_Crisis_main.ReadTIM_main(c, m);
        if (c.V0 == 0u) {
            goto L801C1B58;
        }
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        if (c.A1 == 0u) {
            goto L801C1B58;
        }
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.RA = 0x801C1B40u;
        Courier_Crisis_main.LoadImage_main(c, m);
        goto L801C1B58;
        L801C1B48: ;
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C1AA0;
        }
        L801C1B58: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1504u));
        mem.WriteU16(c.V0, (ushort)0u);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1504u));
        c.V0 = 0u | 0x0100u;
        mem.WriteU16((c.V1 + 0x2u), (ushort)c.V0);
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        c.S0 = 0u | 0x0078u;
        c.RA = 0x801C1B90u;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1B98u;
        Courier_Crisis_main.func_801C0C74(c, m);
        L801C1B98: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1BA0u;
        Courier_Crisis_main.VSync_main(c, m);
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            goto L801C1B98;
        }
        c.S0 = 0u | 0x00F0u;
        L801C1BB0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1BB8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C1BC0u;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 != 0u) {
            goto L801C1BD4;
        }
        c.S0 = c.S0 - 0x1u;
        if ((int)c.S0 > 0) {
            goto L801C1BB0;
        }
        L801C1BD4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0u | 0x0001u;
        c.RA = 0x801C1BDCu;
        Courier_Crisis_main.PadRead_main(c, m);
        if (c.V0 == 0u) {
            goto L801C1BF4;
        }
        c.A0 = 0u;
        c.RA = 0x801C1BECu;
        Courier_Crisis_main.VSync_main(c, m);
        goto L801C1BD4;
        L801C1BF4: ;
        c.A0 = 0u;
        c.RA = 0x801C1BFCu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1C04u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1C0Cu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1C14u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1C1Cu;
        Courier_Crisis_main.func_801C0C74(c, m);
        c.A1 = 0x801E0000u;
        c.A1 = (uint)(short)mem.ReadU16((c.A1 + 0x14D8u));
        c.A2 = 0x801E0000u;
        c.A2 = (uint)(short)mem.ReadU16((c.A2 + 0x14DAu));
        c.A3 = 0x801E0000u;
        c.A3 = (uint)(short)mem.ReadU16((c.A3 + 0x14DCu));
        c.V0 = 0x801E0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 + 0x14DEu));
        c.S0 = 0x801E0000u;
        c.S0 = c.S0 + 0x1520u;
        c.A0 = c.S0;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C1C50u;
        Courier_Crisis_main.SetDefDrawEnv_main(c, m);
        c.A0 = 0u;
        c.A1 = 0u | 0x0002u;
        c.A2 = 0u;
        c.A3 = 0u;
        c.RA = 0x801C1C64u;
        Courier_Crisis_main.GetTPage_main(c, m);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x1534u), (ushort)c.V0);
        c.A0 = c.S0;
        c.RA = 0x801C1C74u;
        Courier_Crisis_main.PutDrawEnv_main(c, m);
        c.S0 = c.SP + 0x20u;
        c.A0 = c.S0;
        c.RA = 0x801C1C80u;
        Courier_Crisis_main.SetPolyF4_main(c, m);
        c.A0 = c.S0;
        c.A1 = 0u | 0x0001u;
        c.V1 = 0u | 0x0140u;
        c.V0 = 0u | 0x0100u;
        mem.WriteU16((c.SP + 0x32u), (ushort)c.V0);
        mem.WriteU16((c.SP + 0x36u), (ushort)c.V0);
        c.V0 = 0u | 0x0020u;
        mem.WriteU16((c.SP + 0x28u), (ushort)0u);
        mem.WriteU16((c.SP + 0x2Au), (ushort)0u);
        mem.WriteU16((c.SP + 0x2Cu), (ushort)c.V1);
        mem.WriteU16((c.SP + 0x2Eu), (ushort)0u);
        mem.WriteU16((c.SP + 0x30u), (ushort)0u);
        mem.WriteU16((c.SP + 0x34u), (ushort)c.V1);
        mem.WriteU8((c.SP + 0x24u), (byte)c.V0);
        mem.WriteU8((c.SP + 0x25u), (byte)c.V0);
        mem.WriteU8((c.SP + 0x26u), (byte)c.V0);
        c.RA = 0x801C1CC4u;
        Courier_Crisis_main.SetSemiTrans_main(c, m);
        c.A0 = c.S0;
        c.RA = 0x801C1CCCu;
        Courier_Crisis_main.DrawPrim_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1CD4u;
        Courier_Crisis_main.DrawSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1CDCu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = c.SP + 0x48u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0xCCu;
        c.S2 = 0u | 0x0080u;
        c.RA = 0x801C1CF0u;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            c.S1 = 0u;
            goto L801C1D10;
        }
        c.S1 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C1D08u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.A0 = c.SP + 0x18u;
        goto L801C1DC8;
        L801C1D10: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x4Cu));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x48u;
        c.A2 = c.SP + 0x60u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C1D2Cu;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A1 = mem.ReadU32((c.GP + 0x2Cu));
        c.A0 = c.S0;
        c.A2 = c.S2;
        c.RA = 0x801C1D3Cu;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C1D40: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C1D48u;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C1D60;
        }
        c.A0 = 0u;
        c.RA = 0x801C1D58u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C1D40;
        L801C1D60: ;
        if (c.V0 != 0u) {
            goto L801C1DB8;
        }
        c.A0 = mem.ReadU32((c.GP + 0x2Cu));
        c.RA = 0x801C1D74u;
        Courier_Crisis_main.OpenTIM_main(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x14F8u;
        c.RA = 0x801C1D84u;
        Courier_Crisis_main.ReadTIM_main(c, m);
        if (c.V0 == 0u) {
            c.A0 = c.SP + 0x18u;
            goto L801C1DC8;
        }
        c.A0 = c.SP + 0x18u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1508u));
        if (c.A1 == 0u) {
            goto L801C1DC8;
        }
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1504u));
        c.RA = 0x801C1DB0u;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = c.SP + 0x18u;
        goto L801C1DC8;
        L801C1DB8: ;
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.A0 = c.SP + 0x18u;
            goto L801C1D10;
        }
        c.A0 = c.SP + 0x18u;
        L801C1DC8: ;
        c.A1 = 0u | 0x0010u;
        c.A2 = 0u | 0x0090u;
        c.V0 = 0u | 0x0100u;
        mem.WriteU16((c.SP + 0x1Au), (ushort)c.V0);
        c.V0 = 0u | 0x0050u;
        mem.WriteU16((c.SP + 0x18u), (ushort)0u);
        mem.WriteU16((c.SP + 0x1Cu), (ushort)c.V0);
        mem.WriteU16((c.SP + 0x1Eu), (ushort)c.V0);
        c.RA = 0x801C1DECu;
        Courier_Crisis_main.MoveImage_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1DF4u;
        Courier_Crisis_main.DrawSync_main(c, m);
        c.A1 = 0x801E0000u;
        c.A1 = (uint)(short)mem.ReadU16((c.A1 + 0x14E0u));
        c.A2 = 0x801E0000u;
        c.A2 = (uint)(short)mem.ReadU16((c.A2 + 0x14E2u));
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU16((c.V0 + 0x14D8u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU16((c.V1 + 0x14DAu));
        c.A3 = mem.ReadU32((c.GP + 0xCu));
        c.T0 = mem.ReadU32((c.GP + 0x10u));
        c.A0 = c.SP + 0x18u;
        c.S3 = 0u | 0x0080u;
        mem.WriteU16((c.SP + 0x18u), (ushort)c.V0);
        mem.WriteU16((c.SP + 0x1Au), (ushort)c.V1);
        mem.WriteU16((c.SP + 0x1Cu), (ushort)c.A3);
        mem.WriteU16((c.SP + 0x1Eu), (ushort)c.T0);
        c.RA = 0x801C1E38u;
        Courier_Crisis_main.MoveImage_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1E40u;
        Courier_Crisis_main.DrawSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1E48u;
        Courier_Crisis_main.VSync_main(c, m);
        c.S2 = 0x80180000u;
        L801C1E4C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x0u;
        c.A0 = c.SP + 0x48u;
        c.RA = 0x801C1E5Cu;
        Courier_Crisis_main.CdSearchFile(c, m);
        if (c.V0 != 0u) {
            goto L801C1E84;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10u;
        c.RA = 0x801C1E74u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801C1EFC;
        L801C1E7C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0u | 0x0001u;
        goto L801C1EFC;
        L801C1E84: ;
        c.V0 = mem.ReadU32((c.SP + 0x4Cu));
        c.S1 = 0u;
        mem.WriteU32(c.S2, c.V0);
        c.S2 = 0x80180000u;
        c.S2 = c.S2 | 0x0004u;
        L801C1E98: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S0 = mem.ReadU32((c.SP + 0x4Cu));
        c.A0 = 0u | 0x0002u;
        c.A1 = c.SP + 0x48u;
        c.A2 = c.SP + 0x60u;
        c.S0 = c.S0 + 0x7FFu;
        c.S0 = c.S0 >> 11;
        c.RA = 0x801C1EB4u;
        Courier_Crisis_main.CdControlB_main(c, m);
        c.A0 = c.S0;
        c.A1 = c.S2;
        c.A2 = c.S3;
        c.RA = 0x801C1EC4u;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u | 0x0001u;
        L801C1EC8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0u;
        c.RA = 0x801C1ED0u;
        Courier_Crisis_main.CdReadSync_main(c, m);
        if ((int)c.V0 <= 0) {
            goto L801C1EE8;
        }
        c.A0 = 0u;
        c.RA = 0x801C1EE0u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u | 0x0001u;
        goto L801C1EC8;
        L801C1EE8: ;
        if (c.V0 == 0u) {
            c.S1 = c.S1 + 0x1u;
            goto L801C1E7C;
        }
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 100 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801C1E98;
        }
        c.V0 = 0u;
        L801C1EFC: ;
        if (c.V0 != 0u) {
            goto L801C1F1C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xECu;
        c.S2 = 0x80180000u;
        c.RA = 0x801C1F14u;
        Courier_Crisis_main.func_801C87FC(c, m);
        goto L801C1E4C;
        L801C1F1C: ;
        c.RA = 0x801C1F24u;
        Courier_Crisis_main.PadStop_main(c, m);
        c.RA = 0x801C1F2Cu;
        Courier_Crisis_main.StopCallback_main(c, m);
        c.RA = 0x801C1F34u;
        Courier_Crisis_main.func_801C1FBC(c, m);
        c.RA = 0x801C1F3Cu;
        Courier_Crisis_main.func_801C1FA4(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1F44u;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C1F4Cu;
        Courier_Crisis_main.VSync_main(c, m);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x10Cu;
        c.A1 = 0x801F0000u;
        c.A1 = c.A1 | 0xFF00u;
        c.A2 = 0u;
        c.RA = 0x801C1F64u;
        Courier_Crisis_main.func_801C1F94(c, m);
        c.RA = mem.ReadU32((c.SP + 0x78u));
        c.S3 = mem.ReadU32((c.SP + 0x74u));
        c.S2 = mem.ReadU32((c.SP + 0x70u));
        c.S1 = mem.ReadU32((c.SP + 0x6Cu));
        c.S0 = mem.ReadU32((c.SP + 0x68u));
        c.SP = c.SP + 0x80u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1F84(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000039u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1F94(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000051u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1FA4(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000071u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C1FBC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000072u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void PadInit_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.V0 = 0xFFFFFFFFu;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B54u), c.A0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x157Cu), c.V0);
        c.RA = 0x801C1FF8u;
        Courier_Crisis_main.ResetCallback_main(c, m);
        c.A0 = 0x20000000u;
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x157Cu;
        c.A0 = c.A0 | 0x0001u;
        c.RA = 0x801C200Cu;
        Courier_Crisis_main.PAD_init_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C2014u;
        Courier_Crisis_main.func_801C207C(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void PadRead_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801C2034u;
        Courier_Crisis_main.func_801C206C(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x157Cu));
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.V0 = ~(0u | c.V0);
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void PadStop_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801C205Cu;
        Courier_Crisis_main.StopPAD_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C206C(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000016u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C207C(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x0000005Bu;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetInitPadFlag_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x1C68u), c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ReadInitPadFlag_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x1C68u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void PAD_init_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A1;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = c.A2;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        mem.WriteU32((c.SP + 0x20u), c.RA);
        c.S3 = c.A3;
        c.RA = 0x801C20D8u;
        Courier_Crisis_main._remove_ChgclrPAD_main(c, m);
        c.RA = 0x801C20E0u;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.RA = 0x801C20E8u;
        Courier_Crisis_main._patch_pad_main(c, m);
        c.RA = 0x801C20F0u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C20F8u;
        Courier_Crisis_main.func_801C207C(c, m);
        c.RA = 0x801C2100u;
        Courier_Crisis_main.func_801C224C(c, m);
        c.A0 = c.S0;
        c.A1 = c.S1;
        c.A2 = c.S2;
        c.A3 = c.S3;
        c.RA = 0x801C2114u;
        Courier_Crisis_main.func_801C23DC(c, m);
        c.RA = 0x801C211Cu;
        Courier_Crisis_main._send_pad_main(c, m);
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x1C68u), c.V0);
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void InitPAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A1;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = c.A2;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        mem.WriteU32((c.SP + 0x20u), c.RA);
        c.S3 = c.A3;
        c.RA = 0x801C2174u;
        Courier_Crisis_main._remove_ChgclrPAD_main(c, m);
        c.RA = 0x801C217Cu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.RA = 0x801C2184u;
        Courier_Crisis_main._patch_pad_main(c, m);
        c.RA = 0x801C218Cu;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C2194u;
        Courier_Crisis_main.func_801C207C(c, m);
        c.RA = 0x801C219Cu;
        Courier_Crisis_main.func_801C224C(c, m);
        c.A0 = c.S0;
        c.A1 = c.S1;
        c.A2 = c.S2;
        c.A3 = c.S3;
        c.RA = 0x801C21B0u;
        Courier_Crisis_main.func_801C23AC(c, m);
        c.RA = 0x801C21B8u;
        Courier_Crisis_main._send_pad_main(c, m);
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x1C68u), c.V0);
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StartPAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801C21F4u;
        Courier_Crisis_main.func_801C23BC(c, m);
        c.A0 = 0u;
        c.RA = 0x801C21FCu;
        Courier_Crisis_main.func_801C207C(c, m);
        c.RA = 0x801C2204u;
        Courier_Crisis_main.EnablePAD_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StopPAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801C2224u;
        Courier_Crisis_main.DisablePAD_main(c, m);
        c.RA = 0x801C222Cu;
        Courier_Crisis_main.func_801C23CC(c, m);
        c.RA = 0x801C2234u;
        Courier_Crisis_main.func_801C22CC(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x1C68u), 0u);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C224C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.RA = 0x801C225Cu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.A0 = 0x00000001u;
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x1584u;
        c.S0 = c.V1 - 0x4u;
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x2304u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x236Cu;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1588u), c.V0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1580u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x158Cu), 0u);
        c.A1 = c.S0;
        c.RA = 0x801C22A0u;
        Courier_Crisis_main.func_801C241C(c, m);
        c.A0 = 0x00000001u;
        c.A1 = c.S0;
        c.RA = 0x801C22ACu;
        Courier_Crisis_main.func_801C240C(c, m);
        c.RA = 0x801C22B4u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.V0 = 0x00000001u;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C22CC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801C22DCu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x1580u;
        c.A0 = 0x00000001u;
        c.RA = 0x801C22ECu;
        Courier_Crisis_main.func_801C241C(c, m);
        c.RA = 0x801C22F4u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.V0 = 0x00000001u;
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2304(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x1C64u));
        c.SP = c.SP - 0x10u;
        mem.WriteU16((c.V0 + 0xAu), (ushort)0u);
        c.V0 = 0x0000000Au;
        mem.WriteU32(c.SP, c.V0);
        c.V0 = mem.ReadU32(c.SP);
        c.V0 = c.V0 - 0x1u;
        mem.WriteU32(c.SP, c.V0);
        c.V1 = mem.ReadU32(c.SP);
        c.V0 = 0xFFFFFFFFu;
        if (c.V1 == c.V0) {
            c.V0 = 0u;
            goto L801C2360;
        }
        c.V0 = 0u;
        c.V1 = 0xFFFFFFFFu;
        L801C2340: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.SP);
        c.V0 = c.V0 - 0x1u;
        mem.WriteU32(c.SP, c.V0);
        c.V0 = mem.ReadU32(c.SP);
        if (c.V0 != c.V1) {
            c.V0 = 0u;
            goto L801C2340;
        }
        c.V0 = 0u;
        L801C2360: ;
        c.SP = c.SP + 0x10u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C236C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x1C60u));
        c.V0 = mem.ReadU32((c.V1 + 0x4u));
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            c.V0 = 0u;
            goto L801C23A4;
        }
        c.V0 = 0u;
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 != 0u) {
            c.V0 = 0x00000001u;
            goto L801C23A4;
        }
        c.V0 = 0x00000001u;
        c.V0 = 0u;
        L801C23A4: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C23AC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000012u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C23BC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000013u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C23CC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000014u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C23DC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000015u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void EnterCriticalSection_main(CpuContext c, IMemory m)
    {
        c.A0 = 0x00000001u;
        Bios.Syscall(c, m);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ExitCriticalSection_main(CpuContext c, IMemory m)
    {
        c.A0 = 0x00000002u;
        Bios.Syscall(c, m);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C240C(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000C0u;
        c.T1 = 0x00000002u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C241C(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000C0u;
        c.T1 = 0x00000003u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void EnablePAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        L801C242C: ;
        c.T1 = 0x801E0000u;
        c.T1 = mem.ReadU32((c.T1 + 0x1488u));
        switch (c.T1)
        {
            case 0x801C242Cu: goto L801C242C;
            default: Dispatcher.Call(c, m, c.T1); return;
        }
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DisablePAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        L801C2440: ;
        c.T1 = 0x801E0000u;
        c.T1 = mem.ReadU32((c.T1 + 0x148Cu));
        switch (c.T1)
        {
            case 0x801C2440u: goto L801C2440;
            default: Dispatcher.Call(c, m, c.T1); return;
        }
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _patch_pad_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1480u), c.RA);
        c.RA = 0x801C2464u;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000057u;
        c.RA = 0x801C2470u;
        Dispatcher.Call(c, m, c.T2);
        c.V0 = mem.ReadU32((c.V0 + 0x16Cu));
        c.At = 0x801E0000u;
        c.V1 = c.V0 + 0x884u;
        mem.WriteU32((c.At + 0x1488u), c.V1);
        c.At = 0x801E0000u;
        c.V1 = c.V0 + 0x894u;
        c.T1 = 0x0000000Bu;
        mem.WriteU32((c.At + 0x148Cu), c.V1);
        L801C2490: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.T1 = c.T1 - 0x1u;
        mem.WriteU32((c.V0 + 0x594u), 0u);
        if (c.T1 != 0u) {
            c.V0 = c.V0 + 0x4u;
            goto L801C2490;
        }
        c.V0 = c.V0 + 0x4u;
        c.RA = 0x801C24A8u;
        Courier_Crisis_main.func_801C24BC(c, m);
        c.RA = 0x801E0000u;
        c.RA = mem.ReadU32((c.RA + 0x1480u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C24BC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000044u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _SendPAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.T1 = 0x801E0000u;
        c.T1 = mem.ReadU32((c.T1 + 0x1494u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.RA = 0x801C24E4u;
        Dispatcher.Call(c, m, c.T1);
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _send_pad_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1490u), c.RA);
        c.RA = 0x801C2504u;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000057u;
        c.RA = 0x801C2510u;
        Dispatcher.Call(c, m, c.T2);
        c.V0 = mem.ReadU32((c.V0 + 0x16Cu));
        c.T2 = 0x801C0000u;
        c.T1 = 0x801C0000u;
        c.At = 0x801E0000u;
        c.V1 = c.V0 + 0x7A0u;
        c.T2 = c.T2 + 0x2570u;
        c.T1 = c.T1 + 0x2580u;
        mem.WriteU32((c.At + 0x1494u), c.V1);
        L801C2530: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V1 = mem.ReadU32(c.T2);
        c.T2 = c.T2 + 0x4u;
        mem.WriteU32((c.V0 + 0x3D8u), c.V1);
        c.V0 = c.V0 + 0x4u;
        if (c.T2 != c.T1) {
            mem.WriteU32((c.V0 + 0x4DCu), c.V1);
            goto L801C2530;
        }
        mem.WriteU32((c.V0 + 0x4DCu), c.V1);
        c.RA = 0x801C2550u;
        Courier_Crisis_main.func_801C24BC(c, m);
        c.RA = 0x801C2558u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.RA = 0x801E0000u;
        c.RA = mem.ReadU32((c.RA + 0x1490u));
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1494u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _remove_ChgclrPAD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14A0u), c.RA);
        c.RA = 0x801C259Cu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000057u;
        c.RA = 0x801C25A8u;
        Dispatcher.Call(c, m, c.T2);
        c.V0 = mem.ReadU32((c.V0 + 0x16Cu));
        c.T2 = 0x00000009u;
        c.V1 = c.V0 + 0x62Cu;
        L801C25B4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.T2 = c.T2 - 0x1u;
        mem.WriteU32(c.V1, 0u);
        if (c.T2 != 0u) {
            c.V1 = c.V1 + 0x4u;
            goto L801C25B4;
        }
        c.V1 = c.V1 + 0x4u;
        c.RA = 0x801C25CCu;
        Courier_Crisis_main.func_801C24BC(c, m);
        c.RA = 0x801C25D4u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.RA = 0x801E0000u;
        c.RA = mem.ReadU32((c.RA + 0x14A0u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void VSync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibEtc.VSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2734(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        c.A1 = c.A1 << 15;
        mem.WriteU32((c.SP + 0x10u), c.A1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB30u));
        c.V0 = (int)c.V0 < (int)c.A0 ? 1u : 0u;
        if (c.V0 == 0u) {
            mem.WriteU32((c.SP + 0x18u), c.RA);
            goto L801C27C0;
        }
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.V1 = 0xFFFFFFFFu;
        L801C275C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        c.V0 = c.V0 - 0x1u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        if (c.V0 != c.V1) {
            goto L801C27A8;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x120u;
        c.RA = 0x801C278Cu;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.A0 = 0u;
        c.RA = 0x801C2794u;
        Courier_Crisis_main.func_801C207C(c, m);
        c.A0 = 0x00000003u;
        c.A1 = 0u;
        c.RA = 0x801C27A0u;
        Courier_Crisis_main.func_801C27D0(c, m);
        goto L801C27C0;
        L801C27A8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB30u));
        c.V0 = (int)c.V0 < (int)c.A0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C275C;
        }
        L801C27C0: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C27D0(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000C0u;
        c.T1 = 0x0000000Au;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ResetCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0xCu));
        c.RA = 0x801C2800u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void InterruptCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x8u));
        c.RA = 0x801C2830u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DMACallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x4u));
        c.RA = 0x801C2860u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void VSyncCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.A1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x14u));
        c.A0 = 0x00000004u;
        c.RA = 0x801C2894u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void VSyncCallbacks_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x14u));
        c.RA = 0x801C28C4u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StopCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x10u));
        c.RA = 0x801C28F4u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void RestartCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB64u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x18u));
        c.RA = 0x801C2924u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CheckCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU16((c.V0 - 0x1BEAu));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetIntrMask_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        c.V0 = mem.ReadU16(c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetIntrMask_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xB5Cu));
        c.V0 = mem.ReadU16(c.V1);
        mem.WriteU16(c.V1, (ushort)c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2978(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0x1BECu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.V0 = mem.ReadU16(c.S0);
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801C2A40;
        }
        c.V0 = 0u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xB60u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        c.A1 = 0x33330000u;
        mem.WriteU16(c.V0, (ushort)0u);
        c.V0 = mem.ReadU16(c.V0);
        c.A1 = c.A1 | 0x3333u;
        mem.WriteU16(c.V1, (ushort)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB58u));
        c.A0 = c.S0;
        mem.WriteU32(c.V0, c.A1);
        c.A1 = 0x0000041Au;
        c.RA = 0x801C29D8u;
        Courier_Crisis_main.func_801C2EC4(c, m);
        c.A0 = c.S0 + 0x38u;
        c.RA = 0x801C29E0u;
        Courier_Crisis_main.func_801C87CC(c, m);
        if (c.V0 == 0u) {
            goto L801C29F0;
        }
        c.RA = 0x801C29F0u;
        Courier_Crisis_main.func_801C2A54(c, m);
        L801C29F0: ;
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0x1BB0u;
        c.A0 = c.S0 - 0x4u;
        c.V0 = c.S0 + 0xFDCu;
        mem.WriteU32(c.S0, c.V0);
        c.RA = 0x801C2A08u;
        Courier_Crisis_main.func_801C2F10(c, m);
        c.V0 = 0x00000001u;
        mem.WriteU16((c.S0 - 0x3Cu), (ushort)c.V0);
        c.RA = 0x801C2A14u;
        Courier_Crisis_main.startIntrVSync_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xB64u));
        mem.WriteU32((c.V1 + 0x14u), c.V0);
        c.RA = 0x801C2A24u;
        Courier_Crisis_main.startIntrDMA_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB64u));
        mem.WriteU32((c.A0 + 0x4u), c.V0);
        c.RA = 0x801C2A34u;
        Courier_Crisis_main.func_801C1FBC(c, m);
        c.S0 = c.S0 - 0x3Cu;
        c.RA = 0x801C2A3Cu;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.V0 = c.S0;
        L801C2A40: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2A54(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = 0x801D0000u;
        c.S1 = c.S1 - 0x1BECu;
        mem.WriteU32((c.SP + 0x24u), c.RA);
        mem.WriteU32((c.SP + 0x20u), c.S4);
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        mem.WriteU32((c.SP + 0x18u), c.S2);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = mem.ReadU16(c.S1);
        if (c.V0 != 0u) {
            goto L801C2AB0;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB60u));
        c.A1 = mem.ReadU16(c.V0);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x164u;
        c.RA = 0x801C2AA8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.RA = 0x801C2AB0u;
        Courier_Crisis_main.func_801C2EF0(c, m);
        L801C2AB0: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB60u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU16((c.V1 - 0x1BBCu));
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x1BEAu), (ushort)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        c.A0 = mem.ReadU16(c.A0);
        c.V0 = mem.ReadU16(c.V0);
        c.V1 = c.V1 & c.A0;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            c.S0 = c.V0;
            goto L801C2B80;
        }
        c.S0 = c.V0;
        c.S3 = 0x00000001u;
        c.S4 = c.S1 + 0x4u;
        L801C2AF4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        if (c.S0 == 0u) {
            c.S1 = 0u;
            goto L801C2B50;
        }
        c.S1 = 0u;
        c.S2 = c.S4;
        L801C2B00: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = (int)c.S1 < 11 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.S0 & 0x0001u;
            goto L801C2B50;
        }
        c.V0 = c.S0 & 0x0001u;
        if (c.V0 == 0u) {
            c.V0 = c.S3 << (int)(c.S1 & 31u);
            goto L801C2B3C;
        }
        c.V0 = c.S3 << (int)(c.S1 & 31u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xB60u));
        c.V0 = ~(0u | c.V0);
        mem.WriteU16(c.V1, (ushort)c.V0);
        c.V0 = mem.ReadU32(c.S2);
        if (c.V0 == 0u) {
            goto L801C2B3C;
        }
        c.RA = 0x801C2B3Cu;
        Dispatcher.Call(c, m, c.V0);
        L801C2B3C: ;
        c.S2 = c.S2 + 0x4u;
        c.S0 = c.S0 >> 1;
        c.V0 = c.S0 & 0xFFFFu;
        if (c.V0 != 0u) {
            c.S1 = c.S1 + 0x1u;
            goto L801C2B00;
        }
        c.S1 = c.S1 + 0x1u;
        L801C2B50: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB60u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU16((c.V1 - 0x1BBCu));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        c.A0 = mem.ReadU16(c.A0);
        c.V0 = mem.ReadU16(c.V0);
        c.V1 = c.V1 & c.A0;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            c.S0 = c.V0;
            goto L801C2AF4;
        }
        c.S0 = c.V0;
        L801C2B80: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0xB60u));
        c.A2 = 0x801D0000u;
        c.A2 = mem.ReadU32((c.A2 - 0xB5Cu));
        c.V1 = mem.ReadU16(c.A1);
        c.V0 = mem.ReadU16(c.A2);
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            goto L801C2C00;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB54u));
        c.V1 = c.V0 + 0x1u;
        c.V0 = (int)c.V0 < 2049 ? 1u : 0u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xB54u), c.V1);
        if (c.V0 != 0u) {
            goto L801C2C08;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x180u;
        c.A1 = mem.ReadU16(c.A1);
        c.A2 = mem.ReadU16(c.A2);
        c.RA = 0x801C2BE4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB60u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xB54u), 0u);
        mem.WriteU16(c.V0, (ushort)0u);
        goto L801C2C08;
        L801C2C00: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xB54u), 0u);
        L801C2C08: ;
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x1BEAu), (ushort)0u);
        c.RA = 0x801C2C18u;
        Courier_Crisis_main.func_801C2EF0(c, m);
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S4 = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2C3C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = c.A1;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 - 0x1BE8u;
        c.V0 = c.S1 << 2;
        c.A0 = c.V0 + c.A1;
        mem.WriteU32((c.SP + 0x24u), c.RA);
        mem.WriteU32((c.SP + 0x20u), c.S4);
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S4 = mem.ReadU32(c.A0);
        if (c.S2 == c.S4) {
            c.V0 = c.S4;
            goto L801C2D6C;
        }
        c.V0 = c.S4;
        c.V0 = mem.ReadU16((c.A1 - 0x4u));
        if (c.V0 == 0u) {
            c.V0 = c.S4;
            goto L801C2D6C;
        }
        c.V0 = c.S4;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        c.V1 = mem.ReadU16(c.V0);
        mem.WriteU16(c.V0, (ushort)0u);
        if (c.S2 == 0u) {
            c.S3 = c.V1 & 0xFFFFu;
            goto L801C2CCC;
        }
        c.S3 = c.V1 & 0xFFFFu;
        c.V1 = 0x00000001u;
        c.V1 = c.V1 << (int)(c.S1 & 31u);
        mem.WriteU32(c.A0, c.S2);
        c.V0 = mem.ReadU16((c.A1 + 0x2Cu));
        c.S3 = c.S3 | c.V1;
        c.V0 = c.V0 | c.V1;
        mem.WriteU16((c.A1 + 0x2Cu), (ushort)c.V0);
        goto L801C2CF4;
        L801C2CCC: ;
        c.V0 = 0x00000001u;
        c.V0 = c.V0 << (int)(c.S1 & 31u);
        c.V0 = ~(0u | c.V0);
        mem.WriteU32(c.A0, 0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU16((c.V1 - 0x1BBCu));
        c.S3 = c.S3 & c.V0;
        c.V1 = c.V1 & c.V0;
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x1BBCu), (ushort)c.V1);
        L801C2CF4: ;
        if (c.S1 != 0u) {
            c.V0 = 0x00000004u;
            goto L801C2D18;
        }
        c.V0 = 0x00000004u;
        c.S0 = c.S2 < 0x00000001u ? 1u : 0u;
        c.A0 = c.S0;
        c.RA = 0x801C2D08u;
        Courier_Crisis_main.func_801C207C(c, m);
        c.A0 = 0x00000003u;
        c.A1 = c.S0;
        c.RA = 0x801C2D14u;
        Courier_Crisis_main.func_801C27D0(c, m);
        c.V0 = 0x00000004u;
        L801C2D18: ;
        if (c.S1 != c.V0) {
            c.V0 = 0x00000005u;
            goto L801C2D30;
        }
        c.V0 = 0x00000005u;
        c.A0 = 0u;
        c.A1 = c.S2 < 0x00000001u ? 1u : 0u;
        c.RA = 0x801C2D2Cu;
        Courier_Crisis_main.func_801C27D0(c, m);
        c.V0 = 0x00000005u;
        L801C2D30: ;
        if (c.S1 != c.V0) {
            c.V0 = 0x00000006u;
            goto L801C2D48;
        }
        c.V0 = 0x00000006u;
        c.A0 = 0x00000001u;
        c.A1 = c.S2 < 0x00000001u ? 1u : 0u;
        c.RA = 0x801C2D44u;
        Courier_Crisis_main.func_801C27D0(c, m);
        c.V0 = 0x00000006u;
        L801C2D48: ;
        if (c.S1 != c.V0) {
            c.A0 = 0x00000002u;
            goto L801C2D58;
        }
        c.A0 = 0x00000002u;
        c.A1 = c.S2 < 0x00000001u ? 1u : 0u;
        c.RA = 0x801C2D58u;
        Courier_Crisis_main.func_801C27D0(c, m);
        L801C2D58: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        mem.WriteU16(c.V0, (ushort)c.S3);
        c.V0 = c.S4;
        L801C2D6C: ;
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S4 = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2D90(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0x1BECu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.V0 = mem.ReadU16(c.S0);
        if (c.V0 == 0u) {
            c.V0 = 0u;
            goto L801C2E28;
        }
        c.V0 = 0u;
        c.RA = 0x801C2DBCu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB5Cu));
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB58u));
        c.V1 = mem.ReadU16(c.V0);
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x1BBAu), (ushort)c.V1);
        c.V1 = mem.ReadU32(c.A0);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB60u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x1BB8u), c.V1);
        mem.WriteU16(c.V0, (ushort)0u);
        c.V0 = mem.ReadU16(c.V0);
        mem.WriteU16(c.A0, (ushort)c.V0);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB58u));
        c.V1 = 0x77770000u;
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 | 0x7777u;
        c.V0 = c.V0 & c.V1;
        mem.WriteU32(c.A0, c.V0);
        c.RA = 0x801C2E20u;
        Courier_Crisis_main.func_801C2F00(c, m);
        c.V0 = c.S0;
        mem.WriteU16(c.V0, (ushort)0u);
        L801C2E28: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2E3C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0x1BECu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.V0 = mem.ReadU16(c.S0);
        if (c.V0 != 0u) {
            goto L801C2EAC;
        }
        c.A0 = c.S0 + 0x38u;
        c.RA = 0x801C2E68u;
        Courier_Crisis_main.func_801C2F10(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB5Cu));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU16((c.V1 - 0x1BBAu));
        c.V0 = 0x00000001u;
        mem.WriteU16(c.S0, (ushort)c.V0);
        mem.WriteU16(c.A0, (ushort)c.V1);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xB58u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x1BB8u));
        mem.WriteU32(c.V1, c.V0);
        c.RA = 0x801C2EA4u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.V0 = c.S0;
        goto L801C2EB0;
        L801C2EAC: ;
        c.V0 = 0u;
        L801C2EB0: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2EC4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        if (c.A1 == 0u) {
            c.V0 = c.A1 - 0x1u;
            goto L801C2EE4;
        }
        c.V0 = c.A1 - 0x1u;
        c.V1 = 0xFFFFFFFFu;
        L801C2ED4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU32(c.A0, 0u);
        c.V0 = c.V0 - 0x1u;
        if (c.V0 != c.V1) {
            c.A0 = c.A0 + 0x4u;
            goto L801C2ED4;
        }
        c.A0 = c.A0 + 0x4u;
        L801C2EE4: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2EF0(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000017u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2F00(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000018u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2F10(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000019u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void startIntrVSync_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0xB50u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xB2Cu));
        c.V0 = 0x00000107u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        mem.WriteU32(c.V1, c.V0);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xB30u), 0u);
        c.A1 = 0x00000008u;
        c.RA = 0x801C2F50u;
        Courier_Crisis_main.func_801C301C(c, m);
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x2F78u;
        c.A0 = 0u;
        c.RA = 0x801C2F60u;
        Courier_Crisis_main.InterruptCallback_main(c, m);
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x2FF0u;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2F78(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB30u));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = 0u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0xB50u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xB30u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB30u));
        L801C2FB0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.S0);
        if (c.V0 == 0u) {
            goto L801C2FC8;
        }
        c.RA = 0x801C2FC8u;
        Dispatcher.Call(c, m, c.V0);
        L801C2FC8: ;
        c.S1 = c.S1 + 0x1u;
        c.V0 = (int)c.S1 < 8 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S0 = c.S0 + 0x4u;
            goto L801C2FB0;
        }
        c.S0 = c.S0 + 0x4u;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C2FF0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0xB50u;
        c.A0 = c.A0 << 2;
        c.A0 = c.A0 + c.V0;
        c.V0 = mem.ReadU32(c.A0);
        if (c.A1 == c.V0) {
            goto L801C3014;
        }
        mem.WriteU32(c.A0, c.A1);
        L801C3014: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C301C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        if (c.A1 == 0u) {
            c.V0 = c.A1 - 0x1u;
            goto L801C303C;
        }
        c.V0 = c.A1 - 0x1u;
        c.V1 = 0xFFFFFFFFu;
        L801C302C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU32(c.A0, 0u);
        c.V0 = c.V0 - 0x1u;
        if (c.V0 != c.V1) {
            c.A0 = c.A0 + 0x4u;
            goto L801C302C;
        }
        c.A0 = c.A0 + 0x4u;
        L801C303C: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void startIntrDMA_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0xB24u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A1 = 0x00000008u;
        c.RA = 0x801C3060u;
        Courier_Crisis_main.func_801C32C4(c, m);
        c.A0 = 0x00000003u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB28u));
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x3098u;
        mem.WriteU32(c.V0, 0u);
        c.RA = 0x801C3080u;
        Courier_Crisis_main.InterruptCallback_main(c, m);
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x321Cu;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C3098(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB28u));
        c.SP = c.SP - 0x30u;
        mem.WriteU32((c.SP + 0x28u), c.RA);
        mem.WriteU32((c.SP + 0x24u), c.S5);
        mem.WriteU32((c.SP + 0x20u), c.S4);
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        mem.WriteU32((c.SP + 0x18u), c.S2);
        mem.WriteU32((c.SP + 0x14u), c.S1);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 >> 24;
        c.S1 = c.V0 & 0x007Fu;
        if (c.S1 == 0u) {
            goto L801C3174;
        }
        c.S4 = 0x00000001u;
        c.S3 = 0x00FF0000u;
        c.S3 = c.S3 | 0xFFFFu;
        c.S5 = 0x801D0000u;
        c.S5 = c.S5 - 0xB24u;
        L801C30EC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        if (c.S1 == 0u) {
            c.S0 = 0u;
            goto L801C3150;
        }
        c.S0 = 0u;
        c.S2 = c.S5;
        L801C30F8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = (int)c.S0 < 7 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.S1 & 0x0001u;
            goto L801C3150;
        }
        c.V0 = c.S1 & 0x0001u;
        if (c.V0 == 0u) {
            c.V0 = c.S0 + 0x18u;
            goto L801C3140;
        }
        c.V0 = c.S0 + 0x18u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xB28u));
        c.V0 = c.S4 << (int)(c.V0 & 31u);
        c.V1 = mem.ReadU32(c.A0);
        c.V0 = c.V0 | c.S3;
        c.V1 = c.V1 & c.V0;
        mem.WriteU32(c.A0, c.V1);
        c.V0 = mem.ReadU32(c.S2);
        if (c.V0 == 0u) {
            goto L801C3140;
        }
        c.RA = 0x801C3140u;
        Dispatcher.Call(c, m, c.V0);
        L801C3140: ;
        c.S2 = c.S2 + 0x4u;
        c.S1 = c.S1 >> 1;
        if (c.S1 != 0u) {
            c.S0 = c.S0 + 0x1u;
            goto L801C30F8;
        }
        c.S0 = c.S0 + 0x1u;
        L801C3150: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB28u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 >> 24;
        c.S1 = c.V0 & 0x007Fu;
        if (c.S1 != 0u) {
            goto L801C30EC;
        }
        L801C3174: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0xB28u));
        c.V0 = mem.ReadU32(c.A1);
        c.V1 = 0xFF000000u;
        c.V0 = c.V0 & c.V1;
        c.V1 = 0x80000000u;
        if (c.V0 == c.V1) {
            goto L801C31AC;
        }
        c.V0 = mem.ReadU32(c.A1);
        c.V0 = c.V0 & 0x8000u;
        if (c.V0 == 0u) {
            goto L801C31F4;
        }
        L801C31AC: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x19Cu;
        c.A1 = mem.ReadU32(c.A1);
        c.S0 = 0u;
        c.RA = 0x801C31C0u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C31C0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x1B8u;
        c.A1 = c.S0;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB04u));
        c.V1 = c.S0 << 4;
        c.V1 = c.V1 + c.V0;
        c.A2 = mem.ReadU32(c.V1);
        c.S0 = c.S0 + 0x1u;
        c.RA = 0x801C31E8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = (int)c.S0 < 7 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C31C0;
        }
        L801C31F4: ;
        c.RA = mem.ReadU32((c.SP + 0x28u));
        c.S5 = mem.ReadU32((c.SP + 0x24u));
        c.S4 = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x30u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C321C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A2 = c.A0;
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 - 0xB24u;
        c.V0 = c.A2 << 2;
        c.V1 = c.V0 + c.V1;
        c.A3 = mem.ReadU32(c.V1);
        c.A0 = c.A1;
        if (c.A0 == c.A3) {
            goto L801C32BC;
        }
        if (c.A0 == 0u) {
            c.V0 = 0x00FF0000u;
            goto L801C3284;
        }
        c.V0 = 0x00FF0000u;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0xB28u));
        c.V0 = c.V0 | 0xFFFFu;
        mem.WriteU32(c.V1, c.A0);
        c.A0 = mem.ReadU32(c.A1);
        c.V1 = c.A2 + 0x10u;
        c.A0 = c.A0 & c.V0;
        c.V0 = 0x00000001u;
        c.V0 = c.V0 << (int)(c.V1 & 31u);
        c.V1 = 0x00800000u;
        c.V0 = c.V0 | c.V1;
        c.A0 = c.A0 | c.V0;
        mem.WriteU32(c.A1, c.A0);
        goto L801C32BC;
        L801C3284: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0xB28u));
        c.V0 = c.V0 | 0xFFFFu;
        mem.WriteU32(c.V1, 0u);
        c.V1 = mem.ReadU32(c.A1);
        c.A0 = c.A2 + 0x10u;
        c.V1 = c.V1 & c.V0;
        c.V0 = 0x00800000u;
        c.V1 = c.V1 | c.V0;
        c.V0 = 0x00000001u;
        c.V0 = c.V0 << (int)(c.A0 & 31u);
        c.V0 = ~(0u | c.V0);
        c.V1 = c.V1 & c.V0;
        mem.WriteU32(c.A1, c.V1);
        L801C32BC: ;
        c.V0 = c.A3;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C32C4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        if (c.A1 == 0u) {
            c.V0 = c.A1 - 0x1u;
            goto L801C32E4;
        }
        c.V0 = c.A1 - 0x1u;
        c.V1 = 0xFFFFFFFFu;
        L801C32D4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU32(c.A0, 0u);
        c.V0 = c.V0 - 0x1u;
        if (c.V0 != c.V1) {
            c.A0 = c.A0 + 0x4u;
            goto L801C32D4;
        }
        c.A0 = c.A0 + 0x4u;
        L801C32E4: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C32F0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB00u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xB00u), c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C3308(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xB00u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void LoadTPage_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x30u;
        mem.WriteU32((c.SP + 0x24u), c.S3);
        c.S3 = mem.ReadU32((c.SP + 0x40u));
        c.V1 = mem.ReadU32((c.SP + 0x44u));
        c.V0 = mem.ReadU32((c.SP + 0x48u));
        c.T0 = c.A0;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x20u), c.S2);
        c.S2 = c.A2;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A3;
        mem.WriteU32((c.SP + 0x28u), c.RA);
        mem.WriteU16((c.SP + 0x10u), (ushort)c.S1);
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.V0 = 0x00000001u;
        if (c.S0 == c.V0) {
            mem.WriteU16((c.SP + 0x12u), (ushort)c.S3);
            goto L801C33A8;
        }
        mem.WriteU16((c.SP + 0x12u), (ushort)c.S3);
        c.V0 = (int)c.S0 < 2 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C337C;
        }
        if (c.S0 == 0u) {
            c.A0 = c.SP + 0x10u;
            goto L801C3390;
        }
        c.A0 = c.SP + 0x10u;
        goto L801C33C4;
        L801C337C: ;
        c.V0 = 0x00000002u;
        if (c.S0 == c.V0) {
            c.A0 = c.SP + 0x10u;
            goto L801C33BC;
        }
        c.A0 = c.SP + 0x10u;
        goto L801C33C4;
        L801C3390: ;
        if ((int)c.V1 >= 0) {
            c.V0 = c.V1;
            goto L801C339C;
        }
        c.V0 = c.V1;
        c.V0 = c.V1 + 0x3u;
        L801C339C: ;
        c.V0 = (uint)((int)c.V0 >> 2);
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V0);
        goto L801C33C0;
        L801C33A8: ;
        c.V0 = c.V1 >> 31;
        c.V0 = c.V1 + c.V0;
        c.V0 = (uint)((int)c.V0 >> 1);
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V0);
        goto L801C33C0;
        L801C33BC: ;
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V1);
        L801C33C0: ;
        c.A0 = c.SP + 0x10u;
        L801C33C4: ;
        c.A1 = c.T0;
        c.RA = 0x801C33CCu;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = c.S0;
        c.A1 = c.S2;
        c.A2 = c.S1;
        c.A3 = c.S3;
        c.RA = 0x801C33E0u;
        Courier_Crisis_main.GetTPage_main(c, m);
        c.V0 = c.V0 & 0xFFFFu;
        c.RA = mem.ReadU32((c.SP + 0x28u));
        c.S3 = mem.ReadU32((c.SP + 0x24u));
        c.S2 = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x30u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void LoadClut_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        c.V0 = c.A0;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A2;
        c.A0 = c.SP + 0x10u;
        c.A1 = c.V0;
        c.V0 = 0x00000100u;
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V0);
        c.V0 = 0x00000001u;
        mem.WriteU32((c.SP + 0x20u), c.RA);
        mem.WriteU16((c.SP + 0x10u), (ushort)c.S0);
        mem.WriteU16((c.SP + 0x12u), (ushort)c.S1);
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.RA = 0x801C3444u;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = c.S0;
        c.A1 = c.S1;
        c.RA = 0x801C3450u;
        Courier_Crisis_main.GetClut_main(c, m);
        c.V0 = c.V0 & 0xFFFFu;
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void LoadClut2_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        c.V0 = c.A0;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A2;
        c.A0 = c.SP + 0x10u;
        c.A1 = c.V0;
        c.V0 = 0x00000010u;
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V0);
        c.V0 = 0x00000001u;
        mem.WriteU32((c.SP + 0x20u), c.RA);
        mem.WriteU16((c.SP + 0x10u), (ushort)c.S0);
        mem.WriteU16((c.SP + 0x12u), (ushort)c.S1);
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.RA = 0x801C34ACu;
        Courier_Crisis_main.LoadImage_main(c, m);
        c.A0 = c.S0;
        c.A1 = c.S1;
        c.RA = 0x801C34B8u;
        Courier_Crisis_main.GetClut_main(c, m);
        c.V0 = c.V0 & 0xFFFFu;
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDefDrawEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = mem.ReadU32((c.SP + 0x38u));
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        c.S3 = c.A1;
        mem.WriteU32((c.SP + 0x20u), c.S4);
        c.S4 = c.A2;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        mem.WriteU32((c.SP + 0x24u), c.RA);
        c.S0 = c.A3;
        c.RA = 0x801C3508u;
        Courier_Crisis_main.func_801C3308(c, m);
        c.V1 = 0x00000001u;
        mem.WriteU16(c.S1, (ushort)c.S3);
        mem.WriteU16((c.S1 + 0x2u), (ushort)c.S4);
        mem.WriteU16((c.S1 + 0x4u), (ushort)c.S0);
        mem.WriteU16((c.S1 + 0xCu), (ushort)0u);
        mem.WriteU16((c.S1 + 0xEu), (ushort)0u);
        mem.WriteU16((c.S1 + 0x10u), (ushort)0u);
        mem.WriteU16((c.S1 + 0x12u), (ushort)0u);
        mem.WriteU8((c.S1 + 0x19u), (byte)0u);
        mem.WriteU8((c.S1 + 0x1Au), (byte)0u);
        mem.WriteU8((c.S1 + 0x1Bu), (byte)0u);
        mem.WriteU8((c.S1 + 0x16u), (byte)c.V1);
        if (c.V0 == 0u) {
            mem.WriteU16((c.S1 + 0x6u), (ushort)c.S2);
            goto L801C3548;
        }
        mem.WriteU16((c.S1 + 0x6u), (ushort)c.S2);
        c.V0 = (int)c.S2 < 289 ? 1u : 0u;
        goto L801C354C;
        L801C3548: ;
        c.V0 = (int)c.S2 < 257 ? 1u : 0u;
        L801C354C: ;
        mem.WriteU8((c.S1 + 0x17u), (byte)c.V0);
        c.V0 = c.S1;
        c.V1 = 0x0000000Au;
        mem.WriteU16((c.V0 + 0x8u), (ushort)c.S3);
        mem.WriteU16((c.V0 + 0xAu), (ushort)c.S4);
        mem.WriteU16((c.V0 + 0x14u), (ushort)c.V1);
        mem.WriteU8((c.V0 + 0x18u), (byte)0u);
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S4 = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDefDispEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = mem.ReadU32((c.SP + 0x10u));
        c.V0 = c.A0;
        mem.WriteU16(c.V0, (ushort)c.A1);
        mem.WriteU16((c.V0 + 0x2u), (ushort)c.A2);
        mem.WriteU16((c.V0 + 0x4u), (ushort)c.A3);
        mem.WriteU16((c.V0 + 0x8u), (ushort)0u);
        mem.WriteU16((c.V0 + 0xAu), (ushort)0u);
        mem.WriteU16((c.V0 + 0xCu), (ushort)0u);
        mem.WriteU16((c.V0 + 0xEu), (ushort)0u);
        mem.WriteU8((c.V0 + 0x11u), (byte)0u);
        mem.WriteU8((c.V0 + 0x10u), (byte)0u);
        mem.WriteU8((c.V0 + 0x13u), (byte)0u);
        mem.WriteU8((c.V0 + 0x12u), (byte)0u);
        mem.WriteU16((c.V0 + 0x6u), (ushort)c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetTPage_main(CpuContext c, IMemory m)
    {
        c.V0 = c.A0 & 0x0003u;
        c.V0 = c.V0 << 7;
        c.A1 = c.A1 & 0x0003u;
        c.A1 = c.A1 << 5;
        c.V0 = c.V0 | c.A1;
        c.V1 = c.A3 & 0x0100u;
        c.V1 = (uint)((int)c.V1 >> 4);
        c.V0 = c.V0 | c.V1;
        c.A2 = c.A2 & 0x03FFu;
        c.A2 = (uint)((int)c.A2 >> 6);
        c.V0 = c.V0 | c.A2;
        c.A3 = c.A3 & 0x0200u;
        c.A3 = c.A3 << 2;
        c.V0 = c.V0 | c.A3;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetClut_main(CpuContext c, IMemory m)
    {
        c.V0 = c.A1 << 6;
        c.A0 = (uint)((int)c.A0 >> 4);
        c.A0 = c.A0 & 0x003Fu;
        c.V0 = c.V0 | c.A0;
        c.V0 = c.V0 & 0xFFFFu;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DumpTPage_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        c.A3 = c.A0 & 0xFFFFu;
        c.V1 = c.A3 << 4;
        c.V1 = c.V1 & 0x0100u;
        c.V0 = c.A3 >> 2;
        c.V0 = c.V0 & 0x0200u;
        c.V1 = c.V1 + c.V0;
        c.A1 = c.A3 >> 7;
        c.A2 = c.A3 >> 5;
        c.A3 = c.A3 << 6;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x1C8u;
        c.A1 = c.A1 & 0x0003u;
        c.A2 = c.A2 & 0x0003u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A3 = c.A3 & 0x07C0u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.V1);
        c.RA = 0x801C366Cu;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DumpClut_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.A2 = c.A0;
        c.A1 = c.A2 & 0x003Fu;
        c.A2 = c.A2 & 0xFFFFu;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x1E0u;
        c.A1 = c.A1 << 4;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A2 = c.A2 >> 6;
        c.RA = 0x801C36ACu;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void NextPrim_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x00FF0000u;
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        c.V1 = 0x80000000u;
        c.V0 = c.V0 | c.V1;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void IsEndPrim_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x00FF0000u;
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        c.V0 = c.V0 ^ c.V1;
        c.V0 = c.V0 < 0x00000001u ? 1u : 0u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void AddPrim_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A2 = 0x00FF0000u;
        c.A2 = c.A2 | 0xFFFFu;
        c.A3 = 0xFF000000u;
        c.V1 = mem.ReadU32(c.A1);
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 & c.A3;
        c.V0 = c.V0 & c.A2;
        c.V1 = c.V1 | c.V0;
        mem.WriteU32(c.A1, c.V1);
        c.V0 = mem.ReadU32(c.A0);
        c.A1 = c.A1 & c.A2;
        c.V0 = c.V0 & c.A3;
        c.V0 = c.V0 | c.A1;
        mem.WriteU32(c.A0, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void AddPrims_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A3 = 0x00FF0000u;
        c.A3 = c.A3 | 0xFFFFu;
        c.T0 = 0xFF000000u;
        c.V1 = mem.ReadU32(c.A2);
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 & c.T0;
        c.V0 = c.V0 & c.A3;
        c.V1 = c.V1 | c.V0;
        mem.WriteU32(c.A2, c.V1);
        c.V0 = mem.ReadU32(c.A0);
        c.A1 = c.A1 & c.A3;
        c.V0 = c.V0 & c.T0;
        c.V0 = c.V0 | c.A1;
        mem.WriteU32(c.A0, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CatPrim_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A2 = 0x00FF0000u;
        c.A2 = c.A2 | 0xFFFFu;
        c.V1 = 0xFF000000u;
        c.V0 = mem.ReadU32(c.A0);
        c.A1 = c.A1 & c.A2;
        c.V0 = c.V0 & c.V1;
        c.V0 = c.V0 | c.A1;
        mem.WriteU32(c.A0, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void TermPrim_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x00FF0000u;
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.A0, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetSemiTrans_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        if (c.A1 == 0u) {
            goto L801C37BC;
        }
        c.V0 = mem.ReadU8((c.A0 + 0x7u));
        c.V0 = c.V0 | 0x0002u;
        goto L801C37C8;
        L801C37BC: ;
        c.V0 = mem.ReadU8((c.A0 + 0x7u));
        c.V0 = c.V0 & 0x00FDu;
        L801C37C8: ;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetShadeTex_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        if (c.A1 == 0u) {
            goto L801C37E4;
        }
        c.V0 = mem.ReadU8((c.A0 + 0x7u));
        c.V0 = c.V0 | 0x0001u;
        goto L801C37F0;
        L801C37E4: ;
        c.V0 = mem.ReadU8((c.A0 + 0x7u));
        c.V0 = c.V0 & 0x00FEu;
        L801C37F0: ;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyF3_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000004u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000020u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyFT3_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000007u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000024u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyG3_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000006u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000030u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyGT3_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000009u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000034u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyF4_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000005u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000028u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyFT4_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000009u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x0000002Cu;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyG4_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000008u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000038u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPolyGT4_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x0000000Cu;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x0000003Cu;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetSprt8_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000003u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000074u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetSprt16_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000003u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x0000007Cu;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetSprt_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000004u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000064u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetTile1_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000002u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000068u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetTile8_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000002u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000070u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetTile16_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000002u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000078u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetTile_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000003u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000060u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetLineF2_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000003u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000040u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetLineG2_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000004u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000050u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetLineF3_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x55550000u;
        c.V1 = c.V1 | 0x5555u;
        c.V0 = 0x00000005u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000048u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        mem.WriteU32((c.A0 + 0x14u), c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetLineG3_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x55550000u;
        c.V1 = c.V1 | 0x5555u;
        c.V0 = 0x00000007u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x00000058u;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        mem.WriteU32((c.A0 + 0x1Cu), c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetLineF4_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x55550000u;
        c.V1 = c.V1 | 0x5555u;
        c.V0 = 0x00000006u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x0000004Cu;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        mem.WriteU32((c.A0 + 0x18u), c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetLineG4_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x55550000u;
        c.V1 = c.V1 | 0x5555u;
        c.V0 = 0x00000009u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        c.V0 = 0x0000005Cu;
        mem.WriteU8((c.A0 + 0x7u), (byte)c.V0);
        mem.WriteU32((c.A0 + 0x24u), c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawTPage_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000001u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        if (c.A2 == 0u) {
            c.V1 = 0xE1000000u;
            goto L801C39E0;
        }
        c.V1 = 0xE1000000u;
        c.V1 = c.V1 | 0x0200u;
        L801C39E0: ;
        if (c.A1 == 0u) {
            c.V0 = c.A3 & 0x09FFu;
            goto L801C39EC;
        }
        c.V0 = c.A3 & 0x09FFu;
        c.V0 = c.V0 | 0x0400u;
        L801C39EC: ;
        c.V0 = c.V1 | c.V0;
        mem.WriteU32((c.A0 + 0x4u), c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawMove_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.T0 = c.A0;
        c.V0 = (uint)(short)mem.ReadU16((c.A1 + 0x4u));
        if (c.V0 == 0u) {
            c.A0 = 0x00000005u;
            goto L801C3A1C;
        }
        c.A0 = 0x00000005u;
        c.V0 = (uint)(short)mem.ReadU16((c.A1 + 0x6u));
        if (c.V0 != 0u) {
            c.V0 = 0x01000000u;
            goto L801C3A24;
        }
        c.V0 = 0x01000000u;
        L801C3A1C: ;
        c.A0 = 0u;
        c.V0 = 0x01000000u;
        L801C3A24: ;
        mem.WriteU32((c.T0 + 0x4u), c.V0);
        c.V0 = 0x80000000u;
        mem.WriteU32((c.T0 + 0x8u), c.V0);
        c.V0 = c.A3 << 16;
        c.V1 = c.A2 & 0xFFFFu;
        mem.WriteU8((c.T0 + 0x3u), (byte)c.A0);
        c.A0 = mem.ReadU32(c.A1);
        c.V0 = c.V0 | c.V1;
        mem.WriteU32((c.T0 + 0x10u), c.V0);
        mem.WriteU32((c.T0 + 0xCu), c.A0);
        c.V0 = mem.ReadU32((c.A1 + 0x4u));
        mem.WriteU32((c.T0 + 0x14u), c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawLoad_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = (uint)(short)mem.ReadU16((c.A1 + 0x4u));
        c.V0 = (uint)(short)mem.ReadU16((c.A1 + 0x6u));
        { var _r = (long)(int)c.V1 * (int)c.V0; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.A2 = c.LO;
        c.V0 = c.A2 + 0x1u;
        c.V1 = c.V0 >> 31;
        c.V0 = c.V0 + c.V1;
        c.V0 = (uint)((int)c.V0 >> 1);
        c.V1 = c.V0 + 0x4u;
        c.V0 = c.V0 < 0x0000000Du ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0xA0000000u;
            goto L801C3A90;
        }
        c.V0 = 0xA0000000u;
        c.V1 = 0u;
        L801C3A90: ;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V1);
        mem.WriteU32((c.A0 + 0x4u), c.V0);
        c.V0 = mem.ReadU32(c.A1);
        mem.WriteU32((c.A0 + 0x8u), c.V0);
        c.V0 = mem.ReadU32((c.A1 + 0x4u));
        mem.WriteU32((c.A0 + 0xCu), c.V0);
        c.V0 = c.V1 << 2;
        c.V0 = c.A0 + c.V0;
        c.V1 = 0x01000000u;
        mem.WriteU32(c.V0, c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void MargePrim_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = mem.ReadU8((c.A0 + 0x3u));
        c.V1 = mem.ReadU8((c.A1 + 0x3u));
        c.V0 = c.V0 + c.V1;
        c.V1 = c.V0 + 0x1u;
        c.V0 = (int)c.V1 < 17 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = 0u;
            goto L801C3AF0;
        }
        c.V0 = 0u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V1);
        mem.WriteU32(c.A1, 0u);
        goto L801C3AF4;
        L801C3AF0: ;
        c.V0 = 0xFFFFFFFFu;
        L801C3AF4: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DumpDrawEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        c.A1 = (uint)(short)mem.ReadU16(c.S0);
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.A3 = (uint)(short)mem.ReadU16((c.S0 + 0x4u));
        c.V0 = (uint)(short)mem.ReadU16((c.S0 + 0x6u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x1F0u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C3B34u;
        Dispatcher.Call(c, m, c.V1);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x8u));
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0xAu));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x208u;
        c.RA = 0x801C3B54u;
        Dispatcher.Call(c, m, c.V0);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0xCu));
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0xEu));
        c.A3 = (uint)(short)mem.ReadU16((c.S0 + 0x10u));
        c.V0 = (uint)(short)mem.ReadU16((c.S0 + 0x12u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x218u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C3B7Cu;
        Dispatcher.Call(c, m, c.V1);
        c.A1 = mem.ReadU8((c.S0 + 0x16u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x230u;
        c.RA = 0x801C3B98u;
        Dispatcher.Call(c, m, c.V0);
        c.A1 = mem.ReadU8((c.S0 + 0x17u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x23Cu;
        c.RA = 0x801C3BB4u;
        Dispatcher.Call(c, m, c.V0);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x1C8u;
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        c.T0 = 0x801D0000u;
        c.T0 = mem.ReadU32((c.T0 - 0xAB0u));
        c.A1 = c.V0 >> 7;
        c.A1 = c.A1 & 0x0003u;
        c.A2 = c.V0 >> 5;
        c.A2 = c.A2 & 0x0003u;
        c.A3 = c.V0 << 6;
        c.A3 = c.A3 & 0x07C0u;
        c.V1 = c.V0 << 4;
        c.V1 = c.V1 & 0x0100u;
        c.V0 = c.V0 >> 2;
        c.V0 = c.V0 & 0x0200u;
        c.V1 = c.V1 + c.V0;
        mem.WriteU32((c.SP + 0x10u), c.V1);
        c.RA = 0x801C3BFCu;
        Dispatcher.Call(c, m, c.T0);
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DumpDispEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        c.A1 = (uint)(short)mem.ReadU16(c.S0);
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.A3 = (uint)(short)mem.ReadU16((c.S0 + 0x4u));
        c.V0 = (uint)(short)mem.ReadU16((c.S0 + 0x6u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x248u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C3C48u;
        Dispatcher.Call(c, m, c.V1);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x8u));
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0xAu));
        c.A3 = (uint)(short)mem.ReadU16((c.S0 + 0xCu));
        c.V0 = (uint)(short)mem.ReadU16((c.S0 + 0xEu));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x264u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C3C70u;
        Dispatcher.Call(c, m, c.V1);
        c.A1 = mem.ReadU8((c.S0 + 0x10u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x280u;
        c.RA = 0x801C3C8Cu;
        Dispatcher.Call(c, m, c.V0);
        c.A1 = mem.ReadU8((c.S0 + 0x11u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x28Cu;
        c.RA = 0x801C3CA8u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ResetGraph_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        c.V1 = c.S1 & 0x0007u;
        c.V0 = 0x00000003u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        if (c.V1 == c.V0) {
            mem.WriteU32((c.SP + 0x10u), c.S0);
            goto L801C3D0C;
        }
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = (int)c.V1 < 4 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C3CF8;
        }
        if (c.V1 == 0u) {
            goto L801C3D0C;
        }
        goto L801C3DD8;
        L801C3CF8: ;
        c.V0 = 0x00000005u;
        if (c.V1 == c.V0) {
            goto L801C3D2C;
        }
        goto L801C3DD8;
        L801C3D0C: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x2CCu;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 - 0xAF4u;
        c.A2 = 0x801D0000u;
        c.A2 = c.A2 - 0xAACu;
        c.RA = 0x801C3D2Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C3D2C: ;
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0xAACu;
        c.A0 = c.S0;
        c.A1 = 0u;
        c.A2 = 0x00000080u;
        c.RA = 0x801C3D44u;
        Courier_Crisis_main.func_801C6D24(c, m);
        c.RA = 0x801C3D4Cu;
        Courier_Crisis_main.ResetCallback_main(c, m);
        c.V0 = 0x00FF0000u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0xAB4u));
        c.V0 = c.V0 | 0xFFFFu;
        c.A0 = c.A0 & c.V0;
        c.RA = 0x801C3D64u;
        Courier_Crisis_main.func_801C6D50(c, m);
        c.A0 = c.S1;
        c.RA = 0x801C3D6Cu;
        Courier_Crisis_main.func_801C6804(c, m);
        c.A0 = c.S0 + 0x10u;
        c.V1 = 0x00000001u;
        mem.WriteU8(c.S0, (byte)c.V0);
        c.V0 = c.V0 & 0x00FFu;
        c.V0 = c.V0 << 2;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At - 0xAABu), (byte)c.V1);
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.V1 = mem.ReadU32((c.At - 0xA2Cu));
        c.A1 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0xAA8u), (ushort)c.V1);
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At - 0xA18u));
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0xAA6u), (ushort)c.V0);
        c.A2 = 0x0000005Cu;
        c.RA = 0x801C3DBCu;
        Courier_Crisis_main.func_801C6D24(c, m);
        c.A0 = c.S0 + 0x6Cu;
        c.A1 = 0xFFFFFFFFu;
        c.A2 = 0x00000014u;
        c.RA = 0x801C3DCCu;
        Courier_Crisis_main.func_801C6D24(c, m);
        c.V0 = mem.ReadU8(c.S0);
        goto L801C3E28;
        L801C3DD8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAAAu));
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C3E0C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x2ECu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A1 = c.S1;
        c.RA = 0x801C3E0Cu;
        Dispatcher.Call(c, m, c.V0);
        L801C3E0C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        c.V0 = mem.ReadU32((c.V0 + 0x34u));
        c.A0 = 0x00000001u;
        c.RA = 0x801C3E28u;
        Dispatcher.Call(c, m, c.V0);
        L801C3E28: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetGraphReverse_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAAAu));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0xAA9u;
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = mem.ReadU8(c.S0);
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S1 = c.A0;
            goto L801C3E90;
        }
        c.S1 = c.A0;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x300u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A1 = c.S1;
        c.RA = 0x801C3E90u;
        Dispatcher.Call(c, m, c.V0);
        L801C3E90: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        mem.WriteU8(c.S0, (byte)c.S1);
        c.V0 = mem.ReadU32((c.V0 + 0x28u));
        c.A0 = 0x00000008u;
        c.RA = 0x801C3EACu;
        Dispatcher.Call(c, m, c.V0);
        c.V1 = mem.ReadU8(c.S0);
        if (c.V1 == 0u) {
            c.A0 = c.V0;
            goto L801C3EC8;
        }
        c.A0 = c.V0;
        c.V0 = 0x08000000u;
        c.V0 = c.V0 | 0x0080u;
        goto L801C3ECC;
        L801C3EC8: ;
        c.V0 = 0x08000000u;
        L801C3ECC: ;
        c.A0 = c.A0 | c.V0;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        c.V0 = mem.ReadU32((c.V0 + 0x10u));
        c.RA = 0x801C3EECu;
        Dispatcher.Call(c, m, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU8((c.V1 - 0xAACu));
        c.V0 = 0x00000002u;
        if (c.V1 != c.V0) {
            c.V0 = c.S2;
            goto L801C3F38;
        }
        c.V0 = c.S2;
        c.A0 = 0x20000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAA9u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB4u));
        if (c.V0 == 0u) {
            c.A0 = c.A0 | 0x0504u;
            goto L801C3F24;
        }
        c.A0 = c.A0 | 0x0504u;
        c.A0 = 0x20000000u;
        c.A0 = c.A0 | 0x0501u;
        L801C3F24: ;
        c.V0 = mem.ReadU32((c.V1 + 0x10u));
        c.RA = 0x801C3F34u;
        Dispatcher.Call(c, m, c.V0);
        c.V0 = c.S2;
        L801C3F38: ;
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetGraphDebug_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0xAAAu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = mem.ReadU8(c.V0);
        c.A1 = c.A0 & 0x00FFu;
        if (c.A1 == 0u) {
            mem.WriteU8(c.V0, (byte)c.A0);
            goto L801C3FA0;
        }
        mem.WriteU8(c.V0, (byte)c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A2 = 0x801D0000u;
        c.A2 = mem.ReadU8((c.A2 - 0xAACu));
        c.A3 = 0x801D0000u;
        c.A3 = mem.ReadU8((c.A3 - 0xAA9u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x318u;
        c.RA = 0x801C3FA0u;
        Dispatcher.Call(c, m, c.V0);
        L801C3FA0: ;
        c.V0 = c.S0;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetGraphQueue_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAAAu));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = 0x801D0000u;
        c.S1 = c.S1 - 0xAABu;
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = mem.ReadU8(c.S1);
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S0 = c.A0;
            goto L801C4008;
        }
        c.S0 = c.A0;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x344u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A1 = c.S0;
        c.RA = 0x801C4008u;
        Dispatcher.Call(c, m, c.V0);
        L801C4008: ;
        c.V0 = mem.ReadU8(c.S1);
        if (c.S0 == c.V0) {
            c.V0 = c.S2;
            goto L801C4048;
        }
        c.V0 = c.S2;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        c.V0 = mem.ReadU32((c.V0 + 0x34u));
        c.A0 = 0x00000001u;
        c.RA = 0x801C4034u;
        Dispatcher.Call(c, m, c.V0);
        c.A0 = 0x00000002u;
        c.A1 = 0u;
        mem.WriteU8(c.S1, (byte)c.S0);
        c.RA = 0x801C4044u;
        Courier_Crisis_main.DMACallback_main(c, m);
        c.V0 = c.S2;
        L801C4048: ;
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetGraphType_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAACu));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetGraphDebug_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAAAu));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DrawSyncCallback_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.DrawSyncCallback(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDispMask_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = 0x801D0000u;
        c.S1 = c.S1 - 0xAAAu;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = mem.ReadU8(c.S1);
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S0 = c.A0;
            goto L801C4128;
        }
        c.S0 = c.A0;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x374u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A1 = c.S0;
        c.RA = 0x801C4128u;
        Dispatcher.Call(c, m, c.V0);
        L801C4128: ;
        if (c.S0 != 0u) {
            c.A0 = c.S1 + 0x6Au;
            goto L801C413C;
        }
        c.A0 = c.S1 + 0x6Au;
        c.A1 = 0xFFFFFFFFu;
        c.A2 = 0x00000014u;
        c.RA = 0x801C413Cu;
        Courier_Crisis_main.func_801C6D24(c, m);
        L801C413C: ;
        c.A0 = 0x03000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        if (c.S0 == 0u) {
            c.A0 = c.A0 | 0x0001u;
            goto L801C4154;
        }
        c.A0 = c.A0 | 0x0001u;
        c.A0 = 0x03000000u;
        L801C4154: ;
        c.V0 = mem.ReadU32((c.V0 + 0x10u));
        c.RA = 0x801C4164u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DrawSync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.DrawSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C41E8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        c.T0 = c.A0;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A1;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU8((c.V1 - 0xAAAu));
        c.V0 = 0x00000001u;
        if (c.V1 == c.V0) {
            mem.WriteU32((c.SP + 0x1Cu), c.RA);
            goto L801C4220;
        }
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        c.V0 = 0x00000002u;
        if (c.V1 == c.V0) {
            goto L801C42B8;
        }
        goto L801C42FC;
        L801C4220: ;
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x4u));
        c.V1 = 0x801D0000u;
        c.V1 = (uint)(short)mem.ReadU16((c.V1 - 0xAA8u));
        c.V0 = (int)c.V1 < (int)c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C42A8;
        }
        c.A3 = (uint)(short)mem.ReadU16(c.S0);
        c.V0 = c.A1 + c.A3;
        c.V0 = (int)c.V1 < (int)c.V0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C42A8;
        }
        c.V1 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.A0 = 0x801D0000u;
        c.A0 = (uint)(short)mem.ReadU16((c.A0 - 0xAA6u));
        c.V0 = (int)c.A0 < (int)c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C42A8;
        }
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0x6u));
        c.V0 = c.V1 + c.A2;
        c.V0 = (int)c.A0 < (int)c.V0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C42A8;
        }
        if ((int)c.A1 <= 0) {
            goto L801C42A8;
        }
        if ((int)c.A3 < 0) {
            goto L801C42A8;
        }
        if ((int)c.V1 < 0) {
            goto L801C42A8;
        }
        if ((int)c.A2 > 0) {
            goto L801C42FC;
        }
        L801C42A8: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x39Cu;
        goto L801C42C0;
        L801C42B8: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x3BCu;
        L801C42C0: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A1 = c.T0;
        c.RA = 0x801C42D4u;
        Dispatcher.Call(c, m, c.V0);
        c.A1 = (uint)(short)mem.ReadU16(c.S0);
        c.A2 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.A3 = (uint)(short)mem.ReadU16((c.S0 + 0x4u));
        c.V0 = (uint)(short)mem.ReadU16((c.S0 + 0x6u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x3A8u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C42FCu;
        Dispatcher.Call(c, m, c.V1);
        L801C42FC: ;
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ClearImage_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.ClearImage(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ClearImage2_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        c.S3 = c.A0;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x3C0u;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = c.A1;
        c.A1 = c.S3;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A2;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        mem.WriteU32((c.SP + 0x20u), c.RA);
        c.S1 = c.A3;
        c.RA = 0x801C43DCu;
        Courier_Crisis_main.func_801C41E8(c, m);
        c.A1 = c.S3;
        c.S1 = c.S1 & 0x00FFu;
        c.S1 = c.S1 << 16;
        c.S0 = c.S0 & 0x00FFu;
        c.S0 = c.S0 << 8;
        c.V0 = 0x80000000u;
        c.S0 = c.S0 | c.V0;
        c.S1 = c.S1 | c.S0;
        c.S2 = c.S2 & 0x00FFu;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB4u));
        c.A2 = 0x00000008u;
        c.A0 = mem.ReadU32((c.V1 + 0xCu));
        c.V0 = mem.ReadU32((c.V1 + 0x8u));
        c.A3 = c.S1 | c.S2;
        c.RA = 0x801C4420u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void LoadImage_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.LoadImage(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StoreImage_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.StoreImage(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void MoveImage_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.MoveImage(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ClearOTag_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAAAu));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A1;
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x18u), c.RA);
            goto L801C4610;
        }
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x3F0u;
        c.A1 = c.S0;
        c.A2 = c.S1;
        c.RA = 0x801C4610u;
        Dispatcher.Call(c, m, c.V0);
        L801C4610: ;
        c.S1 = c.S1 - 0x1u;
        if (c.S1 == 0u) {
            c.V1 = 0x00FF0000u;
            goto L801C4654;
        }
        c.V1 = 0x00FF0000u;
        c.A1 = 0x00FF0000u;
        c.A1 = c.A1 | 0xFFFFu;
        c.A2 = 0xFF000000u;
        L801C4628: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.S1 = c.S1 - 0x1u;
        c.A0 = c.S0 + 0x4u;
        mem.WriteU8((c.S0 + 0x3u), (byte)0u);
        c.V0 = mem.ReadU32(c.S0);
        c.V1 = c.A0 & c.A1;
        c.V0 = c.V0 & c.A2;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.S0, c.V0);
        if (c.S1 != 0u) {
            c.S0 = c.A0;
            goto L801C4628;
        }
        c.S0 = c.A0;
        c.V1 = 0x00FF0000u;
        L801C4654: ;
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0x9F0u;
        c.V0 = c.V0 & c.V1;
        mem.WriteU32(c.S0, c.V0);
        c.V0 = c.S0;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ClearOTagR_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAAAu));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A1;
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x18u), c.RA);
            goto L801C46CC;
        }
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x408u;
        c.A1 = c.S0;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A2 = c.S1;
        c.RA = 0x801C46CCu;
        Dispatcher.Call(c, m, c.V0);
        L801C46CC: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        c.A0 = c.S0;
        c.V0 = mem.ReadU32((c.V0 + 0x2Cu));
        c.A1 = c.S1;
        c.RA = 0x801C46E8u;
        Dispatcher.Call(c, m, c.V0);
        c.A0 = 0x00FF0000u;
        c.A0 = c.A0 | 0xFFFFu;
        c.V0 = c.S0;
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 - 0x9F0u;
        c.V1 = c.V1 & c.A0;
        mem.WriteU32(c.V0, c.V1);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DrawPrim_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.DrawPrim(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DrawOTag_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.DrawOTag(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void PutDrawEnv_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.PutDrawEnv(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DrawOTagEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = c.A0;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        c.S3 = 0x801D0000u;
        c.S3 = c.S3 - 0xAAAu;
        mem.WriteU32((c.SP + 0x20u), c.RA);
        mem.WriteU32((c.SP + 0x14u), c.S1);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = mem.ReadU8(c.S3);
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S1 = c.A1;
            goto L801C494C;
        }
        c.S1 = c.A1;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x44Cu;
        c.A1 = c.S2;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB0u));
        c.A2 = c.S1;
        c.RA = 0x801C494Cu;
        Dispatcher.Call(c, m, c.V0);
        L801C494C: ;
        c.S0 = c.S1 + 0x1Cu;
        c.A0 = c.S0;
        c.A1 = c.S1;
        c.RA = 0x801C495Cu;
        Courier_Crisis_main.func_801C52F8(c, m);
        c.A0 = 0x00FF0000u;
        c.A0 = c.A0 | 0xFFFFu;
        c.A1 = c.S0;
        c.A2 = 0x00000040u;
        c.V1 = 0xFF000000u;
        c.V0 = mem.ReadU32((c.S1 + 0x1Cu));
        c.A0 = c.S2 & c.A0;
        c.V0 = c.V0 & c.V1;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0xAB4u));
        c.V0 = c.V0 | c.A0;
        mem.WriteU32((c.S1 + 0x1Cu), c.V0);
        c.A0 = mem.ReadU32((c.V1 + 0x18u));
        c.V0 = mem.ReadU32((c.V1 + 0x8u));
        c.A3 = 0u;
        c.RA = 0x801C49A0u;
        Dispatcher.Call(c, m, c.V0);
        c.A3 = c.S3 + 0xEu;
        c.A2 = c.S1;
        c.T0 = c.A2 + 0x50u;
        L801C49AC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A2);
        c.V1 = mem.ReadU32((c.A2 + 0x4u));
        c.A0 = mem.ReadU32((c.A2 + 0x8u));
        c.A1 = mem.ReadU32((c.A2 + 0xCu));
        mem.WriteU32(c.A3, c.V0);
        mem.WriteU32((c.A3 + 0x4u), c.V1);
        mem.WriteU32((c.A3 + 0x8u), c.A0);
        mem.WriteU32((c.A3 + 0xCu), c.A1);
        c.A2 = c.A2 + 0x10u;
        if (c.A2 != c.T0) {
            c.A3 = c.A3 + 0x10u;
            goto L801C49AC;
        }
        c.A3 = c.A3 + 0x10u;
        c.V0 = mem.ReadU32(c.A2);
        c.V1 = mem.ReadU32((c.A2 + 0x4u));
        c.A0 = mem.ReadU32((c.A2 + 0x8u));
        mem.WriteU32(c.A3, c.V0);
        mem.WriteU32((c.A3 + 0x4u), c.V1);
        mem.WriteU32((c.A3 + 0x8u), c.A0);
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetDrawEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 - 0xA9Cu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.A2 = 0x0000005Cu;
        c.RA = 0x801C4A30u;
        Courier_Crisis_main.func_801C87DC(c, m);
        c.V0 = c.S0;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void PutDispEnv_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibGpu.PutDispEnv(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetDispEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 - 0xA40u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.A2 = 0x00000014u;
        c.RA = 0x801C4F10u;
        Courier_Crisis_main.func_801C87DC(c, m);
        c.V0 = c.S0;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void GetODE_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAB4u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = mem.ReadU32((c.V0 + 0x38u));
        c.RA = 0x801C4F48u;
        Dispatcher.Call(c, m, c.V0);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.V0 = c.V0 >> 31;
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetTexWindow_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.V0 = 0x00000002u;
        c.A0 = c.A1;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        mem.WriteU8((c.S0 + 0x3u), (byte)c.V0);
        c.RA = 0x801C4F78u;
        Courier_Crisis_main.func_801C57BC(c, m);
        mem.WriteU32((c.S0 + 0x4u), c.V0);
        mem.WriteU32((c.S0 + 0x8u), 0u);
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawArea_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A1;
        c.V0 = 0x00000002u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU8((c.S1 + 0x3u), (byte)c.V0);
        c.A0 = (uint)(short)mem.ReadU16(c.S0);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.RA = 0x801C4FC4u;
        Courier_Crisis_main.func_801C55E0(c, m);
        mem.WriteU32((c.S1 + 0x4u), c.V0);
        c.A0 = mem.ReadU16(c.S0);
        c.V0 = mem.ReadU16((c.S0 + 0x4u));
        c.A1 = mem.ReadU16((c.S0 + 0x2u));
        c.A0 = c.A0 + c.V0;
        c.A0 = c.A0 - 0x1u;
        c.A0 = c.A0 << 16;
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        c.A0 = (uint)((int)c.A0 >> 16);
        c.A1 = c.A1 + c.V0;
        c.A1 = c.A1 - 0x1u;
        c.A1 = c.A1 << 16;
        c.A1 = (uint)((int)c.A1 >> 16);
        c.RA = 0x801C4FFCu;
        Courier_Crisis_main.func_801C56AC(c, m);
        mem.WriteU32((c.S1 + 0x8u), c.V0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawOffset_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.V0 = 0x00000002u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        mem.WriteU8((c.S0 + 0x3u), (byte)c.V0);
        c.A0 = (uint)(short)mem.ReadU16(c.A1);
        c.A1 = (uint)(short)mem.ReadU16((c.A1 + 0x2u));
        c.RA = 0x801C5040u;
        Courier_Crisis_main.func_801C5778(c, m);
        mem.WriteU32((c.S0 + 0x4u), c.V0);
        mem.WriteU32((c.S0 + 0x8u), 0u);
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetPriority_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x00000002u;
        mem.WriteU8((c.A0 + 0x3u), (byte)c.V0);
        if (c.A1 == 0u) {
            c.V0 = 0xE6000000u;
            goto L801C5070;
        }
        c.V0 = 0xE6000000u;
        c.V0 = c.V0 | 0x0002u;
        L801C5070: ;
        if (c.A2 == 0u) {
            goto L801C507C;
        }
        c.V0 = c.V0 | 0x0001u;
        L801C507C: ;
        mem.WriteU32((c.A0 + 0x4u), c.V0);
        mem.WriteU32((c.A0 + 0x8u), 0u);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawMode_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A0 = c.A1;
        c.V0 = 0x00000002u;
        c.A1 = c.A2;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = mem.ReadU32((c.SP + 0x30u));
        c.A2 = c.A3 & 0xFFFFu;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU8((c.S0 + 0x3u), (byte)c.V0);
        c.RA = 0x801C50B8u;
        Courier_Crisis_main.func_801C5588(c, m);
        mem.WriteU32((c.S0 + 0x4u), c.V0);
        c.A0 = c.S1;
        c.RA = 0x801C50C4u;
        Courier_Crisis_main.func_801C57BC(c, m);
        mem.WriteU32((c.S0 + 0x8u), c.V0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetDrawEnv_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x40u;
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x34u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x38u), c.RA);
        c.A0 = (uint)(short)mem.ReadU16(c.S0);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.RA = 0x801C5108u;
        Courier_Crisis_main.func_801C55E0(c, m);
        mem.WriteU32((c.S1 + 0x4u), c.V0);
        c.A0 = mem.ReadU16((c.S0 + 0x4u));
        c.V0 = mem.ReadU16(c.S0);
        c.A1 = mem.ReadU16((c.S0 + 0x2u));
        c.A0 = c.A0 + c.V0;
        c.A0 = c.A0 - 0x1u;
        c.A0 = c.A0 << 16;
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        c.A0 = (uint)((int)c.A0 >> 16);
        c.A1 = c.A1 + c.V0;
        c.A1 = c.A1 - 0x1u;
        c.A1 = c.A1 << 16;
        c.A1 = (uint)((int)c.A1 >> 16);
        c.RA = 0x801C5140u;
        Courier_Crisis_main.func_801C56AC(c, m);
        mem.WriteU32((c.S1 + 0x8u), c.V0);
        c.A0 = (uint)(short)mem.ReadU16((c.S0 + 0x8u));
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0xAu));
        c.RA = 0x801C5154u;
        Courier_Crisis_main.func_801C5778(c, m);
        mem.WriteU32((c.S1 + 0xCu), c.V0);
        c.A0 = mem.ReadU8((c.S0 + 0x17u));
        c.A1 = mem.ReadU8((c.S0 + 0x16u));
        c.A2 = mem.ReadU16((c.S0 + 0x14u));
        c.RA = 0x801C516Cu;
        Courier_Crisis_main.func_801C5588(c, m);
        c.A0 = c.S0 + 0xCu;
        mem.WriteU32((c.S1 + 0x10u), c.V0);
        c.RA = 0x801C5178u;
        Courier_Crisis_main.func_801C57BC(c, m);
        mem.WriteU32((c.S1 + 0x14u), c.V0);
        c.V0 = 0xE6000000u;
        mem.WriteU32((c.S1 + 0x18u), c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x18u));
        if (c.V0 == 0u) {
            c.A3 = 0x00000007u;
            goto L801C52D8;
        }
        c.A3 = 0x00000007u;
        c.V0 = mem.ReadU16(c.S0);
        mem.WriteU16((c.SP + 0x10u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x2u));
        mem.WriteU16((c.SP + 0x12u), (ushort)c.V0);
        c.A0 = mem.ReadU16((c.S0 + 0x4u));
        mem.WriteU16((c.SP + 0x14u), (ushort)c.A0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.V0 = c.A0 << 16;
        c.A1 = (uint)((int)c.V0 >> 16);
        if ((int)c.A1 < 0) {
            c.V0 = 0u;
            goto L801C51F8;
        }
        c.V0 = 0u;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.V1 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.V1 - 0x1u;
            goto L801C51F8;
        }
        c.V0 = c.V1 - 0x1u;
        c.V0 = c.A0;
        L801C51F8: ;
        c.A1 = (uint)(short)mem.ReadU16((c.SP + 0x16u));
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V0);
        if ((int)c.A1 < 0) {
            c.A0 = c.A1;
            goto L801C5230;
        }
        c.A0 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.V1 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.V1 - 0x1u;
            goto L801C5234;
        }
        c.V0 = c.V1 - 0x1u;
        c.V0 = c.A0;
        goto L801C5234;
        L801C5230: ;
        c.V0 = 0u;
        L801C5234: ;
        c.A2 = c.A3 << 2;
        c.A3 = c.A3 + 0x1u;
        c.A1 = c.A3 << 2;
        c.A3 = c.A3 + 0x1u;
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.SP + 0x10u));
        c.V1 = mem.ReadU16((c.S0 + 0x8u));
        c.A2 = c.A2 + c.S1;
        c.V0 = c.V0 - c.V1;
        mem.WriteU16((c.SP + 0x10u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.SP + 0x12u));
        c.V1 = mem.ReadU16((c.S0 + 0xAu));
        c.A0 = 0x60000000u;
        c.V0 = c.V0 - c.V1;
        mem.WriteU16((c.SP + 0x12u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x1Bu));
        c.V1 = mem.ReadU8((c.S0 + 0x1Au));
        c.V0 = c.V0 << 16;
        c.V1 = c.V1 << 8;
        c.V1 = c.V1 | c.A0;
        c.A0 = mem.ReadU8((c.S0 + 0x19u));
        c.V0 = c.V0 | c.V1;
        c.V0 = c.V0 | c.A0;
        mem.WriteU32(c.A2, c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        c.A1 = c.A1 + c.S1;
        mem.WriteU32(c.A1, c.V0);
        c.V0 = c.A3 << 2;
        c.V1 = mem.ReadU32((c.SP + 0x14u));
        c.V0 = c.V0 + c.S1;
        mem.WriteU32(c.V0, c.V1);
        c.V0 = mem.ReadU16((c.SP + 0x10u));
        c.V1 = mem.ReadU16((c.S0 + 0x8u));
        c.V0 = c.V0 + c.V1;
        mem.WriteU16((c.SP + 0x10u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.SP + 0x12u));
        c.V1 = mem.ReadU16((c.S0 + 0xAu));
        c.A3 = c.A3 + 0x1u;
        c.V0 = c.V0 + c.V1;
        mem.WriteU16((c.SP + 0x12u), (ushort)c.V0);
        L801C52D8: ;
        c.V0 = c.A3 - 0x1u;
        mem.WriteU8((c.S1 + 0x3u), (byte)c.V0);
        c.RA = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x40u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C52F8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x40u;
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x34u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x38u), c.RA);
        c.A0 = (uint)(short)mem.ReadU16(c.S0);
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0x2u));
        c.RA = 0x801C5320u;
        Courier_Crisis_main.func_801C55E0(c, m);
        mem.WriteU32((c.S1 + 0x4u), c.V0);
        c.A0 = mem.ReadU16((c.S0 + 0x4u));
        c.V0 = mem.ReadU16(c.S0);
        c.A1 = mem.ReadU16((c.S0 + 0x2u));
        c.A0 = c.A0 + c.V0;
        c.A0 = c.A0 - 0x1u;
        c.A0 = c.A0 << 16;
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        c.A0 = (uint)((int)c.A0 >> 16);
        c.A1 = c.A1 + c.V0;
        c.A1 = c.A1 - 0x1u;
        c.A1 = c.A1 << 16;
        c.A1 = (uint)((int)c.A1 >> 16);
        c.RA = 0x801C5358u;
        Courier_Crisis_main.func_801C56AC(c, m);
        mem.WriteU32((c.S1 + 0x8u), c.V0);
        c.A0 = (uint)(short)mem.ReadU16((c.S0 + 0x8u));
        c.A1 = (uint)(short)mem.ReadU16((c.S0 + 0xAu));
        c.RA = 0x801C536Cu;
        Courier_Crisis_main.func_801C5778(c, m);
        mem.WriteU32((c.S1 + 0xCu), c.V0);
        c.A0 = mem.ReadU8((c.S0 + 0x17u));
        c.A1 = mem.ReadU8((c.S0 + 0x16u));
        c.A2 = mem.ReadU16((c.S0 + 0x14u));
        c.RA = 0x801C5384u;
        Courier_Crisis_main.func_801C5588(c, m);
        c.A0 = c.S0 + 0xCu;
        mem.WriteU32((c.S1 + 0x10u), c.V0);
        c.RA = 0x801C5390u;
        Courier_Crisis_main.func_801C57BC(c, m);
        mem.WriteU32((c.S1 + 0x14u), c.V0);
        c.V0 = 0xE6000000u;
        mem.WriteU32((c.S1 + 0x18u), c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x18u));
        if (c.V0 == 0u) {
            c.T0 = 0x00000007u;
            goto L801C5568;
        }
        c.T0 = 0x00000007u;
        c.V0 = mem.ReadU16(c.S0);
        mem.WriteU16((c.SP + 0x10u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x2u));
        mem.WriteU16((c.SP + 0x12u), (ushort)c.V0);
        c.A0 = mem.ReadU16((c.S0 + 0x4u));
        mem.WriteU16((c.SP + 0x14u), (ushort)c.A0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.V0 = c.A0 << 16;
        c.A1 = (uint)((int)c.V0 >> 16);
        if ((int)c.A1 < 0) {
            c.V0 = 0u;
            goto L801C5410;
        }
        c.V0 = 0u;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.V1 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.V1 - 0x1u;
            goto L801C5410;
        }
        c.V0 = c.V1 - 0x1u;
        c.V0 = c.A0;
        L801C5410: ;
        c.A1 = (uint)(short)mem.ReadU16((c.SP + 0x16u));
        mem.WriteU16((c.SP + 0x14u), (ushort)c.V0);
        if ((int)c.A1 < 0) {
            c.A0 = c.A1;
            goto L801C5448;
        }
        c.A0 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.V1 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.V1 - 0x1u;
            goto L801C544C;
        }
        c.V0 = c.V1 - 0x1u;
        c.V0 = c.A0;
        goto L801C544C;
        L801C5448: ;
        c.V0 = 0u;
        L801C544C: ;
        c.V1 = mem.ReadU16((c.SP + 0x10u));
        mem.WriteU16((c.SP + 0x16u), (ushort)c.V0);
        c.V0 = c.V1 & 0x003Fu;
        if (c.V0 != 0u) {
            c.A2 = c.T0 << 2;
            goto L801C5474;
        }
        c.A2 = c.T0 << 2;
        c.V0 = mem.ReadU16((c.SP + 0x14u));
        c.V0 = c.V0 & 0x003Fu;
        if (c.V0 == 0u) {
            c.A1 = c.T0 << 2;
            goto L801C5510;
        }
        c.A1 = c.T0 << 2;
        L801C5474: ;
        c.T0 = c.T0 + 0x1u;
        c.A1 = c.T0 << 2;
        c.T0 = c.T0 + 0x1u;
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        c.A2 = c.A2 + c.S1;
        c.V0 = c.V1 - c.V0;
        mem.WriteU16((c.SP + 0x10u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.SP + 0x12u));
        c.V1 = mem.ReadU16((c.S0 + 0xAu));
        c.A0 = 0x60000000u;
        c.V0 = c.V0 - c.V1;
        mem.WriteU16((c.SP + 0x12u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x1Bu));
        c.V1 = mem.ReadU8((c.S0 + 0x1Au));
        c.V0 = c.V0 << 16;
        c.V1 = c.V1 << 8;
        c.V1 = c.V1 | c.A0;
        c.A0 = mem.ReadU8((c.S0 + 0x19u));
        c.V0 = c.V0 | c.V1;
        c.V0 = c.V0 | c.A0;
        mem.WriteU32(c.A2, c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        c.A1 = c.A1 + c.S1;
        mem.WriteU32(c.A1, c.V0);
        c.V0 = c.T0 << 2;
        c.V1 = mem.ReadU32((c.SP + 0x14u));
        c.V0 = c.V0 + c.S1;
        mem.WriteU32(c.V0, c.V1);
        c.V0 = mem.ReadU16((c.SP + 0x10u));
        c.V1 = mem.ReadU16((c.S0 + 0x8u));
        c.V0 = c.V0 + c.V1;
        mem.WriteU16((c.SP + 0x10u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.SP + 0x12u));
        c.V1 = mem.ReadU16((c.S0 + 0xAu));
        c.T0 = c.T0 + 0x1u;
        c.V0 = c.V0 + c.V1;
        mem.WriteU16((c.SP + 0x12u), (ushort)c.V0);
        goto L801C5568;
        L801C5510: ;
        c.T0 = c.T0 + 0x1u;
        c.A2 = c.T0 << 2;
        c.T0 = c.T0 + 0x1u;
        c.A3 = c.T0 << 2;
        c.T0 = c.T0 + 0x1u;
        c.A1 = c.A1 + c.S1;
        c.A0 = 0x02000000u;
        c.V0 = mem.ReadU8((c.S0 + 0x1Bu));
        c.V1 = mem.ReadU8((c.S0 + 0x1Au));
        c.V0 = c.V0 << 16;
        c.V1 = c.V1 << 8;
        c.V1 = c.V1 | c.A0;
        c.A0 = mem.ReadU8((c.S0 + 0x19u));
        c.V0 = c.V0 | c.V1;
        c.V0 = c.V0 | c.A0;
        mem.WriteU32(c.A1, c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        c.A2 = c.A2 + c.S1;
        mem.WriteU32(c.A2, c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x14u));
        c.A3 = c.A3 + c.S1;
        mem.WriteU32(c.A3, c.V0);
        L801C5568: ;
        c.V0 = c.T0 - 0x1u;
        mem.WriteU8((c.S1 + 0x3u), (byte)c.V0);
        c.RA = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x40u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C5588(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAACu));
        c.V0 = c.V0 - 0x1u;
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C55C0;
        }
        if (c.A1 == 0u) {
            c.V1 = 0xE1000000u;
            goto L801C55B0;
        }
        c.V1 = 0xE1000000u;
        c.V1 = c.V1 | 0x0800u;
        L801C55B0: ;
        if (c.A0 == 0u) {
            c.V0 = c.A2 & 0x27FFu;
            goto L801C55D8;
        }
        c.V0 = c.A2 & 0x27FFu;
        c.V0 = c.V0 | 0x1000u;
        goto L801C55D8;
        L801C55C0: ;
        if (c.A1 == 0u) {
            c.V1 = 0xE1000000u;
            goto L801C55CC;
        }
        c.V1 = 0xE1000000u;
        c.V1 = c.V1 | 0x0200u;
        L801C55CC: ;
        if (c.A0 == 0u) {
            c.V0 = c.A2 & 0x09FFu;
            goto L801C55D8;
        }
        c.V0 = c.A2 & 0x09FFu;
        c.V0 = c.V0 | 0x0400u;
        L801C55D8: ;
        c.V0 = c.V1 | c.V0;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C55E0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A3 = c.A0;
        c.A0 = c.A0 << 16;
        c.A0 = (uint)((int)c.A0 >> 16);
        if ((int)c.A0 < 0) {
            c.SP = c.SP - 0x10u;
            goto L801C561C;
        }
        c.SP = c.SP - 0x10u;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.A2 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A0 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.A2 - 0x1u;
            goto L801C5620;
        }
        c.V0 = c.A2 - 0x1u;
        c.V0 = c.A3;
        goto L801C5620;
        L801C561C: ;
        c.V0 = 0u;
        L801C5620: ;
        c.A3 = c.V0;
        c.V0 = c.A1 << 16;
        c.A2 = (uint)((int)c.V0 >> 16);
        if ((int)c.A2 < 0) {
            goto L801C565C;
        }
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.A0 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A2 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C5660;
        }
        c.A1 = c.A0 - 0x1u;
        goto L801C5660;
        L801C565C: ;
        c.A1 = 0u;
        L801C5660: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAACu));
        c.V0 = c.V0 - 0x1u;
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.A1 & 0x0FFFu;
            goto L801C568C;
        }
        c.V1 = c.A1 & 0x0FFFu;
        c.V1 = c.A1 & 0x03FFu;
        c.V1 = c.V1 << 10;
        c.V0 = c.A3 & 0x03FFu;
        goto L801C5694;
        L801C568C: ;
        c.V1 = c.V1 << 12;
        c.V0 = c.A3 & 0x0FFFu;
        L801C5694: ;
        c.A0 = 0xE3000000u;
        c.V0 = c.V0 | c.A0;
        c.V0 = c.V1 | c.V0;
        c.SP = c.SP + 0x10u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C56AC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A3 = c.A0;
        c.A0 = c.A0 << 16;
        c.A0 = (uint)((int)c.A0 >> 16);
        if ((int)c.A0 < 0) {
            c.SP = c.SP - 0x10u;
            goto L801C56E8;
        }
        c.SP = c.SP - 0x10u;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.A2 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A0 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.A2 - 0x1u;
            goto L801C56EC;
        }
        c.V0 = c.A2 - 0x1u;
        c.V0 = c.A3;
        goto L801C56EC;
        L801C56E8: ;
        c.V0 = 0u;
        L801C56EC: ;
        c.A3 = c.V0;
        c.V0 = c.A1 << 16;
        c.A2 = (uint)((int)c.V0 >> 16);
        if ((int)c.A2 < 0) {
            goto L801C5728;
        }
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.A0 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A2 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C572C;
        }
        c.A1 = c.A0 - 0x1u;
        goto L801C572C;
        L801C5728: ;
        c.A1 = 0u;
        L801C572C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAACu));
        c.V0 = c.V0 - 0x1u;
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.A1 & 0x0FFFu;
            goto L801C5758;
        }
        c.V1 = c.A1 & 0x0FFFu;
        c.V1 = c.A1 & 0x03FFu;
        c.V1 = c.V1 << 10;
        c.V0 = c.A3 & 0x03FFu;
        goto L801C5760;
        L801C5758: ;
        c.V1 = c.V1 << 12;
        c.V0 = c.A3 & 0x0FFFu;
        L801C5760: ;
        c.A0 = 0xE4000000u;
        c.V0 = c.V0 | c.A0;
        c.V0 = c.V1 | c.V0;
        c.SP = c.SP + 0x10u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C5778(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAACu));
        c.V0 = c.V0 - 0x1u;
        c.V0 = c.V0 < 0x00000002u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.A1 & 0x0FFFu;
            goto L801C57A4;
        }
        c.V1 = c.A1 & 0x0FFFu;
        c.V1 = c.A1 & 0x07FFu;
        c.V1 = c.V1 << 11;
        c.V0 = c.A0 & 0x07FFu;
        goto L801C57AC;
        L801C57A4: ;
        c.V1 = c.V1 << 12;
        c.V0 = c.A0 & 0x0FFFu;
        L801C57AC: ;
        c.A0 = 0xE5000000u;
        c.V0 = c.V0 | c.A0;
        c.V0 = c.V1 | c.V0;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C57BC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        if (c.A0 != 0u) {
            c.SP = c.SP - 0x10u;
            goto L801C57CC;
        }
        c.SP = c.SP - 0x10u;
        c.V0 = 0u;
        goto L801C5834;
        L801C57CC: ;
        c.A1 = mem.ReadU8(c.A0);
        c.A1 = c.A1 >> 3;
        mem.WriteU32(c.SP, c.A1);
        c.A2 = (uint)(short)mem.ReadU16((c.A0 + 0x4u));
        c.A2 = 0u - c.A2;
        c.A2 = c.A2 & 0x00FFu;
        c.A2 = (uint)((int)c.A2 >> 3);
        mem.WriteU32((c.SP + 0x8u), c.A2);
        c.V0 = mem.ReadU8((c.A0 + 0x2u));
        c.A1 = c.A1 << 10;
        c.V0 = c.V0 >> 3;
        mem.WriteU32((c.SP + 0x4u), c.V0);
        c.V0 = c.V0 << 15;
        c.V1 = (uint)(short)mem.ReadU16((c.A0 + 0x6u));
        c.A0 = 0xE2000000u;
        c.A1 = c.A1 | c.A0;
        c.V0 = c.V0 | c.A1;
        c.V1 = 0u - c.V1;
        c.V1 = c.V1 & 0x00FFu;
        c.V1 = (uint)((int)c.V1 >> 3);
        c.A0 = c.V1 << 5;
        c.V0 = c.V0 | c.A0;
        c.V0 = c.V0 | c.A2;
        mem.WriteU32((c.SP + 0xCu), c.V1);
        L801C5834: ;
        c.SP = c.SP + 0x10u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C5840(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU8((c.V1 - 0xAACu));
        c.V0 = 0x00000001u;
        if (c.V1 == c.V0) {
            c.V0 = 0x00000002u;
            goto L801C5864;
        }
        c.V0 = 0x00000002u;
        if (c.V1 == c.V0) {
            goto L801C588C;
        }
        goto L801C58E4;
        L801C5864: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAA9u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000400u;
            goto L801C58E4;
        }
        c.V0 = 0x00000400u;
        c.V1 = (uint)(short)mem.ReadU16((c.A0 + 0x4u));
        c.A0 = (uint)(short)mem.ReadU16(c.A0);
        L801C5880: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V0 - c.V1;
        c.V0 = c.V0 - c.A0;
        goto L801C58E8;
        L801C588C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xAA9u));
        if (c.V0 == 0u) {
            goto L801C58C4;
        }
        c.V0 = mem.ReadU16((c.A0 + 0x4u));
        c.A0 = (uint)(short)mem.ReadU16(c.A0);
        c.V0 = c.V0 << 16;
        c.V1 = (uint)((int)c.V0 >> 16);
        c.V0 = c.V0 >> 31;
        c.V1 = c.V1 + c.V0;
        c.V1 = (uint)((int)c.V1 >> 1);
        c.V0 = 0x00000400u;
        goto L801C5880;
        L801C58C4: ;
        c.V0 = mem.ReadU16(c.A0);
        c.V0 = c.V0 << 16;
        c.V1 = (uint)((int)c.V0 >> 16);
        c.V0 = c.V0 >> 31;
        c.V1 = c.V1 + c.V0;
        c.V0 = (uint)((int)c.V1 >> 1);
        goto L801C58E8;
        L801C58E4: ;
        c.V0 = (uint)(short)mem.ReadU16(c.A0);
        L801C58E8: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C58F0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C5908(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A1;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x9BCu));
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.V0 = mem.ReadU32(c.A1);
        c.V1 = 0x08000000u;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.A1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9C0u));
        mem.WriteU32(c.V0, 0u);
        c.V0 = c.S0 << 2;
        c.V0 = c.V0 - 0x4u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9C8u));
        c.A0 = c.A0 + c.V0;
        mem.WriteU32(c.V1, c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9C4u));
        c.V1 = 0x11000000u;
        mem.WriteU32(c.V0, c.S0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9C0u));
        c.V1 = c.V1 | 0x0002u;
        mem.WriteU32(c.V0, c.V1);
        c.RA = 0x801C5984u;
        Courier_Crisis_main.func_801C6AA8(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9C0u));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            c.V0 = c.S0;
            goto L801C59D8;
        }
        c.V0 = c.S0;
        c.S1 = 0x01000000u;
        L801C59A8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C59B0u;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C59D8;
        }
        c.V0 = 0xFFFFFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9C0u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.S1;
        if (c.V0 != 0u) {
            c.V0 = c.S0;
            goto L801C59A8;
        }
        c.V0 = c.S0;
        L801C59D8: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C59F0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x40u;
        c.T0 = c.A0;
        mem.WriteU32((c.SP + 0x38u), c.RA);
        mem.WriteU32((c.SP + 0x34u), c.S1);
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.A0 = (uint)(short)mem.ReadU16((c.T0 + 0x4u));
        c.T1 = c.A1;
        if ((int)c.A0 < 0) {
            c.A1 = c.A0;
            goto L801C5A3C;
        }
        c.A1 = c.A0;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.V1 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A0 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.V1 - 0x1u;
            goto L801C5A40;
        }
        c.V0 = c.V1 - 0x1u;
        c.V0 = c.A1;
        goto L801C5A40;
        L801C5A3C: ;
        c.V0 = 0u;
        L801C5A40: ;
        c.A1 = (uint)(short)mem.ReadU16((c.T0 + 0x6u));
        mem.WriteU16((c.T0 + 0x4u), (ushort)c.V0);
        if ((int)c.A1 < 0) {
            c.A0 = c.A1;
            goto L801C5A78;
        }
        c.A0 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.V1 = c.V0;
        c.V0 = c.V0 - 0x1u;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.V1 - 0x1u;
            goto L801C5A7C;
        }
        c.V1 = c.V1 - 0x1u;
        c.V1 = c.A0;
        goto L801C5A7C;
        L801C5A78: ;
        c.V1 = 0u;
        L801C5A7C: ;
        c.V0 = mem.ReadU16(c.T0);
        c.V0 = c.V0 & 0x003Fu;
        if (c.V0 != 0u) {
            mem.WriteU16((c.T0 + 0x6u), (ushort)c.V1);
            goto L801C5AA4;
        }
        mem.WriteU16((c.T0 + 0x6u), (ushort)c.V1);
        c.V0 = mem.ReadU16((c.T0 + 0x4u));
        c.V0 = c.V0 & 0x003Fu;
        if (c.V0 == 0u) {
            c.V0 = 0x05FF0000u;
            goto L801C5BA8;
        }
        c.V0 = 0x05FF0000u;
        L801C5AA4: ;
        c.A1 = 0x00FF0000u;
        c.A1 = c.A1 | 0xFFFFu;
        c.A0 = 0xE4FF0000u;
        c.A0 = c.A0 | 0xFFFFu;
        c.A3 = 0x03FF0000u;
        c.A2 = 0x801E0000u;
        c.A2 = c.A2 + 0x15B4u;
        c.V0 = c.A2 & c.A1;
        c.V1 = 0x08000000u;
        c.V0 = c.V0 | c.V1;
        c.S0 = 0xE3000000u;
        c.S1 = 0xE5000000u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1590u), c.V0);
        c.V0 = 0xE6000000u;
        c.A1 = c.T1 & c.A1;
        c.V1 = 0x60000000u;
        c.A1 = c.A1 | c.V1;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15A0u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V1 = 0xE1000000u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1594u), c.S0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1598u), c.A0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x159Cu), c.S1);
        c.A0 = mem.ReadU32(c.V0);
        c.V0 = c.T1 >> 31;
        c.V0 = c.V0 << 10;
        c.V0 = c.V0 | c.V1;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15A8u), c.A1);
        c.A0 = c.A0 & 0x07FFu;
        c.A0 = c.A0 | c.V0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15A4u), c.A0);
        c.V0 = mem.ReadU32(c.T0);
        c.A3 = c.A3 | 0xFFFFu;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15ACu), c.V0);
        c.V0 = mem.ReadU32((c.T0 + 0x4u));
        mem.WriteU32(c.A2, c.A3);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15B0u), c.V0);
        c.A0 = 0x00000003u;
        c.RA = 0x801C5B68u;
        Courier_Crisis_main.func_801C61E4(c, m);
        c.V0 = c.V0 | c.S0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15B8u), c.V0);
        c.A0 = 0x00000004u;
        c.RA = 0x801C5B7Cu;
        Courier_Crisis_main.func_801C61E4(c, m);
        c.V1 = 0xE4000000u;
        c.V0 = c.V0 | c.V1;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15BCu), c.V0);
        c.A0 = 0x00000005u;
        c.RA = 0x801C5B94u;
        Courier_Crisis_main.func_801C61E4(c, m);
        c.V0 = c.V0 | c.S1;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15C0u), c.V0);
        goto L801C5C20;
        L801C5BA8: ;
        c.V0 = c.V0 | 0xFFFFu;
        c.V1 = 0x00FF0000u;
        c.V1 = c.V1 | 0xFFFFu;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1590u), c.V0);
        c.V0 = 0xE6000000u;
        c.V1 = c.T1 & c.V1;
        c.A1 = 0x02000000u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1594u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V1 = c.V1 | c.A1;
        c.A0 = mem.ReadU32(c.V0);
        c.V0 = c.T1 >> 31;
        c.V0 = c.V0 << 10;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x159Cu), c.V1);
        c.V1 = 0xE1000000u;
        c.V0 = c.V0 | c.V1;
        c.A0 = c.A0 & 0x07FFu;
        c.A0 = c.A0 | c.V0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1598u), c.A0);
        c.V0 = mem.ReadU32(c.T0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15A0u), c.V0);
        c.V0 = mem.ReadU32((c.T0 + 0x4u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x15A4u), c.V0);
        L801C5C20: ;
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x1590u;
        c.RA = 0x801C5C30u;
        Courier_Crisis_main.func_801C6198(c, m);
        c.V0 = 0u;
        c.RA = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x40u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C5C4C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x50u;
        mem.WriteU32((c.SP + 0x34u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x38u), c.S2);
        c.S2 = c.A1;
        mem.WriteU32((c.SP + 0x48u), c.RA);
        mem.WriteU32((c.SP + 0x44u), c.S5);
        mem.WriteU32((c.SP + 0x40u), c.S4);
        mem.WriteU32((c.SP + 0x3Cu), c.S3);
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.RA = 0x801C5C78u;
        Courier_Crisis_main.func_801C6AA8(c, m);
        c.A1 = (uint)(short)mem.ReadU16((c.S1 + 0x4u));
        c.S5 = 0u;
        if ((int)c.A1 < 0) {
            c.V1 = c.A1;
            goto L801C5CAC;
        }
        c.V1 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.A0 = c.V0;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C5CB0;
        }
        c.V1 = c.A0;
        goto L801C5CB0;
        L801C5CAC: ;
        c.V1 = 0u;
        L801C5CB0: ;
        c.A1 = (uint)(short)mem.ReadU16((c.S1 + 0x6u));
        mem.WriteU16((c.S1 + 0x4u), (ushort)c.V1);
        if ((int)c.A1 < 0) {
            c.V1 = c.A1;
            goto L801C5CE4;
        }
        c.V1 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.A0 = c.V1;
        c.V1 = c.V0;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.A0 << 16;
            goto L801C5CEC;
        }
        c.V0 = c.A0 << 16;
        c.A0 = c.V1;
        goto L801C5CE8;
        L801C5CE4: ;
        c.A0 = 0u;
        L801C5CE8: ;
        c.V0 = c.A0 << 16;
        L801C5CEC: ;
        c.V1 = (uint)(short)mem.ReadU16((c.S1 + 0x4u));
        c.V0 = (uint)((int)c.V0 >> 16);
        { var _r = (long)(int)c.V1 * (int)c.V0; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        mem.WriteU16((c.S1 + 0x6u), (ushort)c.A0);
        c.A2 = c.LO;
        c.V1 = c.A2 + 0x1u;
        c.V0 = c.V1 >> 31;
        c.V1 = c.V1 + c.V0;
        c.A0 = (uint)((int)c.V1 >> 1);
        if ((int)c.A0 > 0) {
            c.S0 = (uint)((int)c.V1 >> 5);
            goto L801C5D20;
        }
        c.S0 = (uint)((int)c.V1 >> 5);
        c.V0 = 0xFFFFFFFFu;
        goto L801C5E60;
        L801C5D20: ;
        c.V1 = c.S0;
        c.V0 = c.V1 << 4;
        c.S0 = c.A0 - c.V0;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.S4 = c.V1;
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x04000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            c.A0 = 0xA0000000u;
            goto L801C5D80;
        }
        c.A0 = 0xA0000000u;
        c.S3 = 0x04000000u;
        L801C5D50: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C5D58u;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C5E60;
        }
        c.V0 = 0xFFFFFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.S3;
        if (c.V0 == 0u) {
            c.A0 = 0xA0000000u;
            goto L801C5D50;
        }
        c.A0 = 0xA0000000u;
        L801C5D80: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x04000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = 0x01000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9DCu));
        if (c.S5 == 0u) {
            goto L801C5DB4;
        }
        c.A0 = 0xB0000000u;
        L801C5DB4: ;
        mem.WriteU32(c.V0, c.A0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = mem.ReadU32(c.S1);
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = mem.ReadU32((c.S1 + 0x4u));
        c.S0 = c.S0 - 0x1u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0xFFFFFFFFu;
        if (c.S0 == c.V0) {
            goto L801C5E10;
        }
        c.A0 = 0xFFFFFFFFu;
        L801C5DF0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V1 = mem.ReadU32(c.S2);
        c.S2 = c.S2 + 0x4u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9DCu));
        c.S0 = c.S0 - 0x1u;
        mem.WriteU32(c.V0, c.V1);
        if (c.S0 != c.A0) {
            goto L801C5DF0;
        }
        L801C5E10: ;
        if (c.S4 == 0u) {
            c.V1 = 0x04000000u;
            goto L801C5E5C;
        }
        c.V1 = 0x04000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V1 = c.V1 | 0x0002u;
        mem.WriteU32(c.V0, c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D4u));
        c.A0 = 0x01000000u;
        mem.WriteU32(c.V0, c.S2);
        c.V0 = c.S4 << 16;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D0u));
        c.V0 = c.V0 | 0x0010u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.A0 = c.A0 | 0x0201u;
        mem.WriteU32(c.V0, c.A0);
        L801C5E5C: ;
        c.V0 = 0u;
        L801C5E60: ;
        c.RA = mem.ReadU32((c.SP + 0x48u));
        c.S5 = mem.ReadU32((c.SP + 0x44u));
        c.S4 = mem.ReadU32((c.SP + 0x40u));
        c.S3 = mem.ReadU32((c.SP + 0x3Cu));
        c.S2 = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x50u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C5E88(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x48u;
        mem.WriteU32((c.SP + 0x34u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x38u), c.S2);
        c.S2 = c.A1;
        mem.WriteU32((c.SP + 0x44u), c.RA);
        mem.WriteU32((c.SP + 0x40u), c.S4);
        mem.WriteU32((c.SP + 0x3Cu), c.S3);
        mem.WriteU32((c.SP + 0x30u), c.S0);
        c.RA = 0x801C5EB0u;
        Courier_Crisis_main.func_801C6AA8(c, m);
        c.A1 = (uint)(short)mem.ReadU16((c.S1 + 0x4u));
        if ((int)c.A1 < 0) {
            c.V1 = c.A1;
            goto L801C5EE4;
        }
        c.V1 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA8u));
        c.A0 = c.V0;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C5EE8;
        }
        c.V1 = c.A0;
        goto L801C5EE8;
        L801C5EE4: ;
        c.V1 = 0u;
        L801C5EE8: ;
        c.A1 = (uint)(short)mem.ReadU16((c.S1 + 0x6u));
        mem.WriteU16((c.S1 + 0x4u), (ushort)c.V1);
        if ((int)c.A1 < 0) {
            c.V1 = c.A1;
            goto L801C5F1C;
        }
        c.V1 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 - 0xAA6u));
        c.A0 = c.V1;
        c.V1 = c.V0;
        c.V0 = (int)c.V0 < (int)c.A1 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.A0 << 16;
            goto L801C5F24;
        }
        c.V0 = c.A0 << 16;
        c.A0 = c.V1;
        goto L801C5F20;
        L801C5F1C: ;
        c.A0 = 0u;
        L801C5F20: ;
        c.V0 = c.A0 << 16;
        L801C5F24: ;
        c.V1 = (uint)(short)mem.ReadU16((c.S1 + 0x4u));
        c.V0 = (uint)((int)c.V0 >> 16);
        { var _r = (long)(int)c.V1 * (int)c.V0; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        mem.WriteU16((c.S1 + 0x6u), (ushort)c.A0);
        c.A2 = c.LO;
        c.V1 = c.A2 + 0x1u;
        c.V0 = c.V1 >> 31;
        c.V1 = c.V1 + c.V0;
        c.A0 = (uint)((int)c.V1 >> 1);
        if ((int)c.A0 > 0) {
            c.S0 = (uint)((int)c.V1 >> 5);
            goto L801C5F58;
        }
        c.S0 = (uint)((int)c.V1 >> 5);
        c.V0 = 0xFFFFFFFFu;
        goto L801C60E8;
        L801C5F58: ;
        c.V1 = c.S0;
        c.V0 = c.V1 << 4;
        c.S0 = c.A0 - c.V0;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.S4 = c.V1;
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x04000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C5FB8;
        }
        c.S3 = 0x04000000u;
        L801C5F88: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C5F90u;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C60E8;
        }
        c.V0 = 0xFFFFFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.S3;
        if (c.V0 == 0u) {
            goto L801C5F88;
        }
        L801C5FB8: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x04000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = 0x01000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = 0xC0000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = mem.ReadU32(c.S1);
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9DCu));
        c.V0 = mem.ReadU32((c.S1 + 0x4u));
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x08000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C6064;
        }
        c.S1 = 0x08000000u;
        L801C6034: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C603Cu;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C60E8;
        }
        c.V0 = 0xFFFFFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.S1;
        if (c.V0 == 0u) {
            goto L801C6034;
        }
        L801C6064: ;
        c.S0 = c.S0 - 0x1u;
        c.V0 = 0xFFFFFFFFu;
        if (c.S0 == c.V0) {
            goto L801C6098;
        }
        c.V1 = 0xFFFFFFFFu;
        L801C6078: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9DCu));
        c.V0 = mem.ReadU32(c.V0);
        c.S0 = c.S0 - 0x1u;
        mem.WriteU32(c.S2, c.V0);
        if (c.S0 != c.V1) {
            c.S2 = c.S2 + 0x4u;
            goto L801C6078;
        }
        c.S2 = c.S2 + 0x4u;
        L801C6098: ;
        if (c.S4 == 0u) {
            c.V1 = 0x04000000u;
            goto L801C60E4;
        }
        c.V1 = 0x04000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V1 = c.V1 | 0x0003u;
        mem.WriteU32(c.V0, c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D4u));
        c.A0 = 0x01000000u;
        mem.WriteU32(c.V0, c.S2);
        c.V0 = c.S4 << 16;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D0u));
        c.V0 = c.V0 | 0x0010u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.A0 = c.A0 | 0x0200u;
        mem.WriteU32(c.V0, c.A0);
        L801C60E4: ;
        c.V0 = 0u;
        L801C60E8: ;
        c.RA = mem.ReadU32((c.SP + 0x44u));
        c.S4 = mem.ReadU32((c.SP + 0x40u));
        c.S3 = mem.ReadU32((c.SP + 0x3Cu));
        c.S2 = mem.ReadU32((c.SP + 0x38u));
        c.S1 = mem.ReadU32((c.SP + 0x34u));
        c.S0 = mem.ReadU32((c.SP + 0x30u));
        c.SP = c.SP + 0x48u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C610C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        mem.WriteU32(c.V0, c.A0);
        c.V0 = c.A0 >> 24;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        mem.WriteU8((c.At + 0x15D4u), (byte)c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6134(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801E0000u;
        c.At = c.At + c.A0;
        c.V0 = mem.ReadU8((c.At + 0x15D4u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6148(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        c.A2 = c.A1 - 0x1u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x04000000u;
        mem.WriteU32(c.V1, c.V0);
        if (c.A1 == 0u) {
            c.V0 = 0u;
            goto L801C618C;
        }
        c.V0 = 0u;
        c.A1 = 0xFFFFFFFFu;
        L801C616C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V1 = mem.ReadU32(c.A0);
        c.A0 = c.A0 + 0x4u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9DCu));
        c.A2 = c.A2 - 0x1u;
        mem.WriteU32(c.V0, c.V1);
        if (c.A2 != c.A1) {
            c.V0 = 0u;
            goto L801C616C;
        }
        c.V0 = 0u;
        L801C618C: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6198(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x04000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V1 = c.V1 | 0x0002u;
        mem.WriteU32(c.V0, c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D4u));
        mem.WriteU32(c.V0, c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D0u));
        c.V1 = 0x01000000u;
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V1 = c.V1 | 0x0401u;
        mem.WriteU32(c.V0, c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C61E4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x10000000u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.A0 = c.A0 | c.V0;
        mem.WriteU32(c.V1, c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9DCu));
        c.V1 = 0x00FF0000u;
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6214(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A3 = c.A2;
        c.A2 = 0u;
        c.RA = 0x801C6228u;
        Courier_Crisis_main.func_801C6238(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6238(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        c.S3 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A1;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A2;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        mem.WriteU32((c.SP + 0x20u), c.RA);
        c.S2 = c.A3;
        c.RA = 0x801C6264u;
        Courier_Crisis_main.func_801C6AA8(c, m);
        goto L801C6284;
        L801C626C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C6274u;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C64F8;
        }
        c.V0 = 0xFFFFFFFFu;
        c.RA = 0x801C6284u;
        Courier_Crisis_main.func_801C6518(c, m);
        L801C6284: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A8u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V0 + 0x1u;
        c.V0 = c.V0 & 0x003Fu;
        if (c.V0 == c.V1) {
            goto L801C626C;
        }
        c.A0 = 0u;
        c.RA = 0x801C62ACu;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU8((c.V1 - 0xAABu));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A0u), c.V0);
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xAA4u), c.V0);
        if (c.V1 == 0u) {
            goto L801C6320;
        }
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A4u));
        if (c.V1 != c.V0) {
            goto L801C6380;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C6380;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAA0u));
        if (c.V0 != 0u) {
            goto L801C6380;
        }
        L801C6320: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.A0 = 0x04000000u;
        L801C632C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 & c.A0;
        if (c.V0 == 0u) {
            goto L801C632C;
        }
        c.A0 = c.S0;
        c.A1 = c.S2;
        c.RA = 0x801C634Cu;
        Dispatcher.Call(c, m, c.S3);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x9A0u));
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0x9B8u;
        mem.WriteU32(c.V0, c.S3);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9B4u), c.S0);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9B0u), c.S2);
        c.RA = 0x801C6378u;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.V0 = 0u;
        goto L801C64F8;
        L801C6380: ;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x6518u;
        c.A0 = 0x00000002u;
        c.RA = 0x801C6390u;
        Courier_Crisis_main.DMACallback_main(c, m);
        if (c.S1 == 0u) {
            c.A2 = 0u;
            goto L801C6440;
        }
        c.A2 = 0u;
        c.T0 = 0x801E0000u;
        c.T0 = c.T0 + 0x3B6Cu;
        c.A3 = c.S0;
        c.V0 = c.S1;
        L801C63A8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        if ((int)c.V0 >= 0) {
            goto L801C63B4;
        }
        c.V0 = c.V0 + 0x3u;
        L801C63B4: ;
        c.V0 = (uint)((int)c.V0 >> 2);
        c.V0 = (int)c.A2 < (int)c.V0 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.A0 = c.A2 << 2;
            goto L801C63F8;
        }
        c.A0 = c.A2 << 2;
        c.A1 = mem.ReadU32(c.A3);
        c.A3 = c.A3 + 0x4u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.A2 = c.A2 + 0x1u;
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.V0 = c.V0 + c.T0;
        c.A0 = c.A0 + c.V0;
        mem.WriteU32(c.A0, c.A1);
        c.V0 = c.S1;
        goto L801C63A8;
        L801C63F8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A8u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.A0 = c.V0 << 1;
        c.A0 = c.A0 + c.V0;
        c.A0 = c.A0 << 5;
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x3B6Cu;
        c.V0 = c.V0 + c.V1;
        c.At = 0x801E0000u;
        c.At = c.At + c.A0;
        mem.WriteU32((c.At + 0x3B64u), c.V0);
        goto L801C6464;
        L801C6440: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        mem.WriteU32((c.At + 0x3B64u), c.S0);
        L801C6464: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        mem.WriteU32((c.At + 0x3B68u), c.S2);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        mem.WriteU32((c.At + 0x3B60u), c.S3);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A8u));
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x9A0u));
        c.V0 = c.V0 + 0x1u;
        c.V0 = c.V0 & 0x003Fu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A8u), c.V0);
        c.RA = 0x801C64D4u;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.RA = 0x801C64DCu;
        Courier_Crisis_main.func_801C6518(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A8u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V0 - c.V1;
        c.V0 = c.V0 & 0x003Fu;
        L801C64F8: ;
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6518(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = mem.ReadU32(c.V0);
        c.S0 = 0x01000000u;
        c.V0 = c.V0 & c.S0;
        if (c.V0 != 0u) {
            c.V0 = 0x00000001u;
            goto L801C67F0;
        }
        c.V0 = 0x00000001u;
        c.A0 = 0u;
        c.RA = 0x801C6548u;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x9A8u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x99Cu), c.V0);
        if (c.A0 == c.V1) {
            goto L801C6750;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.S0;
        if (c.V0 != 0u) {
            goto L801C6750;
        }
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 - 0x9B8u;
        L801C6590: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A4u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = c.V0 + 0x1u;
        c.V0 = c.V0 & 0x003Fu;
        if (c.V0 != c.V1) {
            goto L801C65CC;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAA0u));
        if (c.V0 != 0u) {
            c.A0 = 0x00000002u;
            goto L801C65CC;
        }
        c.A0 = 0x00000002u;
        c.A1 = 0u;
        c.RA = 0x801C65CCu;
        Courier_Crisis_main.DMACallback_main(c, m);
        L801C65CC: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = 0x04000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            c.V1 = c.A0;
            goto L801C6604;
        }
        c.V1 = c.A0;
        c.A0 = 0x04000000u;
        L801C65F0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 & c.A0;
        if (c.V0 == 0u) {
            goto L801C65F0;
        }
        L801C6604: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x9A4u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.V1 = c.A1 << 1;
        c.V1 = c.V1 + c.A1;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.A0 = mem.ReadU32((c.At + 0x3B64u));
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x9A4u));
        c.V1 = c.V1 << 5;
        c.V0 = c.A1 << 1;
        c.V0 = c.V0 + c.A1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.A1 = mem.ReadU32((c.At + 0x3B68u));
        c.At = 0x801E0000u;
        c.At = c.At + c.V1;
        c.V0 = mem.ReadU32((c.At + 0x3B60u));
        c.RA = 0x801C6674u;
        Dispatcher.Call(c, m, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At + 0x3B60u));
        mem.WriteU32(c.S0, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At + 0x3B64u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9B4u), c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 5;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At + 0x3B68u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9B0u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A4u));
        c.V0 = c.V0 + 0x1u;
        c.V0 = c.V0 & 0x003Fu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A4u), c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A4u));
        if (c.V1 == c.V0) {
            goto L801C6750;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            goto L801C6590;
        }
        L801C6750: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x99Cu));
        c.RA = 0x801C6760u;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A4u));
        if (c.V1 != c.V0) {
            goto L801C67D4;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C67D4;
        }
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 - 0xAA4u;
        c.V0 = mem.ReadU32(c.V1);
        if (c.V0 == 0u) {
            goto L801C67D4;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xAA0u));
        if (c.V0 == 0u) {
            goto L801C67D4;
        }
        mem.WriteU32(c.V1, 0u);
        c.RA = 0x801C67D4u;
        Dispatcher.Call(c, m, c.V0);
        L801C67D4: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A8u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V0 - c.V1;
        c.V0 = c.V0 & 0x003Fu;
        L801C67F0: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6804(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.A0 = 0u;
        c.RA = 0x801C681Cu;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A4u), 0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x998u), c.V0);
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A8u), c.V1);
        c.V1 = c.S0 & 0x0007u;
        if (c.V1 == c.V0) {
            c.V0 = (int)c.V1 < 2 ? 1u : 0u;
            goto L801C68DC;
        }
        c.V0 = (int)c.V1 < 2 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C6864;
        }
        if (c.V1 == 0u) {
            goto L801C6878;
        }
        goto L801C6928;
        L801C6864: ;
        c.V0 = 0x00000003u;
        if (c.V1 == c.V0) {
            c.V0 = 0x00000005u;
            goto L801C68DC;
        }
        c.V0 = 0x00000005u;
        if (c.V1 != c.V0) {
            goto L801C6928;
        }
        L801C6878: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9CCu));
        c.V0 = 0x00000401u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9BCu));
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x15D4u;
        c.V0 = mem.ReadU32(c.V1);
        c.A1 = 0u;
        c.V0 = c.V0 | 0x0800u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.A2 = 0x00000100u;
        mem.WriteU32(c.V0, 0u);
        c.RA = 0x801C68C0u;
        Courier_Crisis_main.func_801C6D24(c, m);
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x3B60u;
        c.A1 = 0u;
        c.A2 = 0x00001800u;
        c.RA = 0x801C68D4u;
        Courier_Crisis_main.func_801C6D24(c, m);
        goto L801C6928;
        L801C68DC: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9CCu));
        c.V0 = 0x00000401u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9BCu));
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 | 0x0800u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x02000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x01000000u;
        mem.WriteU32(c.V1, c.V0);
        L801C6928: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x998u));
        c.RA = 0x801C6938u;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.V0 = c.S0 & 0x0007u;
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801C694C;
        }
        c.V0 = 0u;
        c.A0 = c.S0;
        c.RA = 0x801C694Cu;
        Courier_Crisis_main.func_801C6C48(c, m);
        L801C694C: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6960(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        if (c.A0 != 0u) {
            mem.WriteU32((c.SP + 0x10u), c.S0);
            goto L801C6A14;
        }
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.RA = 0x801C6978u;
        Courier_Crisis_main.func_801C6AA8(c, m);
        goto L801C6998;
        L801C6980: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C6988u;
        Courier_Crisis_main.func_801C6518(c, m);
        c.RA = 0x801C6990u;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C6A94;
        }
        c.V0 = 0xFFFFFFFFu;
        L801C6998: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A8u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A4u));
        if (c.V1 == c.V0) {
            goto L801C69CC;
        }
        goto L801C6980;
        L801C69BC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801C69C4u;
        Courier_Crisis_main.func_801C6ADC(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C6A94;
        }
        c.V0 = 0xFFFFFFFFu;
        L801C69CC: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C69BC;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x04000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            c.V0 = 0u;
            goto L801C69BC;
        }
        c.V0 = 0u;
        goto L801C6A94;
        L801C6A14: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9A8u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.V0 = c.V0 - c.V1;
        c.S0 = c.V0 & 0x003Fu;
        if (c.S0 == 0u) {
            goto L801C6A40;
        }
        c.RA = 0x801C6A40u;
        Courier_Crisis_main.func_801C6518(c, m);
        L801C6A40: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C6A80;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x04000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            goto L801C6A90;
        }
        L801C6A80: ;
        if (c.S0 != 0u) {
            c.V0 = c.S0;
            goto L801C6A94;
        }
        c.V0 = c.S0;
        c.V0 = 0x00000001u;
        goto L801C6A94;
        L801C6A90: ;
        c.V0 = c.S0;
        L801C6A94: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6AA8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801C6AB8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.V0 = c.V0 + 0xF0u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x994u), c.V0);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x990u), 0u);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6ADC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801C6AECu;
        Courier_Crisis_main.VSync_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x994u));
        c.V1 = (int)c.V1 < (int)c.V0 ? 1u : 0u;
        if (c.V1 != 0u) {
            goto L801C6B2C;
        }
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x990u));
        c.V0 = c.V1 + 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x990u), c.V0);
        c.V0 = 0x000F0000u;
        c.V0 = (int)c.V0 < (int)c.V1 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C6C34;
        }
        L801C6B2C: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x480u;
        c.V0 = mem.ReadU32(c.V1);
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x9A8u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D4u));
        c.T0 = 0x801D0000u;
        c.T0 = mem.ReadU32((c.T0 - 0x9A4u));
        c.V0 = mem.ReadU32(c.V0);
        c.A1 = c.A1 - c.T0;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9CCu));
        c.A2 = mem.ReadU32(c.V1);
        c.A3 = mem.ReadU32(c.V0);
        c.A1 = c.A1 & 0x003Fu;
        c.RA = 0x801C6B7Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0x9B8u;
        c.A1 = mem.ReadU32(c.V0);
        c.A2 = 0x801D0000u;
        c.A2 = mem.ReadU32((c.A2 - 0x9B4u));
        c.A3 = 0x801D0000u;
        c.A3 = mem.ReadU32((c.A3 - 0x9B0u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x4B4u;
        c.RA = 0x801C6BA8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.A0 = 0u;
        c.RA = 0x801C6BB0u;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A4u), 0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9A4u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x998u), c.V0);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x9A8u), c.V1);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9CCu));
        c.V0 = 0x00000401u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9BCu));
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 | 0x0800u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x02000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x01000000u;
        mem.WriteU32(c.V1, c.V0);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x998u));
        c.RA = 0x801C6C2Cu;
        Courier_Crisis_main.SetIntrMask_main(c, m);
        c.V0 = 0xFFFFFFFFu;
        goto L801C6C38;
        L801C6C34: ;
        c.V0 = 0u;
        L801C6C38: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6C48(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x10000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V1 = c.V1 | 0x0007u;
        mem.WriteU32(c.V0, c.V1);
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x9DCu));
        c.V1 = 0x00FF0000u;
        c.V0 = mem.ReadU32(c.A1);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        c.V1 = 0x00000002u;
        if (c.V0 == c.V1) {
            c.V1 = 0xE1000000u;
            goto L801C6CF0;
        }
        c.V1 = 0xE1000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = c.V1 | 0x1000u;
        c.V0 = c.V0 & 0x3FFFu;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.A1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x9DCu));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 & 0x1000u;
        if (c.V0 != 0u) {
            c.V0 = c.A0 & 0x0008u;
            goto L801C6CD0;
        }
        c.V0 = c.A0 & 0x0008u;
        c.V0 = 0u;
        goto L801C6D1C;
        L801C6CD0: ;
        if (c.V0 != 0u) {
            c.V0 = 0x20000000u;
            goto L801C6CE0;
        }
        c.V0 = 0x20000000u;
        c.V0 = 0x00000001u;
        goto L801C6D1C;
        L801C6CE0: ;
        c.V0 = c.V0 | 0x0504u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x00000002u;
        goto L801C6D1C;
        L801C6CF0: ;
        c.V0 = c.A0 & 0x0008u;
        if (c.V0 == 0u) {
            c.A0 = 0x09000000u;
            goto L801C6D18;
        }
        c.A0 = 0x09000000u;
        c.A0 = c.A0 | 0x0001u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x9D8u));
        c.V0 = 0x00000004u;
        mem.WriteU32(c.V1, c.A0);
        goto L801C6D1C;
        L801C6D18: ;
        c.V0 = 0x00000003u;
        L801C6D1C: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6D24(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        if (c.A2 == 0u) {
            c.V0 = c.A2 - 0x1u;
            goto L801C6D44;
        }
        c.V0 = c.A2 - 0x1u;
        c.V1 = 0xFFFFFFFFu;
        L801C6D34: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU8(c.A0, (byte)c.A1);
        c.V0 = c.V0 - 0x1u;
        if (c.V0 != c.V1) {
            c.A0 = c.A0 + 0x1u;
            goto L801C6D34;
        }
        c.A0 = c.A0 + 0x1u;
        L801C6D44: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C6D50(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000049u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void OpenTIM_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x16D4u), c.A0);
        c.V0 = 0u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ReadTIM_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x16D4u));
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.A1 = c.S0;
        c.RA = 0x801C6D90u;
        Courier_Crisis_main.func_801C70C4(c, m);
        c.A0 = c.V0;
        c.V0 = 0xFFFFFFFFu;
        if (c.A0 == c.V0) {
            c.A0 = c.A0 << 2;
            goto L801C6DC0;
        }
        c.A0 = c.A0 << 2;
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x16D4u));
        c.V1 = c.V1 + c.A0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x16D4u), c.V1);
        c.V0 = c.S0;
        goto L801C6DC4;
        L801C6DC0: ;
        c.V0 = 0u;
        L801C6DC4: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void OpenTMD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        c.V0 = 0x801E0000u;
        c.V0 = c.V0 + 0x16DCu;
        c.A2 = 0x801E0000u;
        c.A2 = c.A2 + 0x16E0u;
        c.A3 = 0x801E0000u;
        c.A3 = c.A3 + 0x16D8u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801C6E00u;
        Courier_Crisis_main.func_801C71E4(c, m);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x16E4u), c.V0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void ReadTMD_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x16E0u));
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.A1 = c.S0;
        c.RA = 0x801C6E38u;
        Courier_Crisis_main.func_801C737C(c, m);
        c.A2 = c.V0;
        if ((int)c.A2 < 0) {
            c.V0 = 0u;
            goto L801C70B0;
        }
        c.V0 = 0u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x16D8u));
        c.V0 = mem.ReadU16((c.S0 + 0x70u));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x16DCu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU32((c.S0 + 0x60u), c.A1);
        mem.WriteU32((c.S0 + 0x64u), c.A0);
        c.V1 = mem.ReadU16(c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x70u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x40u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x70u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x42u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = mem.ReadU16((c.S0 + 0x72u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x44u), (ushort)c.V1);
        c.V1 = mem.ReadU16(c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x72u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x48u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x72u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x4Au), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = mem.ReadU16((c.S0 + 0x74u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x4Cu), (ushort)c.V1);
        c.V1 = mem.ReadU16(c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x74u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x50u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x74u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x52u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.S0 + 0x76u));
        c.V0 = mem.ReadU16((c.V0 + 0x4u));
        c.V1 = c.V1 << 3;
        c.V1 = c.V1 + c.A0;
        mem.WriteU16((c.S0 + 0x54u), (ushort)c.V0);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x16E0u));
        c.V1 = mem.ReadU16(c.V1);
        c.V0 = c.V0 + c.A2;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x16E0u), c.V0);
        mem.WriteU16((c.S0 + 0x58u), (ushort)c.V1);
        c.V0 = mem.ReadU16((c.S0 + 0x76u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x76u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A0;
        mem.WriteU16((c.S0 + 0x5Au), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = mem.ReadU16((c.S0 + 0x68u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x5Cu), (ushort)c.V1);
        c.V1 = mem.ReadU16(c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x68u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x20u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x68u));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x22u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = mem.ReadU16((c.S0 + 0x6Au));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x24u), (ushort)c.V1);
        c.V1 = mem.ReadU16(c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6Au));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x28u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x6Au));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x2Au), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = mem.ReadU16((c.S0 + 0x6Cu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x2Cu), (ushort)c.V1);
        c.V1 = mem.ReadU16(c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6Cu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x30u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x6Cu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x32u), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = mem.ReadU16((c.S0 + 0x6Eu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x34u), (ushort)c.V1);
        c.V0 = mem.ReadU16(c.V0);
        mem.WriteU16((c.S0 + 0x38u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6Eu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        c.V1 = mem.ReadU16((c.V0 + 0x2u));
        c.V0 = mem.ReadU16((c.S0 + 0x6Eu));
        c.V0 = c.V0 << 3;
        c.V0 = c.V0 + c.A1;
        mem.WriteU16((c.S0 + 0x3Au), (ushort)c.V1);
        c.V1 = mem.ReadU16((c.V0 + 0x4u));
        c.V0 = c.S0;
        mem.WriteU16((c.V0 + 0x3Cu), (ushort)c.V1);
        L801C70B0: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C70C4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A1;
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.V1 = mem.ReadU32(c.S0);
        c.V0 = 0x00000010u;
        if (c.V1 == c.V0) {
            c.S0 = c.S0 + 0x4u;
            goto L801C70F8;
        }
        c.S0 = c.S0 + 0x4u;
        c.V0 = 0xFFFFFFFFu;
        goto L801C71C8;
        L801C70F8: ;
        c.V0 = mem.ReadU32(c.S0);
        c.S0 = c.S0 + 0x4u;
        mem.WriteU32(c.S1, c.V0);
        c.RA = 0x801C7108u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.S2 = 0x00000002u;
        if (c.V0 != c.S2) {
            goto L801C7124;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x4CCu;
        c.A1 = 0x00000010u;
        c.RA = 0x801C7124u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7124: ;
        c.RA = 0x801C712Cu;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        if (c.V0 != c.S2) {
            goto L801C7148;
        }
        c.A1 = mem.ReadU32(c.S1);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x4D8u;
        c.RA = 0x801C7148u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7148: ;
        c.RA = 0x801C7150u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        if (c.V0 != c.S2) {
            goto L801C7168;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x4E4u;
        c.A1 = c.S0;
        c.RA = 0x801C7168u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7168: ;
        c.V0 = mem.ReadU32(c.S1);
        c.V0 = c.V0 & 0x0008u;
        if (c.V0 == 0u) {
            c.V0 = c.S0 + 0x4u;
            goto L801C719C;
        }
        c.V0 = c.S0 + 0x4u;
        c.V1 = mem.ReadU32(c.S0);
        mem.WriteU32((c.S1 + 0x4u), c.V0);
        c.V0 = c.S0 + 0xCu;
        mem.WriteU32((c.S1 + 0x8u), c.V0);
        c.A0 = c.V1 >> 2;
        c.V0 = c.A0 << 2;
        c.S0 = c.S0 + c.V0;
        goto L801C71A8;
        L801C719C: ;
        c.A0 = 0u;
        mem.WriteU32((c.S1 + 0x4u), 0u);
        mem.WriteU32((c.S1 + 0x8u), 0u);
        L801C71A8: ;
        c.V0 = mem.ReadU32(c.S0);
        c.V1 = c.S0 + 0x4u;
        mem.WriteU32((c.S1 + 0xCu), c.V1);
        c.V1 = c.S0 + 0xCu;
        mem.WriteU32((c.S1 + 0x10u), c.V1);
        c.V0 = c.V0 >> 2;
        c.V0 = c.V0 + 0x2u;
        c.V0 = c.A0 + c.V0;
        L801C71C8: ;
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C71E4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x38u;
        mem.WriteU32((c.SP + 0x30u), c.S6);
        c.S6 = mem.ReadU32((c.SP + 0x48u));
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A1;
        mem.WriteU32((c.SP + 0x2Cu), c.S5);
        c.S5 = c.A2;
        mem.WriteU32((c.SP + 0x28u), c.S4);
        c.S4 = c.A3;
        mem.WriteU32((c.SP + 0x34u), c.RA);
        mem.WriteU32((c.SP + 0x24u), c.S3);
        mem.WriteU32((c.SP + 0x20u), c.S2);
        c.RA = 0x801C7220u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.S3 = 0x00000002u;
        if (c.V0 != c.S3) {
            c.S2 = c.S0 + 0xCu;
            goto L801C723C;
        }
        c.S2 = c.S0 + 0xCu;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x4F4u;
        c.RA = 0x801C723Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C723C: ;
        c.RA = 0x801C7244u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        if (c.V0 != c.S3) {
            goto L801C726C;
        }
        mem.WriteU32((c.SP + 0x10u), c.S1);
        c.A1 = mem.ReadU32(c.S0);
        c.A2 = mem.ReadU32((c.S0 + 0x4u));
        c.A3 = mem.ReadU32((c.S0 + 0x8u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x508u;
        c.RA = 0x801C726Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C726C: ;
        c.RA = 0x801C7274u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        if (c.V0 != c.S3) {
            c.V0 = c.S1 << 3;
            goto L801C72A0;
        }
        c.V0 = c.S1 << 3;
        c.V0 = c.V0 - c.S1;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S2;
        c.A1 = mem.ReadU32(c.V0);
        c.A2 = mem.ReadU32((c.V0 + 0x4u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x530u;
        c.RA = 0x801C72A0u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C72A0: ;
        c.RA = 0x801C72A8u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        if (c.V0 != c.S3) {
            c.V0 = c.S1 << 3;
            goto L801C72D4;
        }
        c.V0 = c.S1 << 3;
        c.V0 = c.V0 - c.S1;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S2;
        c.A1 = mem.ReadU32((c.V0 + 0x8u));
        c.A2 = mem.ReadU32((c.V0 + 0xCu));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x548u;
        c.RA = 0x801C72D4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C72D4: ;
        c.RA = 0x801C72DCu;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        if (c.V0 != c.S3) {
            c.V1 = c.S1 << 3;
            goto L801C7310;
        }
        c.V1 = c.S1 << 3;
        c.V0 = c.S1 << 3;
        c.V0 = c.V0 - c.S1;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S2;
        c.A1 = mem.ReadU32((c.V0 + 0x10u));
        c.A2 = mem.ReadU32((c.V0 + 0x14u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x560u;
        c.RA = 0x801C730Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V1 = c.S1 << 3;
        L801C7310: ;
        c.V1 = c.V1 - c.S1;
        c.V1 = c.V1 << 2;
        c.V1 = c.V1 + c.S2;
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.S2 + c.V0;
        mem.WriteU32(c.S4, c.V0);
        c.V0 = mem.ReadU32((c.V1 + 0x8u));
        c.V0 = c.S2 + c.V0;
        mem.WriteU32(c.S6, c.V0);
        c.V0 = mem.ReadU32((c.V1 + 0x10u));
        c.V0 = c.S2 + c.V0;
        mem.WriteU32(c.S5, c.V0);
        c.V0 = mem.ReadU32((c.V1 + 0x14u));
        c.RA = mem.ReadU32((c.SP + 0x34u));
        c.S6 = mem.ReadU32((c.SP + 0x30u));
        c.S5 = mem.ReadU32((c.SP + 0x2Cu));
        c.S4 = mem.ReadU32((c.SP + 0x28u));
        c.S3 = mem.ReadU32((c.SP + 0x24u));
        c.S2 = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x38u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C737C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A1;
        c.A0 = c.S1;
        c.A1 = 0u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.A2 = 0x00000078u;
        c.RA = 0x801C73A4u;
        Courier_Crisis_main.func_801C87EC(c, m);
        c.V1 = 0xFDFF0000u;
        c.V1 = c.V1 | 0xFFFFu;
        c.A0 = 0x2D030000u;
        c.V0 = mem.ReadU32(c.S0);
        c.A0 = c.A0 | 0x0709u;
        c.V1 = c.V0 & c.V1;
        if (c.V1 == c.A0) {
            mem.WriteU32(c.S1, c.V0);
            goto L801C8368;
        }
        mem.WriteU32(c.S1, c.V0);
        c.V0 = c.A0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x35030000u;
            goto L801C751C;
        }
        c.V0 = 0x35030000u;
        c.V0 = 0x25030000u;
        c.V0 = c.V0 | 0x0607u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7B38;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x29030000u;
            goto L801C7484;
        }
        c.V0 = 0x29030000u;
        c.V0 = 0x21030000u;
        c.V0 = c.V0 | 0x0304u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C79C8;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x24020000u;
            goto L801C7444;
        }
        c.V0 = 0x24020000u;
        c.V0 = 0x20020000u;
        c.V0 = c.V0 | 0x0304u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7670;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x21010000u;
            goto L801C7430;
        }
        c.V0 = 0x21010000u;
        c.V0 = 0x20000000u;
        c.V0 = c.V0 | 0x0304u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7670;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7430: ;
        c.V0 = c.V0 | 0x0304u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C79C8;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7444: ;
        c.V0 = c.V0 | 0x0507u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7828;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x25010000u;
            goto L801C7470;
        }
        c.V0 = 0x25010000u;
        c.V0 = 0x24000000u;
        c.V0 = c.V0 | 0x0507u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7828;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7470: ;
        c.V0 = c.V0 | 0x0607u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7B38;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7484: ;
        c.V0 = c.V0 | 0x0305u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C8198;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x2C020000u;
            goto L801C74DC;
        }
        c.V0 = 0x2C020000u;
        c.V0 = 0x28020000u;
        c.V0 = c.V0 | 0x0405u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7D68;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x29010000u;
            goto L801C74C8;
        }
        c.V0 = 0x29010000u;
        c.V0 = 0x28000000u;
        c.V0 = c.V0 | 0x0405u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7D68;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C74C8: ;
        c.V0 = c.V0 | 0x0305u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C8198;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C74DC: ;
        c.V0 = c.V0 | 0x0709u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7F98;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x2D010000u;
            goto L801C7508;
        }
        c.V0 = 0x2D010000u;
        c.V0 = 0x2C000000u;
        c.V0 = c.V0 | 0x0709u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7F98;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7508: ;
        c.V0 = c.V0 | 0x0709u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C8368;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C751C: ;
        c.V0 = c.V0 | 0x0809u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7C50;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x39030000u;
            goto L801C75CC;
        }
        c.V0 = 0x39030000u;
        c.V0 = 0x31030000u;
        c.V0 = c.V0 | 0x0506u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7A80;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x34020000u;
            goto L801C758C;
        }
        c.V0 = 0x34020000u;
        c.V0 = 0x30020000u;
        c.V0 = c.V0 | 0x0406u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C774C;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x31010000u;
            goto L801C7578;
        }
        c.V0 = 0x31010000u;
        c.V0 = 0x30000000u;
        c.V0 = c.V0 | 0x0406u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C774C;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7578: ;
        c.V0 = c.V0 | 0x0506u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7A80;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C758C: ;
        c.V0 = c.V0 | 0x0609u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C78F8;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x35010000u;
            goto L801C75B8;
        }
        c.V0 = 0x35010000u;
        c.V0 = 0x34000000u;
        c.V0 = c.V0 | 0x0609u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C78F8;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C75B8: ;
        c.V0 = c.V0 | 0x0809u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7C50;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C75CC: ;
        c.V0 = c.V0 | 0x0608u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C8280;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x3C020000u;
            goto L801C7624;
        }
        c.V0 = 0x3C020000u;
        c.V0 = 0x38020000u;
        c.V0 = c.V0 | 0x0508u;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C7E80;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x39010000u;
            goto L801C7610;
        }
        c.V0 = 0x39010000u;
        c.V0 = 0x38000000u;
        c.V0 = c.V0 | 0x0508u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C7E80;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7610: ;
        c.V0 = c.V0 | 0x0608u;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C8280;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7624: ;
        c.V0 = c.V0 | 0x080Cu;
        if (c.V1 == c.V0) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801C8098;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x3D010000u;
            goto L801C7650;
        }
        c.V0 = 0x3D010000u;
        c.V0 = 0x3C000000u;
        c.V0 = c.V0 | 0x080Cu;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C8098;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7650: ;
        c.V0 = c.V0 | 0x0A0Cu;
        if (c.V1 == c.V0) {
            c.V0 = 0x3D030000u;
            goto L801C84C8;
        }
        c.V0 = 0x3D030000u;
        c.V0 = c.V0 | 0x0A0Cu;
        if (c.V1 == c.V0) {
            c.V0 = 0xFDFF0000u;
            goto L801C84C8;
        }
        c.V0 = 0xFDFF0000u;
        goto L801C8628;
        L801C7670: ;
        c.RA = 0x801C7678u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7694;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x578u;
        c.RA = 0x801C7694u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7694: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xCu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xEu));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x8u));
        c.V0 = 0x00000010u;
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V1);
        goto L801C8644;
        L801C774C: ;
        c.RA = 0x801C7754u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7770;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x580u;
        c.RA = 0x801C7770u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7770: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xEu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x12u));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xCu));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x10u));
        c.V0 = 0x00000014u;
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V1);
        goto L801C8644;
        L801C7828: ;
        c.RA = 0x801C7830u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C784C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x588u;
        c.RA = 0x801C784Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C784C: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x12u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x10u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x10u));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x10u));
        c.V0 = 0x00000018u;
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V1);
        goto L801C8644;
        L801C78F8: ;
        c.RA = 0x801C7900u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C791C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x590u;
        c.RA = 0x801C791Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C791C: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x12u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Au));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x10u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x18u));
        c.V0 = 0x0000001Cu;
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V1);
        goto L801C8644;
        L801C79C8: ;
        c.RA = 0x801C79D0u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C79EC;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x598u;
        c.RA = 0x801C79ECu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C79EC: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0xCu));
        c.V0 = 0x00000010u;
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V1);
        goto L801C8644;
        L801C7A80: ;
        c.RA = 0x801C7A88u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7AA4;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x59Cu;
        c.RA = 0x801C7AA4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7AA4: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xAu));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xEu));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x10u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x12u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x14u));
        c.V0 = 0x00000018u;
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V1);
        goto L801C8644;
        L801C7B38: ;
        c.RA = 0x801C7B40u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7B5C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5A0u;
        c.RA = 0x801C7B5Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7B5C: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x12u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x12u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x12u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x18u));
        c.V0 = 0x0000001Cu;
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V1);
        goto L801C8644;
        L801C7C50: ;
        c.RA = 0x801C7C58u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7C74;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5A8u;
        c.RA = 0x801C7C74u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7C74: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Cu));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Eu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x20u));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x12u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x14u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x15u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x16u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x18u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x19u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V1 = mem.ReadU8((c.S0 + 0x1Au));
        c.V0 = 0x00000024u;
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V1);
        goto L801C8644;
        L801C7D68: ;
        c.RA = 0x801C7D70u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7D8C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5B0u;
        c.RA = 0x801C7D8Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7D8C: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x11u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x12u), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xCu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xEu));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x10u));
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x8u));
        c.V0 = 0x00000014u;
        mem.WriteU16((c.S1 + 0x76u), (ushort)c.V1);
        goto L801C8644;
        L801C7E80: ;
        c.RA = 0x801C7E88u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7EA4;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5B8u;
        c.RA = 0x801C7EA4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7EA4: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x11u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x12u), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xEu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x12u));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xCu));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x10u));
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x14u));
        c.V0 = 0x00000018u;
        mem.WriteU16((c.S1 + 0x76u), (ushort)c.V1);
        goto L801C8644;
        L801C7F98: ;
        c.RA = 0x801C7FA0u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C7FBC;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5C0u;
        c.RA = 0x801C7FBCu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C7FBC: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x1Eu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x1Fu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x18u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Au));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Cu));
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x14u));
        c.V0 = 0x00000020u;
        mem.WriteU16((c.S1 + 0x76u), (ushort)c.V1);
        goto L801C8644;
        L801C8098: ;
        c.RA = 0x801C80A0u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C80BC;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5C8u;
        c.RA = 0x801C80BCu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C80BC: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x1Eu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x1Fu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Au));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Eu));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x22u));
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x70u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x18u));
        mem.WriteU16((c.S1 + 0x72u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Cu));
        mem.WriteU16((c.S1 + 0x74u), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x20u));
        c.V0 = 0x00000024u;
        mem.WriteU16((c.S1 + 0x76u), (ushort)c.V1);
        goto L801C8644;
        L801C8198: ;
        c.RA = 0x801C81A0u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C81BC;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5D0u;
        c.RA = 0x801C81BCu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C81BC: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x11u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x12u), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x8u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0xCu));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0xEu));
        c.V0 = 0x00000010u;
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V1);
        goto L801C8644;
        L801C8280: ;
        c.RA = 0x801C8288u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C82A4;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5D4u;
        c.RA = 0x801C82A4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C82A4: ;
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x6u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xAu));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xEu));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x11u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x12u));
        mem.WriteU8((c.S1 + 0x12u), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x14u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x16u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x18u));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x1Au));
        c.V0 = 0x0000001Cu;
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V1);
        goto L801C8644;
        L801C8368: ;
        c.RA = 0x801C8370u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C838C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5D8u;
        c.RA = 0x801C838Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C838C: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x1Eu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x1Fu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x14u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x15u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x16u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x14u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x15u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x16u));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x14u));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x15u));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x16u));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x14u));
        mem.WriteU8((c.S1 + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x15u));
        mem.WriteU8((c.S1 + 0x11u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x16u));
        mem.WriteU8((c.S1 + 0x12u), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x18u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Au));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x1Cu));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V1 = mem.ReadU16((c.S0 + 0x1Eu));
        c.V0 = 0x00000020u;
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V1);
        goto L801C8644;
        L801C84C8: ;
        c.RA = 0x801C84D0u;
        Courier_Crisis_main.GetGraphDebug_main(c, m);
        c.V1 = 0x00000002u;
        if (c.V0 != c.V1) {
            goto L801C84EC;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5E0u;
        c.RA = 0x801C84ECu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801C84EC: ;
        c.V0 = mem.ReadU16((c.S0 + 0xAu));
        mem.WriteU16((c.S1 + 0x14u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x6u));
        mem.WriteU16((c.S1 + 0x16u), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x4u));
        mem.WriteU8((c.S1 + 0x18u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x5u));
        mem.WriteU8((c.S1 + 0x19u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x8u));
        mem.WriteU8((c.S1 + 0x1Au), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x9u));
        mem.WriteU8((c.S1 + 0x1Bu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xCu));
        mem.WriteU8((c.S1 + 0x1Cu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0xDu));
        mem.WriteU8((c.S1 + 0x1Du), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x10u));
        mem.WriteU8((c.S1 + 0x1Eu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x11u));
        mem.WriteU8((c.S1 + 0x1Fu), (byte)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x24u));
        mem.WriteU16((c.S1 + 0x68u), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x26u));
        mem.WriteU16((c.S1 + 0x6Au), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x28u));
        mem.WriteU16((c.S1 + 0x6Cu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.S0 + 0x2Au));
        mem.WriteU16((c.S1 + 0x6Eu), (ushort)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x14u));
        mem.WriteU8((c.S1 + 0x4u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x15u));
        mem.WriteU8((c.S1 + 0x5u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x16u));
        mem.WriteU8((c.S1 + 0x6u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x18u));
        mem.WriteU8((c.S1 + 0x8u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x19u));
        mem.WriteU8((c.S1 + 0x9u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x1Au));
        mem.WriteU8((c.S1 + 0xAu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x1Cu));
        mem.WriteU8((c.S1 + 0xCu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x1Du));
        mem.WriteU8((c.S1 + 0xDu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x1Eu));
        mem.WriteU8((c.S1 + 0xEu), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x20u));
        mem.WriteU8((c.S1 + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.S0 + 0x21u));
        mem.WriteU8((c.S1 + 0x11u), (byte)c.V0);
        c.V1 = mem.ReadU8((c.S0 + 0x22u));
        c.V0 = 0x0000002Cu;
        mem.WriteU8((c.S1 + 0x12u), (byte)c.V1);
        goto L801C8644;
        L801C8628: ;
        c.V0 = c.V0 | 0xFFFFu;
        c.A1 = mem.ReadU32(c.S1);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x5E8u;
        c.A1 = c.A1 & c.V0;
        c.RA = 0x801C8640u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0xFFFFFFFFu;
        L801C8644: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void InitGeom_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x98Cu), c.RA);
        c.RA = 0x801C8674u;
        Courier_Crisis_main._patch_gte_main(c, m);
        c.RA = 0x801D0000u;
        c.RA = mem.ReadU32((c.RA - 0x98Cu));
        c.V0 = c.SR;
        c.V1 = 0x40000000u;
        c.V0 = c.V0 | c.V1;
        c.SR = c.V0;
        c.T0 = 0x00000155u;
        RecompOne.Runtime.Gte.WriteControl(29, c.T0);
        c.T0 = 0x00000100u;
        RecompOne.Runtime.Gte.WriteControl(30, c.T0);
        c.T0 = 0x000003E8u;
        RecompOne.Runtime.Gte.WriteControl(26, c.T0);
        c.T0 = 0xFFFFEF9Eu;
        RecompOne.Runtime.Gte.WriteControl(27, c.T0);
        c.T0 = 0x01400000u;
        RecompOne.Runtime.Gte.WriteControl(28, c.T0);
        RecompOne.Runtime.Gte.WriteControl(24, 0u);
        RecompOne.Runtime.Gte.WriteControl(25, 0u);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SetGeomOffset_main(CpuContext c, IMemory m)
    {
        c.A0 = c.A0 << 16;
        c.A1 = c.A1 << 16;
        RecompOne.Runtime.Gte.WriteControl(24, c.A0);
        RecompOne.Runtime.Gte.WriteControl(25, c.A1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _patch_gte_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x14B0u), c.RA);
        c.RA = 0x801C871Cu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000056u;
        c.RA = 0x801C8728u;
        Dispatcher.Call(c, m, c.T2);
        c.T2 = 0x801D0000u;
        c.T1 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x18u));
        c.T2 = c.T2 - 0x788Cu;
        c.T1 = c.T1 - 0x7854u;
        L801C873C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V1 = mem.ReadU32(c.T2);
        c.T2 = c.T2 + 0x4u;
        c.V0 = c.V0 + 0x4u;
        if (c.T2 != c.T1) {
            mem.WriteU32((c.V0 - 0x4u), c.V1);
            goto L801C873C;
        }
        mem.WriteU32((c.V0 - 0x4u), c.V1);
        c.RA = 0x801C8758u;
        Courier_Crisis_main.func_801C24BC(c, m);
        c.RA = 0x801C8760u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        c.RA = 0x801E0000u;
        c.RA = mem.ReadU32((c.RA + 0x14B0u));
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C87B4(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x0000003Fu;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C87CC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000013u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C87DC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x0000002Au;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C87EC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x0000002Bu;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C87FC(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x0000003Fu;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SpuInit_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A0 = 0u;
        c.RA = 0x801C881Cu;
        Courier_Crisis_main._SpuInit_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _SpuInit_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.S0 = c.A0;
        c.RA = 0x801C8840u;
        Courier_Crisis_main.ResetCallback_main(c, m);
        c.A0 = c.S0;
        c.RA = 0x801C8848u;
        Courier_Crisis_main._spu_init_main(c, m);
        if (c.S0 != 0u) {
            c.A0 = 0u | 0xC000u;
            goto L801C886C;
        }
        c.A0 = 0u | 0xC000u;
        c.V1 = 0x00000017u;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0x912u;
        L801C885C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU16(c.V0, (ushort)c.A0);
        c.V1 = c.V1 - 0x1u;
        if ((int)c.V1 >= 0) {
            c.V0 = c.V0 - 0x2u;
            goto L801C885C;
        }
        c.V0 = c.V0 - 0x2u;
        L801C886C: ;
        c.RA = 0x801C8874u;
        Courier_Crisis_main.SpuStart_main(c, m);
        c.A0 = 0x000000D1u;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x4A0u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x968u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x964u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x958u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x954u), (ushort)0u);
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x952u), (ushort)0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x950u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x94Cu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x960u), c.A1);
        c.A2 = 0u;
        c.RA = 0x801C88C8u;
        Courier_Crisis_main._spu_FsetRXX_main(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4ACu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4A8u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4A4u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x96Cu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4ECu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x970u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x944u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x948u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x510u), 0u);
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SpuStart_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x50Cu));
        c.SP = c.SP - 0x18u;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x10u), c.RA);
            goto L801C8990;
        }
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x50Cu), c.V0);
        c.RA = 0x801C894Cu;
        Courier_Crisis_main.EnterCriticalSection_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x71E0u;
        c.RA = 0x801C895Cu;
        Courier_Crisis_main._SpuDataCallback_main(c, m);
        c.A0 = 0xF0000000u;
        c.A0 = c.A0 | 0x0009u;
        c.A1 = 0x00000020u;
        c.A2 = 0x00002000u;
        c.A3 = 0u;
        c.RA = 0x801C8974u;
        Courier_Crisis_main.func_801C89A0(c, m);
        c.A0 = c.V0;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x974u), c.A0);
        c.RA = 0x801C8988u;
        Courier_Crisis_main.func_801C89B0(c, m);
        c.RA = 0x801C8990u;
        Courier_Crisis_main.ExitCriticalSection_main(c, m);
        L801C8990: ;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C89A0(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000008u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C89B0(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x0000000Cu;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_init_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x4F8u));
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = 0x000B0000u;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.A0, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4ECu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4E8u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x4F0u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x180u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x182u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x1AAu), (ushort)0u);
        c.RA = 0x801C8A20u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        mem.WriteU16((c.V0 + 0x180u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x182u), (ushort)0u);
        c.V0 = mem.ReadU16((c.V0 + 0x1AEu));
        c.V0 = c.V0 & 0x07FFu;
        if (c.V0 == 0u) {
            c.V1 = 0u;
            goto L801C8A98;
        }
        c.V1 = 0u;
        c.V1 = c.V1 + 0x1u;
        L801C8A4C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C8A78;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x604u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x614u;
        c.RA = 0x801C8A70u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.A0 = 0u;
        goto L801C8A9C;
        L801C8A78: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V0 = mem.ReadU16((c.V0 + 0x1AEu));
        c.V0 = c.V0 & 0x07FFu;
        if (c.V0 != 0u) {
            c.V1 = c.V1 + 0x1u;
            goto L801C8A4C;
        }
        c.V1 = c.V1 + 0x1u;
        L801C8A98: ;
        c.A0 = 0u;
        L801C8A9C: ;
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x3B34u;
        c.V0 = 0x00000002u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4E4u), c.V0);
        c.V0 = 0x00000003u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4E0u), c.V0);
        c.V0 = 0x00000008u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4DCu), c.V0);
        c.V0 = 0x00000007u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4D8u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V1 = 0x00000004u;
        mem.WriteU16((c.V0 + 0x1ACu), (ushort)c.V1);
        c.V1 = 0u | 0xFFFFu;
        mem.WriteU16((c.V0 + 0x184u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x186u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x18Cu), (ushort)c.V1);
        mem.WriteU16((c.V0 + 0x18Eu), (ushort)c.V1);
        mem.WriteU16((c.V0 + 0x198u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x19Au), (ushort)0u);
        L801C8B00: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU16(c.A1, (ushort)0u);
        c.A0 = c.A0 + 0x1u;
        c.V0 = (int)c.A0 < 10 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.A1 = c.A1 + 0x2u;
            goto L801C8B00;
        }
        c.A1 = c.A1 + 0x2u;
        if (c.S0 != 0u) {
            c.V0 = 0u;
            goto L801C8C10;
        }
        c.V0 = 0u;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x4C8u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V1 = 0x00000200u;
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x4F0u), (ushort)c.V1);
        mem.WriteU16((c.V0 + 0x190u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x192u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x194u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x196u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x1B0u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x1B2u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x1B4u), (ushort)0u);
        mem.WriteU16((c.V0 + 0x1B6u), (ushort)0u);
        c.A1 = 0x00000010u;
        c.RA = 0x801C8B60u;
        Courier_Crisis_main.func_801C8C54(c, m);
        c.A0 = 0u;
        c.A2 = 0x00003FFFu;
        c.A1 = 0x00000200u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x508u));
        L801C8B74: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU16(c.V1, (ushort)0u);
        mem.WriteU16((c.V1 + 0x2u), (ushort)0u);
        mem.WriteU16((c.V1 + 0x4u), (ushort)c.A2);
        mem.WriteU16((c.V1 + 0x6u), (ushort)c.A1);
        mem.WriteU16((c.V1 + 0x8u), (ushort)0u);
        mem.WriteU16((c.V1 + 0xAu), (ushort)0u);
        c.A0 = c.A0 + 0x1u;
        c.V0 = (int)c.A0 < 24 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.V1 + 0x10u;
            goto L801C8B74;
        }
        c.V1 = c.V1 + 0x10u;
        c.S1 = 0u | 0xFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.S0 = 0x000000FFu;
        mem.WriteU16((c.V0 + 0x188u), (ushort)c.S1);
        mem.WriteU16((c.V0 + 0x18Au), (ushort)c.S0);
        c.RA = 0x801C8BC0u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8BC8u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8BD0u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8BD8u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        mem.WriteU16((c.V0 + 0x18Cu), (ushort)c.S1);
        mem.WriteU16((c.V0 + 0x18Eu), (ushort)c.S0);
        c.RA = 0x801C8BF4u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8BFCu;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8C04u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8C0Cu;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.V0 = 0u;
        L801C8C10: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x508u));
        c.V1 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4D4u), c.V1);
        c.V1 = 0u | 0xC000u;
        mem.WriteU16((c.A0 + 0x1AAu), (ushort)c.V1);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4D0u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4CCu), 0u);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C8C54(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU16((c.V1 - 0x4F0u));
        c.SP = c.SP - 0x30u;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A1;
        mem.WriteU32((c.SP + 0x28u), c.RA);
        mem.WriteU32((c.SP + 0x24u), c.S3);
        mem.WriteU32((c.SP + 0x20u), c.S2);
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.A1 = mem.ReadU16((c.V0 + 0x1AEu));
        c.S2 = c.A0;
        mem.WriteU16((c.V0 + 0x1A6u), (ushort)c.V1);
        c.S3 = c.A1 & 0x07FFu;
        c.RA = 0x801C8C94u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        if (c.S1 == 0u) {
            c.V0 = c.S1 < 0x00000041u ? 1u : 0u;
            goto L801C8D84;
        }
        c.V0 = c.S1 < 0x00000041u ? 1u : 0u;
        L801C8C9C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        if (c.V0 == 0u) {
            c.S0 = 0x00000040u;
            goto L801C8CA8;
        }
        c.S0 = 0x00000040u;
        c.S0 = c.S1;
        L801C8CA8: ;
        if ((int)c.S0 <= 0) {
            c.V1 = 0u;
            goto L801C8CD4;
        }
        c.V1 = 0u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x508u));
        L801C8CB8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU16(c.S2);
        c.S2 = c.S2 + 0x2u;
        c.V1 = c.V1 + 0x2u;
        mem.WriteU16((c.A0 + 0x1A8u), (ushort)c.V0);
        c.V0 = (int)c.V1 < (int)c.S0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C8CB8;
        }
        L801C8CD4: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x508u));
        c.A0 = mem.ReadU16((c.V1 + 0x1AAu));
        c.V0 = c.A0 & 0xFFCFu;
        c.A0 = c.V0 | 0x0010u;
        mem.WriteU16((c.V1 + 0x1AAu), (ushort)c.A0);
        c.RA = 0x801C8CFCu;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V0 = mem.ReadU16((c.V0 + 0x1AEu));
        c.V0 = c.V0 & 0x0400u;
        if (c.V0 == 0u) {
            c.V1 = 0u;
            goto L801C8D6C;
        }
        c.V1 = 0u;
        c.V1 = c.V1 + 0x1u;
        L801C8D20: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C8D4C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x604u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x624u;
        c.RA = 0x801C8D44u;
        Courier_Crisis_main.func_801C87FC(c, m);
        goto L801C8D6C;
        L801C8D4C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V0 = mem.ReadU16((c.V0 + 0x1AEu));
        c.V0 = c.V0 & 0x0400u;
        if (c.V0 != 0u) {
            c.V1 = c.V1 + 0x1u;
            goto L801C8D20;
        }
        c.V1 = c.V1 + 0x1u;
        L801C8D6C: ;
        c.S1 = c.S1 - c.S0;
        c.RA = 0x801C8D74u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8D7Cu;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        if (c.S1 != 0u) {
            c.V0 = c.S1 < 0x00000041u ? 1u : 0u;
            goto L801C8C9C;
        }
        c.V0 = c.S1 < 0x00000041u ? 1u : 0u;
        L801C8D84: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.A0 = mem.ReadU16((c.V0 + 0x1AAu));
        c.V1 = 0u;
        c.A0 = c.A0 & 0xFFCFu;
        mem.WriteU16((c.V0 + 0x1AAu), (ushort)c.A0);
        c.V0 = mem.ReadU16((c.V0 + 0x1AEu));
        c.A1 = c.S3 & 0xFFFFu;
        c.V0 = c.V0 & 0x07FFu;
        if (c.V0 == c.A1) {
            c.V1 = c.V1 + 0x1u;
            goto L801C8E00;
        }
        c.V1 = c.V1 + 0x1u;
        L801C8DB4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C8DE0;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x604u;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x638u;
        c.RA = 0x801C8DD8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        goto L801C8E00;
        L801C8DE0: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V0 = mem.ReadU16((c.V0 + 0x1AEu));
        c.V0 = c.V0 & 0x07FFu;
        if (c.V0 != c.A1) {
            c.V1 = c.V1 + 0x1u;
            goto L801C8DB4;
        }
        c.V1 = c.V1 + 0x1u;
        L801C8E00: ;
        c.RA = mem.ReadU32((c.SP + 0x28u));
        c.S3 = mem.ReadU32((c.SP + 0x24u));
        c.S2 = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x30u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_FiDMA_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4B8u));
        c.SP = c.SP - 0x18u;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x10u), c.RA);
            goto L801C8E3C;
        }
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801C8E3Cu;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        L801C8E3C: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x508u));
        c.V0 = mem.ReadU16((c.A0 + 0x1AAu));
        c.V0 = c.V0 & 0xFFCFu;
        mem.WriteU16((c.A0 + 0x1AAu), (ushort)c.V0);
        c.V0 = mem.ReadU16((c.A0 + 0x1AAu));
        c.V0 = c.V0 & 0x0030u;
        if (c.V0 == 0u) {
            c.V1 = 0u;
            goto L801C8E94;
        }
        c.V1 = 0u;
        c.V1 = c.V1 + 0x1u;
        L801C8E70: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C8E94;
        }
        c.V0 = mem.ReadU16((c.A0 + 0x1AAu));
        c.V0 = c.V0 & 0x0030u;
        if (c.V0 != 0u) {
            c.V1 = c.V1 + 0x1u;
            goto L801C8E70;
        }
        c.V1 = c.V1 + 0x1u;
        c.V1 = c.V1 - 0x1u;
        L801C8E94: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4D0u));
        if (c.V0 == 0u) {
            c.A0 = 0xF0000000u;
            goto L801C8EC4;
        }
        c.A0 = 0xF0000000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4D0u));
        c.RA = 0x801C8EBCu;
        Dispatcher.Call(c, m, c.V0);
        goto L801C8ED0;
        L801C8EC4: ;
        c.A0 = c.A0 | 0x0009u;
        c.A1 = 0x00000020u;
        c.RA = 0x801C8ED0u;
        Courier_Crisis_main.func_801C9554(c, m);
        L801C8ED0: ;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_Fr__main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU16((c.V0 + 0x1A6u), (ushort)c.A1);
        c.S0 = c.A2;
        c.RA = 0x801C8F08u;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x508u));
        c.V0 = mem.ReadU16((c.V1 + 0x1AAu));
        c.V0 = c.V0 | 0x0030u;
        mem.WriteU16((c.V1 + 0x1AAu), (ushort)c.V0);
        c.S0 = c.S0 << 16;
        c.RA = 0x801C8F2Cu;
        Courier_Crisis_main._spu_Fw1ts_main(c, m);
        c.RA = 0x801C8F34u;
        Courier_Crisis_main.func_801C94C0(c, m);
        c.A0 = 0x01000000u;
        c.A0 = c.A0 | 0x0200u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x504u));
        mem.WriteU32(c.V0, c.S1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x500u));
        c.S0 = c.S0 | 0x0010u;
        mem.WriteU32(c.V0, c.S0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x4FCu));
        c.V0 = 0x00000001u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4B8u), c.V0);
        mem.WriteU32(c.V1, c.A0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_t_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        mem.WriteU32(c.SP, c.A0);
        mem.WriteU32((c.SP + 0x4u), c.A1);
        mem.WriteU32((c.SP + 0x8u), c.A2);
        mem.WriteU32((c.SP + 0xCu), c.A3);
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.SP + 0x1Cu;
        c.A2 = 0x00000001u;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        if (c.A0 == c.A2) {
            mem.WriteU32((c.SP + 0x18u), c.A0);
            goto L801C901C;
        }
        mem.WriteU32((c.SP + 0x18u), c.A0);
        c.V0 = (int)c.A0 < 2 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801C8FD4;
        }
        if (c.A0 == 0u) {
            c.V0 = 0u;
            goto L801C908C;
        }
        c.V0 = 0u;
        goto L801C9208;
        L801C8FD4: ;
        c.V0 = 0x00000002u;
        if (c.A0 == c.V0) {
            c.V0 = 0x00000003u;
            goto L801C8FF0;
        }
        c.V0 = 0x00000003u;
        if (c.A0 == c.V0) {
            c.V0 = 0u;
            goto L801C90F8;
        }
        c.V0 = 0u;
        goto L801C9208;
        L801C8FF0: ;
        c.A0 = mem.ReadU32((c.SP + 0x1Cu));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4E0u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x508u));
        c.V0 = c.A0 >> (int)(c.V0 & 31u);
        c.At = 0x801D0000u;
        mem.WriteU16((c.At - 0x4F0u), (ushort)c.V0);
        mem.WriteU16((c.V1 + 0x1A6u), (ushort)c.V0);
        c.V0 = 0u;
        goto L801C9208;
        L801C901C: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x508u));
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU16((c.A0 - 0x4F0u));
        c.V0 = mem.ReadU16((c.A1 + 0x1A6u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4B8u), 0u);
        c.V0 = c.V0 & 0xFFFFu;
        if (c.V0 == c.A0) {
            c.V1 = 0u;
            goto L801C9064;
        }
        c.V1 = 0u;
        c.V1 = c.V1 + 0x1u;
        L801C9048: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = 0xFFFFFFFEu;
            goto L801C9208;
        }
        c.V0 = 0xFFFFFFFEu;
        c.V0 = mem.ReadU16((c.A1 + 0x1A6u));
        if (c.V0 != c.A0) {
            c.V1 = c.V1 + 0x1u;
            goto L801C9048;
        }
        c.V1 = c.V1 + 0x1u;
        L801C9064: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x508u));
        c.A0 = mem.ReadU16((c.V1 + 0x1AAu));
        c.V0 = c.A0 & 0xFFCFu;
        c.A0 = c.V0 | 0x0020u;
        mem.WriteU16((c.V1 + 0x1AAu), (ushort)c.A0);
        c.V0 = 0u;
        goto L801C9208;
        L801C908C: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x508u));
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU16((c.A0 - 0x4F0u));
        c.V0 = mem.ReadU16((c.A1 + 0x1A6u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4B8u), c.A2);
        c.V0 = c.V0 & 0xFFFFu;
        if (c.V0 == c.A0) {
            c.V1 = 0u;
            goto L801C90D4;
        }
        c.V1 = 0u;
        c.V1 = c.V1 + 0x1u;
        L801C90B8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = 0xFFFFFFFEu;
            goto L801C9208;
        }
        c.V0 = 0xFFFFFFFEu;
        c.V0 = mem.ReadU16((c.A1 + 0x1A6u));
        if (c.V0 != c.A0) {
            c.V1 = c.V1 + 0x1u;
            goto L801C90B8;
        }
        c.V1 = c.V1 + 0x1u;
        L801C90D4: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.A0 = mem.ReadU16((c.V0 + 0x1AAu));
        c.A0 = c.A0 | 0x0030u;
        mem.WriteU16((c.V0 + 0x1AAu), (ushort)c.A0);
        c.V0 = 0u;
        goto L801C9208;
        L801C90F8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4B8u));
        if (c.V0 != c.A2) {
            c.A0 = 0x00000020u;
            goto L801C9110;
        }
        c.A0 = 0x00000020u;
        c.A0 = 0x00000030u;
        L801C9110: ;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x508u));
        c.V1 = 0u;
        c.V0 = mem.ReadU16((c.A1 + 0x1AAu));
        c.A0 = c.A0 & 0xFFFFu;
        c.V0 = c.V0 & 0x0030u;
        if (c.V0 == c.A0) {
            c.V1 = c.V1 + 0x1u;
            goto L801C9150;
        }
        c.V1 = c.V1 + 0x1u;
        L801C9130: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.V1 < 0x00000F01u ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = 0xFFFFFFFEu;
            goto L801C9208;
        }
        c.V0 = 0xFFFFFFFEu;
        c.V0 = mem.ReadU16((c.A1 + 0x1AAu));
        c.V0 = c.V0 & 0x0030u;
        if (c.V0 != c.A0) {
            c.V1 = c.V1 + 0x1u;
            goto L801C9130;
        }
        c.V1 = c.V1 + 0x1u;
        L801C9150: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x4B8u));
        c.V0 = 0x00000001u;
        if (c.V1 != c.V0) {
            goto L801C9174;
        }
        c.S0 = c.S0 + 0x4u;
        c.RA = 0x801C916Cu;
        Courier_Crisis_main.func_801C94C0(c, m);
        c.A2 = 0x01000000u;
        goto L801C9180;
        L801C9174: ;
        c.S0 = c.S0 + 0x4u;
        c.RA = 0x801C917Cu;
        Courier_Crisis_main.func_801C9494(c, m);
        c.A2 = 0x01000000u;
        L801C9180: ;
        c.A0 = mem.ReadU32((c.S0 - 0x4u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4B4u), c.A0);
        c.A0 = mem.ReadU32(c.S0);
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x504u));
        c.V1 = c.A0 >> 6;
        c.V0 = c.A0 & 0x003Fu;
        c.V0 = 0u < c.V0 ? 1u : 0u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x4B4u));
        c.V1 = c.V1 + c.V0;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x4B0u), c.V1);
        mem.WriteU32(c.A1, c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4B0u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x500u));
        c.V0 = c.V0 << 16;
        c.V0 = c.V0 | 0x0010u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x4B8u));
        c.V0 = 0x00000001u;
        if (c.V1 != c.V0) {
            c.A2 = c.A2 | 0x0201u;
            goto L801C91F4;
        }
        c.A2 = c.A2 | 0x0201u;
        c.A2 = 0x01000000u;
        c.A2 = c.A2 | 0x0200u;
        L801C91F4: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4FCu));
        mem.WriteU32(c.V0, c.A2);
        c.V0 = 0u;
        L801C9208: ;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_Fw_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4ECu));
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A1;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x18u), c.RA);
            goto L801C927C;
        }
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU16((c.V0 - 0x4F0u));
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x4E0u));
        c.A0 = 0x00000002u;
        c.A1 = c.V0 << (int)(c.A1 & 31u);
        c.RA = 0x801C925Cu;
        Courier_Crisis_main._spu_t_main(c, m);
        c.A0 = 0x00000001u;
        c.RA = 0x801C9264u;
        Courier_Crisis_main._spu_t_main(c, m);
        c.A0 = 0x00000003u;
        c.A1 = c.S1;
        c.A2 = c.S0;
        c.RA = 0x801C9274u;
        Courier_Crisis_main._spu_t_main(c, m);
        c.V0 = c.S0;
        goto L801C928C;
        L801C927C: ;
        c.A0 = c.S1;
        c.A1 = c.S0;
        c.RA = 0x801C9288u;
        Courier_Crisis_main.func_801C8C54(c, m);
        c.V0 = c.S0;
        L801C928C: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_Fr_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A1;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU16((c.V0 - 0x4F0u));
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x4E0u));
        c.A0 = 0x00000002u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.A1 = c.V0 << (int)(c.A1 & 31u);
        c.RA = 0x801C92D8u;
        Courier_Crisis_main._spu_t_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801C92E0u;
        Courier_Crisis_main._spu_t_main(c, m);
        c.A0 = 0x00000003u;
        c.A1 = c.S1;
        c.A2 = c.S0;
        c.RA = 0x801C92F0u;
        Courier_Crisis_main._spu_t_main(c, m);
        c.V0 = c.S0;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_FsetRXX_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        if (c.A2 != 0u) {
            c.V0 = c.A0 << 1;
            goto L801C9330;
        }
        c.V0 = c.A0 << 1;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x508u));
        c.V0 = c.V0 + c.V1;
        mem.WriteU16(c.V0, (ushort)c.A1);
        goto L801C934C;
        L801C9330: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x508u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 - 0x4E0u));
        c.V0 = c.V0 + c.A0;
        c.V1 = c.A1 >> (int)(c.V1 & 31u);
        mem.WriteU16(c.V0, (ushort)c.V1);
        L801C934C: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_FsetRXXa_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4E4u));
        if (c.V0 == 0u) {
            c.A2 = c.A0;
            goto L801C93A8;
        }
        c.A2 = c.A0;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x4DCu));
        if (c.A0 != 0u) { c.LO = c.A1 / c.A0; c.HI = c.A1 % c.A0; }
        if (c.A0 != 0u) {
            goto L801C9384;
        }
        Bios.Break(c, m);
        L801C9384: ;
        c.V0 = c.HI;
        if (c.V0 == 0u) {
            goto L801C93A8;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4D8u));
        c.A1 = c.A1 + c.A0;
        c.V0 = ~(0u | c.V0);
        c.A1 = c.A1 & c.V0;
        L801C93A8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4E0u));
        c.A3 = c.A1 >> (int)(c.V0 & 31u);
        c.V0 = 0xFFFFFFFEu;
        if (c.A2 == c.V0) {
            c.V0 = 0xFFFFFFFFu;
            goto L801C93D4;
        }
        c.V0 = 0xFFFFFFFFu;
        if (c.A2 != c.V0) {
            c.V0 = c.A1;
            goto L801C93DC;
        }
        c.V0 = c.A1;
        c.V0 = c.A3 & 0xFFFFu;
        goto L801C93F0;
        L801C93D4: ;
        c.V0 = c.A1;
        goto L801C93F0;
        L801C93DC: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x508u));
        c.V1 = c.A2 << 1;
        c.V1 = c.V1 + c.A0;
        mem.WriteU16(c.V1, (ushort)c.A3);
        L801C93F0: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_FgetRXXa_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.A0 = c.A0 << 1;
        c.A0 = c.A0 + c.V0;
        c.V0 = 0xFFFFFFFFu;
        c.A0 = mem.ReadU16(c.A0);
        if (c.A1 == c.V0) {
            goto L801C9428;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4E0u));
        c.V0 = c.A0 << (int)(c.V0 & 31u);
        goto L801C942C;
        L801C9428: ;
        c.V0 = c.A0;
        L801C942C: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_FsetPCR_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 - 0x4F8u));
        c.V1 = 0xFFF80000u;
        c.V0 = mem.ReadU32(c.A1);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        mem.WriteU32(c.A1, c.V0);
        if (c.A0 == 0u) {
            goto L801C9470;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4F8u));
        c.V1 = mem.ReadU32(c.V0);
        c.A0 = 0x00030000u;
        goto L801C9484;
        L801C9470: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x4F8u));
        c.V1 = mem.ReadU32(c.V0);
        c.A0 = 0x00050000u;
        L801C9484: ;
        c.V1 = c.V1 | c.A0;
        mem.WriteU32(c.V0, c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C9494(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x4F4u));
        c.V1 = 0xF0FF0000u;
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        c.V1 = 0x20000000u;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.A0, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C94C0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 - 0x4F4u));
        c.V1 = 0xF0FF0000u;
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = c.V1 | 0xFFFFu;
        c.V0 = c.V0 & c.V1;
        c.V1 = 0x22000000u;
        c.V0 = c.V0 | c.V1;
        mem.WriteU32(c.A0, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _spu_Fw1ts_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        c.V0 = 0x0000000Du;
        mem.WriteU32((c.SP + 0x4u), c.V0);
        mem.WriteU32(c.SP, 0u);
        goto L801C9534;
        L801C9504: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V1 = mem.ReadU32((c.SP + 0x4u));
        c.V0 = c.V1 << 1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.V1;
        mem.WriteU32((c.SP + 0x4u), c.V0);
        c.V0 = mem.ReadU32(c.SP);
        c.V0 = c.V0 + 0x1u;
        mem.WriteU32(c.SP, c.V0);
        c.V0 = mem.ReadU32(c.SP);
        L801C9534: ;
        c.V0 = mem.ReadU32(c.SP);
        c.V0 = (int)c.V0 < 60 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C9504;
        }
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C9554(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000B0u;
        c.T1 = 0x00000007u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void _SpuDataCallback_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A1 = c.A0;
        c.A0 = 0x00000004u;
        c.RA = 0x801C9578u;
        Courier_Crisis_main.DMACallback_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SpuSetCommonMasterVolume(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.A0 = c.A0 & 0x7FFFu;
        mem.WriteU16((c.V0 + 0x180u), (ushort)c.A0);
        c.A0 = c.A1 & 0x7FFFu;
        mem.WriteU16((c.V0 + 0x182u), (ushort)c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SpuSetCommonCDVolume(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        mem.WriteU16((c.V0 + 0x1B0u), (ushort)c.A0);
        mem.WriteU16((c.V0 + 0x1B2u), (ushort)c.A1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void SpuSetCommonCDMix(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        if (c.A0 != 0u) {
            goto L801C95E4;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V1 = mem.ReadU16((c.V0 + 0x1AAu));
        c.V1 = c.V1 & 0xFFFEu;
        goto L801C95FC;
        L801C95E4: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x508u));
        c.V1 = mem.ReadU16((c.V0 + 0x1AAu));
        c.V1 = c.V1 | 0x0001u;
        L801C95FC: ;
        mem.WriteU16((c.V0 + 0x1AAu), (ushort)c.V1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StSetRing(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StSetRing(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdInit_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdInit(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C96D0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A0 = 0xF0000000u;
        c.A0 = c.A0 | 0x0003u;
        c.A1 = 0x00000020u;
        c.RA = 0x801C96E8u;
        Courier_Crisis_main.func_801C9554(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C96F8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A0 = 0xF0000000u;
        c.A0 = c.A0 | 0x0003u;
        c.A1 = 0x00000040u;
        c.RA = 0x801C9710u;
        Courier_Crisis_main.func_801C9554(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C9720(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A0 = 0xF0000000u;
        c.A0 = c.A0 | 0x0003u;
        c.A1 = 0x00000040u;
        c.RA = 0x801C9738u;
        Courier_Crisis_main.func_801C9554(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdStatus_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdStatus(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdMode_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdMode(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdLastCom_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdLastCom(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdLastPos_main(CpuContext c, IMemory m)
    {
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 - 0xF4u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReset_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdReset(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdFlush_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdFlush(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdSetDebug_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x104u), c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdComstr_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A0 = c.A0 & 0x00FFu;
        c.V0 = c.A0 < 0x0000001Cu ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.A0 << 2;
            goto L801C9850;
        }
        c.V0 = c.A0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At - 0xE8u));
        goto L801C9858;
        L801C9850: ;
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x664u;
        L801C9858: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdIntstr_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A0 = c.A0 & 0x00FFu;
        c.V0 = c.A0 < 0x00000007u ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.A0 << 2;
            goto L801C9884;
        }
        c.V0 = c.A0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At - 0x68u));
        goto L801C988C;
        L801C9884: ;
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x664u;
        L801C988C: ;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdSync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReady_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdReady(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdSyncCallback_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdSyncCallback(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReadyCallback_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdReadyCallback(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdControl_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdControl(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdControlF_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdControlF(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdControlB_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdControlB(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdMix_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdMix(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdGetSector_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdGetSector(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdGetSector2_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdGetSector(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdDataCallback_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdDataCallback(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdDataSync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdDataSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdIntToPos_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x1B4E0000u;
        c.V1 = c.V1 | 0x81B5u;
        c.A0 = c.A0 + 0x96u;
        { var _r = (long)(int)c.A0 * (int)c.V1; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.V0 = c.A1;
        c.A1 = 0x88880000u;
        c.A1 = c.A1 | 0x8889u;
        c.V1 = c.HI;
        c.A3 = (uint)((int)c.V1 >> 3);
        c.V1 = (uint)((int)c.A0 >> 31);
        c.A3 = c.A3 - c.V1;
        { var _r = (long)(int)c.A3 * (int)c.A1; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.T1 = 0x66660000u;
        c.T1 = c.T1 | 0x6667u;
        c.A1 = c.A3 << 2;
        c.A1 = c.A1 + c.A3;
        c.V1 = c.A1 << 4;
        c.A2 = c.HI;
        c.V1 = c.V1 - c.A1;
        c.A0 = c.A0 - c.V1;
        { var _r = (long)(int)c.A0 * (int)c.T1; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.V1 = (uint)((int)c.A3 >> 31);
        c.T0 = c.A2 + c.A3;
        c.T0 = (uint)((int)c.T0 >> 5);
        c.T0 = c.T0 - c.V1;
        c.V1 = c.T0 << 4;
        c.V1 = c.V1 - c.T0;
        c.A1 = c.HI;
        c.V1 = c.V1 << 2;
        c.A3 = c.A3 - c.V1;
        { var _r = (long)(int)c.A3 * (int)c.T1; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        c.V1 = (uint)((int)c.A0 >> 31);
        c.A1 = (uint)((int)c.A1 >> 2);
        c.A1 = c.A1 - c.V1;
        c.A2 = c.A1 << 4;
        c.V1 = c.A1 << 2;
        c.V1 = c.V1 + c.A1;
        c.V1 = c.V1 << 1;
        c.A0 = c.A0 - c.V1;
        c.T3 = c.HI;
        c.A2 = c.A2 + c.A0;
        c.V1 = (uint)((int)c.A3 >> 31);
        { var _r = (long)(int)c.T0 * (int)c.T1; c.LO = (uint)_r; c.HI = (uint)(_r >> 32); }
        mem.WriteU8((c.V0 + 0x2u), (byte)c.A2);
        c.A0 = (uint)((int)c.T3 >> 2);
        c.A0 = c.A0 - c.V1;
        c.A1 = c.A0 << 4;
        c.V1 = c.A0 << 2;
        c.V1 = c.V1 + c.A0;
        c.V1 = c.V1 << 1;
        c.A3 = c.A3 - c.V1;
        c.A1 = c.A1 + c.A3;
        c.V1 = (uint)((int)c.T0 >> 31);
        mem.WriteU8((c.V0 + 0x1u), (byte)c.A1);
        c.T1 = c.HI;
        c.A0 = (uint)((int)c.T1 >> 2);
        c.A0 = c.A0 - c.V1;
        c.A1 = c.A0 << 4;
        c.V1 = c.A0 << 2;
        c.V1 = c.V1 + c.A0;
        c.V1 = c.V1 << 1;
        c.T0 = c.T0 - c.V1;
        c.A1 = c.A1 + c.T0;
        mem.WriteU8(c.V0, (byte)c.A1);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdPosToInt_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = mem.ReadU8(c.A0);
        c.A2 = mem.ReadU8((c.A0 + 0x1u));
        c.A1 = c.V1 >> 4;
        c.V0 = c.A1 << 2;
        c.V0 = c.V0 + c.A1;
        c.V0 = c.V0 << 1;
        c.V1 = c.V1 & 0x000Fu;
        c.V0 = c.V0 + c.V1;
        c.A1 = c.V0 << 4;
        c.A1 = c.A1 - c.V0;
        c.A1 = c.A1 << 2;
        c.V1 = c.A2 >> 4;
        c.V0 = c.V1 << 2;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 << 1;
        c.A2 = c.A2 & 0x000Fu;
        c.V0 = c.V0 + c.A2;
        c.A1 = c.A1 + c.V0;
        c.V1 = c.A1 << 2;
        c.V1 = c.V1 + c.A1;
        c.V0 = c.V1 << 4;
        c.A1 = mem.ReadU8((c.A0 + 0x2u));
        c.V0 = c.V0 - c.V1;
        c.A0 = c.A1 >> 4;
        c.V1 = c.A0 << 2;
        c.V1 = c.V1 + c.A0;
        c.V1 = c.V1 << 1;
        c.A1 = c.A1 & 0x000Fu;
        c.V1 = c.V1 + c.A1;
        c.V0 = c.V0 + c.V1;
        c.V0 = c.V0 - 0x96u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801C9ED4(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x30u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000001u;
        mem.WriteU32((c.SP + 0x28u), c.RA);
        mem.WriteU32((c.SP + 0x24u), c.S1);
        mem.WriteU32((c.SP + 0x20u), c.S0);
        mem.WriteU8(c.V1, (byte)c.V0);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1C4u));
        c.V0 = mem.ReadU8(c.A0);
        c.V0 = c.V0 & 0x0007u;
        mem.WriteU8((c.SP + 0x10u), (byte)c.V0);
        c.V0 = mem.ReadU8((c.SP + 0x10u));
        if (c.V0 == 0u) {
            c.S1 = 0u;
            goto L801CA440;
        }
        c.S1 = 0u;
        goto L801C9F38;
        L801C9F28: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A0);
        c.V0 = c.V0 & 0x0007u;
        mem.WriteU8((c.SP + 0x10u), (byte)c.V0);
        L801C9F38: ;
        c.V0 = mem.ReadU8(c.A0);
        c.V1 = mem.ReadU8((c.SP + 0x10u));
        c.V0 = c.V0 & 0x0007u;
        if (c.V1 != c.V0) {
            c.S0 = 0u;
            goto L801C9F28;
        }
        c.S0 = 0u;
        c.V1 = c.SP + 0x18u;
        L801C9F50: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        c.V0 = mem.ReadU8(c.V0);
        c.V0 = c.V0 & 0x0020u;
        if (c.V0 == 0u) {
            c.V0 = (int)c.S0 < 8 ? 1u : 0u;
            goto L801C9F98;
        }
        c.V0 = (int)c.S0 < 8 ? 1u : 0u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1BCu));
        c.V0 = mem.ReadU8(c.V0);
        c.S0 = c.S0 + 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = (int)c.S0 < 8 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.V1 + 0x1u;
            goto L801C9F50;
        }
        c.V1 = c.V1 + 0x1u;
        c.V0 = (int)c.S0 < 8 ? 1u : 0u;
        L801C9F98: ;
        if (c.V0 == 0u) {
            c.V0 = c.SP + 0x18u;
            goto L801C9FBC;
        }
        c.V0 = c.SP + 0x18u;
        c.V1 = c.S0 + c.V0;
        c.A0 = c.SP + 0x20u;
        L801C9FA8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU8(c.V1, (byte)0u);
        c.V1 = c.V1 + 0x1u;
        c.V0 = (int)c.V1 < (int)c.A0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801C9FA8;
        }
        L801C9FBC: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000001u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        c.V1 = 0x00000007u;
        mem.WriteU8(c.V0, (byte)c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C0u));
        mem.WriteU8(c.V0, (byte)c.V1);
        c.V0 = mem.ReadU8((c.SP + 0x10u));
        c.V1 = 0x00000003u;
        c.V0 = c.V0 & 0x00FFu;
        if (c.V0 != c.V1) {
            goto L801CA028;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xEFu));
        c.V0 = c.V0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At + 0xB8u));
        if (c.V0 == 0u) {
            goto L801CA08C;
        }
        L801CA028: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x100u));
        c.V0 = c.V0 & 0x0010u;
        if (c.V0 != 0u) {
            goto L801CA06C;
        }
        c.V0 = mem.ReadU8((c.SP + 0x18u));
        c.V0 = c.V0 & 0x0010u;
        if (c.V0 == 0u) {
            goto L801CA06C;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0xF8u));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xF8u), c.V0);
        L801CA06C: ;
        c.V0 = mem.ReadU8((c.SP + 0x18u));
        c.V1 = mem.ReadU8((c.SP + 0x19u));
        c.V0 = c.V0 & 0x00FFu;
        c.S1 = c.V0 & 0x001Du;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x100u), c.V0);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xFCu), c.V1);
        L801CA08C: ;
        c.V0 = mem.ReadU8((c.SP + 0x10u));
        c.V1 = 0x00000005u;
        c.V0 = c.V0 & 0x00FFu;
        if (c.V0 != c.V1) {
            goto L801CA110;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            goto L801CA110;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x7D4u;
        c.RA = 0x801CA0C4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            goto L801CA110;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xEFu));
        c.A2 = 0x801D0000u;
        c.A2 = mem.ReadU32((c.A2 - 0x100u));
        c.A3 = 0x801D0000u;
        c.A3 = mem.ReadU32((c.A3 - 0xFCu));
        c.V0 = c.V0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.A1 = mem.ReadU32((c.At - 0xE8u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x7E0u;
        c.RA = 0x801CA110u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CA110: ;
        c.V0 = mem.ReadU8((c.SP + 0x10u));
        c.V1 = c.V0 - 0x1u;
        c.V0 = c.V1 < 0x00000005u ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.V1 << 2;
            goto L801CA41C;
        }
        c.V0 = c.V1 << 2;
        c.At = 0x801C0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At + 0x81Cu));
        switch (c.V0)
        {
            case 0x801CA28Cu: goto L801CA28C;
            case 0x801CA240u: goto L801CA240;
            case 0x801CA140u: goto L801CA140;
            case 0x801CA310u: goto L801CA310;
            case 0x801CA394u: goto L801CA394;
            default: Dispatcher.Call(c, m, c.V0); return;
        }
        L801CA140: ;
        if (c.S1 == 0u) {
            c.V0 = 0x00000005u;
            goto L801CA18C;
        }
        c.V0 = 0x00000005u;
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x1D0u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16E8u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA284;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA16C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA16C;
        }
        c.V1 = c.V1 + 0x1u;
        c.V0 = 0x00000002u;
        goto L801CA444;
        L801CA18C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xEFu));
        c.V0 = c.V0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.V0 = mem.ReadU32((c.At - 0x48u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000003u;
            goto L801CA1F8;
        }
        c.V0 = 0x00000003u;
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x1D0u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16E8u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA1F0;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA1D8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA1D8;
        }
        c.V1 = c.V1 + 0x1u;
        L801CA1F0: ;
        c.V0 = 0x00000001u;
        goto L801CA444;
        L801CA1F8: ;
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x1D0u;
        c.V0 = 0x00000002u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16E8u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA284;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA220: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA220;
        }
        c.V1 = c.V1 + 0x1u;
        c.V0 = 0x00000002u;
        goto L801CA444;
        L801CA240: ;
        if (c.S1 == 0u) {
            c.V0 = 0x00000002u;
            goto L801CA24C;
        }
        c.V0 = 0x00000002u;
        c.V0 = 0x00000005u;
        L801CA24C: ;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D0u), (byte)c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16E8u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA284;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA26C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA26C;
        }
        c.V1 = c.V1 + 0x1u;
        L801CA284: ;
        c.V0 = 0x00000002u;
        goto L801CA444;
        L801CA28C: ;
        if (c.S1 == 0u) {
            c.V0 = 0x00000001u;
            goto L801CA2B0;
        }
        c.V0 = 0x00000001u;
        c.V0 = 0x00000001u;
        if (c.S0 != c.V0) {
            goto L801CA2A4;
        }
        c.S1 = 0u;
        L801CA2A4: ;
        if (c.S1 == 0u) {
            c.V0 = 0x00000001u;
            goto L801CA2B0;
        }
        c.V0 = 0x00000001u;
        c.V0 = 0x00000005u;
        L801CA2B0: ;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D1u), (byte)c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16F0u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA2E8;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA2D0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA2D0;
        }
        c.V1 = c.V1 + 0x1u;
        L801CA2E8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        mem.WriteU8(c.V0, (byte)0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C4u));
        c.V0 = 0x00000004u;
        mem.WriteU8(c.V1, (byte)0u);
        goto L801CA444;
        L801CA310: ;
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x16F8u;
        c.V0 = 0x00000004u;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D2u), (byte)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 + 0x1D2u));
        c.A1 = c.SP + 0x18u;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D1u), (byte)c.V0);
        if (c.A0 == 0u) {
            c.V1 = 0x00000007u;
            goto L801CA35C;
        }
        c.V1 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA344: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU8(c.A0, (byte)c.V0);
        if (c.V1 != c.A2) {
            c.A0 = c.A0 + 0x1u;
            goto L801CA344;
        }
        c.A0 = c.A0 + 0x1u;
        L801CA35C: ;
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16F0u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA38C;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA374: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA374;
        }
        c.V1 = c.V1 + 0x1u;
        L801CA38C: ;
        c.V0 = 0x00000004u;
        goto L801CA444;
        L801CA394: ;
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x16E8u;
        c.A1 = c.SP + 0x18u;
        c.V0 = 0x00000005u;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D1u), (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU8((c.V1 + 0x1D1u));
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 + 0x1D0u;
        mem.WriteU8(c.V0, (byte)c.V1);
        if (c.A0 == 0u) {
            c.V1 = 0x00000007u;
            goto L801CA3E4;
        }
        c.V1 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA3CC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU8(c.A0, (byte)c.V0);
        if (c.V1 != c.A2) {
            c.A0 = c.A0 + 0x1u;
            goto L801CA3CC;
        }
        c.A0 = c.A0 + 0x1u;
        L801CA3E4: ;
        c.V1 = 0x801E0000u;
        c.V1 = c.V1 + 0x16F0u;
        if (c.V1 == 0u) {
            c.A1 = c.SP + 0x18u;
            goto L801CA414;
        }
        c.A1 = c.SP + 0x18u;
        c.A0 = 0x00000007u;
        c.A2 = 0xFFFFFFFFu;
        L801CA3FC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        c.A0 = c.A0 - 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        if (c.A0 != c.A2) {
            c.V1 = c.V1 + 0x1u;
            goto L801CA3FC;
        }
        c.V1 = c.V1 + 0x1u;
        L801CA414: ;
        c.V0 = 0x00000006u;
        goto L801CA444;
        L801CA41C: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x7FCu;
        c.RA = 0x801CA42Cu;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.A1 = mem.ReadU8((c.SP + 0x10u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x810u;
        c.RA = 0x801CA440u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CA440: ;
        c.V0 = 0u;
        L801CA444: ;
        c.RA = mem.ReadU32((c.SP + 0x28u));
        c.S1 = mem.ReadU32((c.SP + 0x24u));
        c.S0 = mem.ReadU32((c.SP + 0x20u));
        c.SP = c.SP + 0x30u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_sync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_ready_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdReady(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_cw_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.SP = c.SP - 0x48u;
        mem.WriteU32((c.SP + 0x2Cu), c.S1);
        c.S1 = c.A1;
        mem.WriteU32((c.SP + 0x3Cu), c.S5);
        c.S5 = c.A2;
        mem.WriteU32((c.SP + 0x30u), c.S2);
        c.S2 = c.A3;
        mem.WriteU32((c.SP + 0x28u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x40u), c.RA);
        mem.WriteU32((c.SP + 0x38u), c.S4);
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x34u), c.S3);
            goto L801CAA0C;
        }
        mem.WriteU32((c.SP + 0x34u), c.S3);
        c.V0 = c.S0 & 0x00FFu;
        c.V0 = c.V0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.A1 = mem.ReadU32((c.At - 0xE8u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x844u;
        c.RA = 0x801CAA0Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CAA0C: ;
        c.V0 = c.S0 & 0x00FFu;
        c.V1 = c.V0 << 2;
        c.At = 0x801D0000u;
        c.At = c.At + c.V1;
        c.V0 = mem.ReadU32((c.At + 0x138u));
        if (c.V0 == 0u) {
            c.A0 = 0u;
            goto L801CAA6C;
        }
        c.A0 = 0u;
        if (c.S1 != 0u) {
            goto L801CAA6C;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            c.V0 = 0xFFFFFFFEu;
            goto L801CAD9C;
        }
        c.V0 = 0xFFFFFFFEu;
        c.At = 0x801D0000u;
        c.At = c.At + c.V1;
        c.A1 = mem.ReadU32((c.At - 0xE8u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x84Cu;
        c.RA = 0x801CAA64u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0xFFFFFFFEu;
        goto L801CAD9C;
        L801CAA6C: ;
        c.A1 = 0u;
        c.RA = 0x801CAA74u;
        Courier_Crisis_main.CD_sync_main(c, m);
        c.V1 = c.S0 & 0x00FFu;
        c.V0 = 0x00000002u;
        if (c.V1 != c.V0) {
            c.V0 = 0x0000000Eu;
            goto L801CAAB4;
        }
        c.V0 = 0x0000000Eu;
        c.A0 = 0u;
        c.V1 = c.S1;
        L801CAA8C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.V1);
        c.At = 0x801D0000u;
        c.At = c.At + c.A0;
        mem.WriteU8((c.At - 0xF4u), (byte)c.V0);
        c.A0 = c.A0 + 0x1u;
        c.V0 = (int)c.A0 < 4 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V1 = c.V1 + 0x1u;
            goto L801CAA8C;
        }
        c.V1 = c.V1 + 0x1u;
        c.V1 = c.S0 & 0x00FFu;
        c.V0 = 0x0000000Eu;
        L801CAAB4: ;
        if (c.V1 != c.V0) {
            goto L801CAAC8;
        }
        c.V0 = mem.ReadU8(c.S1);
        c.At = 0x801D0000u;
        mem.WriteU8((c.At - 0xF0u), (byte)c.V0);
        L801CAAC8: ;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 + 0x1D0u;
        c.A0 = c.V1 << 2;
        mem.WriteU8(c.V0, (byte)0u);
        c.At = 0x801D0000u;
        c.At = c.At + c.A0;
        c.V0 = mem.ReadU32((c.At + 0x38u));
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x38u;
        if (c.V0 == 0u) {
            goto L801CAAFC;
        }
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D1u), (byte)0u);
        L801CAAFC: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        mem.WriteU8(c.V0, (byte)0u);
        c.V0 = c.V1 + 0x100u;
        c.V1 = c.A0 + c.V0;
        c.V0 = mem.ReadU32(c.V1);
        if ((int)c.V0 <= 0) {
            c.A0 = 0u;
            goto L801CAB54;
        }
        c.A0 = 0u;
        c.A2 = c.V1;
        c.A1 = c.S1;
        L801CAB2C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C0u));
        c.V0 = mem.ReadU8(c.A1);
        c.A1 = c.A1 + 0x1u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = mem.ReadU32(c.A2);
        c.A0 = c.A0 + 0x1u;
        c.V0 = (int)c.A0 < (int)c.V0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CAB2C;
        }
        L801CAB54: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1BCu));
        c.At = 0x801D0000u;
        mem.WriteU8((c.At - 0xEFu), (byte)c.S0);
        mem.WriteU8(c.V0, (byte)c.S0);
        if (c.S2 != 0u) {
            c.V0 = 0u;
            goto L801CAD9C;
        }
        c.V0 = 0u;
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CAB78u;
        Courier_Crisis_main.VSync_main(c, m);
        c.V0 = c.V0 + 0x3C0u;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 + 0x1D0u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1700u), c.V0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1704u), 0u);
        c.V1 = mem.ReadU8(c.A0);
        c.V0 = 0x801C0000u;
        c.V0 = c.V0 + 0x85Cu;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1708u), c.V0);
        if (c.V1 != 0u) {
            c.A2 = c.S5;
            goto L801CAD50;
        }
        c.A2 = c.S5;
        c.S3 = 0x801D0000u;
        c.S3 = c.S3 - 0x68u;
        c.S2 = c.A0;
        c.S4 = c.S2 + 0x1u;
        L801CABC0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CABC8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1700u));
        c.V1 = (int)c.V1 < (int)c.V0 ? 1u : 0u;
        if (c.V1 != 0u) {
            goto L801CAC08;
        }
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1704u));
        c.V0 = c.V1 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x1704u), c.V0);
        c.V0 = 0x003C0000u;
        c.V0 = (int)c.V0 < (int)c.V1 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801CAC7C;
        }
        L801CAC08: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x7A8u;
        c.RA = 0x801CAC18u;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.A0 = mem.ReadU8(c.S2);
        c.V0 = mem.ReadU8((c.S2 + 0x1u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x1708u));
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 + c.S3;
        c.A0 = c.A0 << 2;
        c.V1 = mem.ReadU32(c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 - 0xEFu));
        c.A0 = c.A0 + c.S3;
        c.V0 = c.V0 << 2;
        mem.WriteU32((c.SP + 0x10u), c.V1);
        c.At = 0x801D0000u;
        c.At = c.At + c.V0;
        c.A2 = mem.ReadU32((c.At - 0xE8u));
        c.A3 = mem.ReadU32(c.A0);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x7B8u;
        c.RA = 0x801CAC6Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.RA = 0x801CAC74u;
        Courier_Crisis_main.CD_flush_main(c, m);
        c.V0 = 0xFFFFFFFFu;
        goto L801CAC80;
        L801CAC7C: ;
        c.V0 = 0u;
        L801CAC80: ;
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CAD9C;
        }
        c.V0 = 0xFFFFFFFFu;
        c.RA = 0x801CAC90u;
        Courier_Crisis_main.CheckCallback_main(c, m);
        if (c.V0 == 0u) {
            goto L801CAD40;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        c.V0 = mem.ReadU8(c.V0);
        c.S1 = c.V0 & 0x0003u;
        L801CACB0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801CACB8u;
        Courier_Crisis_main.func_801C9ED4(c, m);
        c.S0 = c.V0;
        if (c.S0 == 0u) {
            c.V0 = c.S0 & 0x0004u;
            goto L801CAD30;
        }
        c.V0 = c.S0 & 0x0004u;
        if (c.V0 == 0u) {
            c.V0 = c.S0 & 0x0002u;
            goto L801CACF8;
        }
        c.V0 = c.S0 & 0x0002u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x10Cu));
        if (c.V0 == 0u) {
            goto L801CACF4;
        }
        c.A0 = mem.ReadU8(c.S4);
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x16F0u;
        c.RA = 0x801CACF4u;
        Dispatcher.Call(c, m, c.V0);
        L801CACF4: ;
        c.V0 = c.S0 & 0x0002u;
        L801CACF8: ;
        if (c.V0 == 0u) {
            goto L801CACB0;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x110u));
        if (c.V0 == 0u) {
            goto L801CACB0;
        }
        c.A0 = mem.ReadU8(c.S2);
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x16E8u;
        c.RA = 0x801CAD28u;
        Dispatcher.Call(c, m, c.V0);
        goto L801CACB0;
        L801CAD30: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        mem.WriteU8(c.V0, (byte)c.S1);
        L801CAD40: ;
        c.V0 = mem.ReadU8(c.S2);
        if (c.V0 == 0u) {
            c.A2 = c.S5;
            goto L801CABC0;
        }
        c.A2 = c.S5;
        L801CAD50: ;
        c.A0 = 0x801E0000u;
        c.A0 = c.A0 + 0x16E8u;
        if (c.A2 == 0u) {
            goto L801CAD80;
        }
        c.V1 = 0x00000007u;
        c.A1 = 0xFFFFFFFFu;
        L801CAD68: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A0);
        c.A0 = c.A0 + 0x1u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU8(c.A2, (byte)c.V0);
        if (c.V1 != c.A1) {
            c.A2 = c.A2 + 0x1u;
            goto L801CAD68;
        }
        c.A2 = c.A2 + 0x1u;
        L801CAD80: ;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 + 0x1D0u;
        c.V0 = mem.ReadU8(c.V0);
        c.V0 = c.V0 ^ 0x0005u;
        c.V0 = c.V0 < 0x00000001u ? 1u : 0u;
        c.V0 = 0u - c.V0;
        L801CAD9C: ;
        c.RA = mem.ReadU32((c.SP + 0x40u));
        c.S5 = mem.ReadU32((c.SP + 0x3Cu));
        c.S4 = mem.ReadU32((c.SP + 0x38u));
        c.S3 = mem.ReadU32((c.SP + 0x34u));
        c.S2 = mem.ReadU32((c.SP + 0x30u));
        c.S1 = mem.ReadU32((c.SP + 0x2Cu));
        c.S0 = mem.ReadU32((c.SP + 0x28u));
        c.SP = c.SP + 0x48u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_vol_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000002u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C0u));
        c.V0 = mem.ReadU8(c.A0);
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C4u));
        c.V0 = mem.ReadU8((c.A0 + 0x1u));
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000003u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1BCu));
        c.V0 = mem.ReadU8((c.A0 + 0x2u));
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C0u));
        c.V0 = mem.ReadU8((c.A0 + 0x3u));
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C4u));
        c.V0 = 0x00000020u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = 0u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_flush_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000001u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        c.V0 = mem.ReadU8(c.V0);
        c.V0 = c.V0 & 0x0007u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000001u;
            goto L801CAED0;
        }
        c.A0 = 0x00000001u;
        c.V1 = 0x00000007u;
        L801CAE80: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        mem.WriteU8(c.V0, (byte)c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        mem.WriteU8(c.V0, (byte)c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C0u));
        mem.WriteU8(c.V0, (byte)c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        c.V0 = mem.ReadU8(c.V0);
        c.V0 = c.V0 & 0x0007u;
        if (c.V0 != 0u) {
            goto L801CAE80;
        }
        L801CAED0: ;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D2u), (byte)0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 + 0x1D2u));
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x1B8u));
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x1D0u;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D1u), (byte)c.V0);
        c.V0 = 0x00000002u;
        mem.WriteU8(c.V1, (byte)c.V0);
        mem.WriteU8(c.A0, (byte)0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        mem.WriteU8(c.V0, (byte)0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C8u));
        c.V0 = 0x00001325u;
        mem.WriteU32(c.V1, c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_initvol_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1CCu));
        c.V0 = mem.ReadU16((c.V1 + 0x1B8u));
        if (c.V0 != 0u) {
            c.SP = c.SP - 0x8u;
            goto L801CAF68;
        }
        c.SP = c.SP - 0x8u;
        c.V0 = mem.ReadU16((c.V1 + 0x1BAu));
        if (c.V0 != 0u) {
            c.V0 = 0x00003FFFu;
            goto L801CAF6C;
        }
        c.V0 = 0x00003FFFu;
        mem.WriteU16((c.V1 + 0x180u), (ushort)c.V0);
        mem.WriteU16((c.V1 + 0x182u), (ushort)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1CCu));
        L801CAF68: ;
        c.V0 = 0x00003FFFu;
        L801CAF6C: ;
        mem.WriteU16((c.V1 + 0x1B0u), (ushort)c.V0);
        mem.WriteU16((c.V1 + 0x1B2u), (ushort)c.V0);
        c.V0 = 0u | 0xC001u;
        mem.WriteU16((c.V1 + 0x1AAu), (ushort)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000080u;
        mem.WriteU8((c.SP + 0x2u), (byte)c.V0);
        mem.WriteU8(c.SP, (byte)c.V0);
        c.V0 = 0x00000002u;
        mem.WriteU8((c.SP + 0x3u), (byte)0u);
        mem.WriteU8((c.SP + 0x1u), (byte)0u);
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C0u));
        c.V0 = mem.ReadU8(c.SP);
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C4u));
        c.V0 = mem.ReadU8((c.SP + 0x1u));
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000003u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1BCu));
        c.V0 = mem.ReadU8((c.SP + 0x2u));
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C0u));
        c.V0 = mem.ReadU8((c.SP + 0x3u));
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C4u));
        c.V0 = 0x00000020u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = 0u;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_initintr_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x10Cu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x110u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xFCu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x100u), 0u);
        c.RA = 0x801CB050u;
        Courier_Crisis_main.ResetCallback_main(c, m);
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 - 0x4A38u;
        c.A0 = 0x00000002u;
        c.RA = 0x801CB060u;
        Courier_Crisis_main.InterruptCallback_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_init_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x898u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801CB088u;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x8A4u;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 + 0x1D4u;
        c.RA = 0x801CB0A0u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.At = 0x801D0000u;
        mem.WriteU8((c.At - 0xEFu), (byte)0u);
        c.At = 0x801D0000u;
        mem.WriteU8((c.At - 0xF0u), (byte)0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x10Cu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x110u), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0xFCu), 0u);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At - 0x100u), 0u);
        c.RA = 0x801CB0D8u;
        Courier_Crisis_main.ResetCallback_main(c, m);
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 - 0x4A38u;
        c.A0 = 0x00000002u;
        c.RA = 0x801CB0E8u;
        Courier_Crisis_main.InterruptCallback_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1B8u));
        c.V0 = 0x00000001u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        c.V0 = mem.ReadU8(c.V0);
        c.V0 = c.V0 & 0x0007u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000001u;
            goto L801CB16C;
        }
        c.A0 = 0x00000001u;
        c.V1 = 0x00000007u;
        L801CB11C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        mem.WriteU8(c.V0, (byte)c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        mem.WriteU8(c.V0, (byte)c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C0u));
        mem.WriteU8(c.V0, (byte)c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        c.V0 = mem.ReadU8(c.V0);
        c.V0 = c.V0 & 0x0007u;
        if (c.V0 != 0u) {
            goto L801CB11C;
        }
        L801CB16C: ;
        c.A0 = 0x00000001u;
        c.A1 = 0u;
        c.A2 = 0u;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D2u), (byte)0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU8((c.V0 + 0x1D2u));
        c.A3 = 0x801D0000u;
        c.A3 = mem.ReadU32((c.A3 + 0x1B8u));
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x1D0u;
        c.At = 0x801D0000u;
        mem.WriteU8((c.At + 0x1D1u), (byte)c.V0);
        c.V0 = 0x00000002u;
        mem.WriteU8(c.V1, (byte)c.V0);
        mem.WriteU8(c.A3, (byte)0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1C4u));
        c.A3 = 0u;
        mem.WriteU8(c.V0, (byte)0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x1C8u));
        c.V0 = 0x00001325u;
        mem.WriteU32(c.V1, c.V0);
        c.RA = 0x801CB1D4u;
        Courier_Crisis_main.CD_cw_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x100u));
        c.V0 = c.V0 & 0x0010u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000001u;
            goto L801CB1FC;
        }
        c.A0 = 0x00000001u;
        c.A1 = 0u;
        c.A2 = 0u;
        c.A3 = 0u;
        c.RA = 0x801CB1FCu;
        Courier_Crisis_main.CD_cw_main(c, m);
        L801CB1FC: ;
        c.A0 = 0x0000000Au;
        c.A1 = 0u;
        c.A2 = 0u;
        c.A3 = 0u;
        c.RA = 0x801CB210u;
        Courier_Crisis_main.CD_cw_main(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CB24C;
        }
        c.V0 = 0xFFFFFFFFu;
        c.A0 = 0x0000000Cu;
        c.A1 = 0u;
        c.A2 = 0u;
        c.A3 = 0u;
        c.RA = 0x801CB22Cu;
        Courier_Crisis_main.CD_cw_main(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CB24C;
        }
        c.V0 = 0xFFFFFFFFu;
        c.A0 = 0u;
        c.A1 = 0u;
        c.RA = 0x801CB240u;
        Courier_Crisis_main.CD_sync_main(c, m);
        c.V0 = c.V0 ^ 0x0002u;
        c.V0 = 0u < c.V0 ? 1u : 0u;
        c.V0 = 0u - c.V0;
        L801CB24C: ;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_datasync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdDataSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_getsector_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdGetSector(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_getsector2_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdGetSector(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CD_set_test_parmnum_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x19Cu), c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CB5C8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = 0x801D0000u;
        c.S1 = c.S1 + 0x1D1u;
        mem.WriteU32((c.SP + 0x20u), c.RA);
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        mem.WriteU32((c.SP + 0x18u), c.S2);
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.V0 = mem.ReadU8(c.V0);
        c.S3 = c.S1 - 0x1u;
        c.S2 = c.V0 & 0x0003u;
        L801CB5FC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.RA = 0x801CB604u;
        Courier_Crisis_main.func_801C9ED4(c, m);
        c.S0 = c.V0;
        if (c.S0 == 0u) {
            c.V0 = c.S0 & 0x0004u;
            goto L801CB67C;
        }
        c.V0 = c.S0 & 0x0004u;
        if (c.V0 == 0u) {
            c.V0 = c.S0 & 0x0002u;
            goto L801CB644;
        }
        c.V0 = c.S0 & 0x0002u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x10Cu));
        if (c.V0 == 0u) {
            goto L801CB640;
        }
        c.A0 = mem.ReadU8(c.S1);
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x16F0u;
        c.RA = 0x801CB640u;
        Dispatcher.Call(c, m, c.V0);
        L801CB640: ;
        c.V0 = c.S0 & 0x0002u;
        L801CB644: ;
        if (c.V0 == 0u) {
            goto L801CB5FC;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x110u));
        if (c.V0 == 0u) {
            goto L801CB5FC;
        }
        c.A0 = mem.ReadU8(c.S3);
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x16E8u;
        c.RA = 0x801CB674u;
        Dispatcher.Call(c, m, c.V0);
        goto L801CB5FC;
        L801CB67C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x1B8u));
        mem.WriteU8(c.V0, (byte)c.S2);
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdSearchFile(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdSearchFile(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CB978(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A2 = 0x0000000Cu;
        c.RA = 0x801CB988u;
        Courier_Crisis_main.func_801CC048(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.V0 = c.V0 < 0x00000001u ? 1u : 0u;
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CB998(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x40u;
        c.A0 = 0x00000001u;
        c.A1 = 0x00000010u;
        mem.WriteU32((c.SP + 0x20u), c.S0);
        c.S0 = 0x801E0000u;
        c.S0 = c.S0 + 0x330Cu;
        c.A2 = c.S0;
        mem.WriteU32((c.SP + 0x38u), c.RA);
        mem.WriteU32((c.SP + 0x34u), c.S5);
        mem.WriteU32((c.SP + 0x30u), c.S4);
        mem.WriteU32((c.SP + 0x2Cu), c.S3);
        mem.WriteU32((c.SP + 0x28u), c.S2);
        mem.WriteU32((c.SP + 0x24u), c.S1);
        c.RA = 0x801CB9D0u;
        Courier_Crisis_main.func_801CBFCC(c, m);
        c.S1 = c.V0;
        c.V0 = 0x00000001u;
        if (c.S1 == c.V0) {
            c.A0 = c.S0 + 0x1u;
            goto L801CBA0C;
        }
        c.A0 = c.S0 + 0x1u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            c.V0 = 0u;
            goto L801CBC50;
        }
        c.V0 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x948u;
        c.RA = 0x801CBA04u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801CBC50;
        L801CBA0C: ;
        c.A1 = 0x801C0000u;
        c.A1 = c.A1 + 0x974u;
        c.A2 = 0x00000005u;
        c.RA = 0x801CBA1Cu;
        Courier_Crisis_main.func_801CC048(c, m);
        if (c.V0 == 0u) {
            goto L801CBA50;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            c.V0 = 0u;
            goto L801CBC50;
        }
        c.V0 = 0u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x97Cu;
        c.RA = 0x801CBA48u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801CBC50;
        L801CBA50: ;
        c.A1 = 0x801E0000u;
        c.A1 = c.A1 + 0x3398u;
        c.V0 = mem.ReadWordLeft(c.V0, (c.A1 + 0x3u));
        c.V0 = mem.ReadWordRight(c.V0, c.A1);
        mem.WriteWordLeft((c.SP + 0x1Bu), c.V0);
        mem.WriteWordRight((c.SP + 0x18u), c.V0);
        c.A0 = 0x00000001u;
        c.A1 = mem.ReadU32((c.SP + 0x18u));
        c.A2 = c.S0;
        c.RA = 0x801CBA7Cu;
        Courier_Crisis_main.func_801CBFCC(c, m);
        if (c.V0 == c.S1) {
            goto L801CBAB4;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            c.V0 = 0u;
            goto L801CBC50;
        }
        c.V0 = 0u;
        c.A1 = mem.ReadU32((c.SP + 0x18u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x9ACu;
        c.RA = 0x801CBAACu;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0u;
        goto L801CBC50;
        L801CBAB4: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S1 = c.S0;
            goto L801CBADC;
        }
        c.S1 = c.S0;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x9D0u;
        c.RA = 0x801CBADCu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CBADC: ;
        c.V0 = c.S1 + 0x800u;
        c.V0 = c.S1 < c.V0 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.A3 = 0u;
            goto L801CBBF8;
        }
        c.A3 = 0u;
        c.S4 = 0x801E0000u;
        c.S4 = c.S4 + 0x1D14u;
        c.S5 = c.S4 + 0x4u;
        L801CBAF8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.S1);
        if (c.V0 == 0u) {
            c.V0 = c.A3 << 1;
            goto L801CBBF8;
        }
        c.V0 = c.A3 << 1;
        c.V0 = c.V0 + c.A3;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 - c.A3;
        c.S0 = c.V0 << 2;
        c.V0 = c.S0 + c.S4;
        c.V1 = mem.ReadWordLeft(c.V1, (c.S1 + 0x5u));
        c.V1 = mem.ReadWordRight(c.V1, (c.S1 + 0x2u));
        mem.WriteWordLeft((c.V0 + 0x3u), c.V1);
        mem.WriteWordRight(c.V0, c.V1);
        c.S2 = c.S0 + c.S5;
        c.A0 = c.S2;
        c.V0 = mem.ReadU8((c.S1 + 0x6u));
        c.S3 = c.A3 + 0x1u;
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        mem.WriteU32((c.At + 0x1D0Cu), c.S3);
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        mem.WriteU32((c.At + 0x1D10u), c.V0);
        c.A2 = mem.ReadU8(c.S1);
        c.A1 = c.S1 + 0x8u;
        c.RA = 0x801CBB64u;
        Courier_Crisis_main.func_801C87DC(c, m);
        c.V0 = mem.ReadU8(c.S1);
        c.V0 = c.S2 + c.V0;
        mem.WriteU8(c.V0, (byte)0u);
        c.V1 = mem.ReadU8(c.S1);
        c.V0 = c.V1 & 0x0001u;
        c.V0 = c.V0 + 0x8u;
        c.V1 = c.V1 + c.V0;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S1 = c.S1 + c.V1;
            goto L801CBBD4;
        }
        c.S1 = c.S1 + c.V1;
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A1 = mem.ReadU32((c.At + 0x1D14u));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A2 = mem.ReadU32((c.At + 0x1D0Cu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S0;
        c.A3 = mem.ReadU32((c.At + 0x1D10u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0x9F0u;
        mem.WriteU32((c.SP + 0x10u), c.S2);
        c.RA = 0x801CBBD4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CBBD4: ;
        c.A3 = c.S3;
        c.V0 = (int)c.A3 < 128 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801CBC20;
        }
        c.V0 = 0x801E0000u;
        c.V0 = c.V0 + 0x3B0Cu;
        c.V0 = c.S1 < c.V0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CBAF8;
        }
        L801CBBF8: ;
        c.V0 = (int)c.A3 < 128 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.A3 << 1;
            goto L801CBC20;
        }
        c.V0 = c.A3 << 1;
        c.V0 = c.V0 + c.A3;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 - c.A3;
        c.V0 = c.V0 << 2;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        mem.WriteU32((c.At + 0x1D10u), 0u);
        L801CBC20: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x200u), 0u);
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x00000001u;
            goto L801CBC50;
        }
        c.V0 = 0x00000001u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xA04u;
        c.A1 = c.A3;
        c.RA = 0x801CBC4Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0x00000001u;
        L801CBC50: ;
        c.RA = mem.ReadU32((c.SP + 0x38u));
        c.S5 = mem.ReadU32((c.SP + 0x34u));
        c.S4 = mem.ReadU32((c.SP + 0x30u));
        c.S3 = mem.ReadU32((c.SP + 0x2Cu));
        c.S2 = mem.ReadU32((c.SP + 0x28u));
        c.S1 = mem.ReadU32((c.SP + 0x24u));
        c.S0 = mem.ReadU32((c.SP + 0x20u));
        c.SP = c.SP + 0x40u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CBC78(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x1Cu), c.S3);
        c.S3 = c.A0;
        mem.WriteU32((c.SP + 0x20u), c.S4);
        c.S4 = c.A1;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0u;
        mem.WriteU32((c.SP + 0x18u), c.S2);
        c.S2 = 0x801E0000u;
        c.S2 = c.S2 + 0x1D18u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = 0u;
        mem.WriteU32((c.SP + 0x24u), c.RA);
        L801CBCAC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.At = 0x801E0000u;
        c.At = c.At + c.S1;
        c.V0 = mem.ReadU32((c.At + 0x1D10u));
        if (c.V0 == 0u) {
            goto L801CBCF8;
        }
        if (c.V0 != c.S3) {
            c.A0 = c.S4;
            goto L801CBCE4;
        }
        c.A0 = c.S4;
        c.A1 = c.S2;
        c.RA = 0x801CBCD4u;
        Courier_Crisis_main.func_801CC038(c, m);
        if (c.V0 != 0u) {
            c.S2 = c.S2 + 0x2Cu;
            goto L801CBCE8;
        }
        c.S2 = c.S2 + 0x2Cu;
        c.V0 = c.S0 + 0x1u;
        goto L801CBCFC;
        L801CBCE4: ;
        c.S2 = c.S2 + 0x2Cu;
        L801CBCE8: ;
        c.S0 = c.S0 + 0x1u;
        c.V0 = (int)c.S0 < 128 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.S1 = c.S1 + 0x2Cu;
            goto L801CBCAC;
        }
        c.S1 = c.S1 + 0x2Cu;
        L801CBCF8: ;
        c.V0 = 0xFFFFFFFFu;
        L801CBCFC: ;
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S4 = mem.ReadU32((c.SP + 0x20u));
        c.S3 = mem.ReadU32((c.SP + 0x1Cu));
        c.S2 = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CBD20(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x200u));
        c.SP = c.SP - 0x40u;
        mem.WriteU32((c.SP + 0x38u), c.S6);
        c.S6 = c.A0;
        mem.WriteU32((c.SP + 0x3Cu), c.RA);
        mem.WriteU32((c.SP + 0x34u), c.S5);
        mem.WriteU32((c.SP + 0x30u), c.S4);
        mem.WriteU32((c.SP + 0x2Cu), c.S3);
        mem.WriteU32((c.SP + 0x28u), c.S2);
        mem.WriteU32((c.SP + 0x24u), c.S1);
        if (c.S6 == c.V0) {
            mem.WriteU32((c.SP + 0x20u), c.S0);
            goto L801CBF9C;
        }
        mem.WriteU32((c.SP + 0x20u), c.S0);
        c.A0 = 0x00000001u;
        c.V0 = c.S6 << 1;
        c.V0 = c.V0 + c.S6;
        c.V0 = c.V0 << 2;
        c.V0 = c.V0 - c.S6;
        c.V0 = c.V0 << 2;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        c.A1 = mem.ReadU32((c.At + 0x1CE8u));
        c.S0 = 0x801E0000u;
        c.S0 = c.S0 + 0x330Cu;
        c.A2 = c.S0;
        c.RA = 0x801CBD88u;
        Courier_Crisis_main.func_801CBFCC(c, m);
        c.V1 = 0x00000001u;
        if (c.V0 == c.V1) {
            goto L801CBDC0;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        if ((int)c.V0 <= 0) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CBFA0;
        }
        c.V0 = 0xFFFFFFFFu;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xA28u;
        c.RA = 0x801CBDB8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = 0xFFFFFFFFu;
        goto L801CBFA0;
        L801CBDC0: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = c.S0 + 0x800u;
            goto L801CBDEC;
        }
        c.V0 = c.S0 + 0x800u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xA48u;
        c.RA = 0x801CBDE8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = c.S0 + 0x800u;
        L801CBDEC: ;
        c.V0 = c.S0 < c.V0 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.S2 = 0u;
            goto L801CBF4C;
        }
        c.S2 = 0u;
        c.S5 = 0x801E0000u;
        c.S5 = c.S5 + 0x170Cu;
        c.S3 = c.S5 + 0x8u;
        c.S1 = 0u;
        c.S4 = c.S5;
        L801CBE0C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.S0);
        if (c.V0 == 0u) {
            goto L801CBF4C;
        }
        c.V0 = mem.ReadWordLeft(c.V0, (c.S0 + 0x5u));
        c.V0 = mem.ReadWordRight(c.V0, (c.S0 + 0x2u));
        mem.WriteWordLeft((c.SP + 0x1Bu), c.V0);
        mem.WriteWordRight((c.SP + 0x18u), c.V0);
        c.A0 = mem.ReadU32((c.SP + 0x18u));
        c.A1 = c.S4;
        c.RA = 0x801CBE3Cu;
        Courier_Crisis_main.CdIntToPos_main(c, m);
        c.V0 = c.S5 + 0x4u;
        c.V0 = c.S1 + c.V0;
        c.V1 = mem.ReadWordLeft(c.V1, (c.S0 + 0xDu));
        c.V1 = mem.ReadWordRight(c.V1, (c.S0 + 0xAu));
        mem.WriteWordLeft((c.V0 + 0x3u), c.V1);
        mem.WriteWordRight(c.V0, c.V1);
        if (c.S2 == 0u) {
            c.V0 = 0x00000001u;
            goto L801CBE70;
        }
        c.V0 = 0x00000001u;
        if (c.S2 == c.V0) {
            c.A0 = c.S3;
            goto L801CBE80;
        }
        c.A0 = c.S3;
        goto L801CBEA0;
        L801CBE70: ;
        c.V0 = 0x801C0000u;
        c.V0 = mem.ReadU16((c.V0 + 0xA64u));
        mem.WriteU16((c.S5 + 0x8u), (ushort)c.V0);
        goto L801CBEBC;
        L801CBE80: ;
        c.V0 = 0x801C0000u;
        c.V0 = (uint)(short)mem.ReadU16((c.V0 + 0xA68u));
        c.V1 = 0x801C0000u;
        c.V1 = (uint)(sbyte)mem.ReadU8((c.V1 + 0xA6Au));
        mem.WriteU16((c.S5 + 0x20u), (ushort)c.V0);
        mem.WriteU8((c.S5 + 0x22u), (byte)c.V1);
        goto L801CBEBC;
        L801CBEA0: ;
        c.A2 = mem.ReadU8((c.S0 + 0x20u));
        c.A1 = c.S0 + 0x21u;
        c.RA = 0x801CBEACu;
        Courier_Crisis_main.func_801C87DC(c, m);
        c.V0 = mem.ReadU8((c.S0 + 0x20u));
        c.V0 = c.S3 + c.V0;
        mem.WriteU8(c.V0, (byte)0u);
        L801CBEBC: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CBF18;
        }
        c.At = 0x801E0000u;
        c.At = c.At + c.S1;
        c.A1 = mem.ReadU8((c.At + 0x170Cu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S1;
        c.A2 = mem.ReadU8((c.At + 0x170Du));
        c.At = 0x801E0000u;
        c.At = c.At + c.S1;
        c.A3 = mem.ReadU8((c.At + 0x170Eu));
        c.At = 0x801E0000u;
        c.At = c.At + c.S1;
        c.V0 = mem.ReadU32((c.At + 0x1710u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xA6Cu;
        mem.WriteU32((c.SP + 0x14u), c.S3);
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = 0x801CBF18u;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CBF18: ;
        c.S3 = c.S3 + 0x18u;
        c.S1 = c.S1 + 0x18u;
        c.V0 = mem.ReadU8(c.S0);
        c.S2 = c.S2 + 0x1u;
        c.S0 = c.S0 + c.V0;
        c.V0 = (int)c.S2 < 64 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.S4 = c.S4 + 0x18u;
            goto L801CBF4C;
        }
        c.S4 = c.S4 + 0x18u;
        c.V0 = 0x801E0000u;
        c.V0 = c.V0 + 0x3B0Cu;
        c.V0 = c.S0 < c.V0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CBE0C;
        }
        L801CBF4C: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x200u), c.S6);
        c.V0 = (int)c.S2 < 64 ? 1u : 0u;
        if (c.V0 == 0u) {
            c.V0 = c.S2 << 1;
            goto L801CBF74;
        }
        c.V0 = c.S2 << 1;
        c.V0 = c.V0 + c.S2;
        c.V0 = c.V0 << 3;
        c.At = 0x801E0000u;
        c.At = c.At + c.V0;
        mem.WriteU8((c.At + 0x1714u), (byte)0u);
        L801CBF74: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 - 0x104u));
        c.V0 = (int)c.V0 < 2 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.V0 = 0x00000001u;
            goto L801CBFA0;
        }
        c.V0 = 0x00000001u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xA88u;
        c.A1 = c.S2;
        c.RA = 0x801CBF9Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CBF9C: ;
        c.V0 = 0x00000001u;
        L801CBFA0: ;
        c.RA = mem.ReadU32((c.SP + 0x3Cu));
        c.S6 = mem.ReadU32((c.SP + 0x38u));
        c.S5 = mem.ReadU32((c.SP + 0x34u));
        c.S4 = mem.ReadU32((c.SP + 0x30u));
        c.S3 = mem.ReadU32((c.SP + 0x2Cu));
        c.S2 = mem.ReadU32((c.SP + 0x28u));
        c.S1 = mem.ReadU32((c.SP + 0x24u));
        c.S0 = mem.ReadU32((c.SP + 0x20u));
        c.SP = c.SP + 0x40u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CBFCC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A0;
        c.A0 = c.A1;
        c.A1 = c.SP + 0x10u;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        mem.WriteU32((c.SP + 0x20u), c.RA);
        c.S0 = c.A2;
        c.RA = 0x801CBFF0u;
        Courier_Crisis_main.CdIntToPos_main(c, m);
        c.A0 = 0x00000002u;
        c.A1 = c.SP + 0x10u;
        c.A2 = 0u;
        c.RA = 0x801CC000u;
        Courier_Crisis_main.CdControl_main(c, m);
        c.A0 = c.S1;
        c.A1 = c.S0;
        c.A2 = 0x00000080u;
        c.RA = 0x801CC010u;
        Courier_Crisis_main.CdRead_main(c, m);
        c.A0 = 0u;
        c.A1 = 0u;
        c.RA = 0x801CC01Cu;
        Courier_Crisis_main.CdReadSync_main(c, m);
        c.V0 = c.V0 < 0x00000001u ? 1u : 0u;
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CC038(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000017u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CC048(CpuContext c, IMemory m)
    {
        c.T2 = 0x000000A0u;
        c.T1 = 0x00000018u;
        Dispatcher.Call(c, m, c.T2);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CC058(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x20u), c.S0);
        c.S0 = c.A1;
        c.A0 = c.A0 & 0x00FFu;
        c.V0 = 0x00000001u;
        mem.WriteU32((c.SP + 0x24u), c.RA);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x240u), c.S0);
        if (c.A0 != c.V0) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CC1F4;
        }
        c.V0 = 0xFFFFFFFFu;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        if ((int)c.V0 <= 0) {
            goto L801CC1FC;
        }
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x21Cu));
        c.V0 = 0x00000200u;
        if (c.V1 != c.V0) {
            goto L801CC138;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x23Cu));
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            c.A0 = c.SP + 0x10u;
            goto L801CC0F4;
        }
        c.A0 = c.SP + 0x10u;
        c.A0 = 0u;
        c.RA = 0x801CC0C8u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = c.SP + 0x10u;
        c.A1 = 0x00000003u;
        c.RA = 0x801CC0D4u;
        Courier_Crisis_main.CdGetSector2_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801CC0DCu;
        Courier_Crisis_main.CdDataSync_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x3CD8u;
        c.RA = 0x801CC0ECu;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        goto L801CC0FC;
        L801CC0F4: ;
        c.A1 = 0x00000003u;
        c.RA = 0x801CC0FCu;
        Courier_Crisis_main.CdGetSector_main(c, m);
        L801CC0FC: ;
        c.A0 = c.SP + 0x10u;
        c.RA = 0x801CC104u;
        Courier_Crisis_main.CdPosToInt_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x22Cu;
        c.V1 = mem.ReadU32(c.V1);
        if (c.V0 == c.V1) {
            goto L801CC138;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xAA8u;
        c.RA = 0x801CC12Cu;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.V0 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        L801CC138: ;
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 + 0x23Cu;
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            goto L801CC174;
        }
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x214u));
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x21Cu));
        c.RA = 0x801CC16Cu;
        Courier_Crisis_main.CdGetSector2_main(c, m);
        goto L801CC1FC;
        L801CC174: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x214u));
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x21Cu));
        c.RA = 0x801CC18Cu;
        Courier_Crisis_main.CdGetSector_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x21Cu));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x214u));
        c.V0 = c.V0 << 2;
        c.V1 = c.V1 + c.V0;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x214u), c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        c.V0 = c.V0 - 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x22Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x22Cu), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x22Cu));
        goto L801CC1FC;
        L801CC1F4: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        L801CC1FC: ;
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CC204u;
        Courier_Crisis_main.VSync_main(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x224u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        if ((int)c.V0 >= 0) {
            goto L801CC228;
        }
        c.A0 = 0x00000001u;
        c.RA = 0x801CC228u;
        Courier_Crisis_main.func_801CC424(c, m);
        L801CC228: ;
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CC230u;
        Courier_Crisis_main.VSync_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x228u));
        c.V1 = c.V1 + 0x4B0u;
        c.V1 = (int)c.V1 < (int)c.V0 ? 1u : 0u;
        if (c.V1 == 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CC254;
        }
        c.V0 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        L801CC254: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        if (c.V0 == 0u) {
            goto L801CC28C;
        }
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CC270u;
        Courier_Crisis_main.VSync_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x228u));
        c.V1 = c.V1 + 0x4B0u;
        c.V1 = (int)c.V1 < (int)c.V0 ? 1u : 0u;
        if (c.V1 == 0u) {
            goto L801CC314;
        }
        L801CC28C: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x230u));
        c.RA = 0x801CC29Cu;
        Courier_Crisis_main.CdSyncCallback_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x234u));
        c.RA = 0x801CC2ACu;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x23Cu));
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000009u;
            goto L801CC2D8;
        }
        c.A0 = 0x00000009u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x238u));
        c.RA = 0x801CC2D4u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = 0x00000009u;
        L801CC2D8: ;
        c.A1 = 0u;
        c.RA = 0x801CC2E0u;
        Courier_Crisis_main.CdControlF_main(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x208u));
        if (c.V1 == 0u) {
            goto L801CC314;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        if (c.V0 != 0u) {
            c.A0 = 0x00000005u;
            goto L801CC30C;
        }
        c.A0 = 0x00000005u;
        c.A0 = 0x00000002u;
        L801CC30C: ;
        c.A1 = c.S0;
        c.RA = 0x801CC314u;
        Dispatcher.Call(c, m, c.V1);
        L801CC314: ;
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S0 = mem.ReadU32((c.SP + 0x20u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CC328(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x21Cu));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x214u));
        c.V0 = c.V0 << 2;
        c.V1 = c.V1 + c.V0;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x214u), c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        c.V0 = c.V0 - 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x22Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x22Cu), c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x22Cu));
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        c.SP = c.SP - 0x18u;
        if (c.V0 != 0u) {
            mem.WriteU32((c.SP + 0x10u), c.RA);
            goto L801CC414;
        }
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x230u));
        c.RA = 0x801CC3ACu;
        Courier_Crisis_main.CdSyncCallback_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x234u));
        c.RA = 0x801CC3BCu;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x23Cu));
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000009u;
            goto L801CC3E8;
        }
        c.A0 = 0x00000009u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x238u));
        c.RA = 0x801CC3E4u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = 0x00000009u;
        L801CC3E8: ;
        c.A1 = 0u;
        c.RA = 0x801CC3F0u;
        Courier_Crisis_main.CdControlF_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x208u));
        if (c.V0 == 0u) {
            goto L801CC414;
        }
        c.A1 = 0x801D0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x240u));
        c.A0 = 0x00000002u;
        c.RA = 0x801CC414u;
        Dispatcher.Call(c, m, c.V0);
        L801CC414: ;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CC424(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.S1 = c.A0;
        c.A0 = 0u;
        mem.WriteU32((c.SP + 0x20u), c.RA);
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.RA = 0x801CC440u;
        Courier_Crisis_main.CdSyncCallback_main(c, m);
        c.A0 = 0u;
        c.RA = 0x801CC448u;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 + 0x23Cu;
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            goto L801CC46C;
        }
        c.A0 = 0u;
        c.RA = 0x801CC46Cu;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        L801CC46C: ;
        c.RA = 0x801CC474u;
        Courier_Crisis_main.CdStatus_main(c, m);
        c.V0 = c.V0 & 0x0010u;
        if (c.V0 == 0u) {
            goto L801CC4D4;
        }
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CC488u;
        Courier_Crisis_main.VSync_main(c, m);
        c.V0 = c.V0 & 0x003Fu;
        if (c.V0 != 0u) {
            c.A0 = 0x00000001u;
            goto L801CC4A8;
        }
        c.A0 = 0x00000001u;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xAC0u;
        c.RA = 0x801CC4A4u;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.A0 = 0x00000001u;
        L801CC4A8: ;
        c.A1 = 0u;
        c.RA = 0x801CC4B0u;
        Courier_Crisis_main.CdControlF_main(c, m);
        c.A0 = 0xFFFFFFFFu;
        c.RA = 0x801CC4B8u;
        Courier_Crisis_main.VSync_main(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x228u), c.V0);
        c.V0 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        goto L801CC618;
        L801CC4D4: ;
        if (c.S1 == 0u) {
            goto L801CC52C;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xAD8u;
        c.RA = 0x801CC4ECu;
        Courier_Crisis_main.func_801C87B4(c, m);
        c.A0 = 0x00000009u;
        c.A1 = 0u;
        c.A2 = 0u;
        c.RA = 0x801CC4FCu;
        Courier_Crisis_main.CdControl_main(c, m);
        c.RA = 0x801CC504u;
        Courier_Crisis_main.CdLastPos_main(c, m);
        c.A0 = 0x00000002u;
        c.A1 = c.V0;
        c.A2 = 0u;
        c.RA = 0x801CC514u;
        Courier_Crisis_main.CdControl_main(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CC52C;
        }
        c.V0 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        goto L801CC618;
        L801CC52C: ;
        c.RA = 0x801CC534u;
        Courier_Crisis_main.CdFlush_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = c.V0 + 0x218u;
        c.S0 = mem.ReadU32(c.V0);
        mem.WriteU8((c.SP + 0x10u), (byte)c.S0);
        c.S0 = c.S0 & 0x00FFu;
        c.RA = 0x801CC550u;
        Courier_Crisis_main.CdMode_main(c, m);
        if (c.S0 != c.V0) {
            c.A0 = 0x0000000Eu;
            goto L801CC560;
        }
        c.A0 = 0x0000000Eu;
        if (c.S1 == 0u) {
            goto L801CC584;
        }
        L801CC560: ;
        c.A1 = c.SP + 0x10u;
        c.A2 = 0u;
        c.RA = 0x801CC56Cu;
        Courier_Crisis_main.CdControl_main(c, m);
        if (c.V0 != 0u) {
            c.V0 = 0xFFFFFFFFu;
            goto L801CC584;
        }
        c.V0 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        goto L801CC618;
        L801CC584: ;
        c.RA = 0x801CC58Cu;
        Courier_Crisis_main.CdLastPos_main(c, m);
        c.A0 = c.V0;
        c.RA = 0x801CC594u;
        Courier_Crisis_main.CdPosToInt_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x3FA8u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x22Cu), c.V0);
        c.RA = 0x801CC5ACu;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x23Cu));
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000006u;
            goto L801CC5D8;
        }
        c.A0 = 0x00000006u;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x3CD8u;
        c.RA = 0x801CC5D4u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = 0x00000006u;
        L801CC5D8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x210u));
        c.A1 = 0u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x214u), c.V0);
        c.RA = 0x801CC5F4u;
        Courier_Crisis_main.CdControlF_main(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x20Cu));
        c.A0 = 0xFFFFFFFFu;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), c.V0);
        c.RA = 0x801CC610u;
        Courier_Crisis_main.VSync_main(c, m);
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x224u), c.V0);
        L801CC618: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x220u));
        c.RA = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReadBreak_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = 0x801D0000u;
        c.S0 = c.S0 + 0x23Cu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.V0 = mem.ReadU32(c.S0);
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            goto L801CC668;
        }
        c.A0 = 0u;
        c.RA = 0x801CC668u;
        Courier_Crisis_main.CdDataSync_main(c, m);
        L801CC668: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x220u), 0u);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x230u));
        c.RA = 0x801CC680u;
        Courier_Crisis_main.CdSyncCallback_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x234u));
        c.RA = 0x801CC690u;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        c.V0 = mem.ReadU32(c.S0);
        c.V0 = c.V0 & 0x0001u;
        if (c.V0 == 0u) {
            c.A0 = 0x00000009u;
            goto L801CC6B8;
        }
        c.A0 = 0x00000009u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x238u));
        c.RA = 0x801CC6B4u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = 0x00000009u;
        L801CC6B8: ;
        c.A1 = 0u;
        c.RA = 0x801CC6C0u;
        Courier_Crisis_main.CdControlF_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdRead_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdRead(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReadSync_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdReadSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReadCallback_main(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCd.CdReadCallback(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdReadMode_main(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V1 = 0x801D0000u;
        c.V1 = c.V1 + 0x23Cu;
        c.V0 = mem.ReadU32(c.V1);
        mem.WriteU32(c.V1, c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void CdRead2(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A0;
        c.A0 = 0x0000000Eu;
        c.A1 = c.SP + 0x10u;
        c.A2 = 0u;
        mem.WriteU32((c.SP + 0x1Cu), c.RA);
        mem.WriteU8((c.SP + 0x10u), (byte)c.S0);
        c.RA = 0x801CC8F8u;
        Courier_Crisis_main.CdControl_main(c, m);
        c.V0 = c.S0 & 0x0100u;
        if (c.V0 == 0u) {
            c.V0 = c.S0 & 0x0020u;
            goto L801CC944;
        }
        c.V0 = c.S0 & 0x0020u;
        if (c.V0 == 0u) {
            c.V0 = 0x00000001u;
            goto L801CC91C;
        }
        c.V0 = 0x00000001u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B24u), 0u);
        goto L801CC924;
        L801CC91C: ;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B24u), c.V0);
        L801CC924: ;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x3618u;
        c.RA = 0x801CC934u;
        Courier_Crisis_main.CdDataCallback_main(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 - 0x3698u;
        c.RA = 0x801CC944u;
        Courier_Crisis_main.CdReadyCallback_main(c, m);
        L801CC944: ;
        c.A0 = 0x0000001Bu;
        c.A1 = 0u;
        c.A2 = 0u;
        c.RA = 0x801CC954u;
        Courier_Crisis_main.CdControl_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CC968(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.RA = 0x801CC978u;
        Courier_Crisis_main.StCdInterrupt(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StClearRing(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StClearRing(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void data_ready_callback(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5364u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5380u));
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = c.V0 << 5;
        c.V1 = c.V1 + c.V0;
        c.V0 = 0x00000002u;
        mem.WriteU16(c.V1, (ushort)c.V0);
        c.A2 = 0x801E0000u;
        c.A2 = c.A2 + 0x3B0Cu;
        c.V0 = mem.ReadWordLeft(c.V0, (c.V1 + 0x1Fu));
        c.V0 = mem.ReadWordRight(c.V0, (c.V1 + 0x1Cu));
        mem.WriteWordLeft((c.A2 + 0x3u), c.V0);
        mem.WriteWordRight(c.A2, c.V0);
        c.V0 = mem.ReadU32((c.V1 + 0x8u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5360u));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B28u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B10u), c.V0);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5364u), c.V1);
        if (c.A0 == 0u) {
            goto L801CCA60;
        }
        c.RA = 0x801CCA60u;
        Dispatcher.Call(c, m, c.A0);
        L801CCA60: ;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B58u), 0u);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StGetBackloc(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StGetBackloc(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StSetStream(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StSetStream(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StFreeRing(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StFreeRing(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void init_ring_status(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        if (c.A1 == 0u) {
            c.A2 = 0u;
            goto L801CCC48;
        }
        c.A2 = 0u;
        L801CCC24: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = c.A2 + c.A0;
        c.A2 = c.A2 + 0x1u;
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5380u));
        c.V0 = c.V0 << 5;
        c.V1 = c.V1 + c.V0;
        c.V0 = c.A2 < c.A1 ? 1u : 0u;
        if (c.V0 != 0u) {
            mem.WriteU32(c.V1, 0u);
            goto L801CCC24;
        }
        mem.WriteU32(c.V1, 0u);
        L801CCC48: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StGetNext(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StGetNext(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StSetMask(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibCdStream.StSetMask(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void StCdInterrupt(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x40u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B58u));
        c.A0 = 0x00000001u;
        if (c.V0 == c.A0) {
            mem.WriteU32((c.SP + 0x38u), c.RA);
            goto L801CD698;
        }
        mem.WriteU32((c.SP + 0x38u), c.RA);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B20u));
        if (c.V0 == 0u) {
            goto L801CCDC4;
        }
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2D4u));
        c.V0 = mem.ReadU32(c.V0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            goto L801CCDC4;
        }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B30u), c.A0);
        if (c.V0 == 0u) {
            goto L801CCDB4;
        }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        L801CCDB4: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.A0);
        goto L801CD698;
        L801CCDC4: ;
        c.A1 = c.SP + 0x30u;
        c.RA = 0x801CCDCCu;
        Courier_Crisis_main.CdReady_main(c, m);
        c.V1 = 0x00000005u;
        if (c.V0 == c.V1) {
            goto L801CD698;
        }
        c.V0 = mem.ReadU8((c.SP + 0x30u));
        c.V1 = mem.ReadU8((c.SP + 0x31u));
        mem.WriteU16((c.SP + 0x22u), (ushort)c.V0);
        mem.WriteU16((c.SP + 0x24u), (ushort)c.V1);
        c.V0 = mem.ReadU16((c.SP + 0x22u));
        c.V0 = c.V0 & 0x0004u;
        if (c.V0 == 0u) {
            c.V0 = 0x00000003u;
            goto L801CCE0C;
        }
        c.V0 = 0x00000003u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        goto L801CD698;
        L801CCE0C: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5360u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5380u));
        c.V0 = c.V0 << 5;
        c.V1 = c.V1 + c.V0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B14u), c.V1);
        c.V0 = mem.ReadU16(c.V1);
        if (c.V0 == 0u) {
            goto L801CCE7C;
        }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000004u;
            goto L801CCE6C;
        }
        c.V0 = 0x00000004u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        c.V0 = 0x00000004u;
        L801CCE6C: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        goto L801CD698;
        L801CCE7C: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2B4u));
        mem.WriteU8(c.V0, (byte)0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2C0u));
        mem.WriteU8(c.V0, (byte)0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2B4u));
        c.A0 = 0x00020000u;
        mem.WriteU8(c.V0, (byte)0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2C0u));
        c.V0 = 0x00000080u;
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2C4u));
        c.A0 = c.A0 | 0x0943u;
        mem.WriteU32(c.V0, c.A0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2C8u));
        c.V0 = 0x00001323u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B24u));
        if (c.V0 != 0u) {
            goto L801CCF44;
        }
        c.V1 = c.SP + 0x28u;
        c.A0 = c.SP + 0x2Cu;
        L801CCEF8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2BCu));
        c.V0 = mem.ReadU8(c.V0);
        mem.WriteU8(c.V1, (byte)c.V0);
        c.V1 = c.V1 + 0x1u;
        c.V0 = c.V1 < c.A0 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CCEF8;
        }
        c.V1 = 0u;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x2BCu));
        L801CCF2C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.A0);
        c.V1 = c.V1 + 0x1u;
        c.V0 = c.V1 < 0x00000008u ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CCF2C;
        }
        L801CCF44: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.T0 = 0x11000000u;
            goto L801CCF84;
        }
        c.T0 = 0x11000000u;
        c.A2 = 0x00000008u;
        c.A3 = 0u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x3B5Cu));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B14u));
        c.A1 = c.A1 << 11;
        c.A1 = c.V0 + c.A1;
        c.RA = 0x801CCF7Cu;
        Courier_Crisis_main.func_801CD6A8(c, m);
        goto L801CCFA8;
        L801CCF84: ;
        c.A0 = 0x00000003u;
        c.A2 = 0u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x3B14u));
        c.A3 = 0x00000008u;
        mem.WriteU32((c.SP + 0x10u), c.T0);
        mem.WriteU32((c.SP + 0x14u), 0u);
        mem.WriteU32((c.SP + 0x18u), 0u);
        c.RA = 0x801CCFA8u;
        Courier_Crisis_main.func_801CD6DC(c, m);
        L801CCFA8: ;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x2E4u));
        c.V0 = mem.ReadU32(c.A0);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            c.V1 = c.A0;
            goto L801CCFE0;
        }
        c.V1 = c.A0;
        c.A0 = 0x01000000u;
        L801CCFCC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.V1);
        c.V0 = c.V0 & c.A0;
        if (c.V0 != 0u) {
            goto L801CCFCC;
        }
        L801CCFE0: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B14u));
        c.V1 = 0x00020000u;
        c.A0 = mem.ReadWordLeft(c.A0, (c.SP + 0x2Bu));
        c.A0 = mem.ReadWordRight(c.A0, (c.SP + 0x28u));
        mem.WriteWordLeft((c.V0 + 0x1Fu), c.A0);
        mem.WriteWordRight((c.V0 + 0x1Cu), c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2C4u));
        c.V1 = c.V1 | 0x0843u;
        mem.WriteU32(c.V0, c.V1);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2C8u));
        c.V0 = 0x00001325u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5378u));
        c.V0 = 0x00000001u;
        if (c.V1 != c.V0) {
            goto L801CD0A4;
        }
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B4Cu));
        if (c.A0 == 0u) {
            goto L801CD0A4;
        }
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B14u));
        c.V0 = mem.ReadU16((c.V1 + 0x8u));
        if (c.A0 == c.V0) {
            goto L801CD09C;
        }
        mem.WriteU16(c.V1, (ushort)0u);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            goto L801CD698;
        }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        goto L801CD698;
        L801CD09C: ;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5378u), 0u);
        L801CD0A4: ;
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B14u));
        c.V0 = mem.ReadU16(c.A0);
        c.V1 = 0x00000160u;
        c.V0 = c.V0 & 0xFFFFu;
        if (c.V0 != c.V1) {
            goto L801CD0E0;
        }
        c.V0 = mem.ReadU16((c.A0 + 0x2u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B50u));
        c.V0 = c.V0 >> 10;
        c.V0 = c.V0 & 0x001Fu;
        if (c.V0 == c.V1) {
            goto L801CD128;
        }
        L801CD0E0: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            goto L801CD104;
        }
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), 0u);
        goto L801CD108;
        L801CD104: ;
        c.V0 = mem.ReadU16(c.A0);
        L801CD108: ;
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B14u));
        c.V0 = 0x00000005u;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        mem.WriteU16(c.V1, (ushort)0u);
        goto L801CD698;
        L801CD128: ;
        c.V1 = 0x801E0000u;
        c.V1 = (uint)(short)mem.ReadU16((c.V1 + 0x3B1Cu));
        c.V0 = mem.ReadU16((c.A0 + 0x4u));
        if (c.V1 != c.V0) {
            goto L801CD164;
        }
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B18u));
        if (c.V1 == 0u) {
            goto L801CD1E8;
        }
        c.V0 = mem.ReadU16((c.A0 + 0x8u));
        if (c.V1 == c.V0) {
            goto L801CD1E8;
        }
        L801CD164: ;
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x5364u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x5360u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B18u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x3B1Cu), (ushort)0u);
        c.A1 = c.A1 - c.A0;
        c.RA = 0x801CD18Cu;
        Courier_Crisis_main.init_ring_status(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5364u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B14u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5360u), c.V0);
        mem.WriteU16(c.V1, (ushort)0u);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000006u;
            goto L801CD1D8;
        }
        c.V0 = 0x00000006u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        c.V0 = 0x00000006u;
        L801CD1D8: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        goto L801CD698;
        L801CD1E8: ;
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B14u));
        c.V0 = mem.ReadU16((c.V1 + 0x4u));
        if (c.V0 != 0u) {
            c.V0 = 0x0000000Au;
            goto L801CD448;
        }
        c.V0 = 0x0000000Au;
        c.V0 = mem.ReadU16((c.V1 + 0x8u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5374u));
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x3B1Cu), (ushort)0u);
        c.V0 = c.V0 & 0xFFFFu;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B18u), c.V0);
        if (c.V1 == 0u) {
            c.V0 = c.V0 < c.V1 ? 1u : 0u;
            goto L801CD2DC;
        }
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 != 0u) {
            goto L801CD2DC;
        }
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x5364u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x5360u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B18u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x3B1Cu), (ushort)0u);
        c.A1 = c.A1 - c.A0;
        c.RA = 0x801CD25Cu;
        Courier_Crisis_main.init_ring_status(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5364u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B14u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5360u), c.V0);
        mem.WriteU16(c.V1, (ushort)0u);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B2Cu));
        c.V0 = 0x00000001u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5378u), c.V0);
        if (c.V1 == 0u) {
            goto L801CD29C;
        }
        c.RA = 0x801CD29Cu;
        Dispatcher.Call(c, m, c.V1);
        L801CD29C: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000007u;
            goto L801CD2CC;
        }
        c.V0 = 0x00000007u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        c.V0 = 0x00000007u;
        L801CD2CC: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        goto L801CD698;
        L801CD2DC: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5384u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5360u));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B14u));
        c.V0 = c.V0 - c.V1;
        c.V1 = mem.ReadU16((c.A0 + 0x6u));
        c.V0 = c.V0 - 0x1u;
        c.V0 = c.V0 < c.V1 ? 1u : 0u;
        if (c.V0 == 0u) {
            goto L801CD434;
        }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5374u));
        if (c.V0 != 0u) {
            c.V0 = 0x00000001u;
            goto L801CD388;
        }
        c.V0 = 0x00000001u;
        mem.WriteU16(c.A0, (ushort)c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B2Cu));
        c.V0 = 0x00000001u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5378u), c.V0);
        if (c.V1 == 0u) {
            goto L801CD348;
        }
        c.RA = 0x801CD348u;
        Dispatcher.Call(c, m, c.V1);
        L801CD348: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000008u;
            goto L801CD378;
        }
        c.V0 = 0x00000008u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        c.V0 = 0x00000008u;
        L801CD378: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        goto L801CD698;
        L801CD388: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5380u));
        c.V0 = (uint)(short)mem.ReadU16(c.V0);
        if (c.V0 == 0u) {
            c.V0 = 0x00000001u;
            goto L801CD3E8;
        }
        c.V0 = 0x00000001u;
        mem.WriteU16(c.A0, (ushort)0u);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.V0 = 0x00000009u;
            goto L801CD3D8;
        }
        c.V0 = 0x00000009u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        c.V0 = 0x00000009u;
        L801CD3D8: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        goto L801CD698;
        L801CD3E8: ;
        mem.WriteU16(c.A0, (ushort)c.V0);
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x5380u));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B14u));
        c.V1 = 0u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5360u), 0u);
        L801CD408: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A0);
        c.A0 = c.A0 + 0x4u;
        c.V1 = c.V1 + 0x1u;
        mem.WriteU32(c.A1, c.V0);
        c.V0 = c.V1 < 0x00000008u ? 1u : 0u;
        if (c.V0 != 0u) {
            c.A1 = c.A1 + 0x4u;
            goto L801CD408;
        }
        c.A1 = c.A1 + 0x4u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5380u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B14u), c.V0);
        L801CD434: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5360u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5364u), c.V0);
        c.V0 = 0x0000000Au;
        L801CD448: ;
        c.At = 0x801D0000u;
        mem.WriteU32((c.At + 0x2FCu), c.V0);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU16((c.V0 + 0x3B1Cu));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x5384u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5380u));
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x5360u));
        c.V0 = c.V0 + 0x1u;
        c.A0 = c.A0 << 5;
        c.V1 = c.V1 + c.A0;
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x3B1Cu), (ushort)c.V0);
        c.V0 = c.A1 << 6;
        c.V0 = c.V0 - c.A1;
        c.V0 = c.V0 << 5;
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x3B20u));
        c.V1 = c.V1 + c.V0;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x537Cu), c.V1);
        if (c.A0 == 0u) {
            c.T0 = 0x11000000u;
            goto L801CD4D8;
        }
        c.T0 = 0x11000000u;
        c.V1 = 0x00020000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2C4u));
        c.V1 = c.V1 | 0x0943u;
        mem.WriteU32(c.V0, c.V1);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2C8u));
        c.V0 = 0x00001323u;
        mem.WriteU32(c.V1, c.V0);
        goto L801CD4F4;
        L801CD4D8: ;
        c.V1 = 0x21020000u;
        c.V1 = c.V1 | 0x0843u;
        c.T0 = 0x11400000u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2C4u));
        c.T0 = c.T0 | 0x0100u;
        mem.WriteU32(c.V0, c.V1);
        L801CD4F4: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B14u));
        c.V1 = mem.ReadU16((c.V0 + 0x6u));
        c.V0 = mem.ReadU16((c.V0 + 0x4u));
        c.V1 = c.V1 - 0x1u;
        if (c.V1 != c.V0) {
            c.V1 = 0x00000001u;
            goto L801CD5BC;
        }
        c.V1 = 0x00000001u;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B58u), c.V1);
        if (c.V0 == 0u) {
            c.A2 = 0x000001F8u;
            goto L801CD570;
        }
        c.A2 = 0x000001F8u;
        c.A3 = 0x00000001u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x3B5Cu));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x537Cu));
        c.A1 = c.A1 << 11;
        c.A1 = c.V0 + c.A1;
        c.A1 = c.A1 + 0x20u;
        c.RA = 0x801CD550u;
        Courier_Crisis_main.func_801CD6A8(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        goto L801CD594;
        L801CD570: ;
        c.A0 = 0x00000003u;
        c.A2 = 0u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x537Cu));
        c.A3 = 0x000001F8u;
        mem.WriteU32((c.SP + 0x10u), c.T0);
        mem.WriteU32((c.SP + 0x14u), c.V1);
        mem.WriteU32((c.SP + 0x18u), 0u);
        c.RA = 0x801CD594u;
        Courier_Crisis_main.func_801CD6DC(c, m);
        L801CD594: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B48u));
        c.At = 0x801E0000u;
        mem.WriteU16((c.At + 0x3B1Cu), (ushort)0u);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B18u), 0u);
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B50u), c.V0);
        goto L801CD638;
        L801CD5BC: ;
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5370u));
        if (c.V0 == 0u) {
            c.A2 = 0x000001F8u;
            goto L801CD614;
        }
        c.A2 = 0x000001F8u;
        c.A3 = 0u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x3B5Cu));
        c.A0 = 0x801E0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x537Cu));
        c.A1 = c.A1 << 11;
        c.A1 = c.V0 + c.A1;
        c.A1 = c.A1 + 0x20u;
        c.RA = 0x801CD5F4u;
        Courier_Crisis_main.func_801CD6A8(c, m);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B5Cu));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x3B5Cu), c.V0);
        goto L801CD638;
        L801CD614: ;
        c.A0 = 0x00000003u;
        c.A2 = 0u;
        c.A1 = 0x801E0000u;
        c.A1 = mem.ReadU32((c.A1 + 0x537Cu));
        c.A3 = 0x000001F8u;
        mem.WriteU32((c.SP + 0x10u), c.T0);
        mem.WriteU32((c.SP + 0x14u), 0u);
        mem.WriteU32((c.SP + 0x18u), 0u);
        c.RA = 0x801CD638u;
        Courier_Crisis_main.func_801CD6DC(c, m);
        L801CD638: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2C8u));
        c.V0 = 0x00001325u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x3B14u));
        c.V0 = 0x00000003u;
        mem.WriteU16(c.V1, (ushort)c.V0);
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x5360u));
        c.V1 = 0x801E0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x5370u));
        c.V0 = c.V0 + 0x1u;
        c.At = 0x801E0000u;
        mem.WriteU32((c.At + 0x5360u), c.V0);
        if (c.V1 == 0u) {
            goto L801CD698;
        }
        c.V0 = 0x801E0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x3B58u));
        if (c.V0 == 0u) {
            goto L801CD698;
        }
        c.RA = 0x801CD698u;
        Courier_Crisis_main.data_ready_callback(c, m);
        L801CD698: ;
        c.RA = mem.ReadU32((c.SP + 0x38u));
        c.SP = c.SP + 0x40u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CD6A8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x8u;
        if (c.A2 == 0u) {
            c.V1 = 0u;
            goto L801CD6D0;
        }
        c.V1 = 0u;
        L801CD6B4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A1);
        c.A1 = c.A1 + 0x4u;
        c.V1 = c.V1 + 0x1u;
        mem.WriteU32(c.A0, c.V0);
        c.V0 = c.V1 < c.A2 ? 1u : 0u;
        if (c.V0 != 0u) {
            c.A0 = c.A0 + 0x4u;
            goto L801CD6B4;
        }
        c.A0 = c.A0 + 0x4u;
        L801CD6D0: ;
        c.SP = c.SP + 0x8u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CD6DC(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x38u;
        mem.WriteU32((c.SP + 0x18u), c.S0);
        c.S0 = c.A0;
        mem.WriteU32((c.SP + 0x20u), c.S2);
        c.S2 = c.A1;
        mem.WriteU32((c.SP + 0x24u), c.S3);
        c.S3 = c.A2;
        mem.WriteU32((c.SP + 0x28u), c.S4);
        c.S4 = c.A3;
        c.A0 = 0u;
        c.A1 = c.S0 << 4;
        c.V0 = 0x01000000u;
        mem.WriteU32((c.SP + 0x30u), c.RA);
        mem.WriteU32((c.SP + 0x2Cu), c.S5);
        mem.WriteU32((c.SP + 0x1Cu), c.S1);
        c.At = 0x1F800000u;
        c.At = c.A1 + c.At;
        c.V1 = mem.ReadU32((c.At + 0x1088u));
        c.S5 = mem.ReadU32((c.SP + 0x48u));
        c.S1 = mem.ReadU8((c.SP + 0x4Cu));
        c.V1 = c.V1 & c.V0;
        if (c.V1 == 0u) {
            c.V0 = c.S1 & 0x00FFu;
            goto L801CD768;
        }
        c.V0 = c.S1 & 0x00FFu;
        c.A2 = 0x00010000u;
        c.V1 = 0x01000000u;
        L801CD740: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        if (c.A0 == c.A2) {
            goto L801CD78C;
        }
        c.At = 0x1F800000u;
        c.At = c.A1 + c.At;
        c.V0 = mem.ReadU32((c.At + 0x1088u));
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            c.A0 = c.A0 + 0x1u;
            goto L801CD740;
        }
        c.A0 = c.A0 + 0x1u;
        c.V0 = c.S1 & 0x00FFu;
        L801CD768: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.A1 = 0x00000001u;
        if (c.V0 != c.A1) {
            c.V0 = c.A1 << (int)(c.S0 & 31u);
            goto L801CD7B0;
        }
        c.V0 = c.A1 << (int)(c.S0 & 31u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2D0u));
        c.A0 = mem.ReadU8((c.V1 + 0x2u));
        c.A0 = c.A0 | c.V0;
        goto L801CD7C8;
        L801CD78C: ;
        c.At = 0x1F800000u;
        c.At = c.A1 + c.At;
        c.A1 = mem.ReadU32((c.At + 0x1088u));
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xAECu;
        c.RA = 0x801CD7A8u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V0 = c.S1 & 0x00FFu;
        goto L801CD768;
        L801CD7B0: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2D0u));
        c.A0 = mem.ReadU8((c.V1 + 0x2u));
        c.V0 = ~(0u | c.V0);
        c.A0 = c.A0 & c.V0;
        L801CD7C8: ;
        mem.WriteU8((c.V1 + 0x2u), (byte)c.A0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x2D0u));
        c.V0 = mem.ReadU32(c.V0);
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.A2 = c.S0 << 2;
        c.A2 = c.A2 + 0x3u;
        c.V1 = 0x00000001u;
        c.V1 = c.V1 << (int)(c.A2 & 31u);
        c.A1 = 0x1F800000u;
        c.A1 = c.A1 | 0x1080u;
        c.V0 = c.S0 << 4;
        c.A1 = c.V0 + c.A1;
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x2CCu));
        c.V0 = c.S3 << 16;
        c.A2 = mem.ReadU32(c.A0);
        c.V0 = c.V0 | c.S4;
        c.A2 = c.A2 | c.V1;
        mem.WriteU32(c.A0, c.A2);
        mem.WriteU32(c.A1, c.S2);
        c.A1 = c.A1 + 0x4u;
        mem.WriteU32(c.A1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x2B4u));
        c.V0 = mem.ReadU8(c.V1);
        c.V0 = c.V0 & 0x0040u;
        if (c.V0 != 0u) {
            c.A1 = c.A1 + 0x4u;
            goto L801CD860;
        }
        c.A1 = c.A1 + 0x4u;
        L801CD84C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU8(c.V1);
        c.V0 = c.V0 & 0x0040u;
        if (c.V0 == 0u) {
            goto L801CD84C;
        }
        L801CD860: ;
        mem.WriteU32(c.A1, c.S5);
        c.V0 = mem.ReadU32(c.A1);
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.RA = mem.ReadU32((c.SP + 0x30u));
        c.S5 = mem.ReadU32((c.SP + 0x2Cu));
        c.S4 = mem.ReadU32((c.SP + 0x28u));
        c.S3 = mem.ReadU32((c.SP + 0x24u));
        c.S2 = mem.ReadU32((c.SP + 0x20u));
        c.S1 = mem.ReadU32((c.SP + 0x1Cu));
        c.S0 = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x38u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTReset(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        if (c.S0 != 0u) {
            mem.WriteU32((c.SP + 0x14u), c.RA);
            goto L801CD8B4;
        }
        mem.WriteU32((c.SP + 0x14u), c.RA);
        c.RA = 0x801CD8B4u;
        Courier_Crisis_main.ResetCallback_main(c, m);
        L801CD8B4: ;
        c.A0 = c.S0;
        c.RA = 0x801CD8BCu;
        Courier_Crisis_main.func_801CDB60(c, m);
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTGetEnv(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.A2 = c.A0;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 + 0x308u;
        c.V1 = 0x0000000Fu;
        c.A3 = 0xFFFFFFFFu;
        L801CD8E4: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A1);
        c.A1 = c.A1 + 0x4u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU32(c.A2, c.V0);
        if (c.V1 != c.A3) {
            c.A2 = c.A2 + 0x4u;
            goto L801CD8E4;
        }
        c.A2 = c.A2 + 0x4u;
        c.A2 = c.A0 + 0x40u;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 + 0x348u;
        c.V1 = 0x0000000Fu;
        c.A3 = 0xFFFFFFFFu;
        L801CD910: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A1);
        c.A1 = c.A1 + 0x4u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU32(c.A2, c.V0);
        if (c.V1 != c.A3) {
            c.A2 = c.A2 + 0x4u;
            goto L801CD910;
        }
        c.A2 = c.A2 + 0x4u;
        c.A2 = c.A0 + 0x80u;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 + 0x38Cu;
        c.V1 = 0x0000001Fu;
        c.A3 = 0xFFFFFFFFu;
        L801CD93C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A1);
        c.A1 = c.A1 + 0x4u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU32(c.A2, c.V0);
        if (c.V1 != c.A3) {
            c.A2 = c.A2 + 0x4u;
            goto L801CD93C;
        }
        c.A2 = c.A2 + 0x4u;
        c.V0 = c.A0;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTPutEnv(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        c.S0 = c.A0;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 + 0x308u;
        c.V1 = 0x0000000Fu;
        c.A2 = 0xFFFFFFFFu;
        mem.WriteU32((c.SP + 0x14u), c.RA);
        L801CD97C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A0);
        c.A0 = c.A0 + 0x4u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU32(c.A1, c.V0);
        if (c.V1 != c.A2) {
            c.A1 = c.A1 + 0x4u;
            goto L801CD97C;
        }
        c.A1 = c.A1 + 0x4u;
        c.A1 = 0x801D0000u;
        c.A1 = c.A1 + 0x348u;
        c.A0 = c.S0 + 0x40u;
        c.V1 = 0x0000000Fu;
        c.A2 = 0xFFFFFFFFu;
        L801CD9A8: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32(c.A0);
        c.A0 = c.A0 + 0x4u;
        c.V1 = c.V1 - 0x1u;
        mem.WriteU32(c.A1, c.V0);
        if (c.V1 != c.A2) {
            c.A1 = c.A1 + 0x4u;
            goto L801CD9A8;
        }
        c.A1 = c.A1 + 0x4u;
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 + 0x304u;
        c.A1 = 0x00000020u;
        c.RA = 0x801CD9D0u;
        Courier_Crisis_main.func_801CDC5C(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 + 0x388u;
        c.A1 = 0x00000020u;
        c.RA = 0x801CD9E0u;
        Courier_Crisis_main.func_801CDC5C(c, m);
        c.V0 = c.S0;
        c.RA = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTBufSize(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = mem.ReadU16(c.A0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTin(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibPress.DecDCTin(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTout(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibPress.DecDCTout(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTinSync(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibPress.DecDCTinSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCToutSync(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibPress.DecDCToutSync(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTinCallback(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.A1 = c.A0;
        c.A0 = 0u;
        c.RA = 0x801CDB2Cu;
        Courier_Crisis_main.DMACallback_main(c, m);
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCToutCallback(CpuContext c, IMemory m) => RecompOne.Runtime.Sdk.LibPress.DecDCToutCallback(c, m);
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDB60(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x18u;
        c.A1 = c.A0;
        if (c.A1 == 0u) {
            mem.WriteU32((c.SP + 0x10u), c.RA);
            goto L801CDB84;
        }
        mem.WriteU32((c.SP + 0x10u), c.RA);
        c.V0 = 0x00000001u;
        if (c.A1 == c.V0) {
            c.V0 = 0x80000000u;
            goto L801CDBE8;
        }
        c.V0 = 0x80000000u;
        goto L801CDC3C;
        L801CDB84: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x448u));
        c.V0 = 0x80000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x41Cu));
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 + 0x304u;
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        c.A1 = 0x00000020u;
        mem.WriteU32(c.V0, 0u);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x448u));
        c.V0 = 0x60000000u;
        mem.WriteU32(c.V1, c.V0);
        c.RA = 0x801CDBD0u;
        Courier_Crisis_main.func_801CDC5C(c, m);
        c.A0 = 0x801D0000u;
        c.A0 = c.A0 + 0x388u;
        c.A1 = 0x00000020u;
        c.RA = 0x801CDBE0u;
        Courier_Crisis_main.func_801CDC5C(c, m);
        goto L801CDC4C;
        L801CDBE8: ;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x448u));
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x41Cu));
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x448u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = 0x60000000u;
        mem.WriteU32(c.V1, c.V0);
        goto L801CDC4C;
        L801CDC3C: ;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xB04u;
        c.RA = 0x801CDC4Cu;
        Courier_Crisis_main.func_801C87FC(c, m);
        L801CDC4C: ;
        c.RA = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x18u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDC5C(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.S0 = c.A1;
        c.RA = 0x801CDC78u;
        Courier_Crisis_main.func_801CDD80(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x44Cu));
        c.S0 = c.S0 >> 5;
        c.V0 = mem.ReadU32(c.V1);
        c.S0 = c.S0 << 16;
        c.V0 = c.V0 | 0x0088u;
        mem.WriteU32(c.V1, c.V0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x414u));
        c.V0 = c.S1 + 0x4u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x418u));
        c.S0 = c.S0 | 0x0020u;
        mem.WriteU32(c.V0, c.S0);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x444u));
        c.V0 = mem.ReadU32(c.S1);
        c.A0 = 0x01000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x41Cu));
        c.A0 = c.A0 | 0x0201u;
        mem.WriteU32(c.V0, c.A0);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDCF0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        mem.WriteU32((c.SP + 0x14u), c.S1);
        c.S1 = c.A0;
        mem.WriteU32((c.SP + 0x10u), c.S0);
        mem.WriteU32((c.SP + 0x18u), c.RA);
        c.S0 = c.A1;
        c.RA = 0x801CDD0Cu;
        Courier_Crisis_main.func_801CDE18(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x44Cu));
        c.V0 = mem.ReadU32(c.V1);
        c.S0 = c.S0 >> 5;
        c.V0 = c.V0 | 0x0088u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        c.S0 = c.S0 << 16;
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x420u));
        c.S0 = c.S0 | 0x0020u;
        mem.WriteU32(c.V0, c.S1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x424u));
        c.V1 = 0x01000000u;
        mem.WriteU32(c.V0, c.S0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        c.V1 = c.V1 | 0x0200u;
        mem.WriteU32(c.V0, c.V1);
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.S1 = mem.ReadU32((c.SP + 0x14u));
        c.S0 = mem.ReadU32((c.SP + 0x10u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDD80(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x448u));
        c.V0 = 0x00100000u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = mem.ReadU32(c.V1);
        c.V1 = 0x20000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            c.V0 = 0u;
            goto L801CDE08;
        }
        c.V0 = 0u;
        c.A0 = 0xFFFFFFFFu;
        L801CDDB0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        c.V0 = c.V0 - 0x1u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        if (c.V0 != c.A0) {
            goto L801CDDE8;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xB20u;
        c.RA = 0x801CDDE0u;
        Courier_Crisis_main.func_801CDEC8(c, m);
        c.V0 = 0xFFFFFFFFu;
        goto L801CDE08;
        L801CDDE8: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x448u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801CDDB0;
        }
        c.V0 = 0u;
        L801CDE08: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDE18(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x20u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x428u));
        c.V0 = 0x00100000u;
        mem.WriteU32((c.SP + 0x18u), c.RA);
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = mem.ReadU32(c.V1);
        c.V1 = 0x01000000u;
        c.V0 = c.V0 & c.V1;
        if (c.V0 == 0u) {
            c.V0 = 0u;
            goto L801CDEA0;
        }
        c.V0 = 0u;
        c.A0 = 0xFFFFFFFFu;
        L801CDE48: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        c.V0 = c.V0 - 0x1u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = mem.ReadU32((c.SP + 0x10u));
        if (c.V0 != c.A0) {
            goto L801CDE80;
        }
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xB30u;
        c.RA = 0x801CDE78u;
        Courier_Crisis_main.func_801CDEC8(c, m);
        c.V0 = 0xFFFFFFFFu;
        goto L801CDEA0;
        L801CDE80: ;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        c.V0 = mem.ReadU32(c.V0);
        c.V0 = c.V0 & c.V1;
        if (c.V0 != 0u) {
            c.V0 = 0u;
            goto L801CDE48;
        }
        c.V0 = 0u;
        L801CDEA0: ;
        c.RA = mem.ReadU32((c.SP + 0x18u));
        c.SP = c.SP + 0x20u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDEB0(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x448u));
        c.V0 = mem.ReadU32(c.V0);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CDEC8(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.SP = c.SP - 0x28u;
        c.A1 = c.A0;
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xBA0u;
        mem.WriteU32((c.SP + 0x24u), c.RA);
        mem.WriteU32((c.SP + 0x20u), c.S0);
        c.RA = 0x801CDEE4u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xB40u;
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x448u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x41Cu));
        c.S0 = mem.ReadU32(c.V0);
        c.A1 = mem.ReadU32(c.V1);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x414u));
        c.A1 = c.A1 >> 24;
        c.A2 = mem.ReadU32(c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x420u));
        c.A1 = c.A1 & 0x0001u;
        c.V0 = mem.ReadU32(c.V0);
        c.A2 = c.A2 >> 24;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.A3 = mem.ReadU32(c.V1);
        c.A2 = c.A2 & 0x0001u;
        c.RA = 0x801CDF40u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.A0 = 0x801C0000u;
        c.A0 = c.A0 + 0xB68u;
        c.A1 = ~(0u | c.S0);
        c.A1 = c.A1 >> 31;
        c.A2 = c.S0 >> 30;
        c.A2 = c.A2 & 0x0001u;
        c.A3 = c.S0 >> 29;
        c.A3 = c.A3 & 0x0001u;
        c.V0 = c.S0 >> 28;
        c.V0 = c.V0 & 0x0001u;
        mem.WriteU32((c.SP + 0x10u), c.V0);
        c.V0 = c.S0 >> 27;
        c.V0 = c.V0 & 0x0001u;
        mem.WriteU32((c.SP + 0x14u), c.V0);
        c.V0 = c.S0 >> 25;
        c.V0 = c.V0 & 0x0001u;
        c.S0 = c.S0 >> 23;
        c.S0 = c.S0 & 0x0001u;
        mem.WriteU32((c.SP + 0x18u), c.V0);
        mem.WriteU32((c.SP + 0x1Cu), c.S0);
        c.RA = 0x801CDF94u;
        Courier_Crisis_main.func_801C87FC(c, m);
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x448u));
        c.V0 = 0x80000000u;
        mem.WriteU32(c.V1, c.V0);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x41Cu));
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0x801D0000u;
        c.V0 = mem.ReadU32((c.V0 + 0x428u));
        mem.WriteU32(c.V0, 0u);
        c.V0 = 0u;
        c.V1 = 0x801D0000u;
        c.V1 = mem.ReadU32((c.V1 + 0x428u));
        c.A0 = 0x801D0000u;
        c.A0 = mem.ReadU32((c.A0 + 0x448u));
        c.V1 = mem.ReadU32(c.V1);
        c.V1 = 0x60000000u;
        mem.WriteU32(c.A0, c.V1);
        c.RA = mem.ReadU32((c.SP + 0x24u));
        c.S0 = mem.ReadU32((c.SP + 0x20u));
        c.SP = c.SP + 0x28u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTvlcSize(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.T0 = 0x801D0000u;
        c.T0 = c.T0 - 0x2008u;
        c.At = c.A0 - 0x1u;
        if ((int)c.At <= 0) {
            c.V0 = mem.ReadU32(c.T0);
            goto L801CE01C;
        }
        c.V0 = mem.ReadU32(c.T0);
        c.At = c.A0 << 1;
        mem.WriteU32(c.T0, c.At);
        return;
        L801CE01C: ;
        c.At = 0x00FF0000u;
        c.At = c.At | 0xFFFFu;
        mem.WriteU32(c.T0, c.At);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void DecDCTvlc(CpuContext c, IMemory m)
    {
        var mem = (PSMemory)m;
        c.T0 = 0x801D0000u;
        c.T0 = c.T0 - 0x2008u;
        c.A2 = 0x801D0000u;
        c.A2 = c.A2 + 0xC50u;
        c.A3 = 0x801E0000u;
        c.A3 = c.A3 + 0xC50u;
        if (c.A0 != 0u) {
            c.T1 = mem.ReadU32(c.T0);
            goto L801CE084;
        }
        c.T1 = mem.ReadU32(c.T0);
        c.T0 = 0x801D0000u;
        c.T0 = c.T0 - 0x1C94u;
        c.A0 = mem.ReadU32(c.T0);
        c.A1 = mem.ReadU32((c.T0 + 0x4u));
        c.V0 = mem.ReadU32((c.T0 + 0x8u));
        c.V1 = mem.ReadU32((c.T0 + 0xCu));
        c.T4 = mem.ReadU32((c.T0 + 0x10u));
        c.T5 = mem.ReadU32((c.T0 + 0x14u));
        c.T7 = mem.ReadU32((c.T0 + 0x18u));
        c.T8 = mem.ReadU32((c.T0 + 0x1Cu));
        c.T9 = mem.ReadU32((c.T0 + 0x20u));
        c.T1 = c.T1 + c.T1;
        if ((int)0u >= 0) {
            c.T6 = c.A1 + c.T1;
            goto L801CE1FC;
        }
        c.T6 = c.A1 + c.T1;
        L801CE084: ;
        c.T5 = 0u;
        c.T7 = 0u;
        c.T8 = 0u;
        c.T9 = 0u;
        c.T1 = c.T1 + c.T1;
        c.T6 = c.A1 + c.T1;
        c.T0 = mem.ReadU16(c.A0);
        c.T1 = mem.ReadU16((c.A0 + 0x2u));
        c.T4 = mem.ReadU16((c.A0 + 0x4u));
        c.T2 = mem.ReadU16((c.A0 + 0x6u));
        c.V0 = mem.ReadU16((c.A0 + 0x8u));
        c.V1 = mem.ReadU16((c.A0 + 0xAu));
        c.T2 = c.T2 - 0x3u;
        if ((int)c.T2 < 0) {
            c.T4 = c.T4 << 10;
            goto L801CE0C4;
        }
        c.T4 = c.T4 << 10;
        c.T5 = 0x00000001u;
        L801CE0C4: ;
        c.A0 = c.A0 + 0xCu;
        c.V0 = c.V0 << 16;
        c.V0 = c.V0 | c.V1;
        c.V1 = 0u;
        mem.WriteU16(c.A1, (ushort)c.T0);
        mem.WriteU16((c.A1 + 0x2u), (ushort)c.T1);
        c.A1 = c.A1 + 0x2u;
        L801CE0E0: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        if (c.T5 == 0u) {
            c.T0 = c.V0 >> 22;
            goto L801CE1B8;
        }
        c.T0 = c.V0 >> 22;
        c.At = c.T0 ^ 0x03FFu;
        if (c.At == 0u) {
            c.A1 = c.A1 + 0x2u;
            goto L801CE304;
        }
        c.A1 = c.A1 + 0x2u;
        c.At = c.T5 - 0x3u;
        if ((int)c.At < 0) {
            c.At = c.A2 - 0x400u;
            goto L801CE104;
        }
        c.At = c.A2 - 0x400u;
        c.At = c.At - 0x400u;
        L801CE104: ;
        c.T0 = c.V0 >> 24;
        c.T0 = c.T0 << 2;
        c.T0 = c.T0 + c.At;
        c.T1 = mem.ReadU16(c.T0);
        c.T2 = mem.ReadU16((c.T0 + 0x2u));
        c.T0 = 0u & 0u;
        if (c.T2 == 0u) {
            c.V0 = c.V0 << (int)(c.T1 & 31u);
            goto L801CE148;
        }
        c.V0 = c.V0 << (int)(c.T1 & 31u);
        c.At = 0x00000020u;
        c.At = c.At - c.T2;
        c.T0 = c.V0 >> (int)(c.At & 31u);
        if ((int)c.V0 < 0) {
            c.V0 = c.V0 << (int)(c.T2 & 31u);
            goto L801CE144;
        }
        c.V0 = c.V0 << (int)(c.T2 & 31u);
        c.T3 = 0xFFFFFFFFu;
        c.T3 = c.T3 >> (int)(c.At & 31u);
        c.T0 = c.T0 - c.T3;
        L801CE144: ;
        c.V1 = c.V1 + c.T2;
        L801CE148: ;
        c.V1 = c.V1 + c.T1;
        c.At = c.V1 & 0x0010u;
        if (c.At == 0u) {
            c.V1 = c.V1 & 0x000Fu;
            goto L801CE168;
        }
        c.V1 = c.V1 & 0x000Fu;
        c.T1 = mem.ReadU16(c.A0);
        c.A0 = c.A0 + 0x2u;
        c.T1 = c.T1 << (int)(c.V1 & 31u);
        c.V0 = c.V0 | c.T1;
        L801CE168: ;
        c.At = c.T5 - 0x2u;
        if ((int)c.At > 0) {
            c.T1 = c.T9 + c.T0;
            goto L801CE190;
        }
        c.T1 = c.T9 + c.T0;
        if (c.At == 0u) {
            c.T1 = c.T8 + c.T0;
            goto L801CE188;
        }
        c.T1 = c.T8 + c.T0;
        c.T1 = c.T7 + c.T0;
        if ((int)0u >= 0) {
            c.T7 = c.T7 + c.T0;
            goto L801CE194;
        }
        c.T7 = c.T7 + c.T0;
        L801CE188: ;
        if ((int)0u >= 0) {
            c.T8 = c.T8 + c.T0;
            goto L801CE194;
        }
        c.T8 = c.T8 + c.T0;
        L801CE190: ;
        c.T9 = c.T9 + c.T0;
        L801CE194: ;
        c.T1 = c.T1 << 2;
        c.T1 = c.T1 & 0x03FFu;
        c.T1 = c.T4 | c.T1;
        c.T5 = c.T5 + 0x1u;
        c.At = c.T5 - 0x7u;
        if (c.At != 0u) {
            mem.WriteU16(c.A1, (ushort)c.T1);
            goto L801CE1F0;
        }
        mem.WriteU16(c.A1, (ushort)c.T1);
        if ((int)0u >= 0) {
            c.T5 = c.T5 - 0x6u;
            goto L801CE1F0;
        }
        c.T5 = c.T5 - 0x6u;
        L801CE1B8: ;
        c.At = c.T0 ^ 0x01FFu;
        if (c.At == 0u) {
            c.A1 = c.A1 + 0x2u;
            goto L801CE304;
        }
        c.A1 = c.A1 + 0x2u;
        c.V0 = c.V0 << 10;
        c.V1 = c.V1 + 0xAu;
        c.At = c.V1 & 0x0010u;
        if (c.At == 0u) {
            c.V1 = c.V1 & 0x000Fu;
            goto L801CE1E8;
        }
        c.V1 = c.V1 & 0x000Fu;
        c.T1 = mem.ReadU16(c.A0);
        c.A0 = c.A0 + 0x2u;
        c.T1 = c.T1 << (int)(c.V1 & 31u);
        c.V0 = c.V0 | c.T1;
        L801CE1E8: ;
        c.T0 = c.T4 | c.T0;
        mem.WriteU16(c.A1, (ushort)c.T0);
        L801CE1F0: ;
        c.At = c.A1 - c.T6;
        if ((int)c.At >= 0) {
            c.A1 = c.A1 + 0x2u;
            goto L801CE338;
        }
        c.A1 = c.A1 + 0x2u;
        L801CE1FC: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        c.T0 = c.V0 >> 19;
        c.T0 = c.T0 << 3;
        c.T0 = c.T0 + c.A2;
        c.T1 = mem.ReadU32(c.T0);
        if (c.T1 != 0u) {
            c.At = c.T1 & 0x00FFu;
            goto L801CE258;
        }
        c.At = c.T1 & 0x00FFu;
        c.V0 = c.V0 << 8;
        c.V1 = c.V1 + 0x8u;
        c.At = c.V1 & 0x0010u;
        if (c.At == 0u) {
            c.V1 = c.V1 & 0x000Fu;
            goto L801CE23C;
        }
        c.V1 = c.V1 & 0x000Fu;
        c.T0 = mem.ReadU16(c.A0);
        c.A0 = c.A0 + 0x2u;
        c.T0 = c.T0 << (int)(c.V1 & 31u);
        c.V0 = c.V0 | c.T0;
        L801CE23C: ;
        c.T0 = c.V0 >> 23;
        c.T0 = c.T0 << 2;
        c.T0 = c.T0 + c.A3;
        c.T1 = mem.ReadU32(c.T0);
        c.T3 = 0u;
        if ((int)0u >= 0) {
            c.At = c.T1 & 0x00FFu;
            goto L801CE25C;
        }
        c.At = c.T1 & 0x00FFu;
        L801CE258: ;
        c.T3 = mem.ReadU32((c.T0 + 0x4u));
        L801CE25C: ;
        c.V0 = c.V0 << (int)(c.At & 31u);
        c.V1 = c.V1 + c.At;
        c.At = c.V1 & 0x0010u;
        if (c.At == 0u) {
            c.V1 = c.V1 & 0x000Fu;
            goto L801CE280;
        }
        c.V1 = c.V1 & 0x000Fu;
        c.T0 = mem.ReadU16(c.A0);
        c.A0 = c.A0 + 0x2u;
        c.T0 = c.T0 << (int)(c.V1 & 31u);
        c.V0 = c.V0 | c.T0;
        L801CE280: ;
        c.T1 = c.T1 >> 16;
        c.At = c.T1 ^ 0x7C1Fu;
        if (c.At == 0u) {
            c.At = c.T1 ^ 0xFE00u;
            goto L801CE2E0;
        }
        c.At = c.T1 ^ 0xFE00u;
        if (c.At == 0u) {
            mem.WriteU16(c.A1, (ushort)c.T1);
            goto L801CE0E0;
        }
        mem.WriteU16(c.A1, (ushort)c.T1);
        if (c.T3 == 0u) {
            c.A1 = c.A1 + 0x2u;
            goto L801CE1FC;
        }
        c.A1 = c.A1 + 0x2u;
        c.T2 = c.T3 & 0xFFFFu;
        c.At = c.T2 ^ 0x7C1Fu;
        if (c.At == 0u) {
            c.At = c.T2 ^ 0xFE00u;
            goto L801CE2E0;
        }
        c.At = c.T2 ^ 0xFE00u;
        if (c.At == 0u) {
            mem.WriteU16(c.A1, (ushort)c.T2);
            goto L801CE0E0;
        }
        mem.WriteU16(c.A1, (ushort)c.T2);
        c.T2 = c.T3 >> 16;
        if (c.T2 == 0u) {
            c.A1 = c.A1 + 0x2u;
            goto L801CE1FC;
        }
        c.A1 = c.A1 + 0x2u;
        c.At = c.T2 ^ 0x7C1Fu;
        if (c.At == 0u) {
            c.At = c.T2 ^ 0xFE00u;
            goto L801CE2E0;
        }
        c.At = c.T2 ^ 0xFE00u;
        if (c.At == 0u) {
            mem.WriteU16(c.A1, (ushort)c.T2);
            goto L801CE0E0;
        }
        mem.WriteU16(c.A1, (ushort)c.T2);
        if ((int)0u >= 0) {
            c.A1 = c.A1 + 0x2u;
            goto L801CE1FC;
        }
        c.A1 = c.A1 + 0x2u;
        L801CE2E0: ;
        c.T0 = c.V0 >> 16;
        mem.WriteU16(c.A1, (ushort)c.T0);
        c.A1 = c.A1 + 0x2u;
        c.T0 = mem.ReadU16(c.A0);
        c.A0 = c.A0 + 0x2u;
        c.V0 = c.V0 << 16;
        c.T0 = c.T0 << (int)(c.V1 & 31u);
        if ((int)0u >= 0) {
            c.V0 = c.V0 | c.T0;
            goto L801CE1FC;
        }
        c.V0 = c.V0 | c.T0;
        L801CE304: ;
        c.T0 = 0u | 0xFE00u;
        c.V0 = 0x00000040u;
        L801CE30C: ;
        RecompOne.Runtime.Interrupts.Poll(c, m);
        mem.WriteU16(c.A1, (ushort)c.T0);
        c.A1 = c.A1 + 0x2u;
        if (c.V0 != 0u) {
            c.V0 = c.V0 - 0x1u;
            goto L801CE30C;
        }
        c.V0 = c.V0 - 0x1u;
        c.T1 = c.SR;
        c.At = 0x00020000u;
        c.T1 = c.T1 | c.At;
        c.SR = c.T1;
        c.V0 = 0u;
        return;
        L801CE338: ;
        c.T0 = 0x801D0000u;
        c.T0 = c.T0 - 0x1C94u;
        mem.WriteU32(c.T0, c.A0);
        mem.WriteU32((c.T0 + 0x4u), c.A1);
        mem.WriteU32((c.T0 + 0x8u), c.V0);
        mem.WriteU32((c.T0 + 0xCu), c.V1);
        mem.WriteU32((c.T0 + 0x10u), c.T4);
        mem.WriteU32((c.T0 + 0x14u), c.T5);
        mem.WriteU32((c.T0 + 0x18u), c.T7);
        mem.WriteU32((c.T0 + 0x1Cu), c.T8);
        mem.WriteU32((c.T0 + 0x20u), c.T9);
        c.V0 = 0x00000001u;
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801CFB1C(CpuContext c, IMemory m)
    {
        Dispatcher.Call(c, m, 0u);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801E0DD0(CpuContext c, IMemory m)
    {
        Dispatcher.Call(c, m, c.At);
        return;
    }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    public static void func_801E0DD8(CpuContext c, IMemory m)
    {
        return;
    }
}

public sealed class MainDispatchTable : IOverlay
{
    public string Name => "main";
    public int LbaStart => -1;
    public uint Base => 0x00000000u;
    public uint Size => 0x0u;
    public IReadOnlyDictionary<uint, Action<CpuContext, IMemory>> Functions { get; } =
        new Dictionary<uint, Action<CpuContext, IMemory>>
        {
            [0x801C0BB0u] = Courier_Crisis_main.func_801C0BB0,
            [0x801C0BB8u] = Courier_Crisis_main.func_801C0BB8,
            [0x801C0C74u] = Courier_Crisis_main.func_801C0C74,
            [0x801C0D48u] = Courier_Crisis_main.func_801C0D48,
            [0x801C0E38u] = Courier_Crisis_main.func_801C0E38,
            [0x801C0F58u] = Courier_Crisis_main.func_801C0F58,
            [0x801C1088u] = Courier_Crisis_main.func_801C1088,
            [0x801C11DCu] = Courier_Crisis_main.func_801C11DC,
            [0x801C1560u] = Courier_Crisis_main.func_801C1560,
            [0x801C15A4u] = Courier_Crisis_main.func_801C15A4,
            [0x801C1618u] = Courier_Crisis_main.func_801C1618,
            [0x801C1F84u] = Courier_Crisis_main.func_801C1F84,
            [0x801C1F94u] = Courier_Crisis_main.func_801C1F94,
            [0x801C1FA4u] = Courier_Crisis_main.func_801C1FA4,
            [0x801C1FBCu] = Courier_Crisis_main.func_801C1FBC,
            [0x801C1FD4u] = Courier_Crisis_main.PadInit_main,
            [0x801C2024u] = Courier_Crisis_main.PadRead_main,
            [0x801C204Cu] = Courier_Crisis_main.PadStop_main,
            [0x801C206Cu] = Courier_Crisis_main.func_801C206C,
            [0x801C207Cu] = Courier_Crisis_main.func_801C207C,
            [0x801C208Cu] = Courier_Crisis_main.SetInitPadFlag_main,
            [0x801C209Cu] = Courier_Crisis_main.ReadInitPadFlag_main,
            [0x801C20ACu] = Courier_Crisis_main.PAD_init_main,
            [0x801C2148u] = Courier_Crisis_main.InitPAD_main,
            [0x801C21E4u] = Courier_Crisis_main.StartPAD_main,
            [0x801C2214u] = Courier_Crisis_main.StopPAD_main,
            [0x801C224Cu] = Courier_Crisis_main.func_801C224C,
            [0x801C22CCu] = Courier_Crisis_main.func_801C22CC,
            [0x801C2304u] = Courier_Crisis_main.func_801C2304,
            [0x801C236Cu] = Courier_Crisis_main.func_801C236C,
            [0x801C23ACu] = Courier_Crisis_main.func_801C23AC,
            [0x801C23BCu] = Courier_Crisis_main.func_801C23BC,
            [0x801C23CCu] = Courier_Crisis_main.func_801C23CC,
            [0x801C23DCu] = Courier_Crisis_main.func_801C23DC,
            [0x801C23ECu] = Courier_Crisis_main.EnterCriticalSection_main,
            [0x801C23FCu] = Courier_Crisis_main.ExitCriticalSection_main,
            [0x801C240Cu] = Courier_Crisis_main.func_801C240C,
            [0x801C241Cu] = Courier_Crisis_main.func_801C241C,
            [0x801C242Cu] = Courier_Crisis_main.EnablePAD_main,
            [0x801C2440u] = Courier_Crisis_main.DisablePAD_main,
            [0x801C2454u] = Courier_Crisis_main._patch_pad_main,
            [0x801C24BCu] = Courier_Crisis_main.func_801C24BC,
            [0x801C24CCu] = Courier_Crisis_main._SendPAD_main,
            [0x801C24F4u] = Courier_Crisis_main._send_pad_main,
            [0x801C258Cu] = Courier_Crisis_main._remove_ChgclrPAD_main,
            [0x801C25ECu] = Courier_Crisis_main.VSync_main,
            [0x801C2734u] = Courier_Crisis_main.func_801C2734,
            [0x801C27D0u] = Courier_Crisis_main.func_801C27D0,
            [0x801C27E0u] = Courier_Crisis_main.ResetCallback_main,
            [0x801C2810u] = Courier_Crisis_main.InterruptCallback_main,
            [0x801C2840u] = Courier_Crisis_main.DMACallback_main,
            [0x801C2870u] = Courier_Crisis_main.VSyncCallback_main,
            [0x801C28A4u] = Courier_Crisis_main.VSyncCallbacks_main,
            [0x801C28D4u] = Courier_Crisis_main.StopCallback_main,
            [0x801C2904u] = Courier_Crisis_main.RestartCallback_main,
            [0x801C2934u] = Courier_Crisis_main.CheckCallback_main,
            [0x801C2944u] = Courier_Crisis_main.GetIntrMask_main,
            [0x801C295Cu] = Courier_Crisis_main.SetIntrMask_main,
            [0x801C2978u] = Courier_Crisis_main.func_801C2978,
            [0x801C2A54u] = Courier_Crisis_main.func_801C2A54,
            [0x801C2C3Cu] = Courier_Crisis_main.func_801C2C3C,
            [0x801C2D90u] = Courier_Crisis_main.func_801C2D90,
            [0x801C2E3Cu] = Courier_Crisis_main.func_801C2E3C,
            [0x801C2EC4u] = Courier_Crisis_main.func_801C2EC4,
            [0x801C2EF0u] = Courier_Crisis_main.func_801C2EF0,
            [0x801C2F00u] = Courier_Crisis_main.func_801C2F00,
            [0x801C2F10u] = Courier_Crisis_main.func_801C2F10,
            [0x801C2F20u] = Courier_Crisis_main.startIntrVSync_main,
            [0x801C2F78u] = Courier_Crisis_main.func_801C2F78,
            [0x801C2FF0u] = Courier_Crisis_main.func_801C2FF0,
            [0x801C301Cu] = Courier_Crisis_main.func_801C301C,
            [0x801C3048u] = Courier_Crisis_main.startIntrDMA_main,
            [0x801C3098u] = Courier_Crisis_main.func_801C3098,
            [0x801C321Cu] = Courier_Crisis_main.func_801C321C,
            [0x801C32C4u] = Courier_Crisis_main.func_801C32C4,
            [0x801C32F0u] = Courier_Crisis_main.func_801C32F0,
            [0x801C3308u] = Courier_Crisis_main.func_801C3308,
            [0x801C3318u] = Courier_Crisis_main.LoadTPage_main,
            [0x801C3404u] = Courier_Crisis_main.LoadClut_main,
            [0x801C346Cu] = Courier_Crisis_main.LoadClut2_main,
            [0x801C34D4u] = Courier_Crisis_main.SetDefDrawEnv_main,
            [0x801C358Cu] = Courier_Crisis_main.SetDefDispEnv_main,
            [0x801C35C8u] = Courier_Crisis_main.GetTPage_main,
            [0x801C3604u] = Courier_Crisis_main.GetClut_main,
            [0x801C361Cu] = Courier_Crisis_main.DumpTPage_main,
            [0x801C367Cu] = Courier_Crisis_main.DumpClut_main,
            [0x801C36BCu] = Courier_Crisis_main.NextPrim_main,
            [0x801C36D8u] = Courier_Crisis_main.IsEndPrim_main,
            [0x801C36F4u] = Courier_Crisis_main.AddPrim_main,
            [0x801C3730u] = Courier_Crisis_main.AddPrims_main,
            [0x801C376Cu] = Courier_Crisis_main.CatPrim_main,
            [0x801C3790u] = Courier_Crisis_main.TermPrim_main,
            [0x801C37A8u] = Courier_Crisis_main.SetSemiTrans_main,
            [0x801C37D0u] = Courier_Crisis_main.SetShadeTex_main,
            [0x801C37F8u] = Courier_Crisis_main.SetPolyF3_main,
            [0x801C380Cu] = Courier_Crisis_main.SetPolyFT3_main,
            [0x801C3820u] = Courier_Crisis_main.SetPolyG3_main,
            [0x801C3834u] = Courier_Crisis_main.SetPolyGT3_main,
            [0x801C3848u] = Courier_Crisis_main.SetPolyF4_main,
            [0x801C385Cu] = Courier_Crisis_main.SetPolyFT4_main,
            [0x801C3870u] = Courier_Crisis_main.SetPolyG4_main,
            [0x801C3884u] = Courier_Crisis_main.SetPolyGT4_main,
            [0x801C3898u] = Courier_Crisis_main.SetSprt8_main,
            [0x801C38ACu] = Courier_Crisis_main.SetSprt16_main,
            [0x801C38C0u] = Courier_Crisis_main.SetSprt_main,
            [0x801C38D4u] = Courier_Crisis_main.SetTile1_main,
            [0x801C38E8u] = Courier_Crisis_main.SetTile8_main,
            [0x801C38FCu] = Courier_Crisis_main.SetTile16_main,
            [0x801C3910u] = Courier_Crisis_main.SetTile_main,
            [0x801C3924u] = Courier_Crisis_main.SetLineF2_main,
            [0x801C3938u] = Courier_Crisis_main.SetLineG2_main,
            [0x801C394Cu] = Courier_Crisis_main.SetLineF3_main,
            [0x801C396Cu] = Courier_Crisis_main.SetLineG3_main,
            [0x801C398Cu] = Courier_Crisis_main.SetLineF4_main,
            [0x801C39ACu] = Courier_Crisis_main.SetLineG4_main,
            [0x801C39CCu] = Courier_Crisis_main.SetDrawTPage_main,
            [0x801C39F8u] = Courier_Crisis_main.SetDrawMove_main,
            [0x801C3A58u] = Courier_Crisis_main.SetDrawLoad_main,
            [0x801C3AC4u] = Courier_Crisis_main.MargePrim_main,
            [0x801C3AFCu] = Courier_Crisis_main.DumpDrawEnv_main,
            [0x801C3C10u] = Courier_Crisis_main.DumpDispEnv_main,
            [0x801C3CBCu] = Courier_Crisis_main.ResetGraph_main,
            [0x801C3E40u] = Courier_Crisis_main.SetGraphReverse_main,
            [0x801C3F54u] = Courier_Crisis_main.SetGraphDebug_main,
            [0x801C3FB8u] = Courier_Crisis_main.SetGraphQueue_main,
            [0x801C4064u] = Courier_Crisis_main.GetGraphType_main,
            [0x801C4074u] = Courier_Crisis_main.GetGraphDebug_main,
            [0x801C4084u] = Courier_Crisis_main.DrawSyncCallback_main,
            [0x801C40E0u] = Courier_Crisis_main.SetDispMask_main,
            [0x801C417Cu] = Courier_Crisis_main.DrawSync_main,
            [0x801C41E8u] = Courier_Crisis_main.func_801C41E8,
            [0x801C4310u] = Courier_Crisis_main.ClearImage_main,
            [0x801C43A4u] = Courier_Crisis_main.ClearImage2_main,
            [0x801C4440u] = Courier_Crisis_main.LoadImage_main,
            [0x801C44A4u] = Courier_Crisis_main.StoreImage_main,
            [0x801C4508u] = Courier_Crisis_main.MoveImage_main,
            [0x801C45CCu] = Courier_Crisis_main.ClearOTag_main,
            [0x801C4684u] = Courier_Crisis_main.ClearOTagR_main,
            [0x801C471Cu] = Courier_Crisis_main.DrawPrim_main,
            [0x801C477Cu] = Courier_Crisis_main.DrawOTag_main,
            [0x801C47F0u] = Courier_Crisis_main.PutDrawEnv_main,
            [0x801C48F4u] = Courier_Crisis_main.DrawOTagEnv_main,
            [0x801C4A10u] = Courier_Crisis_main.GetDrawEnv_main,
            [0x801C4A48u] = Courier_Crisis_main.PutDispEnv_main,
            [0x801C4EF0u] = Courier_Crisis_main.GetDispEnv_main,
            [0x801C4F28u] = Courier_Crisis_main.GetODE_main,
            [0x801C4F58u] = Courier_Crisis_main.SetTexWindow_main,
            [0x801C4F94u] = Courier_Crisis_main.SetDrawArea_main,
            [0x801C5018u] = Courier_Crisis_main.SetDrawOffset_main,
            [0x801C505Cu] = Courier_Crisis_main.SetPriority_main,
            [0x801C5088u] = Courier_Crisis_main.SetDrawMode_main,
            [0x801C50E0u] = Courier_Crisis_main.SetDrawEnv_main,
            [0x801C52F8u] = Courier_Crisis_main.func_801C52F8,
            [0x801C5588u] = Courier_Crisis_main.func_801C5588,
            [0x801C55E0u] = Courier_Crisis_main.func_801C55E0,
            [0x801C56ACu] = Courier_Crisis_main.func_801C56AC,
            [0x801C5778u] = Courier_Crisis_main.func_801C5778,
            [0x801C57BCu] = Courier_Crisis_main.func_801C57BC,
            [0x801C5840u] = Courier_Crisis_main.func_801C5840,
            [0x801C58F0u] = Courier_Crisis_main.func_801C58F0,
            [0x801C5908u] = Courier_Crisis_main.func_801C5908,
            [0x801C59F0u] = Courier_Crisis_main.func_801C59F0,
            [0x801C5C4Cu] = Courier_Crisis_main.func_801C5C4C,
            [0x801C5E88u] = Courier_Crisis_main.func_801C5E88,
            [0x801C610Cu] = Courier_Crisis_main.func_801C610C,
            [0x801C6134u] = Courier_Crisis_main.func_801C6134,
            [0x801C6148u] = Courier_Crisis_main.func_801C6148,
            [0x801C6198u] = Courier_Crisis_main.func_801C6198,
            [0x801C61E4u] = Courier_Crisis_main.func_801C61E4,
            [0x801C6214u] = Courier_Crisis_main.func_801C6214,
            [0x801C6238u] = Courier_Crisis_main.func_801C6238,
            [0x801C6518u] = Courier_Crisis_main.func_801C6518,
            [0x801C6804u] = Courier_Crisis_main.func_801C6804,
            [0x801C6960u] = Courier_Crisis_main.func_801C6960,
            [0x801C6AA8u] = Courier_Crisis_main.func_801C6AA8,
            [0x801C6ADCu] = Courier_Crisis_main.func_801C6ADC,
            [0x801C6C48u] = Courier_Crisis_main.func_801C6C48,
            [0x801C6D24u] = Courier_Crisis_main.func_801C6D24,
            [0x801C6D50u] = Courier_Crisis_main.func_801C6D50,
            [0x801C6D60u] = Courier_Crisis_main.OpenTIM_main,
            [0x801C6D70u] = Courier_Crisis_main.ReadTIM_main,
            [0x801C6DD8u] = Courier_Crisis_main.OpenTMD_main,
            [0x801C6E18u] = Courier_Crisis_main.ReadTMD_main,
            [0x801C70C4u] = Courier_Crisis_main.func_801C70C4,
            [0x801C71E4u] = Courier_Crisis_main.func_801C71E4,
            [0x801C737Cu] = Courier_Crisis_main.func_801C737C,
            [0x801C8664u] = Courier_Crisis_main.InitGeom_main,
            [0x801C86ECu] = Courier_Crisis_main.SetGeomOffset_main,
            [0x801C870Cu] = Courier_Crisis_main._patch_gte_main,
            [0x801C87B4u] = Courier_Crisis_main.func_801C87B4,
            [0x801C87CCu] = Courier_Crisis_main.func_801C87CC,
            [0x801C87DCu] = Courier_Crisis_main.func_801C87DC,
            [0x801C87ECu] = Courier_Crisis_main.func_801C87EC,
            [0x801C87FCu] = Courier_Crisis_main.func_801C87FC,
            [0x801C880Cu] = Courier_Crisis_main.SpuInit_main,
            [0x801C882Cu] = Courier_Crisis_main._SpuInit_main,
            [0x801C8924u] = Courier_Crisis_main.SpuStart_main,
            [0x801C89A0u] = Courier_Crisis_main.func_801C89A0,
            [0x801C89B0u] = Courier_Crisis_main.func_801C89B0,
            [0x801C89C0u] = Courier_Crisis_main._spu_init_main,
            [0x801C8C54u] = Courier_Crisis_main.func_801C8C54,
            [0x801C8E20u] = Courier_Crisis_main._spu_FiDMA_main,
            [0x801C8EE0u] = Courier_Crisis_main._spu_Fr__main,
            [0x801C8F8Cu] = Courier_Crisis_main._spu_t_main,
            [0x801C921Cu] = Courier_Crisis_main._spu_Fw_main,
            [0x801C92A4u] = Courier_Crisis_main._spu_Fr_main,
            [0x801C930Cu] = Courier_Crisis_main._spu_FsetRXX_main,
            [0x801C9354u] = Courier_Crisis_main._spu_FsetRXXa_main,
            [0x801C93F8u] = Courier_Crisis_main._spu_FgetRXXa_main,
            [0x801C9434u] = Courier_Crisis_main._spu_FsetPCR_main,
            [0x801C9494u] = Courier_Crisis_main.func_801C9494,
            [0x801C94C0u] = Courier_Crisis_main.func_801C94C0,
            [0x801C94ECu] = Courier_Crisis_main._spu_Fw1ts_main,
            [0x801C9554u] = Courier_Crisis_main.func_801C9554,
            [0x801C9564u] = Courier_Crisis_main._SpuDataCallback_main,
            [0x801C9588u] = Courier_Crisis_main.SpuSetCommonMasterVolume,
            [0x801C95A8u] = Courier_Crisis_main.SpuSetCommonCDVolume,
            [0x801C95C4u] = Courier_Crisis_main.SpuSetCommonCDMix,
            [0x801C9608u] = Courier_Crisis_main.StSetRing,
            [0x801C9638u] = Courier_Crisis_main.CdInit_main,
            [0x801C96D0u] = Courier_Crisis_main.func_801C96D0,
            [0x801C96F8u] = Courier_Crisis_main.func_801C96F8,
            [0x801C9720u] = Courier_Crisis_main.func_801C9720,
            [0x801C9748u] = Courier_Crisis_main.CdStatus_main,
            [0x801C9758u] = Courier_Crisis_main.CdMode_main,
            [0x801C9768u] = Courier_Crisis_main.CdLastCom_main,
            [0x801C9778u] = Courier_Crisis_main.CdLastPos_main,
            [0x801C9788u] = Courier_Crisis_main.CdReset_main,
            [0x801C97F4u] = Courier_Crisis_main.CdFlush_main,
            [0x801C9814u] = Courier_Crisis_main.CdSetDebug_main,
            [0x801C982Cu] = Courier_Crisis_main.CdComstr_main,
            [0x801C9860u] = Courier_Crisis_main.CdIntstr_main,
            [0x801C9894u] = Courier_Crisis_main.CdSync_main,
            [0x801C98B4u] = Courier_Crisis_main.CdReady_main,
            [0x801C98D4u] = Courier_Crisis_main.CdSyncCallback_main,
            [0x801C98ECu] = Courier_Crisis_main.CdReadyCallback_main,
            [0x801C9904u] = Courier_Crisis_main.CdControl_main,
            [0x801C9A3Cu] = Courier_Crisis_main.CdControlF_main,
            [0x801C9B68u] = Courier_Crisis_main.CdControlB_main,
            [0x801C9CACu] = Courier_Crisis_main.CdMix_main,
            [0x801C9CCCu] = Courier_Crisis_main.CdGetSector_main,
            [0x801C9CECu] = Courier_Crisis_main.CdGetSector2_main,
            [0x801C9D0Cu] = Courier_Crisis_main.CdDataCallback_main,
            [0x801C9D30u] = Courier_Crisis_main.CdDataSync_main,
            [0x801C9D50u] = Courier_Crisis_main.CdIntToPos_main,
            [0x801C9E54u] = Courier_Crisis_main.CdPosToInt_main,
            [0x801C9ED4u] = Courier_Crisis_main.func_801C9ED4,
            [0x801CA45Cu] = Courier_Crisis_main.CD_sync_main,
            [0x801CA6DCu] = Courier_Crisis_main.CD_ready_main,
            [0x801CA9A8u] = Courier_Crisis_main.CD_cw_main,
            [0x801CADC4u] = Courier_Crisis_main.CD_vol_main,
            [0x801CAE4Cu] = Courier_Crisis_main.CD_flush_main,
            [0x801CAF2Cu] = Courier_Crisis_main.CD_initvol_main,
            [0x801CB020u] = Courier_Crisis_main.CD_initintr_main,
            [0x801CB070u] = Courier_Crisis_main.CD_init_main,
            [0x801CB25Cu] = Courier_Crisis_main.CD_datasync_main,
            [0x801CB3C8u] = Courier_Crisis_main.CD_getsector_main,
            [0x801CB4C8u] = Courier_Crisis_main.CD_getsector2_main,
            [0x801CB5B8u] = Courier_Crisis_main.CD_set_test_parmnum_main,
            [0x801CB5C8u] = Courier_Crisis_main.func_801CB5C8,
            [0x801CB6ACu] = Courier_Crisis_main.CdSearchFile,
            [0x801CB978u] = Courier_Crisis_main.func_801CB978,
            [0x801CB998u] = Courier_Crisis_main.func_801CB998,
            [0x801CBC78u] = Courier_Crisis_main.func_801CBC78,
            [0x801CBD20u] = Courier_Crisis_main.func_801CBD20,
            [0x801CBFCCu] = Courier_Crisis_main.func_801CBFCC,
            [0x801CC038u] = Courier_Crisis_main.func_801CC038,
            [0x801CC048u] = Courier_Crisis_main.func_801CC048,
            [0x801CC058u] = Courier_Crisis_main.func_801CC058,
            [0x801CC328u] = Courier_Crisis_main.func_801CC328,
            [0x801CC424u] = Courier_Crisis_main.func_801CC424,
            [0x801CC638u] = Courier_Crisis_main.CdReadBreak_main,
            [0x801CC6D4u] = Courier_Crisis_main.CdRead_main,
            [0x801CC7D8u] = Courier_Crisis_main.CdReadSync_main,
            [0x801CC8A4u] = Courier_Crisis_main.CdReadCallback_main,
            [0x801CC8BCu] = Courier_Crisis_main.CdReadMode_main,
            [0x801CC8D4u] = Courier_Crisis_main.CdRead2,
            [0x801CC968u] = Courier_Crisis_main.func_801CC968,
            [0x801CC988u] = Courier_Crisis_main.StClearRing,
            [0x801CC9E8u] = Courier_Crisis_main.data_ready_callback,
            [0x801CCA78u] = Courier_Crisis_main.StGetBackloc,
            [0x801CCAD8u] = Courier_Crisis_main.StSetStream,
            [0x801CCB60u] = Courier_Crisis_main.StFreeRing,
            [0x801CCC18u] = Courier_Crisis_main.init_ring_status,
            [0x801CCC54u] = Courier_Crisis_main.StGetNext,
            [0x801CCD18u] = Courier_Crisis_main.StSetMask,
            [0x801CCD38u] = Courier_Crisis_main.StCdInterrupt,
            [0x801CD6A8u] = Courier_Crisis_main.func_801CD6A8,
            [0x801CD6DCu] = Courier_Crisis_main.func_801CD6DC,
            [0x801CD898u] = Courier_Crisis_main.DecDCTReset,
            [0x801CD8D0u] = Courier_Crisis_main.DecDCTGetEnv,
            [0x801CD95Cu] = Courier_Crisis_main.DecDCTPutEnv,
            [0x801CD9F8u] = Courier_Crisis_main.DecDCTBufSize,
            [0x801CDA04u] = Courier_Crisis_main.DecDCTin,
            [0x801CDA80u] = Courier_Crisis_main.DecDCTout,
            [0x801CDAA0u] = Courier_Crisis_main.DecDCTinSync,
            [0x801CDADCu] = Courier_Crisis_main.DecDCToutSync,
            [0x801CDB18u] = Courier_Crisis_main.DecDCTinCallback,
            [0x801CDB3Cu] = Courier_Crisis_main.DecDCToutCallback,
            [0x801CDB60u] = Courier_Crisis_main.func_801CDB60,
            [0x801CDC5Cu] = Courier_Crisis_main.func_801CDC5C,
            [0x801CDCF0u] = Courier_Crisis_main.func_801CDCF0,
            [0x801CDD80u] = Courier_Crisis_main.func_801CDD80,
            [0x801CDE18u] = Courier_Crisis_main.func_801CDE18,
            [0x801CDEB0u] = Courier_Crisis_main.func_801CDEB0,
            [0x801CDEC8u] = Courier_Crisis_main.func_801CDEC8,
            [0x801CDFFCu] = Courier_Crisis_main.DecDCTvlcSize,
            [0x801CE02Cu] = Courier_Crisis_main.DecDCTvlc,
            [0x801CFB1Cu] = Courier_Crisis_main.func_801CFB1C,
            [0x801E0DD0u] = Courier_Crisis_main.func_801E0DD0,
            [0x801E0DD8u] = Courier_Crisis_main.func_801E0DD8,
        };
}
