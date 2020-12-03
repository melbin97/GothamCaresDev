using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCares.Web.Controllers
{
    public class OutletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
