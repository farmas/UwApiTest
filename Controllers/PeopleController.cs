using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UwApi.Models;

namespace UwApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Federico", "Andrew", "Huiai", "Jennifer", "Jay"
        };

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Person
            {
                RegId = rng.Next(0, 55).ToString(),
                Name = Names[rng.Next(Names.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IEnumerable<Person> GetPersonsById(string[] ids) {
            var rng = new Random();
            return ids.Select(id => new Person() { RegId = id, Name = Names[rng.Next(Names.Length)]});
            
        }
    }
}
