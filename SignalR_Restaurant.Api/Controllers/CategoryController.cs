using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DtoLayer.Category;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAll());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _mapper.Map<ResultCategoryDto>(_categoryService.TGetById(id));
            return Ok(value);
        }
         
        [HttpGet("count")]
        public IActionResult GetCategoryCount()
        {
            var value = _categoryService.TCategoryCount(); // zaten int döndüğü için mapleme yapmaya gerek yok
            return Ok(value);
        }

        [HttpGet("count/active")]
        public IActionResult GetActiveCategoryCount()
        {
            var value = _categoryService.TActiveCategoryCount();
            return Ok(value);
        }

        [HttpGet("count/passive")]
        public IActionResult GetPassiveCategoryCount()
        {
            var value = _categoryService.TPassiveCategoryCount();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            category.Status = true; // mapperdan hariç bir şekilde sabit değer de eklenebilir -> Şu an tüm eklenen kategoriler aktif olarak eklenecek!
            _categoryService.TInsert(category);
            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var category = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(category);
            return Ok("Kategori Güncellendi");
        }
    }
}
