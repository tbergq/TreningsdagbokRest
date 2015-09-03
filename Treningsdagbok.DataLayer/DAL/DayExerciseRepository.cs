using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL
{
    public class DayExerciseRepository : BaseRepository<DayExercise>, IDayExerciseRepository
    {

        public override System.Data.Entity.DbSet<DayExercise> GetDbSet(TreningsdagbokDbContext context)
        {
            return context.DayExercise;
        }
    }
}
