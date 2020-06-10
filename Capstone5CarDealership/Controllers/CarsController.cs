using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Capstone5CarDealership.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Capstone5CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarsDBContext _context;
        public CarsController(CarsDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Cars>>> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return cars;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cars>> GetCarsById(int id)
        {
            var cars = await _context.Cars.FindAsync(id);
            if (cars == null)
            {
                return NotFound();
            }
            else
            {
                return cars;
            }
        }       

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCars(int id)
        {
            var cars = await _context.Cars.FindAsync(id);
            if (cars == null)
            {
                return NotFound();
            }
            else
            {
                _context.Cars.Remove(cars);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddCars(Cars newCars)
        {
            if(ModelState.IsValid)
            {
                _context.Cars.Add(newCars);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCars), new {id = newCars.Id}, newCars);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> PutCars(int id, Cars updatedCars)
        {
            if(id != updatedCars.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Entry(updatedCars).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}