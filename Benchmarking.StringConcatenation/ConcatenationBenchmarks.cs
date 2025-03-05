using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.StringConcatenation
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ConcatenationBenchmarks
    {
        [Benchmark]
        public string StringConcatenateByAppendToStringBuilder() =>
                    StringConcatenations.ConcatenateByAppendToStringBuilder();

        [Benchmark]
        public string StringConcatenateByDirectAdding() =>
                    StringConcatenations.ConcatenateByDirectAdding();

        [Benchmark]
        public string StringConcatenateByRawStringLiteralsByAddition() =>
                    StringConcatenations.ConcatenateByRawStringLiteralsByAddition();

        [Benchmark]
        public string StringConcatenateByRawStringLiteralsByInterpolation() =>
                    StringConcatenations.ConcatenateByRawStringLiteralsByInterpolation();

        [Benchmark]
        public string StringConcatenateByStringConcatFunc() =>
                    StringConcatenations.ConcatenateByStringConcatFunc();

        [Benchmark]
        public string StringConcatenateByStringInterpolation() =>
                    StringConcatenations.ConcatenateByStringInterpolation();

        [Benchmark]
        public string StringConcatenateByStringJoin() =>
                    StringConcatenations.ConcatenateByStringJoin();

        [Benchmark]
        public string StringConcatenateByUsingStringFormatFunc() =>
                    StringConcatenations.ConcatenateByUsingStringFormatFunc();
    }
}
