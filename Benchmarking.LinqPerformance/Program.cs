using BenchmarkDotNet.Running;

namespace Benchmarking.LINQPerformance
{
    internal static class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run<LINQBenchmarks>();
            Console.ReadKey();
        }
    }
}
