using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Treningsdagbok.ServiceLayer.DTO;

namespace TreningsdagbokRest.Models
{
    public class WeekViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ProgramId { get; set; }

        public DTOProgram Program { get; set; }
    }
}