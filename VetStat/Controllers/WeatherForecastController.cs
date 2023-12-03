using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;

namespace Stat.Controllers
{
    //------------------------------------------------
    // ATTENTION!
    // THIS CONTROLLER IS MADE FOR EXAPMLE PURPOSES
    // FOR DEVELOPERS THAT ARE WORKING ON THIS PROJECT
    //------------------------------------------------

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly DataContext _db;
        public ExampleController(DataContext db)
        {
            _db = db;
        }

        //api/[controller]/GetAll
        [HttpGet]
        public ActionResult<List<object>> GetAll()
        {
            if (true)
                return Ok(value: new List<object>() { new { Id = 1, Name = "Example" } });
            return NoContent();
        }

        //api/[controller]/Get/:id
        [HttpGet("{id:int}")]
        public ActionResult<object> Get(int id)
        {
            var listFromDatabase = new List<object>() { new { Id = 1, Name = "Example1" }, new { Id = 2, Name = "Example2" } }; //_db.[DbSet].ToList();
            try
            {
                //This condition is just for example purposes 
                return Ok(listFromDatabase.Where(x => x.GetType().GetProperty("Id").GetValue(x).Equals(id)).ToList());   //this condition should mostly look like this ->!_db.[DbSet].Where(x => x.Id == id).IsNullOrEmpty()
            } 
            catch (Exception ex)
            {
                return NoContent();
            }
   
        }

        //api/[controller]/Add
        [HttpPost]
        public ActionResult<object> Add([FromBody] object obj)
        {
            try
            {
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/[controller]/Edit/:id
        [HttpPut("{id:int}")]
        public ActionResult Edit([FromBody] object obj, int id)
        {
            if (true) //e.g.
                return Ok(obj);
           return BadRequest();
        }

        //api/[controller]/Delete/:id
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var objectToDelete = new {Id = 1, Name = "Example"}; //var objectToDelete = _db.[DbSet].SingleOrDefault(x => x.Id == id);
                if (objectToDelete.Id == id)    //for example purpose
                    if (objectToDelete != null)
                    objectToDelete = null;      //    _db.[DbSet].Remove(objectToDelete);
                                                //    _db.SaveChanges();

                return Ok(objectToDelete);
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }
    }
}
