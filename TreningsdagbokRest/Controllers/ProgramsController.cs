using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;
using TreningsdagbokRest.Models;

namespace TreningsdagbokRest.Controllers
{
    public class ProgramsController : ApiController
    {
        private readonly IProgramService _programService;

        public ProgramsController(IProgramService programService)
        {
            _programService = programService;
        }

        [HttpPost]
        public IHttpActionResult Post(ProgramViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            model.UserID = GetUserID();
            model.CreationDate = DateTime.Now;
            var program = _programService.Add(Mapper.Map<DTOProgram>(model));
            return Ok(program);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var programs = _programService.GetAllProgramsFromUser(GetUserID());
            return Ok(programs);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var program = _programService.GetById(id);
            return Ok(program);
        }

        [HttpPut]
        public IHttpActionResult Edit(ProgramViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _programService.Edit(Mapper.Map<DTOProgram>(model));
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _programService.Delete(id);
            return Ok();
        }

        private string GetUserID()
        {
            var user = (ClaimsIdentity)RequestContext.Principal.Identity;
            return user.Claims.First(x => x.Type == "UserID").Value;
        }
    }
}
