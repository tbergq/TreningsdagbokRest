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
    public class WeekService : BaseService<Week, DTOWeek>, IWeekService
    {
        private readonly IWeekRepository _weekRepository;

        public WeekService(IWeekRepository weekRepository)
            : base(weekRepository)
        {
            _weekRepository = weekRepository;
        }

        public IEnumerable<DTOWeek> GetAllWeeksOfProgram(int programId)
        {
            return Mapper.Map <IEnumerable<DTOWeek>>(_weekRepository.GetAllWeeksOfProgram(programId));
        }
    }
}
