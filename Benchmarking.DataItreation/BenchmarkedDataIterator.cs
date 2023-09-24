using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarking.DataItreation
{
  [MemoryDiagnoser(false)]
  public class BenchmarkedDataIterator
  {
    private static readonly Random random = new Random(93933);

    [Params(1000, 100_000, 1_000_000)]
    public int Size { get; set; }

    private List<int> _dataList;

    [GlobalSetup]
    public void Setup()
    {
      _dataList = Enumerable
        .Range(1, Size)
        .Select(x => random.Next())
        .ToList();
    }

    [Benchmark]
    public void WhileLoop()
    {
      var i = 0;
      while (i < _dataList.Count)
      {
        var item = _dataList[i];
        i++;
      }
    }

    [Benchmark]
    public void ForLoop()
    {
      for (int i = 0; i < _dataList.Count; i++)
      {
        var item = _dataList[i];
      }
    }

    [Benchmark]
    public void ForEachLoop()
    {
      foreach (var item in _dataList)
      {
        var item2 = item;
      }
    }

    [Benchmark]
    public void LinqForeachLoop()
    {
      _dataList.ForEach(item =>
      {
        var item2 = item;
      });
    }

    [Benchmark]
    public void ParallelForEachLoop()
    {
      Parallel.ForEach(_dataList, item =>
      {
        var item2 = item;
      });
    }

    [Benchmark]
    public void ParallelLinqForAllLoop()
    {
      _dataList.AsParallel().ForAll(item =>
      {
        var item2 = item;
      });
    }

    [Benchmark]
    public void ForMarshalSpanLoop()
    {
      var span = CollectionsMarshal.AsSpan(_dataList);
      for (int i = 0; i < span.Length; i++)
      {
        var itemXf = span[i];
      }
    }

    [Benchmark]
    public void ForeachMarshalSpanLoop()
    {
      foreach (var item in CollectionsMarshal.AsSpan(_dataList))
      {
        var itemX = item;
      }
    }
  }
}
