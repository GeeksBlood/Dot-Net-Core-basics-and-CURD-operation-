using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDemo.Models.DB;
using CoreDemo.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreDemo.Controllers
{
    public class CurdController : Controller
    {
        private readonly IGenericRepository<Reg> _db;
        public CurdController(IGenericRepository<Reg> db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Reg> _reg = _db.GetAll().AsEnumerable();
            return View(_reg);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Reg obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Id == 0)
                {
                    _db.Create(obj);
                }
                else
                {
                    Reg _result = _db.GetByID(obj.Id);
                    _result.Name = obj.Name;
                    _result.Email = obj.Email;
                    _result.Mob = obj.Mob;
                    _result.Address = obj.Address;
                    _db.Update(_result);
                }
            }

            return RedirectToAction("Index");
        }



        public IActionResult Create(int id,string IsType)
        {
            if (IsType == "Edit")
            {
                Reg _reg = _db.GetByID(id);
                return View(_reg);
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
             _db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View();
        }

       
    }
}
