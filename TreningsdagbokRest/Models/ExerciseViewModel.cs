using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Treningsdagbok.ServiceLayer.DTO;

namespace TreningsdagbokRest.Models
{
    public class ExerciseViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int MuscleGroupId { get; set; }
        
        public DTOMuscleGroup MuscleGroup { get; set; }

        public string YoutubeLink { get; set; }

        public string Description { get; set; }
    }
}