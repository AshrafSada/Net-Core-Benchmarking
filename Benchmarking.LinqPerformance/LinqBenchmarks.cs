using BenchmarkDotNet.Attributes;

namespace Benchmarking.LingPerformance
{
    [MemoryDiagnoser()]
    public class LinqBenchmarks
    {
        private static readonly MockData Mocks = new MockData();

        [Benchmark] public List<String> GetProductNameForActive() => Mocks.GetProductNamesForActive();

        [Benchmark] public List<String> GetProductNameForEachActive() => Mocks.GetProductNamesForEachActive();

        [Benchmark] public List<String> GetProductNameLinqToActive() => Mocks.GetProductNamesLinqToActive();
    }
}
