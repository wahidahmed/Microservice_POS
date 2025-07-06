using AutoMapper;
using Purchase.Application.DTOs;
using Purchase.Application.Features.Commands;
using Purchase.Domain.Entities;

namespace Purchase.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductAddDto, Product>().ReverseMap();
            CreateMap<AddNewProductCommand, Product>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Unit, AddNewUnitCommand>().ReverseMap();
            CreateMap<Unit, UnitDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
