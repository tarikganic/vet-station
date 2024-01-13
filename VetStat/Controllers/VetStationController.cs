﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VetStat.Data;
using VetStat.Helpers.Validators;
using VetStat.Models;
using System.Data.SqlClient;

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
        [HttpGet("{id}")]
        public ActionResult<VetStation> Get(int id)
        {
            if (!_db.VetStation.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.VetStation.Where(x => x.Id == id));
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

                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [VetStation] OFF");

                return Ok(vetStation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        //api/VetStation/Edit
        [HttpPut("{id}")]
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

                if (_vetStation.IsInOffice != null)
                    _vetStation.IsInOffice = vetStation.IsInOffice;
                if (_vetStation.IsOnField != null)
                    _vetStation.IsOnField = vetStation.IsOnField;
                if (_vetStation.Parking != null)
                    _vetStation.Parking = vetStation.Parking;
                if (_vetStation.Wheelchair != null)
                    _vetStation.Wheelchair = vetStation.Wheelchair;
                if (_vetStation.Wifi != null)
                    _vetStation.Wifi = vetStation.Wifi;

                _db.SaveChanges();
                return Ok(vetStation);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/VetStation/Delete
        [HttpDelete("{id}")]
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
