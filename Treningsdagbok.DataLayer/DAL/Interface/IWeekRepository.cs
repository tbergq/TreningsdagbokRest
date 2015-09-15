using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL.Interface
{
    public interface IWeekRepository : IBaseRepository<Week>
    {
        IEnumerable<Week> GetAllWeeksOfProgram(int programId);
    }
}
