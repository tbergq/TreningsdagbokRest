using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treningsdagbok.ServiceLayer.Services.Interface;

namespace TreningsdagbokRest.Controllers
{
    public class MuscleGroupsController : ApiController
    {
        private readonly IMuscleGroupService _muscleGroupService;

        public MuscleGroupsController(IMuscleGroupService muscleGroupService)
        {
            _muscleGroupService = muscleGroupService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var muscleGroups = _muscleGroupService.GetAll();
            return Ok(muscleGroups);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var group = _muscleGroupService.GetById(id);
            return Ok(group);
        }
    }
}
