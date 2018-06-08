using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Web.Http;

namespace Lab_7.Controllers
{
    public class ApiPhoneController : ApiController
    {
        Models.PersonContext context = new Models.PersonContext();

        // GET: api/ApiPhone
        public IEnumerable<Models.Person> Get()
        {
            return context.Persons;
        }

        // GET: api/ApiPhone/5
        public Models.Person Get(string phone)
        {
            return context.Persons.Find(phone);
        }

        // POST: api/ApiPhone
        [HttpPost]
        public void Post([FromBody]Models.Person value)
        {
            context.Persons.Add(value);
            context.SaveChanges();
        }

        // PUT: api/ApiPhone/5
        [HttpPut]
        public Models.Person Put(string phone, [FromBody]Models.Person person)
        {
            if (phone == person.Phone)
            {
                context.Entry(person).State = EntityState.Modified;
                context.SaveChanges();
            }
            return person;
        }

        // DELETE: api/ApiPhone/5
        [HttpDelete]
        public void Delete(string phone)
        {
            Models.Person person = context.Persons.Find(phone);
            if (person != null)
            {
                context.Persons.Remove(person);
                context.SaveChanges();
            }
        }
    }
}
