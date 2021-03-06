﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;

namespace Treningsdagbok.ServiceLayer.Services.Interface
{
    public interface IDayExerciseService : IBaseService<DayExercise, DTODayExercise>
    {
        IEnumerable<DTODayExercise> GetAllByDayId(int dayId);
    }
}
