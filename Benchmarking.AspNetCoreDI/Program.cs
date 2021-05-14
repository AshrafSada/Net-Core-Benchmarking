using BenchmarkDotNet.Running;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Benchmarking.AspNetCoreDI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Explicit Types Instantiation Benchmarking Started ...");

            _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            Console.ReadKey();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}