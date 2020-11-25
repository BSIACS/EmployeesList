using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesList_Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult EmployeesList()
        {
            return View();
        }
    }
}
