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
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(RestaurantContext context) : base(context)
        {
        }
    }
}
