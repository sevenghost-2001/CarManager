﻿using CarManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarManager.Controllers
{
    public class HomeController : Controller
    {
        CarDealerContext db= new CarDealerContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XeTheoLoai(string maloai)
        {
            List<Car> cars = db.Cars.Where(x=>x.Model == maloai).ToList();
            return View(cars);  
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