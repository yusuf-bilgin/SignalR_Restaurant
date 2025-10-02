using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
