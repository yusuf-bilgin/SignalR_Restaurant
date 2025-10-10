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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void TDelete(Order entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Order TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Order entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
