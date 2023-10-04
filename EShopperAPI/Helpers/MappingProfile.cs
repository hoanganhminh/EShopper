using AutoMapper;
using EShopperAPI.Data.RequestDTO;
using EShopperAPI.Models;

namespace EShopperAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResponse>();
            CreateMap<Category, CategoryResponse>();
        }
    }
}
