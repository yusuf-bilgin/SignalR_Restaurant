using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR_Restaurant.EntityLayer.Entities;
using SignalR_Restaurant.WebUI.Dtos.SliderDtos;

namespace SignalR_Restaurant.WebUI.ViewComponents.ClientLayoutComponents.ClientHomeComponents
{
    public class ClientHomeSliderViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ClientHomeSliderViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7181/api/Sliders");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
                return View(values);
            }
            else
            {
                return View(responseMessage);
            }
        }
    }
}
