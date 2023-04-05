using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void TDelete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T TGetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> TGetList()
        {
            return _context.Set<T>().ToList();
        }

        public void TInsert(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void TUpdate(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
