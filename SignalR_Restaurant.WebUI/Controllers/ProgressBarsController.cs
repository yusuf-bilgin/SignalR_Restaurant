using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
