using BenchmarkDotNet.Running;

namespace Benchmarking.SwitchVsIfElse
{
    internal static class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run<SwitchVsIfElseBenchmarks>();

            _ = Console.ReadKey();
        }
    }
}
