using BenchmarkDotNet.Running;

namespace Benchmarking.DataIteration;

internal static class Program
{
    private static void Main()
    {
        _ = BenchmarkRunner.Run<BenchmarkedDataIterator>();
    }
}
