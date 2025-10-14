using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_Restaurant.BusinessLayer.Abstract;

namespace SignalR_Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashRegistersController : ControllerBase
    {
        private readonly ICashRegisterService _cashRegisterService;
        public CashRegistersController(ICashRegisterService cashRegisterService)
        {
            _cashRegisterService = cashRegisterService;
        }

        [HttpGet("totalAmount")]
        public IActionResult GetTotalAmount()
        {
            var total = _cashRegisterService.TotalAmount();
            return Ok(total);
        }
    }
}
