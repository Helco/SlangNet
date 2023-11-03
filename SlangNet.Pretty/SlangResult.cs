using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

[StructLayout(LayoutKind.Sequential, Pack = 4, Size = sizeof(int))]
public readonly record struct SlangResult(int RawValue)
{
    public const ushort FacilityWinGeneral = 0;
    public const ushort FacilityWinInterface = 4;
    public const ushort FacilityWinAPI = 7;
    public const ushort FacilityCore = 0x200;
    public const ushort FacilityInternal = 0x201;
    public const ushort FacilityExternalBase = 0x210;

    /// <summary>indicates success, and is equivalent to default</summary>
    public static readonly SlangResult Ok = new(SLANG_OK);
    /// <summary>generic failure code - meaning a serious error occurred and the call couldn't complete</summary>
    public static readonly SlangResult Fail = new(SLANG_FAIL);
    /// <summary>Functionality is not implemented</summary>
    public static readonly SlangResult NotImplemented = new(SLANG_E_NOT_IMPLEMENTED);
    /// <summary>Interface not be found</summary>
    public static readonly SlangResult NoInterface = new(SLANG_E_NO_INTERFACE);
    /// <summary>Operation was aborted (did not correctly complete)</summary>
    public static readonly SlangResult Abort = new(SLANG_E_ABORT);
    /// <summary>Indicates that a handle passed in as aparameter to a method is invalid</summary>
    public static readonly SlangResult InvalidHandle = new(SLANG_E_INVALID_HANDLE);
    /// <summary>Indicates that an argument passed in as parameter to a method is invalid</summary>
    public static readonly SlangResult InvalidArg = new(SLANG_E_INVALID_ARG);
    /// <summary>Operation could not complete - ran out of memory</summary>
    public static readonly SlangResult OutOfMemory = new(SLANG_E_OUT_OF_MEMORY);
    /// <summary>Supplied buffer is too small to be able to complete</summary>
    public static readonly SlangResult BufferTooSmall = new(SLANG_E_BUFFER_TOO_SMALL);
    /// <summary>Used to identify a Result that has yet to be initialized.</summary>
    /// <remarks>It defaults to failure such that if used incorrectly will fail, as similar in concept to using an uninitialized variable.</remarks>
    public static readonly SlangResult Uninitialized = new (SLANG_E_UNINITIALIZED);
    /// <summary>Returned from an async method meaning the output is invalid (thus an error), but a result for the request is pending, and will be returned on a subsequent call with the async handle.</summary>
    public static readonly SlangResult Pending = new (SLANG_E_PENDING);
    /// <summary>Indicates a file/resource could not be opened</summary>
    public static readonly SlangResult CannotOpen = new (SLANG_E_CANNOT_OPEN);
    /// <summary>Indicates a file/resource could not be found</summary>
    public static readonly SlangResult NotFound = new (SLANG_E_NOT_FOUND);
    /// <summary>An unhandled internal failure (typically from unhandled exception)</summary>
    public static readonly SlangResult InternalFail = new (SLANG_E_INTERNAL_FAIL);
    /// <summary>Could not complete because some underlying feature (hardware or software) was not available </summary>
    public static readonly SlangResult NotAvailable = new (SLANG_E_NOT_AVAILABLE);
    /// <summary>Could not complete because the operation times out. </summary>
    public static readonly SlangResult TimeOut = new (SLANG_E_TIME_OUT);

    public bool Succeeded => RawValue >= 0;
    public bool Failed => RawValue < 0;
    public ushort Facility => (ushort)((RawValue >> 16) & 0x7FFF);
    public ushort Code => (ushort)(RawValue & 0xFFFF);

    public SlangResult(bool success, ushort facility, ushort code)
        : this((facility << 16) | code | (success ? 0 : -1))
    {
        if (facility >= 0x8000)
            throw new ArgumentOutOfRangeException(nameof(facility));
    }

    public static implicit operator bool(SlangResult r) => r.Succeeded;
    public static bool operator true(SlangResult r) => r.Succeeded;
    public static bool operator false(SlangResult r) => r.Failed;

    public override string ToString()
    {
        if (this == Ok) return nameof(Ok);
        else if (Facility < FacilityCore)
        {
            var winException = Marshal.GetExceptionForHR(RawValue);
            if (winException != null)
                return winException.Message;
        }
        else if (this == BufferTooSmall) return nameof(BufferTooSmall);
        else if (this == Uninitialized) return nameof(Uninitialized);
        else if (this == Pending) return nameof(Pending);
        else if (this == CannotOpen) return nameof(CannotOpen);
        else if (this == NotFound) return nameof(NotFound);
        else if (this == InternalFail) return nameof(InternalFail);
        else if (this == NotAvailable) return nameof(NotAvailable);
        else if (this == TimeOut) return nameof(TimeOut);

        var builder = new StringBuilder();
        if (Succeeded)
            builder.Append("Success,");
        builder.Append(Facility switch
        {
            FacilityCore => "SlangCore",
            FacilityInternal => "SlangInternal",
            _ => Facility.ToString("X4")
        });
        builder.Append(',');
        builder.Append(Code.ToString("X4"));
        return builder.ToString();
    }

    public void ThrowIfFailed()
    {
        if (Succeeded)
            return;
        if (Facility < FacilityCore)
            Marshal.ThrowExceptionForHR(RawValue, new IntPtr(-1));

        var message = $"Slang operation returned an error: {this}";
        if (this == BufferTooSmall) throw new ArgumentException(message);
        if (this == CannotOpen) throw new IOException(message, RawValue);
        if (this == NotFound) throw new FileNotFoundException(message);
        if (this == TimeOut) throw new TimeoutException(message);
        throw new SlangException(message, this);
    }
}

public sealed class SlangException : Exception
{
    public SlangResult Result => new(HResult);

    public SlangException() : this(SlangResult.Fail) { }

    public SlangException(SlangResult result) : this(result.ToString(), result) { }

    internal SlangException(string message, SlangResult result) : base(message)
    {
        HResult = result.RawValue;
    }

    public SlangException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public SlangException(string message) : this(message, SlangResult.Fail)
    {
    }
}
