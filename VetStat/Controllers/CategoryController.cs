﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;
using VetStat.Helpers.Validators;
using VetStat.Models;

namespace VetStat.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly DataContext _db;
        public CategoryController(DataContext db)
        {
            _db = db;
        }

        //api/Category/GetAll
        [HttpGet]
        public ActionResult<List<Category>> GetAll()
        {
            if (!_db.Category.IsNullOrEmpty())
                return Ok(_db.Category.ToList());

            return NoContent();
        }
        //api/Category/Get/:id
        [HttpGet("{id:int}")]
        public ActionResult<Category> Get(int id)
        {
            if (!_db.Category.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.Category.Where(x => x.Id == id));
            else
                return NoContent();
        }
        //api/Category/Add
        [HttpPost]
        public ActionResult<Category> Add([FromBody] Category category)
        {
            try
            {
                _db.Category.Add(category);
                _db.SaveChanges();
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //api/Category/Edit/:id
        [HttpPut("{id:int}")]
        public ActionResult Edit([FromBody] Category category, int id)
        {
            var _category = _db.Category.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (!string.IsNullOrEmpty(category.Name))
                    _category.Name = category.Name;

                _db.SaveChanges();
                return Ok(category);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/Category/Delete/:id

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var categoryToDelete = _db.Category.SingleOrDefault(x => x.Id == id);
                if (categoryToDelete != null)
                {
                    _db.Category.Remove(categoryToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"Category with ID {id} not found.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }
    }
}
