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
    public class SubCategoryController : Controller
    {
        private readonly DataContext _db;
        public SubCategoryController(DataContext db)
        {
            _db = db;
        }

        //api/SubCategory/GetAll
        [HttpGet]
        public ActionResult<List<SubCategory>> GetAll()
        {
            if (!_db.SubCategory.IsNullOrEmpty())
                return Ok(_db.SubCategory.ToList());

            return NoContent();
        }
        //api/SubCategory/Get/:id
        [HttpGet("{id}")]
        public ActionResult<SubCategory> Get(int id)
        {
            if (!_db.SubCategory.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.SubCategory.Where(x => x.Id == id));
            else
                return NoContent();
        }
        //api/SubCategory/Add
        [HttpPost]
        public ActionResult<SubCategory> Add([FromBody] SubCategory subCategory)
        {
            try
            {
                _db.SubCategory.Add(subCategory);
                _db.SaveChanges();
                return Ok(subCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //api/SubCategory/Edit/:id
        [HttpPut("{id}")]
        public ActionResult Edit([FromBody] SubCategory subCategory, int id)
        {
            var _subCategory = _db.SubCategory.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (!string.IsNullOrEmpty(subCategory.Name))
                    _subCategory.Name = subCategory.Name;
                _db.SaveChanges();
                return Ok(subCategory);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/SubCategory/Delete/:id

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var subCategoryToDelete = _db.SubCategory.SingleOrDefault(x => x.Id == id);
                if (subCategoryToDelete != null)
                {
                    _db.SubCategory.Remove(subCategoryToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"SubCategory with ID {id} not found.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }
    }
}
