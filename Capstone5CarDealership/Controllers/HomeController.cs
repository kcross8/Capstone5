using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Capstone5CarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone5CarDealership.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarsDBContext _context;
        private readonly CarsAPIDAL CD;
        public HomeController(CarsDBContext context)
        {
            CD = new CarsAPIDAL();
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Cars> cars = await CD.GetCars();
            return View(cars);
        }

        public async Task<IActionResult> Search(string make, string model, string color, int? year)
        {
            List<Cars> cars = await CD.GetCars();
            List<Cars> found = cars.Where(x => 
            (make == null || x.Make.ToLower() == make.ToLower())
            && (model == null || x.Model.ToLower() == model.ToLower())
            && (color == null || x.Color.ToLower() == color.ToLower())
            && (year == null || x.Year == year)).ToList();

            return View(found);
        }
        public async Task<IActionResult> AddCars(string make, string model, string color, int year)
        {
            List<Cars> cars = await CD.GetCars();
            Cars newCar = new Cars();
            if(ModelState.IsValid)
            {
                newCar.Make = make;
                newCar.Model = model;
                newCar.Color = color;
                newCar.Year = year;
                _context.Cars.Add(newCar);
                _context.SaveChanges();
                //cars.Add(newCar);
                CD.AddCars(newCar);
            }
            return RedirectToAction("Index", cars);
        }
        public async Task<IActionResult> RemoveCars(int id)
        {
            List<Cars> cars = await CD.GetCars();
            Cars found = _context.Cars.Find(id);
            if (found != null)
            {
                _context.Cars.Remove(found);
                _context.SaveChanges();
                cars.Remove(found);
                CD.DeleteCar(id);
            }
            return RedirectToAction("Index", cars);
        }
        
        public async Task<IActionResult> UpdateCars(int id)
        {            
            Cars found =  _context.Cars.Find(id);            
            return View(found);
        }
        
        public async Task<IActionResult> ChangeCars(int id, string make, string model, string color, int year)
        {
            List<Cars> cars = await CD.GetCars();
            Cars found = _context.Cars.Find(id);
            if (found != null)
            {
                found.Make = make;
                found.Model = model;
                found.Year = year;
                found.Color = color;               
                
                _context.Entry(found).State = EntityState.Modified;
                _context.Update(found);
                await _context.SaveChangesAsync();
                CD.UpdateCar(id, found);
            }
            return RedirectToAction("Index", cars);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
