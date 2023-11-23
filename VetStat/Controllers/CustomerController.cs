using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;
using VetStat.Helpers.Validators;
using VetStat.Models;

namespace VetStat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly DataContext _db;

        public CustomerController(DataContext db)
        {
            _db = db;
        }

        //api/Customer/GetAll
        [HttpGet]
        public ActionResult<List<Customer>> GetAll()
        {
            if (!_db.Customer.IsNullOrEmpty())
                return Ok(_db.Customer.ToList());
            return NoContent();
        }

        //api/Customer/Get/:id
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            if (!_db.Customer.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.Customer.Where<Customer>(x => x.Id == id));
            else return NoContent();
        }


        //api/Customer/Add
        [HttpPost]
        public ActionResult<Customer> Add([FromBody] Customer customer)
        {
            try
            {
                Services.CustomerValidator(customer);

                _db.Customer.Add(customer);
                _db.SaveChanges();

                return Ok(customer);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/Customer/Edit/:id
        [HttpPut("{id}")]
        public ActionResult Edit([FromBody] Customer customer, int id)
        {
            var _customer = _db.Customer.Where(x => x.Id == id).FirstOrDefault();

            try
            {
                Services.UpdateEntity(_customer, customer);

                _db.SaveChanges();
                return Ok(customer);
            }

            catch (Exception err)
            {
                return BadRequest(err.Message); //Error message
            }
        }

        //api/Customer/Delete/:id
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
                try
                {
                    var customerToDelete = _db.Customer.SingleOrDefault(x => x.Id == id);
                    if (customerToDelete != null)
                    {
                        _db.Customer.Remove(customerToDelete);
                        _db.SaveChanges();
                        return Ok("Object deleted!");
                    }
                    else
                    {
                        return NotFound($"Customer with ID {id} not found.");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest($"Could not delete: {ex.Message}");
                }
            
        }


    }
}
