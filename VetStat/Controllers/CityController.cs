using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;
using VetStat.Helpers.Validators;
using VetStat.Models;

namespace VetStat.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly DataContext _db;
        public CityController(DataContext db)
        {
            _db = db;
        }

        //api/City/GetAll
        [HttpGet]
        public ActionResult<List<City>> GetAll()
        {
            if (!_db.City.IsNullOrEmpty())
                return Ok(_db.City.ToList());

            return NoContent();
        }
        //api/City/Get/:id
        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            if (!_db.City.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.City.Where(x => x.Id == id));
            else
                return NoContent();
        }
        //api/City/Add
        [HttpPost]
        public ActionResult<City> Add([FromBody] City city)
        {
            try
            {
                _db.City.Add(city);
                _db.SaveChanges();
                return Ok(city);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //api/City/Edit/:id
        [HttpPut("{id}")]
        public ActionResult Edit([FromBody] City city, int id)
        {
            var _city = _db.City.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                Services.UpdateEntityCity(_city, city);
                _db.SaveChanges();
                return Ok(city);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/City/Delete/:id
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var cityToDelete = _db.City.SingleOrDefault(x => x.Id == id);
                if (cityToDelete != null)
                {
                    _db.City.Remove(cityToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"City with ID {id} not found.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }
    }
}
