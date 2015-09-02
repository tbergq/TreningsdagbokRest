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