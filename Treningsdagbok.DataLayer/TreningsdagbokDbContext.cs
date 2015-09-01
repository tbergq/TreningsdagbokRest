using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer
{
    public class TreningsdagbokDbContext : DbContext
    {

        public TreningsdagbokDbContext()
        {
        }

        public DbSet<Exercise> Exercise { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
