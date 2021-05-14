using BenchmarkDotNet.Running;
using System;

namespace Benchmarking.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            _ = Console.ReadKey();
        }
    }
}
