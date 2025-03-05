using System;
using BenchmarkDotNet.Running;

namespace Benchmarking.Exceptions
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("TryParse Vs TryCatch benchmarking started ...");
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            _ = Console.ReadKey();
        }
    }
}
