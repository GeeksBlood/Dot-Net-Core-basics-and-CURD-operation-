using CoreDemo.Models.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Test1Context _context;
        public GenericRepository(Test1Context _context)
        {
            this._context = _context;
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().ToList().AsQueryable();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Create(T data)
        {
          var res=  _context.Set<T>().Add(data);
            Save();
        }
        public void Update(T data)
        {

            var res = _context.Entry(data).State = EntityState.Modified;
            Save();
        }
        public void Delete(int id)
        {
            T result = GetByID(id);
            var res = _context.Set<T>().Remove(result);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
