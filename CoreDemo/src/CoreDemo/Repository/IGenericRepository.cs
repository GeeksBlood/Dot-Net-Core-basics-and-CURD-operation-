using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetByID(int id);
        void Create(T data);
        void Update(T data);
        void Delete(int id);
        void Save();


       
    }
}
