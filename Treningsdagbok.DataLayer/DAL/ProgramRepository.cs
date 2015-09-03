﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL
{
    public class ProgramRepository : BaseRepository<Program>, IProgramRepository
    {
        public override System.Data.Entity.DbSet<Program> GetDbSet(TreningsdagbokDbContext context)
        {
            return context.Program;
        }
    }
}
