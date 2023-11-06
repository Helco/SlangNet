using System;
using System.Runtime.InteropServices;

namespace SlangNet;

internal unsafe struct Utf8String : IDisposable
{
    public static implicit operator sbyte*(Utf8String self) => self.Memory;

#if NETSTANDARD2_1_OR_GREATER
    public sbyte* Memory { get; private set; }
    public sbyte* MemoryEnd { get; private set; }

    public Utf8String(string? text)
    {
        Memory = (sbyte*)Marshal.StringToCoTaskMemUTF8(text);
        MemoryEnd = Memory + InteropUtils.StrLen(Memory);
    }

    public void Dispose()
    {
        if (Memory != null)
        {
            Marshal.FreeCoTaskMem(new(Memory));
            Memory = MemoryEnd = null;
        }
    }

#else
    private GCHandle handle;
    public sbyte* Memory => handle == default
        ? null
        : (sbyte*)handle.AddrOfPinnedObject();
    public sbyte* MemoryEnd { get; }

    public Utf8String(string? text)
    {
        handle = default;
        if (text == null)
            return;
        var bytes = System.Text.Encoding.UTF8.GetBytes(text);
        handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        MemoryEnd = Memory + bytes.Length;
    }

    public void Dispose()
    {
        if (handle != default)
        {
            handle.Free();
            handle = default;
        }
    }
#endif
}
