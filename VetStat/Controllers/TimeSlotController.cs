using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;
using VetStat.Helpers.Validators;
using VetStat.Models;


namespace VetStat.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TimeSlotController : Controller
    {
        private readonly DataContext _db;
        public TimeSlotController(DataContext db)
        {
            _db = db;
        }

        //api/TimeSlot/GetAll
        [HttpGet]
        public ActionResult<List<TimeSlot>> GetAll()
        {
            if (!_db.TimeSlot.IsNullOrEmpty())
                return Ok(_db.TimeSlot.ToList());

            return NoContent();
        }

        //api/TimeSlot/Get/:id
        [HttpGet("{id:int}")]
        public ActionResult<TimeSlot> Get(int id)
        {
            if (!_db.TimeSlot.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.TimeSlot.Where(x => x.Id == id));
            else
                return NoContent();
        }

        //api/TimeSlot/Add
        [HttpPost]
        public ActionResult<TimeSlot> Add([FromBody] TimeSlot timeslot)
        {
            try
            {
                _db.TimeSlot.Add(timeslot);
                _db.SaveChanges();
                return Ok(timeslot);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        //api/TimeSlot/Edit/:id
        [HttpPut("{id:int}")]
        public ActionResult Edit([FromBody] TimeSlot timeslot, int id)
        {
            var _timeslot = _db.TimeSlot.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (timeslot.AvailabilityId != null)
                    _timeslot.AvailabilityId = timeslot.AvailabilityId;
                if (timeslot.SlotEmployeeId != null)
                    _timeslot.SlotEmployeeId = timeslot.SlotEmployeeId;
                if (timeslot.SlotDateTime != null)
                    _timeslot.SlotDateTime = timeslot.SlotDateTime;
                if (timeslot.IsAvailable != null)
                    _timeslot.IsAvailable = timeslot.IsAvailable;

                _db.SaveChanges();
                return Ok(timeslot);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/TimeSlot/Delete/:id

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var timeslotToDelete = _db.TimeSlot.SingleOrDefault(x => x.Id == id);
                if (timeslotToDelete != null)
                {
                    _db.TimeSlot.Remove(timeslotToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"TimeSlot with ID {id} not found.");
            }
            catch (Exception err)
            {
                return BadRequest($"Could not delete: {err.Message}");
            }
        }
    }
}
