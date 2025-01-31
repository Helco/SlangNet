using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using SlangNet.RHI.Unsafe;
using SlangNet.Unsafe;

namespace SlangNet.Example.RHI.HelloWorld.Unsafe;

internal unsafe class HelloWorldUnsafe
{
    public static void Main(string[] args)
    {
        var rhi = SlangRHI.getRHI();
        Console.WriteLine($"Hello World at {(ulong)rhi:X8}");
        foreach (var deviceType in Enum.GetValues<DeviceType>())
        {
            var isSupported = rhi->isDeviceTypeSupported(deviceType);
            if (!isSupported)
                continue;
            Console.WriteLine($"{deviceType}:");
            ISlangBlob* adaptersBlob = null;
            var result = new SlangResult(rhi->getAdapters(deviceType, &adaptersBlob));
            if (result.Failed)
            {
                Console.WriteLine($"  Failed to get adapters: {result}");
                Console.WriteLine();
                continue;
            }
            
            var address = adaptersBlob->getBufferPointer();
            var rawSize = adaptersBlob->getBufferSize();
            var adapters = new ReadOnlySpan<AdapterInfo>(address, (int)rawSize / sizeof(AdapterInfo));
            if (adapters.IsEmpty)
                Console.WriteLine("  No adapters");
            else
            {
                foreach (ref readonly var adapter in adapters)
                {
                    ReadOnlySpan<byte> nameSpan = MemoryMarshal.AsBytes((ReadOnlySpan<sbyte>)adapter.name);
                    var name = Encoding.UTF8.GetString(nameSpan.TrimEnd((byte)0));
                    Console.WriteLine($"  \"{name}\" ID:{adapter.deviceID:X8} Vendor:{adapter.vendorID:X8}");
                }
            }
                        
            Console.WriteLine();
        }
    }
}
