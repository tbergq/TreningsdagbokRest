using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.DataLayer.Entities
{
    public class DayExercise : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public int ExerciseId { get; set; }

        [ForeignKey("ExerciseId")]
        public Exercise Exercise { get; set; }

        [Required]
        public int MinimumRepetitions { get; set; }

        public int? MaximumRepetitions { get; set; }

        [Required]
        public int MinimumSets { get; set; }

        public int? MaximumSets { get; set; }

        public int Pause { get; set; }

        public string Description { get; set; }
    }
}
