using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.ServiceLayer.DTO
{
    public class DTOProgram : BaseDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string UserID { get; set; }
    }
}
