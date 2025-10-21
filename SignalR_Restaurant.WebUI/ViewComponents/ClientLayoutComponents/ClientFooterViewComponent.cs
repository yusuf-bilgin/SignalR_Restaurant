using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents
{
    public class ClientFooterViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
