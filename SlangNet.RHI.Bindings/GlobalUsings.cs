namespace SlangNet.RHI.Unsafe
{
    static unsafe class Unsafe
    {
        public static void* AsPointer<T>(ref T value) =>
            System.Runtime.CompilerServices.Unsafe.AsPointer(ref value);
    }
}
