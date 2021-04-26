using BenchmarkDotNet.Running;
using System;

namespace Benchmarking.ExcplicitTypeInsatnces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicit Types Instantiation Benchmarking Started ...");

            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            _ = Console.ReadKey();
        }
    }
}
