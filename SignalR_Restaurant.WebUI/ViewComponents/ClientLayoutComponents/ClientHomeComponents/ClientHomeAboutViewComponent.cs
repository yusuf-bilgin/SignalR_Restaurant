using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR_Restaurant.WebUI.Dtos.AboutDtos;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents.ClientHomeComponents
{
    public class ClientHomeAboutViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ClientHomeAboutViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7181/api/About");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return View(values);
        }
    }
}
