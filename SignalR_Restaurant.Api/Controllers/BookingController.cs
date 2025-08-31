using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DtoLayer.Booking;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking
            {
                Name = createBookingDto.Name,
                Phone = createBookingDto.Phone,
                Mail = createBookingDto.Mail,
                PersonCount = createBookingDto.PersonCount,
                Date = createBookingDto.Date
            };
            _bookingService.TInsert(booking);
            return Ok("Rezervasyon Yapıldı");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok("Rezervasyon Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking
            {
                BookingId = updateBookingDto.BookingId,
                Name = updateBookingDto.Name,
                Phone = updateBookingDto.Phone,
                Mail = updateBookingDto.Mail,
                PersonCount = updateBookingDto.PersonCount,
                Date = updateBookingDto.Date
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
    }
}
