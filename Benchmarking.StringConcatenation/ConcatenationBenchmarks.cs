using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.StringConcatenation
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ConcatenationBenchmarks
    {
        [Benchmark]
        public string StringsAddedByPlus() => StringConcatentions.AddStrings();

        [Benchmark]
        public string StringsConcatenated() => StringConcatentions.ConcatenateStrings();

        [Benchmark]
        public string StringsAggregatedByStringBuilder() => StringConcatentions.ConcatStringBuilderStrings();
    }
}
