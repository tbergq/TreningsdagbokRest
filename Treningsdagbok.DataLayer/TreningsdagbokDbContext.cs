﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer
{
    public class TreningsdagbokDbContext : IdentityDbContext<IdentityUser>
    {

        public TreningsdagbokDbContext()
            : base("name=TreningsdagbokDbContext")
        {
        }

        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<MuscleGroup> MuscleGroup { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
