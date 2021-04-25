using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkingMappers.Domain;

namespace BenchmarkingMappers
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MappingBenchmarks
    {
        [Benchmark]
        public ProductDto ManualMap() => MappingSamples.ManualMapperSample();

        [Benchmark]
        public ProductDto ExpressMap() => MappingSamples.ExpressMapperSample();

        [Benchmark]
        public ProductDto AutoMapper() => MappingSamples.AutoMapperSample();

        [Benchmark]
        public ProductDto MapsterAdaptNoConfig() => MappingSamples.MapsterAdaptWithoutConfigSample();

        [Benchmark]
        public ProductDto MapsterAdaptConfig() => MappingSamples.MapsterAdaptWithConfigSample();

        // Most commonly used scenario
        [Benchmark]
        public ProductDto MapsterAdaptToTypeConfig() => MappingSamples.MapsterAdaptToTypeSample();
        
        [Benchmark]
        public ProductCodeGenDto MapsterAdaptToCodeGenConfig() => MappingSamples.MapsterAdaptToCodeGenerationSample();
    }
}
