using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.Controllers.Client
{
    public class DefaultController : Controller
    {
        // Client Home olacak
        public IActionResult Index()
        {
            return View();
        }
    }
}
