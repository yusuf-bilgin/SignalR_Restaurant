using Microsoft.AspNetCore.SignalR;
using SignalR_Restaurant.DataAccessLayer.Concrete;

namespace SignalR_Restaurant.Api.Hubs
{
    public class SignalRHub : Hub
    {
        RestaurantContext context = new RestaurantContext();
        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value); // Gelen değerleri client tarafına gönderiyoruz
        }
    }
}
