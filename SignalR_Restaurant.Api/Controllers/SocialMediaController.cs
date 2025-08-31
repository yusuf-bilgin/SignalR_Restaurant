using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DtoLayer.SocialMedia;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _socialMediaService.TGetAll();
            var result = _mapper.Map<List<ResultSocialMediaDto>>(values);
            return Ok(result);
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var values = _socialMediaService.TGetById(id);
            var result = _mapper.Map<ResultSocialMediaDto>(values);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            var socialMedia = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TInsert(socialMedia);
            return Ok("Sosyal Medya Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya Silindi");
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var socialMedia = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(socialMedia);
            return Ok("Sosyal Medya Güncellendi");
        }
    }
}
