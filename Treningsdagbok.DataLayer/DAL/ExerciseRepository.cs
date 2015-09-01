using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public override DbSet<Exercise> GetDbSet(TreningsdagbokDbContext context)
        {
            return context.Exercise;
        }
    }
}
