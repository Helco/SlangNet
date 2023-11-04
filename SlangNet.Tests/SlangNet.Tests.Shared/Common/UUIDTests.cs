using SlangNet.Unsafe;
using NUnit.Framework;

namespace SlangNet.Tests;

public class UUIDTests
{
    [Test]
    public unsafe void Roundtrip()
    {
        //0x87ede0e1, 0x4852, 0x44b0, { 0x8b, 0xf2, 0xcb, 0x31, 0x87, 0x4d, 0xe2, 0x39
        //87ede0e1-4852-44b0-8bf2cb31874de239

        var uuid = SlangUUID.FromComponents(0x87ede0e1, 0x4852, 0x44b0, 0x8b, 0xf2, 0xcb, 0x31, 0x87, 0x4d, 0xe2, 0x39);

        Assert.That(uuid.data1, Is.EqualTo(0x87ede0e1));
        Assert.That(uuid.data2, Is.EqualTo(0x4852));
        Assert.That(uuid.data3, Is.EqualTo(0x44b0));

        var guid = uuid.ToGuid();
        Assert.That(guid.ToString(), Is.EqualTo("87ede0e1-4852-44b0-8bf2-cb31874de239"));

        var uuid2 = SlangUUID.FromGuid(guid);
        Assert.That(uuid2.data1, Is.EqualTo(uuid.data1));
        Assert.That(uuid2.data2, Is.EqualTo(uuid.data2));
        Assert.That(uuid2.data3, Is.EqualTo(uuid.data3));

        Assert.That(new ReadOnlySpan<byte>(uuid2.data4, 8).ToArray(),
            Is.EquivalentTo(new ReadOnlySpan<byte>(uuid.data4, 8).ToArray()));
    }
}
