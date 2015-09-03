using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treningsdagbok.DataLayer.DAL;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.ServiceLayer.Services;
using Treningsdagbok.ServiceLayer.Services.Interface;
using TreningsdagbokRest.Controllers;

namespace TreningsdagbokRest.App_Start
{
    public static class AutofacSetup
    {
        public static void RegisterDependencies(ref ContainerBuilder builder)
        {
            //Controllers
            builder.RegisterType<ExercisesController>();
            builder.RegisterType<MuscleGroupsController>();

            //Servies and repositories
            builder.RegisterType<ExerciseRepository>().As<IExerciseRepository>();
            builder.RegisterType<ExerciseService>().As<IExerciseService>();
            builder.RegisterType<MuscleGroupRepository>().As<IMuscleGroupRepository>();
            builder.RegisterType<MuscleGroupService>().As<IMuscleGroupService>();
            builder.RegisterType<ProgramRepository>().As<IProgramRepository>();
            builder.RegisterType<ProgramService>().As<IProgramService>();
            builder.RegisterType<DayExerciseRepository>().As<IDayExerciseRepository>();
            builder.RegisterType<DayExerciseService>().As<IDayExerciseService>();
            builder.RegisterType<WeekRepository>().As<IWeekRepository>();
            builder.RegisterType<WeekService>().As<IWeekService>();
        }
    }
}