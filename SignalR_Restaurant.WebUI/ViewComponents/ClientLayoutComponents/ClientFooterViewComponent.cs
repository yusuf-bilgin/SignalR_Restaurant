using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR_Restaurant.WebUI.Dtos.ContactDtos;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents
{
    public class ClientFooterViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ClientFooterViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7181/api/Contact");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            return View(values);
        }
    }
}
