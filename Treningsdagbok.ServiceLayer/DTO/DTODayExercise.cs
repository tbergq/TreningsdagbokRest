using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.ServiceLayer.DTO
{
    public class DTODayExercise : BaseDTO
    {
        public int Id { get; set; }

        public int ExerciseId { get; set; }

        public DTOExercise Exercise { get; set; }

        public int MinimumRepetitions { get; set; }

        public int? MaximumRepetitions { get; set; }

        public int MinimumSets { get; set; }

        public int? MaximumSets { get; set; }

        public int Pause { get; set; }

        public string Description { get; set; }
    }
}
