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
    public class DayExerciseService : BaseService<DayExercise, DTODayExercise>, IDayExerciseService
    {
        private readonly IDayExerciseRepository _dayExerciseRepsitory;

        public DayExerciseService(IDayExerciseRepository dayExerciseRepsitory)
            : base(dayExerciseRepsitory)
        {
            _dayExerciseRepsitory = dayExerciseRepsitory;
        }

        public IEnumerable<DTODayExercise> GetAllByDayId(int dayId)
        {
            return Mapper.Map<IEnumerable<DTODayExercise>>(_dayExerciseRepsitory.GetAllByDayId(dayId));
        }
    }
}
