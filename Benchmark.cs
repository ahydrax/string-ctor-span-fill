using BenchmarkDotNet.Attributes;

namespace StringCtorSpanFill
{
    public class Benchmark
    {
        [Params(1, 2, 4, 5, 8, 10, 11, 12, 16, 17, 32, 100, 103, 128)]
        //[Params(1, 2, 4, 5, 8, 10, 11, 12, 16, 17)]
        //[Params(100)]
        public int Count;

        [Benchmark]
        public string CreateNewString() => new('j', Count);
    }

    public class Benchmark2
    {
        [Benchmark]
        public string[] CreateNewString_AssumedWithoutHotPath()
            => new[]
            {
                new string('j', 12),
                new string(' ', 16),
                new string('a', 1),
                new string('b', 2),
                new string(' ', 3),
                new string('\t', 4),
                new string('z', 100),
                new string('y', 103),
                new string('e', 5),
                new string('f', 7),
                new string(' ', 8),
                new string('h', 10),
                new string('j', 11),
                new string('x', 17),
                new string('x', 32),
                new string('u', 128)
            };
    }
}
