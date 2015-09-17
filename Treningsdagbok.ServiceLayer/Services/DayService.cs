using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;

namespace Treningsdagbok.ServiceLayer.Services
{
    public class DayService : BaseService<Day, DTODay>, IDayService
    {
        private readonly IDayRepository _dayRepository;

        public DayService(IDayRepository dayRepository)
            : base(dayRepository)
        {
            _dayRepository = dayRepository;
        }

        public IEnumerable<DTODay> GetDaysOfWeek(int weekId)
        {
            return Mapper.Map<IEnumerable<DTODay>>(_dayRepository.GetDaysOfWeek(weekId));
        }
    }
}
