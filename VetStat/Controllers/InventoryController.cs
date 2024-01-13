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
    public class InventoryController : Controller
    {
        private readonly DataContext _db;
        public InventoryController(DataContext db)
        {
            _db = db;
        }

        //api/Inventory/GetAll
        [HttpGet]
        public ActionResult<List<Inventory>> GetAll()
        {
            if (!_db.Inventory.IsNullOrEmpty())
                return Ok(_db.Inventory.ToList());

            return NoContent();
        }
        //api/Inventory/Get/:id
        [HttpGet("{id}")]
        public ActionResult<Inventory> Get(int id)
        {
            if (!_db.Inventory.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.Inventory.Where(x => x.Id == id));
            else
                return NoContent();
        }
        //api/Inventory/Add
        [HttpPost]
        public ActionResult<Inventory> Add([FromBody] Inventory inventory)
        {
            try
            {
                if (_db.VetStation.Where(x => x.Id == inventory.VetStationId).IsNullOrEmpty())
                    throw new Exception("samir");
                _db.Inventory.Add(inventory);
                _db.SaveChanges();
                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //api/Inventory/Edit/:id
        [HttpPut("{id}")]
        public ActionResult Edit([FromBody] Inventory inventory, int id)
        {
            var _inventory = _db.Inventory.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (inventory.Quantity != null)
                    _inventory.Quantity = inventory.Quantity;
                if (inventory.DateOfEntry != null)
                    _inventory.DateOfEntry = inventory.DateOfEntry;
                if (inventory.ProductionDate != null)
                    _inventory.ProductionDate = inventory.ProductionDate;
                if (inventory.ExpireDate != null)
                    _inventory.ExpireDate = inventory.ExpireDate;
                if (!string.IsNullOrEmpty(inventory.Status))
                    _inventory.Status = inventory.Status;
                if (inventory.SellingPrice != null)
                    _inventory.SellingPrice = inventory.SellingPrice;

                _db.SaveChanges();
                return Ok(inventory);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/Admin/Delete/:id

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var inventoryToDelete = _db.Inventory.SingleOrDefault(x => x.Id == id);
                if (inventoryToDelete != null)
                {
                    _db.Inventory.Remove(inventoryToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"Inventory with ID {id} not found.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Could not delete: {ex.Message}");
            }
        }
    }
}
