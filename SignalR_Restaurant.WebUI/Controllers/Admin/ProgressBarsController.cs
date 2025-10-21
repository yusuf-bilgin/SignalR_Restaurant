using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers.Admin
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
