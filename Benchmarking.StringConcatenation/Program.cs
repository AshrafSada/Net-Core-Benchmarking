using BenchmarkDotNet.Running;

namespace Benchmarking.StringConcatenation
{
    internal static class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run<ConcatenationBenchmarks>();

            Console.ReadKey();
        }
    }
}
