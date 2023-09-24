using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Benchmarking.ObjectBoxing
{
    [MemoryDiagnoser]
    public class BoxingSampleClass
    {
        private ClassSample _classSample1 = new ClassSample();

        [GlobalSetup]
        public void Setup()
        {
            _classSample1.Title = "Hello, Sample class 1";
        }

        [Benchmark]
        public String GetObject()
        {
            return _classSample1.Title;
        }
    }
}
