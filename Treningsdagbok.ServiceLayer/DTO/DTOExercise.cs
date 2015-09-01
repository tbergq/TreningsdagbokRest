using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.ServiceLayer.DTO
{
    public class DTOExercise : BaseDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MuscleGroup { get; set; }

        public string YoutubeLink { get; set; }

        public string Description { get; set; }
    }
}
