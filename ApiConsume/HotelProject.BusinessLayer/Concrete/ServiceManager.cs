using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceDal
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service entity)
        {
           _serviceDal.TDelete(entity);
        }

        public Service TGetById(int id)
        {
           return _serviceDal.TGetById(id); 
        }

        public List<Service> TGetList()
        {
           return _serviceDal.TGetList();  
        }

        public void TInsert(Service entity)
        {
            _serviceDal.TInsert(entity);
        }

        public void TUpdate(Service entity)
        {
           _serviceDal.TUpdate(entity);
        }
    }
}
