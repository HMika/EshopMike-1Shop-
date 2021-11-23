using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace Models.Controllers
{
    public class ShopController : Controller
    {
        private EshopDbContext db = new EshopDbContext();

        public IActionResult Index()
        {
            List<Products> products = new List<Products>();

            if (db.Article.Count() > 0)
            {
                foreach (var item in db.Products)
                {
                    products.Add(item);
                }
            }
            return View(products);
        }

        
        [HttpPost]
        public IActionResult CheckCountOfProduct(int id, int quantity) 
        {
            int? totalProductQuatityFromDb = GetProductsCountDispositionFromDb(id);
            if (quantity > totalProductQuatityFromDb)
            {
                TempData["TotalCountOfProducError"] = totalProductQuatityFromDb;
                return RedirectToAction("Detail",new {id = id});
            }

            return RedirectToAction("BeforeAddToCart", "Cart", new { id = id, quantity = quantity});
        }


        public IActionResult Detail(int? id) 
        {
            Products product = db.Products.Find(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }

        /// <summary>
        /// Return count of  products  of  disposition from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int? GetProductsCountDispositionFromDb(int? id)
        {
            Products product = db.Products.Find(id);
            return product.Quantity;   // total count of  product in database for sale
        }
    }
}
