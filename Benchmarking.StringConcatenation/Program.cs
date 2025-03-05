using BenchmarkDotNet.Running;

namespace Benchmarking.StringConcatenation
{
    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
