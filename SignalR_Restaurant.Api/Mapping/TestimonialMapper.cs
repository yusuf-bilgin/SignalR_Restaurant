using AutoMapper;
using SignalR_Restaurant.DtoLayer.Testimonial;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class TestimonialMapper : Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
