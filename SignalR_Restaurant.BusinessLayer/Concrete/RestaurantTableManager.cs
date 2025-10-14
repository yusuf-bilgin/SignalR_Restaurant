using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR_Restaurant.BusinessLayer.Abstract;
using SignalR_Restaurant.DataAccessLayer.Abstract;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.BusinessLayer.Concrete
{
    public class RestaurantTableManager : IRestaurantTableService
    {
        private readonly IRestaurantTableDal _restaurantTableDal;

        public RestaurantTableManager(IRestaurantTableDal restaurantTableDal)
        {
            _restaurantTableDal = restaurantTableDal;
        }

        public void TDelete(RestaurantTable entity)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantTable> TGetAll()
        {
            throw new NotImplementedException();
        }

        public RestaurantTable TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(RestaurantTable entity)
        {
            throw new NotImplementedException();
        }

        public int TotalTableCount()
        {
            return _restaurantTableDal.TotalTableCount();
        }

        public void TUpdate(RestaurantTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
