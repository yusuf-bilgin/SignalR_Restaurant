using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.BusinessLayer.Abstract
{
    public interface IBasketService :IGenericService<Basket>
    {
        List<Basket> GetBasketsByRestaurantTableId(int tableId);
    }
}
