using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.DataLayer.Entities
{
    public class Day : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public int WeekId { get; set; }

        [ForeignKey("WeekId")]
        public Week Week { get; set; }
    }
}
