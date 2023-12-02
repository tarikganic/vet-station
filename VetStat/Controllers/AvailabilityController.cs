using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Threading;
using VetStat.Data;
using VetStat.Models;
using VetStat.Helpers;
using VetStat.Helpers.Validators;

namespace VetStat.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AvailabilityController : Controller
    {
        private readonly DataContext _db;
        public AvailabilityController(DataContext db)
        {
            _db = db;
        }

        //api/Availability/GetAll
        [HttpGet]

        public ActionResult<List<Availability>> GetAll()
        {
            if (!_db.Availability.IsNullOrEmpty())
                return Ok(_db.Availability.ToList());
            return NoContent();
        }

        //api/Availability/Get/:Id
        [HttpGet("{id}")]

        public ActionResult<Availability> Get(int id)
        {
            if (!_db.Availability.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.Availability.Where(x => x.Id == id));

            else
                return NoContent();
        }

        //api/Availability/Add
        [HttpPost]

        public ActionResult<Availability> Add([FromBody] Availability availability)
        {
            try
            {
                _db.Add(availability);
                _db.SaveChanges();
                return Ok(availability);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/Availability/Edit/:id
        [HttpPut("{id}")]

        public ActionResult Edit([FromBody] Availability availability, int id)
        {
            var _availability = _db.Availability.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (availability.Date != null)
                    _availability.Date = availability.Date;
                if (availability.AvailableFrom != null)
                    _availability.AvailableFrom = availability.AvailableFrom;
                if (availability.AvailableTo != null)
                    _availability.AvailableTo = availability.AvailableTo;
                if (availability.AppointmentDuration != null)
                    _availability.AppointmentDuration = availability.AppointmentDuration;

                _db.SaveChanges();
                return Ok(availability);


            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/Availability/Delete/:id
        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            try
            {
                var availabilityToDelete = _db.Availability.SingleOrDefault(x => x.Id == id);
                if (availabilityToDelete != null)
                {
                    _db.Availability.Remove(availabilityToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"Availability with ID {id} not found.");
            }
            catch (Exception err)
            {
                return BadRequest($"Could not delete: {err.Message}");
            }
        }
    }
}
