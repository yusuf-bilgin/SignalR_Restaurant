using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DtoLayer.Product;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            var result = _mapper.Map<List<ResultProductDto>>(values);
            return Ok(values);
        }

        [HttpGet("GetProductWithCategory")]
        public IActionResult GetProductWithCategory()
        {
            var values = _productService.TGetProductsWithCategory();
            var result = _mapper.Map<List<GetProductWithCategory>>(values);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            _productService.TInsert(product);
            return Ok("Ürün Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.TGetById(id);
            var value = _mapper.Map<GetProductDto>(product);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(product);
            return Ok("Ürün Güncellendi");
        }

        [HttpGet("count")]
        public IActionResult GetProductCount()
        {
            var values = _productService.TProductCount();
            return Ok(values);
        }

        [HttpGet("count/hamburger")]
        public IActionResult GetHamburgerCount()
        {
            var values = _productService.TProductCountByCategoryNameHamburger();
            return Ok(values);
        }

        [HttpGet("count/drink")]
        public IActionResult GetDrinkCount()
        {
            var values = _productService.TProductCountByCategoryNameDrink();
            return Ok(values);
        }

        [HttpGet("price/average")]
        public IActionResult GetAveragePrice()
        {
            var values = _productService.TAverageProductPrice();
            return Ok(values);
        }

        [HttpGet("price/max/name")]
        public IActionResult GetProductNameByMaxPrice()
        {
            var values = _productService.TProductNameByMaximumPrice();
            return Ok(values);
        }

        [HttpGet("price/min/name")]
        public IActionResult GetProductNameByMinPrice()
        {
            var values = _productService.TProductNameByMinimumPrice();
            return Ok(values);
        }


    }
}
