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
    public class CashRegisterManager : ICashRegisterService
    {
        private readonly ICashRegisterDal _cashRegisterDal;
        public CashRegisterManager(ICashRegisterDal cashRegisterDal)
        {
            _cashRegisterDal = cashRegisterDal;
        }
        public void TDelete(CashRegister entity)
        {
            throw new NotImplementedException();
        }

        public List<CashRegister> TGetAll()
        {
            throw new NotImplementedException();
        }

        public CashRegister TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(CashRegister entity)
        {
            throw new NotImplementedException();
        }

        public decimal TotalAmount()
        {
            return _cashRegisterDal.TotalAmount();
        }

        public void TUpdate(CashRegister entity)
        {
            throw new NotImplementedException();
        }
    }
}
