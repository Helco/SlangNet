using System;
using System.Text;
using System.Runtime.InteropServices;
using SlangNet.Unsafe;

namespace SlangNet;

internal unsafe static class InteropUtils
{
    public static string? BlobToString(ISlangBlob* blob)
    {
        if (blob == null)
            return null;
        var pointer = blob->getBufferPointer();
        if (pointer == null)
            return null;
        var size = checked((int)blob->getBufferSize().ToUInt64());
        if (size == 0)
            return "";
        return Encoding.UTF8.GetString((byte*)pointer, size);
    }

    public static string? GetAsString(this COMPointer<ISlangBlob> pointer) => BlobToString(pointer);

    public static string? PtrToStringUTF8(void* ptr)
#if NETSTANDARD2_2_OR_GREATER
        => Marshal.PtrToStringUTF8(new(ptr));
#else
    {
        if (ptr == null)
            return null;
        var length = StrLen(ptr);
        if (length == 0)
            return "";
        return Encoding.UTF8.GetString((byte*)ptr, length);
    }
#endif

    // if somebody knows a better/native API usable in .NET Standard 2.0, send a PR
    public static int StrLen(void* ptrRaw)
    {
        if (ptrRaw == null)
            return 0;
        int length = 0;
        byte* ptr = (byte*)ptrRaw;
        for (; *ptr != 0; ptr++, length++) ;
        return length;
    }
}
