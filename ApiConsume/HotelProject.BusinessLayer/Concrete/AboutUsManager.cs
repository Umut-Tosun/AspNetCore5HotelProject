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
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }
        public void Delete(AboutUs entity)
        {
           _aboutUsDal.TDelete(entity);
        }

        public AboutUs GetById(int id)
        {
            return _aboutUsDal.TGetById(id);
        }

        public List<AboutUs> GetList()
        {
            return _aboutUsDal.TGetList();
        }

        public void Insert(AboutUs entity)
        {
           _aboutUsDal.TInsert(entity);
        }

        public void Update(AboutUs entity)
        {
            _aboutUsDal.TUpdate(entity);
        }
    }
}
