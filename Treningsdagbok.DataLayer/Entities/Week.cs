using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.DataLayer.Entities
{
    public class Week : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ProgramId { get; set; }

        [ForeignKey("ProgramId")]
        public Program Program { get; set; }
    }
}
