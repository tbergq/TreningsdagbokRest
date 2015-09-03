using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treningsdagbok.DataLayer.DAL;
using Treningsdagbok.DataLayer.Entities;
using TreningsdagbokRest.Models;

namespace TreningsdagbokRest.Controllers
{
    [AllowAnonymous]
    public class AccountsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid modelstate");
            }
            AuthRepository repo = new AuthRepository();
            var result =  repo.RegisterUser(Mapper.Map<UserModel>(model));

            return Ok(result);
        }
    }
}
