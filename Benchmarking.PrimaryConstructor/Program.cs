using BenchmarkDotNet.Running;

namespace Benchmarking.PrimaryConstructor
{
    internal static class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run<PrimaryConstructorBenchmarker>();
            Console.ReadKey();
        }
    }
}
