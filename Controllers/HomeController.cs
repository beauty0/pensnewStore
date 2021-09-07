using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pensnewStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace pensnewStore.Controllers
{
    public class HomeController : Controller
    {
        //creating a constructor injection

        //error invalid operation exception error

        //solution 
        // addSingleton to the startup file using iproductrepo

    

        public IActionResult VIEW()
        {
            throw new NotImplementedException();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUS()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
