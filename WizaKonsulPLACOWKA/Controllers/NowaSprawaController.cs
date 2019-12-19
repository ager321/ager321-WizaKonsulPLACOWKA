using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WizaKonsulPLACOWKA.Controllers
{
    public class NowaSprawaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}