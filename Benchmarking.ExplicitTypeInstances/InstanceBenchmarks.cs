using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Benchmarking.ExplicitTypeInstances.Models;

namespace Benchmarking.ExplicitTypeInstances
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
        public Student ImplicitSimplifiedWithMethods() => GenerateObjectInstances.AddStudentSimplifiedImplicit();

        [Benchmark]
        public Student ImplicitNotSimplifiedWithMethods() => GenerateObjectInstances.AddStudentNotSimplifiedImplicit();

        [Benchmark]
        public Student ExplicitNotSimplifiedWithMethods() => GenerateObjectInstances.AddStudentNotSimplifiedExplicit();

        [Benchmark]
        public Student ExplicitSimplifiedWithMethods() => GenerateObjectInstances.AddStudentSimplifiedExplicit();

        [Benchmark]
        public Specialization ExpressionBodyConstructor() => GenerateObjectInstances.CreateSpecialization();

        [Benchmark]
        public Teacher CodeBlockConstructor() => GenerateObjectInstances.CreateTeacher();
    }
}
