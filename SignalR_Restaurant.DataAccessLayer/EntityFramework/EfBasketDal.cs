using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalR_Restaurant.DataAccessLayer.Abstract;
using SignalR_Restaurant.DataAccessLayer.Concrete;
using SignalR_Restaurant.DataAccessLayer.Repositories;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        private readonly RestaurantContext _context;
        public EfBasketDal(RestaurantContext context) : base(context)
        {
            _context = context;
        }

        public List<Basket> GetBasketsByRestaurantTableId(int tableId)
        {
            return _context.Baskets
                .Where(b => b.RestaurantTableId == tableId)
                .Include(b => b.Product)
                .ToList();
        }
    }
}
