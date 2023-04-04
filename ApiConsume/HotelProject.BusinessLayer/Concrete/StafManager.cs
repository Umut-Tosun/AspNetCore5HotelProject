using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Migrations;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StafManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StafManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff entity)
        {
            _staffDal.TDelete(entity);
        }

        public Staff TGetById(int id)
        {
            return _staffDal.TGetById(id);
        }

        public List<Staff> TGetList()
        {
           return _staffDal.TGetList();
        }

        public void TInsert(Staff entity)
        {
            _staffDal.TInsert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.TUpdate(entity);
        }
    }
}
