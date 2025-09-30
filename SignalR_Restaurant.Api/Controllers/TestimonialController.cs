using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DtoLayer.Testimonial;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetAll();
            var result = _mapper.Map<List<ResultTestimonialDto>>(values);
            return Ok(result);
        }   
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TInsert(testimonial);
            return Ok("Referans Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Referans Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            var result = _mapper.Map<ResultTestimonialDto>(values);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(testimonial);
            return Ok("Referans Güncellendi");
        }
    }
}
