using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeDal
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe entity)
        {
           _subscribeDal.TDelete(entity);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeDal.TGetById(id);
        }

        public List<Subscribe> TGetList()
        {
           return _subscribeDal.TGetList();
        }

        public void TInsert(Subscribe entity)
        {
           _subscribeDal.TInsert(entity);
        }

        public void TUpdate(Subscribe entity)
        {
           _subscribeDal.TUpdate(entity);   
        }
    }
}
