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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(RestaurantContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategory()
        {
            var context = new RestaurantContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new RestaurantContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.Name == "İçecek").Select(z => z.CategoryId).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.Name == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Count();
        }
    }
}
