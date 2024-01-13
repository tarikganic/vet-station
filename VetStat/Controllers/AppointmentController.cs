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
    public class AppointmentController : Controller
    {
        private readonly DataContext _db;
        public AppointmentController(DataContext db)
        {
            _db = db;
        }
        //api/Appointment/GetAll
        [HttpGet]

        public ActionResult<List<Appointment>> GetAll()
        {
            if (!_db.Appointment.IsNullOrEmpty())
                return Ok(_db.Appointment.ToList());
            return NoContent();
        }

        //api/Appointment/Get/:id
        [HttpGet("{id}")]

        public ActionResult<Appointment> Get(int id)
        {
            if (!_db.Appointment.Where(x => x.Id == id).IsNullOrEmpty())
                return Ok(_db.Appointment.Where(x => x.Id == id));
            else
                return NoContent();
        }

        //api/Product/Add
        [HttpPost]

        public ActionResult<Appointment> Add([FromBody] Appointment appointment)
        {
            try
            {
                _db.Appointment.Add(appointment);
                _db.SaveChanges();
                return Ok(appointment);
            }
            catch (Exception err)
            {
                return BadRequest(err.InnerException.Message);
            }
        }

        //api/Appointment/Edit/:id
        [HttpPut("{id}")]

        public ActionResult Edit([FromBody] Appointment appointment, int id)
        {
            var _appointment = _db.Appointment.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                if (appointment.CustomerId != null)
                    _appointment.CustomerId = appointment.CustomerId;
                if (appointment.VetStationId != null)
                    _appointment.VetStationId = appointment.VetStationId;
                if (appointment.EmployeeId != null)
                    _appointment.EmployeeId = appointment.EmployeeId;
                if (appointment.TimeSlotId != null)
                    _appointment.TimeSlotId = appointment.TimeSlotId;
                if (appointment.AnimalId != null)
                    _appointment.AnimalId = appointment.AnimalId;

                _db.SaveChanges();
                return Ok(appointment);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        //api/Appointment/Delete
        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            try
            {
                var appointmentToDelete = _db.Appointment.SingleOrDefault(x => x.Id == id);
                if (appointmentToDelete != null)
                {
                    _db.Appointment.Remove(appointmentToDelete);
                    _db.SaveChanges();
                    return Ok("Object deleted!");
                }
                else
                    return NotFound($"Appointment with ID {id} not found.");
            }
            catch (Exception err)
            {
                return BadRequest($"Could not delete: {err.Message}");
            }
        }
    }

}
