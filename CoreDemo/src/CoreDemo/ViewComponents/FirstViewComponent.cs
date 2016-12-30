using CoreDemo.Models.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreDemo.Repository;

namespace CoreDemo.ViewComponents
{
    public class FirstViewComponent: ViewComponent
    {
        private readonly IGenericRepository<Reg> _db;
        public FirstViewComponent(IGenericRepository<Reg> db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            Reg result =  _db.GetByID(id);
            return View(result);

        }

    }
}
