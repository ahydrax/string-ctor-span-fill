using BenchmarkDotNet.Attributes;

namespace StringCtorSpanFill
{
    public class Benchmark
    {
        [Params(1, 2, 4, 5, 8, 10, 11, 12, 16, 100, 103, 128)]
        //[Params(100)]
        public int Count;


        [Benchmark]
        public string CreateNewString() => new('j', Count);
    }
}