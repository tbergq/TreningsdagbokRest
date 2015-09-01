using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreningsdagbokRest.Models
{
    public class ExerciseViewModel
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