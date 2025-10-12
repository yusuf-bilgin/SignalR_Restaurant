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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(RestaurantContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new RestaurantContext();
            return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new RestaurantContext();
            return context.Orders.OrderByDescending(x => x.OrderId).Select(y => y.TotalAmount).FirstOrDefault();
        }

        public int TotalOrderCount()
        {
            using var context = new RestaurantContext();
            return context.Orders.Count();
        }
    }
}
