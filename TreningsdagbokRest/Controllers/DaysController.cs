using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treningsdagbok.ServiceLayer.Services.Interface;

namespace TreningsdagbokRest.Controllers
{
    public class DaysController : ApiController
    {
        private readonly IDayService _dayService;

        public DaysController(IDayService dayService)
        {
            _dayService = dayService;
        }

        [HttpGet]
        [Route("days/week/{weekId}")]
        public IHttpActionResult GetDaysOfWeek(int weekId)
        {
            var days = _dayService.GetDaysOfWeek(weekId);
            return Ok(days);
        }
    }
}
