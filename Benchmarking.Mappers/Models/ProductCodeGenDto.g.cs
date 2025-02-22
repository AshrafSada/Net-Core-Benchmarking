using System;
using System.Collections.Generic;
using BenchmarkingMappers.Domain;

namespace BenchmarkingMappers.Domain
{
    public partial class ProductCodeGenDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal Weight { get; set; }
        public List<ProductVariantCodeGenDto> Options { get; set; }
        public ProductVariantCodeGenDto DefaultOption { get; set; }
    }
}