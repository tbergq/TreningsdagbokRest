using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;
using TreningsdagbokRest.Models;

namespace TreningsdagbokRest.Controllers
{
    public class WeeksController : ApiController
    {
        private readonly IWeekService _weekService;

        public WeeksController(IWeekService weekService)
        {
            _weekService = weekService;
        }

        [HttpPost]
        public IHttpActionResult Post(WeekViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var week = _weekService.Add(Mapper.Map<DTOWeek>(model));
            return Ok(week);
        }
    }
}
