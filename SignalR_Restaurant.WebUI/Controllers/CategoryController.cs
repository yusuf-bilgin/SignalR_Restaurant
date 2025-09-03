using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
