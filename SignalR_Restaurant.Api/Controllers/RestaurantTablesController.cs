using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantTablesController : ControllerBase
    {
        private readonly IRestaurantTableService _restaurantTableService;
        public RestaurantTablesController(IRestaurantTableService restaurantTableService)
        {
            _restaurantTableService = restaurantTableService;
        }

        [HttpGet("count/total")]
        public IActionResult GetTotalTableCount()
        {   
            var count = _restaurantTableService.TotalTableCount();
            return Ok(count);
        }
    }
}
