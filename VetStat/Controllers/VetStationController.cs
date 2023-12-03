using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;
using VetStat.Models;


namespace VetStat.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VetStationController : Controller
    {
        private readonly DataContext _db;
        public VetStationController(DataContext db)
        {
            _db = db;
        }
        //api/VetStation/GetAll
        [HttpGet]
        public ActionResult<List<VetStation>> GetAll()
        {
            if (!_db.VetStation.IsNullOrEmpty())
                return Ok(_db.VetStation.ToList());
            return NoContent();
        }

        //api/VetStation/Get/:id
        [HttpGet("{id:int}")]
        public ActionResult<VetStation> Get(int id)
        {
            if(!_db.VetStation.Where(x=> x.Id == id).IsNullOrEmpty())
                return Ok(_db.VetStation.Where(x =>  x.Id == id));
            return NoContent();
        }

        //api/VetStation/Add
        [HttpPost]
        public ActionResult<VetStation> Add([FromBody] VetStation vetStation)
        {
            try
            {
                _db.VetStation.Add(vetStation);
                _db.SaveChanges();
                return Ok(vetStation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/VetStation/Edit
        [HttpPut("{id:int}")]
        public ActionResult Edit([FromBody] VetStation vetStation, int id)
        {
            var _vetStation = _db.VetStation.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (!string.IsNullOrEmpty(vetStation.Name))
                    _vetStation.Name = vetStation.Name;
                if (vetStation.CityId != null)
                    _vetStation.CityId = vetStation.CityId;
                if (!string.IsNullOrEmpty(vetStation.ContactNumber))
                    _vetStation.ContactNumber = vetStation.ContactNumber;
                _db.SaveChanges();
                return Ok(vetStation);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/VetStation/Delete
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var vetStationToDelete = _db.VetStation.SingleOrDefault(x => x.Id == id);
                if (vetStationToDelete != null)
                {
                    _db.VetStation.Remove(vetStationToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"Vet Station with ID {id} not found.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }
    }
}
