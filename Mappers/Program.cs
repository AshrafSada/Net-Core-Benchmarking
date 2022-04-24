using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Benchmarking.Mappers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            Console.ReadKey();
        }
    }
}
