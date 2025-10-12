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

            var maxPrice = context.Products.Max(y => y.Price);
            return context.Products.Where(x => x.Price == maxPrice).Select(z => z.Name).FirstOrDefault(); // Find the product with that maximum price
        }

        public string ProductNameByMinimumPrice()
        {
            using var context = new RestaurantContext();

            var minPrice = context.Products.Min(y => y.Price);
            return context.Products.Where(x => x.Price == minPrice).Select(z => z.Name).FirstOrDefault(); // Find the product with that minimum price
        }

        public decimal AverageProductPriceByHamburger()
        {
            using var context = new RestaurantContext();

            // Önce, kategori adı "Hamburger" olan kategorinin CategoryId'sini al
            var categoryId = context.Categories
                .Where(y => y.Name == "Hamburger")
                .Select(z => z.CategoryId)
                .FirstOrDefault();

            // Sonra, bu CategoryId'ye sahip ürünlerin ortalama fiyatını hesapla
            return context.Products
                .Where(x => x.CategoryId == categoryId)
                .Average(w => w.Price);
        }
    }
}
