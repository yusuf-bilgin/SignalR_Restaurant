using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers.Admin
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
