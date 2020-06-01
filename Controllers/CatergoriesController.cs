using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_2.Controllers
{
    public class CatergoriesController : Controller
    {
        public IActionResult Index()
        {
        
            return View();
        }

 
        public IActionResult Details(string product)
        {
            //Store the selected product name in the ViewBag container
            //ViewBag is automatically passed back to the view that loads

            ViewBag.product = product;
            return View();
        }
    }
}
