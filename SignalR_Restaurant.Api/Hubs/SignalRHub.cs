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

        public async Task SendStatistics()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value); // Gelen değerleri client tarafına gönderiyoruz

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var value5 = _productService.TProductCountByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveHamburgerCount", value5);

            var value6 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveDrinkCount", value6);

            var value7 = _productService.TAverageProductPrice();
            await Clients.All.SendAsync("ReceiveAverageProductPrice", value7.ToString("0.00") + " ₺");

            var value8 = _productService.TProductNameByMaximumPrice();
            await Clients.All.SendAsync("ReceiveMostExpensiveProduct", value8);

            var value9 = _productService.TProductNameByMinimumPrice();
            await Clients.All.SendAsync("ReceiveCheapestProduct", value9);
        }
    }
}
