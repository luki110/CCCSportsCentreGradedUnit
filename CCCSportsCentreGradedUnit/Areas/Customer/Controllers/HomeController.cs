﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CCCSportsCentreGradedUnit.Models;
using Microsoft.AspNetCore.Authorization;

namespace CCCSportsCentreGradedUnit.Areas.Customer.Controllers
{
    [AllowAnonymous]
    [Area("Customer")]
    public class HomeController : Controller
    {
        /// <summary>
        /// Display home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// display about page
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {          

            return View();
        }

        /// <summary>
        /// display contact page
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Display information about cafe/bar 
        /// </summary>
        /// <returns></returns>
        public IActionResult Cafe()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
