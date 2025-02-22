using BenchmarkDotNet.Running;

namespace Benchmarking.EnhancedLogging;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Benchmarking Enhanced Logging vs traditional logging");
        BenchmarkRunner.Run<LoggingBenchmarked>();
    }
}