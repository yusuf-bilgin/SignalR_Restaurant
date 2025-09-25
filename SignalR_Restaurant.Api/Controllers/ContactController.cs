using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DtoLayer.Contact;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetAll();
            var result = _mapper.Map<List<ResultContactDto>>(values);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            var contact = _mapper.Map<Contact>(createContactDto);
            _contactService.TInsert(contact);
            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetById(id);
            var result = _mapper.Map<ResultContactDto>(values);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            var contact = _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(contact);
            return Ok("Kategori Güncellendi");
        }
    }
}
