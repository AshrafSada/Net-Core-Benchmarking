using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarking.DataItreation
{
    [MemoryDiagnoser(false)]
    public class BenchmarkedDataIterator
    {
        private static readonly Random random = new Random(93933);

        private List<int>? _dataList;

        [Params(1000, 100_000, 1_000_000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _dataList = Enumerable
              .Range(1, Size)
              .Select(_ => random.Next())
              .ToList();
        }

        [Benchmark]
        public void WhileLoop()
        {
            var i = 0;
            while (i < _dataList?.Count)
            {
                _ = _dataList[i];
                i++;
            }
        }

        [Benchmark]
        public void ForLoop()
        {
            for (int i = 0; i < _dataList?.Count; i++)
            {
                _ = _dataList[i];
            }
        }

        [Benchmark]
        public void ForEachLoop()
        {
            if (_dataList is null)
                return;
            foreach (var item in _dataList)
            {
                var item2 = item;
            }
        }

        [Benchmark]
        public void LinqForeachLoop()
        {
            _dataList?.ForEach(item =>
            {
                var item2 = item;
            });
        }

        [Benchmark]
        public void ParallelForEachLoop()
        {
            if (_dataList is null)
                return;
            Parallel.ForEach(_dataList, item =>
            {
                var item2 = item;
            });
        }

        [Benchmark]
        public void ParallelLinqForAllLoop()
        {
            if (_dataList is null)
                return;
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
