using BenchmarkDotNet.Attributes;

namespace Benchmarking.LingPerformance
{
    [MemoryDiagnoser()]
    public class LinqBenchmarks
    {
        private static readonly MockData Mocks = new MockData();

        public LinqBenchmarks()
        { }

       // [Benchmark] public int ActiveProductsCountWhere() => Mocks.GetProductsWhereActive();

       // [Benchmark] public int ActiveProductsCount() => Mocks.GetProductsCountActive();

       // [Benchmark] public int GetProductsForActive() => Mocks.GetProductsCountForActive();

       // [Benchmark] public int GetProductsForEachActive() => Mocks.GetProductsCountForEachActive();

        [Benchmark] public List<String> GetProductNameForActive() => Mocks.GetProductNamesForActive();

        [Benchmark] public List<String> GetProductNameForEachActive() => Mocks.GetProductNamesForEachActive();

        [Benchmark] public List<String> GetProductNameLinqToActive() => Mocks.GetProductNamesLinqToActive();
    }
}