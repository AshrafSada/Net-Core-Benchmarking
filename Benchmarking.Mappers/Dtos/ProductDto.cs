using BenchmarkingMappers.Domain;
using System;
using System.Collections.Generic;

namespace BenchmarkingMappers
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public decimal Weight { get; set; }

        public List<ProductVariant> Options { get; set; }

        public ProductVariant DefaultOption { get; set; }
    }
}