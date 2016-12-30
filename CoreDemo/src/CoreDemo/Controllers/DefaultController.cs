using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreDemo.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ILogger _logger;
        public DefaultController(ILogger<DefaultController> logger)
        {
            this._logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            _logger.LogInformation("This is the start method");
            return View();
        }
    }
}
