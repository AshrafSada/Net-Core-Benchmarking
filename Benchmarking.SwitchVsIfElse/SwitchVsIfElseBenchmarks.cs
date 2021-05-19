using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.SwitchVsIfElse
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class SwitchVsIfElseBenchmarks
    {
        [Benchmark]
        public int SwitchStatementNullInput() => SampleCode.ValidateEmployeeSwitch(null);

        [Benchmark]
        public int IfElseStatementNullInput() => SampleCode.ValidateEmployeeIfElse(null);

        [Benchmark]
        public int SwitchStatement() => SampleCode.ValidateEmployeeSwitch(new Employee());

        [Benchmark]
        public int IfElseStatement() => SampleCode.ValidateEmployeeIfElse(new Employee());
        
        [Benchmark]
        public int SwitchStatementWithAttr() => SampleCode.ValidateEmployeeSwitch(new Employee() { Name = "Test Name"});

        [Benchmark]
        public int IfElseStatementWithAttr() => SampleCode.ValidateEmployeeIfElse(new Employee() { Name = "Test Name" });
    }
}
