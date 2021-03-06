﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treningsdagbok.ServiceLayer.DTO
{
    public class DTODay : BaseDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int WeekId { get; set; }

        public DTOWeek Week { get; set; }

        public IEnumerable<DTODayExercise> DayExercise { get; set; }
    }
}
