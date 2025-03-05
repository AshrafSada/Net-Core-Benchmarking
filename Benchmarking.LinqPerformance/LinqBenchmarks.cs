using BenchmarkDotNet.Attributes;

namespace Benchmarking.LINQPerformance
{
    [MemoryDiagnoser()]
    public class LINQBenchmarks
    {
        private static readonly MockData Mocks = new MockData();

        [Benchmark] public List<string> GetProductNameForActive() => Mocks.GetProductNamesForActive();

        [Benchmark] public List<string> GetProductNameForEachActive() => Mocks.GetProductNamesForEachActive();

        [Benchmark] public List<string> GetProductNameLinqToActive() => Mocks.GetProductNamesLinqToActive();
    }
}
