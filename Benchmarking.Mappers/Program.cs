using BenchmarkDotNet.Running;

namespace Benchmarking.Mappers
{
    internal static class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
