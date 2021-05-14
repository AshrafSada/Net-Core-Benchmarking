using BenchmarkDotNet.Running;
using System;

namespace Benchmarking.StringConcatenation
{
    internal class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        private static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            _ = Console.ReadKey();
        }
    }
}
