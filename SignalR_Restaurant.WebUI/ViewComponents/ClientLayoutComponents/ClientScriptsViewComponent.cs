using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents
{
    public class ClientScriptsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
