using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
