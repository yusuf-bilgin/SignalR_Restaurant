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
            return context.Products.Where(x => x.CategoryId == context.Categories.Where(y => y.Name == "İçecek").Select(z => z.CategoryId).FirstOrDefault()).Count();
        }

        public decimal AverageProductPrice()
        {
            using var context = new RestaurantContext();
            return context.Products.Average(x => x.Price);
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.CategoryId == context.Categories.Where(y => y.Name == "Hamburger").Select(z => z.CategoryId).FirstOrDefault()).Count();
        }

        public string ProductNameByMaximumPrice()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.Price == context.Products.Max(y => y.Price)).Select(z => z.Name).FirstOrDefault();
        }

        public string ProductNameByMinimumPrice()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.Price == context.Products.Min(y => y.Price)).Select(z => z.Name).FirstOrDefault();
        }
    }
}
