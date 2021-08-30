using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parteIII.Models;

namespace parteIII.Controllers
{
    public class BancoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login()
        {
            return View();

        }
    }
}