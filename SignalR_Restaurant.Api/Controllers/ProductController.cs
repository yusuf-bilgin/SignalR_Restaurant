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

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetById(id);
            var result = _mapper.Map<ResultProductDto>(values);
            return Ok(result);
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

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(product);
            return Ok("Ürün Güncellendi");
        }
    }
}
