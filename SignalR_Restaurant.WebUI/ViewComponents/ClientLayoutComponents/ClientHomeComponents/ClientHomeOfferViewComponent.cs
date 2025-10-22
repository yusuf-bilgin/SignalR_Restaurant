using Microsoft.AspNetCore.Mvc;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents.ClientHomeComponents
{
    public class ClientHomeOfferViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
