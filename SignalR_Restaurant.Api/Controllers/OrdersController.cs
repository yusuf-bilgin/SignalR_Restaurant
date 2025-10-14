using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("count/total")]
        public IActionResult GetTotalOrderCount()
        {
            var values = _orderService.TotalOrderCount();
            return Ok(values);
        }

        [HttpGet("count/active")]
        public IActionResult GetActiveOrderCount()
        {
            var values = _orderService.ActiveOrderCount();
            return Ok(values);
        }

        [HttpGet("last/price")]
        public IActionResult GetLastOrderPrice()
        {
            var values = _orderService.LastOrderPrice();
            return Ok(values);
        }

        [HttpGet("amount/today")]
        public IActionResult GetTodaysAmount()
        {
            var values = _orderService.TodaysAmount();
            return Ok(values);
        }
    }
}
