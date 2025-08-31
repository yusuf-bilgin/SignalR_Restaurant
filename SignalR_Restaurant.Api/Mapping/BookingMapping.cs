using AutoMapper;
using SignalR_Restaurant.DtoLayer.Booking;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
