using Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleGrudOpreation_Product_And_Category_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products.Include(p=>p.Category).OrderBy(p=>p.CategoryId).ToList());
        }
        public IActionResult Fashion()
        {
            return View(_context.Products.Where(p=>p.Category.Name== "Man & Woman Fashion").Include(p => p.Category).ToList());
        }
        public IActionResult Electronic()
        {
            return View(_context.Products.Where(p => p.Category.Name == "Electronic").Include(p => p.Category).ToList());
        }
        public IActionResult Jewellery()
        {
            return View(_context.Products.Where(p => p.Category.Name == "Jewellery Accessorie").Include(p => p.Category).ToList());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
