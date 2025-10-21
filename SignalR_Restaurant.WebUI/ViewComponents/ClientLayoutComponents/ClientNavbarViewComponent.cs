using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents
{
    public class ClientNavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
