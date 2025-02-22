using BenchmarkDotNet.Running;

namespace Benchmarking.LingPerformance
{
    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<LinqBenchmarks>();
        }
    }
}
