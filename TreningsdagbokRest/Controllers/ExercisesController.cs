using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treningsdagbok.DataLayer.DAL;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services;
using Treningsdagbok.ServiceLayer.Services.Interface;
using TreningsdagbokRest.Models;

namespace TreningsdagbokRest.Controllers
{
    public class ExercisesController : ApiController
    {
        private IExerciseService _exerciseService;

        public ExercisesController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

      
        [HttpGet]
        public IHttpActionResult Get()
        {
            var exercises = _exerciseService.GetAll();
            return Ok(exercises);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var exercise = _exerciseService.GetById(id);
            return Ok(exercise);
        }

        [HttpPost]
        public IHttpActionResult Post(ExerciseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Unvalid model");
            }
            var user = _exerciseService.Add(Mapper.Map<DTOExercise>(model));
            return Ok(user);
        }
    }
}
