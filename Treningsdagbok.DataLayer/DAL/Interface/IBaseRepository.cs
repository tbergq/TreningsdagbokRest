using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL.Interface
{
    public interface IBaseRepository<T> : IRepository
        where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        void Delete(int id);
        void Edit(T entity);
    }
}
