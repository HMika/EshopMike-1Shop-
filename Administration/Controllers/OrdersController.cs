using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Data;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace Administration.Controllers
{
    public class OrdersController : Controller
    {
        private EshopDbContext db = new EshopDbContext();

        [HttpGet]
        public IActionResult Index()
        {
            var dataFromDb = db.Orders.ToList();
            return View(dataFromDb);
        }

        [HttpGet]
        public IActionResult Detail(int? id) 
        {
            List<Products> productsList = new List<Products>();
            var orderedBasket = db.OrderedBasket.Where(x=>x.OrderId == id).ToList();
            if (orderedBasket.Count > 0)
            {
                foreach (var item in orderedBasket)
                {
                    Products products = db.Products.Find(item.ProductId);
                    products.Quantity = item.Quantity;
                    productsList.Add(products);
                }
            }

            var dataForView = new PreOrderedProduct
            {
                Products = productsList
            };

            return View(dataForView);
        }
    }
}
