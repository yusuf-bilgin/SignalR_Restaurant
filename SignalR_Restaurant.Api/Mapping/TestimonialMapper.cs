using AutoMapper;
using SignalR_Restaurant.DtoLayer.Testimonial;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class TestimonialMapper : Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial, ResultDto>().ReverseMap();
            CreateMap<Testimonial, CreateDto>().ReverseMap();
            CreateMap<Testimonial, GetDto>().ReverseMap();
            CreateMap<Testimonial, UpdateDto>().ReverseMap();
        }
    }
}
