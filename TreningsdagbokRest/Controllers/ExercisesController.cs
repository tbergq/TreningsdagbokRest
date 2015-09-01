using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treningsdagbok.DataLayer.DAL;
using Treningsdagbok.ServiceLayer.Services;
using Treningsdagbok.ServiceLayer.Services.Interface;

namespace TreningsdagbokRest.Controllers
{
    public class ExercisesController : ApiController
    {
        private IExerciseService _exerciseService;

        public ExercisesController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        public ExercisesController()
        {
            _exerciseService = new ExerciseService(new ExerciseRepository());
        }

        public IHttpActionResult Get()
        {
            var exercises = _exerciseService.GetAll();
            return Ok(exercises);
        }
    }
}
