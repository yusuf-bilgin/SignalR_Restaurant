using Microsoft.AspNetCore.SignalR;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DataAccessLayer.Concrete;

namespace SignalR_Restaurant.Api.Hubs
{
    public class SignalRHub : Hub
    {
        /// => Çok fazla servis yazmak yerine mediator pattern kullanılabilir denildi. (Araştır!) <=
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public SignalRHub(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task SendCategoryCount()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value); // Gelen değerleri client tarafına gönderiyoruz
        }
        public async Task SendProductCount()
        {
            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);
        }
    }
}
