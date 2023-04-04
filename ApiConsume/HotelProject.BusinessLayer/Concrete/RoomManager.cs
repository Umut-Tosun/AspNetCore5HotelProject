using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Delete(Room entity)
        {
            _roomDal.TDelete(entity);
        }

        public Room GetById(int id)
        {
           return _roomDal.TGetById(id);
        }

        public List<Room> GetList()
        {
            return _roomDal.TGetList();
        }

        public void Insert(Room entity)
        {
            _roomDal.TInsert(entity);
        }

        public void Update(Room entity)
        {
            _roomDal.TUpdate(entity);
        }
    }
}
