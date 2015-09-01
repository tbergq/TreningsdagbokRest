using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;
using Treningsdagbok.DataLayer.DAL.Interface;
using AutoMapper;

namespace Treningsdagbok.ServiceLayer.Services
{
    public abstract class BaseService<T, DTO> : IBaseService<T, DTO>
        where T : BaseEntity
        where DTO : BaseDTO
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<DTO> GetAll()
        {
            return Mapper.Map<IEnumerable<DTO>>(_repository.GetAll());
        }

        public virtual DTO GetById(int id)
        {
            return Mapper.Map<DTO>(_repository.GetById(id));
        }

        public virtual DTO Add(DTO dto)
        {
            T entity = Mapper.Map<T>(dto);
            return Mapper.Map<DTO>(_repository.Add(entity));
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
        }

        public virtual void Edit(DTO dto)
        {
            T entity = Mapper.Map<T>(dto);
            _repository.Edit(entity);
        }
    }
}
