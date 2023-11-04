using System;

namespace SlangNet.Unsafe;

partial struct SlangUUID
{
    public static unsafe SlangUUID FromComponents(
        uint a, ushort b, ushort c,
        byte d0, byte d1, byte d2, byte d3, byte d4, byte d5, byte d6, byte d7)
    {
        var uuid = new SlangUUID()
        {
            data1 = a,
            data2 = b,
            data3 = c
        };
        uuid.data4[0] = d0;
        uuid.data4[1] = d1;
        uuid.data4[2] = d2;
        uuid.data4[3] = d3;
        uuid.data4[4] = d4;
        uuid.data4[5] = d5;
        uuid.data4[6] = d6;
        uuid.data4[7] = d7;
        return uuid;
    }

    public static SlangUUID FromGuid(Guid g)
    {
        // SlangUUID uses natively-ordered constants while System.Guid is always little-endian
        // therefore we have to correct for it
        var d = g.ToByteArray();
        var a = BitConverter.ToUInt32(d, 0);
        var b = BitConverter.ToUInt16(d, 4);
        var c = BitConverter.ToUInt16(d, 6);
        if (!BitConverter.IsLittleEndian)
        {
            a = Swap(a);
            b = Swap(b);
            c = Swap(c);
        }
        return FromComponents(a, b, c, d[8], d[9], d[10], d[11], d[12], d[13], d[14], d[15]);
    }

    public unsafe Guid ToGuid() => new Guid(
        unchecked((int)data1),
        unchecked((short)data2),
        unchecked((short)data3),
        data4[0], data4[1], data4[2], data4[3], data4[4], data4[5], data4[6], data4[7]);

    private static uint Swap(uint a)
    {
        a = (a >> 16) | (a << 16);
        a = ((a & 0xff00ff00) >> 8) | ((a & 0x00ff00ff) << 8);
        return a;
    }

    private static ushort Swap(ushort a) =>
        (ushort)((a >> 8) | (a << 8));
}
