using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.StringConcatenation
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public static class ConcatenationBenchmarks
    {
        [Benchmark]
        public static string StringConcatenateByAppendToStringBuilder() =>
                    StringConcatenations.ConcatenateByAppendToStringBuilder();

        [Benchmark]
        public static string StringConcatenateByDirectAdding() =>
                    StringConcatenations.ConcatenateByDirectAdding();

        [Benchmark]
        public static string StringConcatenateByRawStringLiteralsByAddition() =>
                    StringConcatenations.ConcatenateByRawStringLiteralsByAddition();

        [Benchmark]
        public static string StringConcatenateByRawStringLiteralsByInterpolation() =>
                    StringConcatenations.ConcatenateByRawStringLiteralsByInterpolation();

        [Benchmark]
        public static string StringConcatenateByStringConcatFunc() =>
                    StringConcatenations.ConcatenateByStringConcatFunc();

        [Benchmark]
        public static string StringConcatenateByStringInterpolation() =>
                    StringConcatenations.ConcatenateByStringInterpolation();

        [Benchmark]
        public static string StringConcatenateByStringJoin() =>
                    StringConcatenations.ConcatenateByStringJoin();

        [Benchmark]
        public static string StringConcatenateByUsingStringFormatFunc() =>
                    StringConcatenations.ConcatenateByUsingStringFormatFunc();
    }
}
