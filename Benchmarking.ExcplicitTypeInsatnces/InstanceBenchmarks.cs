using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Benchmarking.ExcplicitTypeInsatnces.Models;
using System;

namespace Benchmarking.ExcplicitTypeInsatnces
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class InstanceBenchmarks
    {
        [Benchmark]
        public Student ExplicitInstanceNoProps() => GenerateObjectInstances.CreateExplicitStudentInstance();

        [Benchmark]
        public Student ImplicitInstanceNoProps() => GenerateObjectInstances.CreateImplicitStudentInstance();

        [Benchmark]
        public Student ImplicitInstanceWithProps() => GenerateObjectInstances.CreateImplicitStudentInstanceWithProps();

        [Benchmark]
        public Student ExplicitInstanceWithProps() => GenerateObjectInstances.CreateExplicitStudentInstanceWithProps();

        [Benchmark]
        public Boolean ImplicitSimplifiedWithMethods() => GenerateObjectInstances.AddStudentSimplifiedImplicit();

        [Benchmark]
        public Boolean ImplicitNotSimplifiedWithMethods() => GenerateObjectInstances.AddStudentNotSimplifiedImplicit();

        [Benchmark]
        public Boolean ExplicitNotSimplifiedWithMethods() => GenerateObjectInstances.AddStudentNotSimplifiedExplicit();
        
        [Benchmark]
        public Boolean ExplicitSimplifiedWithMethods() => GenerateObjectInstances.AddStudentSimplifiedExplicit();
    }
}
