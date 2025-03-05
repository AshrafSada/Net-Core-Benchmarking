using System;
using BenchmarkDotNet.Running;

namespace Benchmarking.ObjectBoxing;

internal static class Program
{
    private static void Main()
    {
        _ = BenchmarkRunner.Run(typeof(Program).Assembly);
        Console.ReadKey();
    }
}
