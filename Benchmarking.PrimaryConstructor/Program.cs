using BenchmarkDotNet.Running;

namespace Benchmarking.PrimaryConstructor
{
    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<PrimaryConstructorBenchmarker>();
        }
    }
}
