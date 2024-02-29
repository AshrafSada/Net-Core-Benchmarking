using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.PrimaryConstructor
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class PrimaryConstructorBenchmarker
    {
        [Benchmark]
        public void CreatePersonInstanceUsingDefaultConstructor()
        {
            _ = new Person("Primary Constructor", 18, "Microsoft .Net 8.0");
        }

        [Benchmark]
        public void CreateStudentInstanceUsingPrimaryConstructor()
        {
            _ = new Student("Primary Constructor", 18, "Microsoft .Net 8.0");
        }

        [Benchmark]
        public void CreateMultipleInstancesUsingDefaultConstructor()
        {
            for (var i = 0; i < 1200; i++)
            {
                _ = new Person("Primary Constructor", 18, "Microsoft .Net 8.0");
            }
        }

        [Benchmark]
        public void CreateMultipleInstancesUsingPrimaryConstructor()
        {
            for (var i = 0; i < 1200; i++)
            {
                _ = new Student("Primary Constructor", 18, "Microsoft .Net 8.0");
            }
        }
    }
}
