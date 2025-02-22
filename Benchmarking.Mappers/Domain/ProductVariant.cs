using Mapster;
using System;

namespace BenchmarkingMappers.Domain
{
    [AdaptTo(name: "[name]CodeGenDto"), GenerateMapper]
    public class ProductVariant
    {
        public Guid Id { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }
    }
}