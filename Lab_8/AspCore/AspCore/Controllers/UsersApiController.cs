using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class UsersApiController : Controller
    {
        private PersonContext users;

        public UsersApiController(PersonContext context)
        {
            users = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return users.Persones.ToArray();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            var user = users.Persones.Where(u => u.Id == id).ToArray()[0];
            return user;
        }

        // POST api/<controller>
        [HttpPost]
        public Person Post([FromBody]Person user)
        {
            if (user != null)
            {
                users.Persones.Add(user);
                users.SaveChanges();
            }
            return user;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Person Put(int id, [FromBody]Person newUser)
        {
            var user = users.Persones.Where(u => u.Id == id).ToArray()[0];
            if (newUser != null)
            {
                user.Firstname = newUser.Firstname;
                user.Gender = newUser.Gender;
                user.BDay = newUser.BDay;
                users.Persones.Update(user);
                users.SaveChanges();
            }
            return user;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IEnumerable<Person> Delete(int id)
        {
            var user = users.Persones.Where(u => u.Id == id).ToArray()[0];
            users.Persones.Remove(user);
            users.SaveChanges();
            return users.Persones.ToArray();
        }
    }
}
