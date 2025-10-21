using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents
{
    public class ClientHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
