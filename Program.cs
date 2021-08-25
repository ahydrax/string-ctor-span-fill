using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Running;
using StringCtorSpanFill;

Console.WriteLine(Vector<byte>.Count);
Console.WriteLine(RuntimeHelpers.IsReferenceOrContainsReferences<char>()) ;
Console.WriteLine(!Vector.IsHardwareAccelerated) ;
Console.WriteLine(Unsafe.SizeOf<char>() > Vector<byte>.Count);
Console.WriteLine(!BitOperations.IsPow2(Unsafe.SizeOf<char>()));

BenchmarkSwitcher.FromAssembly(typeof(Benchmark).Assembly).Run(args);
