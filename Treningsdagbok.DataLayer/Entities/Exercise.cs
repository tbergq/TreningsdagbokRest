using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.DataLayer.Entities
{
    public class Exercise : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int MuscleGroup { get; set; }

        public string YoutubeLink { get; set; }

        public string Description { get; set; }
    }
}
