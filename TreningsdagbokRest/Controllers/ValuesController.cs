using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TreningsdagbokRest.Models;

namespace TreningsdagbokRest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            var jsonText = File.ReadAllText(@"c:\kode\TreningsdagbokRest\Treningsdagbok.DataLayer\workout.json");
            //var test = JsonConvert.DeserializeObject<WorkoutModel.Rootobject>(jsonText);

            //foreach (var element in test.Property1)
            //{

            //    Type type = element.GetType();
            //    var properties = type.GetProperties();
            //    foreach (var property in properties)
            //    {
            //        if (property != null)
            //        {
            //            string name = property.GetType().FullName;
            //            var tester = property.GetValue(element);
            //        }
            //    }
                
            //}
            
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        } 
    }
}
