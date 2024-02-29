using System;
using BenchmarkDotNet.Running;

namespace Benchmarking.TryParseVsTryCatch
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
