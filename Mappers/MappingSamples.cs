using AutoMapper;
using BenchmarkingMappers.Domain;
using BenchmarkingMappers.Dtos;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BenchmarkingMappers
{
    public static class MappingSamples
    {
        private static readonly IMapper AutoMapper =
            new Mapper(new MapperConfiguration(mc =>
            mc.AddProfile(new AutomapperProfile())));

        #region Mapster configure

        private static readonly TypeAdapterConfig typeAdapterConfig = GetTypeAdapterConfig();

        private static readonly MapsterMapper.IMapper MapsterMapper =
            new MapsterMapper.Mapper(typeAdapterConfig);

        #endregion Mapster configure

        private static readonly Product GenerateProduct
            = new Product
            {
                Id = Guid.Parse("86f7718a-f931-4c12-b5b5-ed6dcea4d1d5"),
                DefaultOption = new ProductVariant
                {
                    Id = Guid.Parse("66f7718a-f931-4c12-b5b5-ef6fcea4f1f5"),
                    Color = "Red",
                    Size = "Small"
                },
                Options = new List<ProductVariant>
                {
                    new ProductVariant
                    {
                        Id = Guid.Parse("66f7718a-f931-4c12-b5b5-ef6fcea4f1f5"),
                        Color = "Red", Size = "Small"
                    },
                    new ProductVariant
                    {
                        Id = Guid.Parse("55f7718a-f931-4c12-b5b5-ef6fcea4f1f5"),
                        Color = "Green", Size = "Small"
                    },
                    new ProductVariant
                    {
                        Id = Guid.Parse("33f7718a-f931-4c12-b5b5-ef6fcea4f1f5"),
                        Color = "Blue", Size = "Small"
                    }
                }
            };

        public static ProductDto ExpressMapperSample()
        {
            return ExpressMapper.Mapper.Map<Product, ProductDto>(GenerateProduct);
        }

        public static ProductDto MapsterAdaptWithoutConfigSample()
        {
            return GenerateProduct.Adapt<ProductDto>();
        }

        public static ProductDto MapsterAdaptWithConfigSample()
        {
            return GenerateProduct.Adapt<ProductDto>(typeAdapterConfig);
        }

        public static ProductDto MapsterAdaptToTypeSample()
        {
            return MapsterMapper.From(GenerateProduct).AdaptToType<ProductDto>();
        }

        public static ProductCodeGenDto MapsterAdaptToCodeGenerationSample()
        {
            return GenerateProduct.AdaptToCodeGenDto();
        }

        public static ProductDto ManualMapperSample()
        {
            var product = GenerateProduct;

            return new ProductDto
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Weight = product.Weight,
                DefaultOption = new ProductVariant
                {
                    Id = product.DefaultOption.Id,
                    Color = product.DefaultOption.Color,
                    Size = product.DefaultOption.Size
                },
                Options = product.Options.Select(opt => new ProductVariant
                {
                    Id = opt.Id,
                    Color = opt.Color,
                    Size = opt.Size
                }).ToList()
            };
        }

        private static TypeAdapterConfig GetTypeAdapterConfig()
        {
            var config = new TypeAdapterConfig();
            _ = config.NewConfig<Product, ProductDto>();

            return config;
        }

        public static ProductDto AutoMapperSample()
        {
            return AutoMapper.Map<ProductDto>(GenerateProduct);
        }
    }

    internal class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            _ = CreateMap<ProductVariant, ProductVariantDto>();
            _ = CreateMap<Product, ProductDto>();
        }
    }
}
