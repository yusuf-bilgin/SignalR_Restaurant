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
    public class EfCashRegisterDal : GenericRepository<CashRegister>, ICashRegisterDal
    {
        public EfCashRegisterDal(RestaurantContext context) : base(context)
        {
        }

        public decimal TotalAmount()
        {
            using var context = new RestaurantContext();
            return context.CashRegisters.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
