using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;

namespace TreningsdagbokRest.App_Start
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            MapExercise();
        }

        private static void MapExercise()
        {
            Mapper.CreateMap<DTOExercise, Exercise>();
            Mapper.CreateMap<Exercise, DTOExercise>();
        }
    }
}