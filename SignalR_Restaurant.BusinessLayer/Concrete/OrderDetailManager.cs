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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void TDelete(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> TGetAll()
        {
            throw new NotImplementedException();
        }

        public OrderDetail TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
