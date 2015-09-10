using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreningsdagbokRest.Models
{
    public class ProgramViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string UserID { get; set; }
    }
}