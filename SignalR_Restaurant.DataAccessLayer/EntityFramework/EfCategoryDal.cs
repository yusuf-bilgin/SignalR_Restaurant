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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(RestaurantContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new RestaurantContext();
            return context.Categories.Where(c => c.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new RestaurantContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new RestaurantContext();
            return context.Categories.Where(c => c.Status == false).Count();
        }
    }
}
