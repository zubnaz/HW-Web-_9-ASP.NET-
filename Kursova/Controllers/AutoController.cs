using Kursova.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursova.Controllers
{
    public class AutoController : Controller
    {
        AutoDbContext adc = new AutoDbContext();
        public IActionResult Index()
        {
            return View(adc);
        }
    }
}
