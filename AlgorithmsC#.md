
# Algorithms - C#
## Fast Inverse Squere Root aka Quake  III Algorithm
Following has some minor improvements over the original ( see [youtube](https://www.youtube.com/watch?v=p8u_k2LIZyo), see [stackoverflow](https://stackoverflow.com/questions/268853/is-it-possible-to-write-quakes-fast-invsqrt-function-in-c) ). Original was using an inferior constant value ```0x5f3759df``` ( see [paper](http://www.lomont.org/papers/2003/InvSqrt.pdf) ) and unsafe pointer casts. Furthermore, the readability of the document has been improved by separating functionality into three methods. By default, compile-time optimizations would inline method calls in Release config, but optional implementation attribute ```AggressiveInlining``` ensures that we will not lose performance.
```c#
using static System.BitConverter;
using System.Runtime.CompilerServices;

public float InvSqrt(float x) => NewtonMethod(InvSqrtFast(x), 0.5f * x);
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float InvSqrtFast(float x) => Int32BitsToSingle(0x5f375a86 - (SingleToInt32Bits(x) >> 1));
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float NewtonMethod(float x, float half) => x * (1.5f - half * x * x);
```