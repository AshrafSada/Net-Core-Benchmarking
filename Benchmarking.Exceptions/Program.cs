using BenchmarkDotNet.Running;
using System;

namespace Benchmarking.TryParseVsTryCatch
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
