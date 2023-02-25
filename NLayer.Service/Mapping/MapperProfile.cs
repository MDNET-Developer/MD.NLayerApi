using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<ProductDto,Product>().ReverseMap();
            CreateMap<ProductFeatureDto,ProductFeature>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
        }
    }
}
