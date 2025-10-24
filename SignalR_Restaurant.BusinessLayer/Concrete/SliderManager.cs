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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }
        public void TDelete(ClientSlider entity)
        {
            throw new NotImplementedException();
        }

        public List<ClientSlider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public ClientSlider TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(ClientSlider entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ClientSlider entity)
        {
            throw new NotImplementedException();
        }
    }
}
