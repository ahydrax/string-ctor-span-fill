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
        [Arguments('j', 12)]
        [Arguments(' ', 16)]
        [Arguments('a', 1)]
        [Arguments('b', 2)]
        [Arguments(' ', 3)]
        [Arguments('\t', 4)]
        [Arguments('z', 100)]
        [Arguments('y', 103)]
        [Arguments('e', 5)]
        [Arguments('f', 7)]
        [Arguments('e', 5)]
        [Arguments('u', 128)]
        [Arguments('h', 10)]
        [Arguments('j', 11)]
        [Arguments(' ', 8)]
        [Arguments('x', 32)]
        [Arguments('x', 17)]
        public string CreateNewString_AssumedWithoutHotPath(char c, int len) => new(c, len);

        /// <summary>
        /// Regression test for hot path when char is \0
        /// </summary>
        /// <param name="c"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        [Benchmark]
        [Arguments('\0', 12)]
        [Arguments('\0', 16)]
        [Arguments('\0', 1)]
        [Arguments('\0', 2)]
        [Arguments('\0', 3)]
        [Arguments('\0', 4)]
        [Arguments('\0', 100)]
        [Arguments('\0', 103)]
        [Arguments('\0', 5)]
        [Arguments('\0', 7)]
        [Arguments('\0', 5)]
        [Arguments('\0', 128)]
        [Arguments('\0', 10)]
        [Arguments('\0', 11)]
        [Arguments('\0', 8)]
        [Arguments('\0', 32)]
        [Arguments('\0', 17)]
        public string CreateNewStringZeroChar_AssumedWithoutHotPath(char c, int len) => new(c, len);
    }

    /// <summary>
    /// What if every argument of ctor is passed as const literal?
    /// </summary>
    public class Benchmark3
    {
        [Benchmark]
        public string CreateNewStringConstLength_1() => new(' ', 1);
        
        [Benchmark]
        public string CreateNewStringConstLength_5() => new(' ', 5);

        [Benchmark]
        public string CreateNewStringConstLength_16() => new(' ', 16);

        [Benchmark]
        public string CreateNewStringConstLength_19() => new(' ', 19);

        [Benchmark]
        public string CreateNewStringConstLength_32() => new(' ', 32);

        [Benchmark]
        public string CreateNewStringConstLength_128() => new(' ', 128);
        
        [Benchmark]
        public string CreateNewStringConstLength_ZeroChar_1() => new('\0', 1);
        
        [Benchmark]
        public string CreateNewStringConstLength_ZeroChar_5() => new('\0', 5);

        [Benchmark]
        public string CreateNewStringConstLength_ZeroChar_16() => new('\0', 16);

        [Benchmark]
        public string CreateNewStringConstLength_ZeroChar_19() => new('\0', 19);

        [Benchmark]
        public string CreateNewStringConstLength_ZeroChar_32() => new('\0', 32);

        [Benchmark]
        public string CreateNewStringConstLength_ZeroChar_128() => new('\0', 128);
    }

    public class Benchmark4
    {
        [Benchmark]
        public string[] GenerateNewStrings()
            => new[]
            {
                new string(' ', 8),
                new string('a', 1),
                new string('\0', 8),
                new string('0', 8),
                new string(' ', 16),
                new string('b', 7),
                new string('X', 5),
                new string('\0', 32),
                new string('O', 11),
                new string('\t', 2),
                new string('x', 131),
                new string('j', 17),
                new string('\0', 1),
                new string('N', 32),
                new string(' ', 10),
                new string('k', 19),
                new string('\n', 27)
            };
    }
}
