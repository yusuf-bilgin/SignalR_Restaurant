using AutoMapper;
using SignalR_Restaurant.DtoLayer.Feature;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultDto>().ReverseMap();
            CreateMap<Feature, CreateDto>().ReverseMap();
            CreateMap<Feature, GetDto>().ReverseMap();
            CreateMap<Feature, UpdateDto>().ReverseMap();
        }
    }
}
