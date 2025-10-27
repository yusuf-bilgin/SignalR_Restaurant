using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR_Restaurant.WebUI.Dtos.ProductDtos;

namespace SignalR_Restaurant.WebUI.Controllers.Client
{
    public class ClientMenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ClientMenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7181/api/Product");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);
        }
    }
}
