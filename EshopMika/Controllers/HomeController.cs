using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Models;
using Models.Data;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private EshopDbContext db = new EshopDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Show Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<Products> products = new List<Products>();

            if (db.Products.Count() > 0)
            {
                foreach (var item in db.Products)
                {
                    products.Add(item);
                }
            }

            return View(products);
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
