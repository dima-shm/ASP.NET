using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Api")]
    public class ApiController : Controller
    {
        private PersonContext db;

        public ApiController(PersonContext context)
        {
            db = context;
        }

        // GET: api/Api
        [HttpGet]
        public IEnumerable<Person> GetPerson()
        {
            return db.Persones;
        }

        // GET: api/Api/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = await db.Persones.SingleOrDefaultAsync(m => m.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/Api/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson([FromRoute] int id, [FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != person.Id)
            {
                return BadRequest();
            }

            db.Entry(person).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Api
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Persones.Add(person);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        }

        // DELETE: api/Api/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = await db.Persones.SingleOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            db.Persones.Remove(person);
            await db.SaveChangesAsync();

            return Ok(person);
        }

        private bool UserExists(int id)
        {
            return db.Persones.Any(e => e.Id == id);
        }
    }
}