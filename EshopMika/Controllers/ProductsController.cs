using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace Models.Controllers
{
    public class ProductsController : Controller
    {
        private EshopDbContext db = new EshopDbContext();

        /// <summary>
        /// Show Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(int? id, List<string> Vendor, List<int?> Rate, List<string> Size)
        {
            List<Products> products = new List<Products>();

            if (id == null)
            {
                // Show all Products  from database
                if (db.Article.Count() > 0)
                {
                    foreach (var item in db.Products)
                    {
                        products.Add(item);
                    }
                }

                // Filter product by Vendor
                if (Vendor.Count() > 0)
                {
                    List<Products> getProductsByVendor = new List<Products>();
                    foreach (var item in Vendor)
                    {
                        var data = products.Where(x => x.Vendor == item).ToList();
                        getProductsByVendor.AddRange(data);
                    }
                   
                    products.Clear();
                    products = getProductsByVendor;
                }

                // Filter product by Rate
                if (Rate.Count() > 0)
                {
                    List<Products> getProductsByRate = new List<Products>();
                    foreach (var item in Rate)
                    {

                        if (item != 0)
                        {
                            var data = products.Where(x => x.Rate == item).ToList();
                            getProductsByRate.AddRange(data);
                        }
                        else {
                            var data = products.Where(x => x.Rate == null).ToList();
                            getProductsByRate.AddRange(data);
                        }
                    }
                    products.Clear();
                    products = getProductsByRate;
                }

                // Filter product by Size
                if (Size.Count()  > 0)
                {
                    List<Products> getProductsBySize = new List<Products>();
                    foreach (var item in Size)
                    {
                        var data = products.Where(x => x.Size == item).ToList();
                        getProductsBySize.AddRange(data);
                    }
                    products.Clear();
                    products = getProductsBySize;
                }
            }
            else 
            {
                List<int> productIdList = new List<int>();
                foreach (var item in db.ProductsCategory)
                {
                    if (item.Id == id)
                    {
                        productIdList.Add(item.IdProduct);
                    }
                }

                foreach (var item in productIdList)
                {
                    var getSpecificProductById = db.Products.Find(item);
                    products.Add(getSpecificProductById);

                }
            }

            List<Category> categories = db.Category.ToList();
            

            // vlastni model pro view (novy object)
            var productList = new Models.ProductList
            {
                Products = products,
                Categories = categories
            };

            return View(productList);
        }

        [HttpPost]
        public IActionResult SortIndex(List<string> Vendor, List<int?> Rate, List<string> Size) 
        {
            return RedirectToAction("Index", new { Vendor = Vendor, Rate = Rate, Size =  Size});
        }

        /// <summary>
        /// Show Detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Detail(int? id) 
        {
            return View();
        }



    }
}
