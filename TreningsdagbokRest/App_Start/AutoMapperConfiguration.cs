using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;
using TreningsdagbokRest.Models;

namespace TreningsdagbokRest.App_Start
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            MapExercise();
            MapUser();
            MapMuscleGroup();
            MapDayExercise();
            MapProgram();
            MapWeek();
            MapDay();
        }

        private static void MapDay()
        {
            Mapper.CreateMap<Day, DTODay>()
                .ForMember(x => x.DayExercise, y => y.Ignore());
            Mapper.CreateMap<DTODay, Day>();
        }

        private static void MapWeek()
        {
            Mapper.CreateMap<Week, DTOWeek>();
            Mapper.CreateMap<DTOWeek, Week>();

            Mapper.CreateMap<DTOWeek, WeekViewModel>();
            Mapper.CreateMap<WeekViewModel, DTOWeek>();
        }

        private static void MapProgram()
        {
            Mapper.CreateMap<Program, DTOProgram>()
                .ForMember(x => x.Weeks, y => y.Ignore());
            Mapper.CreateMap<DTOProgram, Program>();

            Mapper.CreateMap<ProgramViewModel, DTOProgram>()
                .ForMember(x => x.Weeks, y => y.Ignore());
            Mapper.CreateMap<DTOProgram, ProgramViewModel>();
        }

        private static void MapDayExercise()
        {
            Mapper.CreateMap<DayExercise, DTODayExercise>();
            Mapper.CreateMap<DTODayExercise, DayExercise>();
        }

        private static void MapMuscleGroup()
        {
            Mapper.CreateMap<MuscleGroup, DTOMuscleGroup>();
            Mapper.CreateMap<DTOMuscleGroup, MuscleGroup>();
        }

        private static void MapUser()
        {
            Mapper.CreateMap<UserViewModel, UserModel>();
            Mapper.CreateMap<UserModel, UserViewModel>()
                .ForMember(x => x.ConfirmPassword, y => y.Ignore());

            

        }

        private static void MapExercise()
        {
            Mapper.CreateMap<DTOExercise, Exercise>();
            Mapper.CreateMap<Exercise, DTOExercise>();

            Mapper.CreateMap<ExerciseViewModel, DTOExercise>();
            Mapper.CreateMap<DTOExercise, ExerciseViewModel>();
        }
    }
}