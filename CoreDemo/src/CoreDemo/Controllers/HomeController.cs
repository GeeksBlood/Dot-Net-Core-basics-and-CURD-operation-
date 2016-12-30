using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDemo.Models.DB;
using CoreDemo.Repository;

namespace CoreDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericRepository<Reg> _db;
        public HomeController(IGenericRepository<Reg> db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var result= _db.GetAll().ToList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
