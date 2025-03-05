using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.StringConcatenation
{
   [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
   public class ConcatenationBenchmarks
   {
      [Benchmark] public string StringsAddedByPlus() => StringConcatenations.AddStrings();

      [Benchmark] public string StringsConcatenated() => StringConcatenations.ConcatenateStrings();

      [Benchmark] public string StringsAggregatedByStringBuilder() => StringConcatenations.ConcatStringBuilderStrings();

      [Benchmark] public string StringsAggregatedByStringFormat() => StringConcatenations.ConcatStringWithStringFormat();

      [Benchmark] public string StringsAggregatedByStringInterpolation() => StringConcatenations.ConcatStringWithStringInterpolation();
   }
}
