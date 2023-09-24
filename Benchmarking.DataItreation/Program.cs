using BenchmarkDotNet.Running;

namespace Benchmarking.DataItreation;

internal static class Program
{
  private static void Main()
  {
    BenchmarkRunner.Run<BenchmarkedDataIterator>();
  }
}
