using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;

namespace Treningsdagbok.ServiceLayer.Services
{
    public class DayService : BaseService<Day, DTODay>, IDayService
    {
        private readonly IDayRepository _dayRepository;
        private readonly IDayExerciseService _dayExerciseService;

        public DayService(IDayRepository dayRepository, IDayExerciseService dayExerciseService)
            : base(dayRepository)
        {
            _dayRepository = dayRepository;
            _dayExerciseService = dayExerciseService;
        }

        public IEnumerable<DTODay> GetDaysOfWeek(int weekId)
        {
            return Mapper.Map<IEnumerable<DTODay>>(_dayRepository.GetDaysOfWeek(weekId));
        }

        public override DTODay GetById(int id)
        {
            using (var scope = new TransactionScope())
            {
                DTODay day = Mapper.Map<DTODay>(_dayRepository.GetById(id));
                day.DayExercise = _dayExerciseService.GetAllByDayId(id);
                return day;
            }
        }
    }
}
