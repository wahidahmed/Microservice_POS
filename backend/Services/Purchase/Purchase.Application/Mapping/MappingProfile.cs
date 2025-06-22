using AutoMapper;
using Purchase.Application.DTOs;
using Purchase.Domain.Entities;

namespace Purchase.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductAddDto, Product>().ReverseMap();
        }
    }
}
