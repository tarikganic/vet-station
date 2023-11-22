using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;
using VetStat.Data;
using VetStat.Helpers.Validators;
using VetStat.Models;

namespace VetStat.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly DataContext _db;
        public PersonController(DataContext db)
        {
            _db = db;
        }

        //api/Person/GetAll
        [HttpGet]
        public ActionResult<List<Person>> GetAll()
        {
            if (_db.Person != null)
                return Ok(_db.Person.ToList());
            return NoContent();
        }

        //api/Person/Get/:id
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            if (!_db.Person.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.Person.Where(x => x.Id == id).ToList());
            return NoContent();
        }

        //api/Person/Add
        [HttpPost]
        public ActionResult<Person> Add(Person person)
        {
            try
            {
                Services.PersonValidator(person);
                _db.Person.Add(person);
                _db.SaveChanges();
                return Ok(person);

                throw new Exception("Something is wrong! Try again!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); //Error message
            }
        }

        //api/Person/Edit/:id
        [HttpPut("{id}")]
        public ActionResult Edit([FromBody] Person person, int id) //This signature is temporary
        {
            var _person = _db.Person.Where(x => x.Id == id).FirstOrDefault();

            try
            {
                Services.UpdateEntity(_person, person);
                _db.SaveChanges();
                return Ok(person);
            }

            catch (Exception err)
            {
                return BadRequest(err.Message); //Error message
            }
        }

        //api/Person/Delete/:id
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var personToDelete = _db.Person.SingleOrDefault(x => x.Id == id);
                if (personToDelete != null)
                {
                    _db.Person.Remove(personToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                {
                    return NotFound($"Person with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }

    }
}
