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
    public class ExerciseService : BaseService<Exercise, DTOExercise>, IExerciseService
    {

        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository)
            : base(exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        
    }
}
