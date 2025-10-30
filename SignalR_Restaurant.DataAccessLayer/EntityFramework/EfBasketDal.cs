using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR_Restaurant.DataAccessLayer.Abstract;
using SignalR_Restaurant.DataAccessLayer.Concrete;
using SignalR_Restaurant.DataAccessLayer.Repositories;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(RestaurantContext context) : base(context)
        {
        }

        public List<Basket> GetBasketsByRestaurantTableId(int tableId)
        {
            using var context = new RestaurantContext();
            var values = context.Baskets.Where(b => b.RestaurantTableId == tableId)
                .ToList();

            return values;
        }
    }
}
