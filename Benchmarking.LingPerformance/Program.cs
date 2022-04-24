using BenchmarkDotNet.Running;
using Bogus;

namespace Benchmarking.LingPerformance
{
    internal class Program
    {
        private static void Main()
        {
            Randomizer.Seed = new Random(420);
            BenchmarkRunner.Run<LinqBenchmarks>();
        }
    }
}