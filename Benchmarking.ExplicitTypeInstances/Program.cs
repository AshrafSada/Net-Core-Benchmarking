using BenchmarkDotNet.Running;

namespace Benchmarking.ExplicitTypeInstances
{
    internal class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
