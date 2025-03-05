using BenchmarkDotNet.Running;

namespace Benchmarking.EnhancedLogging;

internal static class Program
{
    private static void Main()
    {
        _ = BenchmarkRunner.Run<LoggingBenchmarked>();
        Console.ReadKey();
    }
}
