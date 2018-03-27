using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class PersonsController : ApiController
    {
        Person[] persons = new Person[]
        {
            new Person { ID = 1, Name = "jay", Age = 30 ,Address="GOA"},
         new Person { ID = 2, Name = "ajay",Age = 35 ,Address="BLR"},
            new Person { ID = 3, Name = "vijay",  Age = 21 ,Address="Diu"}
      };

        public IEnumerable<Person> GetAllpersons()
        {
            return persons;
        }

        public IHttpActionResult Getperson(int id)
        {
            var person = persons.FirstOrDefault((p) => p.ID == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

    }
}
