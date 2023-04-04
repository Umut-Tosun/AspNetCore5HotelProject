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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Delete(Testimonial entity)
        {
           _testimonialDal.TDelete(entity);
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.TGetById(id);
        }

        public List<Testimonial> GetList()
        {
           return _testimonialDal.TGetList();
        }

        public void Insert(Testimonial entity)
        {
           _testimonialDal.TInsert(entity);
        }

        public void Update(Testimonial entity)
        {
           _testimonialDal.TUpdate(entity);
        }
    }
}
