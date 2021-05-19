using BenchmarkDotNet.Running;
using System;

namespace Benchmarking.SwitchVsIfElse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            _ = Console.ReadKey();
        }
    }
}
