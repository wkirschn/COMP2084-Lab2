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
            var products = new List<Product>();

         for (var i = 1; i <= 10; i++)
            {
                products.Add(new Product { Name = "Product " + i.ToString() });
            }



            return View(products);
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
