using firstproj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstproj.Controllers
{
    public class NewProjController : Controller
    {
        public IActionResult Name()
        {
            return View(new NewProjNameModel() {Name = "Ravi Yadav",ID ="1"});
        }
    }
}
