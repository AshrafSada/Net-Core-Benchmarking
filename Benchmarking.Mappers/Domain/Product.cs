using Mapster;
using System;
using System.Collections.Generic;

namespace BenchmarkingMappers.Domain
{
    [AdaptTo("[name]CodeGenDto"), GenerateMapper]
    public class Product
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public decimal Weight { get; set; }

        public List<ProductVariant> Options { get; set; }

        public ProductVariant DefaultOption { get; set; }
    }
}