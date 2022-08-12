using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using odev_web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace odev_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult  AllCreatures()
        {

            return View();
        }
     
        public ViewResult Contact()
        {

            return View();
        }


    }

}
