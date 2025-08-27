using AutoMapper;
using SignalR_Restaurant.DtoLayer.Category;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultDto>().ReverseMap();
            CreateMap<Category, CreateDto>().ReverseMap();
            CreateMap<Category, GetDto>().ReverseMap();
            CreateMap<Category, UpdateDto>().ReverseMap();
        }
    }
}
