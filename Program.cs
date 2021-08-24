using BenchmarkDotNet.Running;
using StringCtorSpanFill;

BenchmarkSwitcher.FromAssembly(typeof(Benchmark).Assembly).Run(args);
