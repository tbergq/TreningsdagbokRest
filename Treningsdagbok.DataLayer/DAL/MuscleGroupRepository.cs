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
    public class MuscleGroupRepository : BaseRepository<MuscleGroup>, IMuscleGroupRepository
    {
        public override DbSet<MuscleGroup> GetDbSet(TreningsdagbokDbContext context)
        {
            return context.MuscleGroup;
        }
    }
}
