using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ITaskScheduler.xml' path='doc/member[@name="ITaskScheduler"]/*' />
[NativeTypeName("struct ITaskScheduler : ISlangUnknown")]
public unsafe partial struct ITaskScheduler
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((ITaskScheduler*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((ITaskScheduler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((ITaskScheduler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITaskScheduler.xml' path='doc/member[@name="ITaskScheduler.submitTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::ITaskScheduler::TaskHandle")]
    public void* submitTask([NativeTypeName("rhi::ITaskScheduler::TaskHandle *")] void** parentTasks, [NativeTypeName("uint32_t")] uint parentTaskCount, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> run, void* payload)
    {
        return lpVtbl->submitTask((ITaskScheduler*)Unsafe.AsPointer(ref this), parentTasks, parentTaskCount, run, payload);
    }

    /// <include file='ITaskScheduler.xml' path='doc/member[@name="ITaskScheduler.releaseTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void releaseTask([NativeTypeName("rhi::ITaskScheduler::TaskHandle")] void* task)
    {
        lpVtbl->releaseTask((ITaskScheduler*)Unsafe.AsPointer(ref this), task);
    }

    /// <include file='ITaskScheduler.xml' path='doc/member[@name="ITaskScheduler.waitForCompletion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void waitForCompletion([NativeTypeName("rhi::ITaskScheduler::TaskHandle")] void* task)
    {
        lpVtbl->waitForCompletion((ITaskScheduler*)Unsafe.AsPointer(ref this), task);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITaskScheduler*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITaskScheduler*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITaskScheduler*, uint> release;

        [NativeTypeName("TaskHandle (TaskHandle *, uint32_t, void (*)(void *), void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITaskScheduler*, void**, uint, delegate* unmanaged[Cdecl]<void*, void>, void*, void*> submitTask;

        [NativeTypeName("void (TaskHandle) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITaskScheduler*, void*, void> releaseTask;

        [NativeTypeName("void (TaskHandle) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITaskScheduler*, void*, void> waitForCompletion;
    }
}
