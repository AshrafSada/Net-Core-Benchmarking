using Benchmarking.Mappers.Domain;
using System;
using System.Collections.Generic;

namespace Benchmarking.Mappers.Dtos
{
    public class ProductVariantDto
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public decimal Weight { get; set; }

        public List<ProductVariant> Options { get; set; }

        public ProductVariant DefaultOption { get; set; }
    }
}