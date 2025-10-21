using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers.Admin
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
