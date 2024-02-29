using BenchmarkDotNet.Running;

namespace Benchmarking.ExcplicitTypeInstances
{
    internal class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
