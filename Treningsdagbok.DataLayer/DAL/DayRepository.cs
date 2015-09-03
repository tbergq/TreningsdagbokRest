using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL
{
    public class DayRepository : BaseRepository<Day>
    {
        public override System.Data.Entity.DbSet<Day> GetDbSet(TreningsdagbokDbContext context)
        {
            return context.Day;
        }
    }
}
