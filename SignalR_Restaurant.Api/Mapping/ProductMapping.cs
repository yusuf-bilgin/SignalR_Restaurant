using AutoMapper;
using SignalR_Restaurant.DtoLayer.Product;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultDto>().ReverseMap();
            CreateMap<Product, CreateDto>().ReverseMap();
            CreateMap<Product, GetDto>().ReverseMap();
            CreateMap<Product, UpdateDto>().ReverseMap();
        }
    }
}
