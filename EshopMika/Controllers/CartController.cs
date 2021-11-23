using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Data;
using Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Models.Controllers
{
    public class CartController : Controller
    {

        private EshopDbContext db = new EshopDbContext();

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if (TempData["MyBasket"] == null)
                TempData["MyBasket"] = TempData["basketX"];

            if (TempData["MyBasket"] != null)
            {
                string getAllOrdersFromBasket = TempData["MyBasket"].ToString();
                string[] itemsInBasket = getAllOrdersFromBasket.Split(";");
                List<int> tmpQuantity = new List<int>();

                Dictionary<int, string> productDic = new Dictionary<int, string>();

                foreach (string x in itemsInBasket)
                {
                    string[] item = x.Split(":");

                    if (!productDic.ContainsKey(int.Parse(item[0])))
                    {
                        productDic.Add(int.Parse(item[0]), item[1]);
                        tmpQuantity.Add(int.Parse(item[1]));
                    }
                }

                List<Products> products = new List<Products>();
                foreach (var item in productDic)
                {
                    Products prod = db.Products.Find(item.Key);

                    products.Add(prod);
                }



                MyBasket myBasket = new MyBasket()
                {
                     ProductList = products,
                     TotalPrice = int.Parse(products.Sum(x => x.Price).ToString()),
                     Quantity = tmpQuantity
                      
                };

                foreach (var item in myBasket.ProductList)
                {

                    var data = db.Basket.Find(item.Id);
                    if (data == null)
                    {
                        var basket = new Data.Basket
                        {
                            ProductId = item.Id,
                            Quantity = item.Quantity
                        };
                        db.Basket.Add(basket);
                        db.SaveChanges();
                    }

                }
                

                ViewData["Data"] = myBasket.ProductList;
                TempData["basketX"] = getAllOrdersFromBasket;

                return View(myBasket);
            }

            return View();
        }
        /// <summary>
        /// Cart
        /// </summary>
        /// <returns></returns>
        public IActionResult Cart() 
        {
            List<Products> productList = GetProductsForBasket(null);
            var saveData = TempData["basketX"].ToString();

            string[] itemsInBasket = saveData.Split(";");
            List<int> tmpQuantity = new List<int>();

            Dictionary<int, string> productDic = new Dictionary<int, string>();

            foreach (string x in itemsInBasket)
            {
                string[] item = x.Split(":");

                if (!productDic.ContainsKey(int.Parse(item[0])))
                {
                    productDic.Add(int.Parse(item[0]), item[1]);
                    tmpQuantity.Add(int.Parse(item[1]));
                }
            }

            var myBasket = new Models.MyBasket
            {
                ProductList = productList,
                Quantity = tmpQuantity
            };

            TempData["basketX"] = saveData;
            return View(myBasket);
        }

        [HttpPost]
        public IActionResult Cart(Orders orders)
        {
            int? tmpOrderId = 0;
            if (ModelState.IsValid)
            {
                db.Orders.Add(orders);
                db.SaveChanges();
                var basketFromDb = db.Basket.Where(x => x.OrderId == null).ToList();
                foreach (var item in basketFromDb)
                {
                    item.OrderId = orders.Id;
                    tmpOrderId = item.OrderId;
                    db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

                
                return RedirectToAction("CartInformation", new {orderId = tmpOrderId});
            }

            return BadRequest();
        }


        private List<Products> GetProductsForBasket(int? orderId) 
        {
            
            List<Products> productList = new List<Products>();
            List<int> prodId = new List<int>();

            if (orderId != null)
            {
                foreach (var item in db.Basket.Where(x => x.OrderId == orderId))
                {
                    prodId.Add(item.ProductId);
                }
            }
            else 
            {
                foreach (var item in db.Basket)
                {
                    if (orderId == null)
                    {
                        if (item.OrderId == null)
                        {
                            prodId.Add(item.ProductId);  
                        }
                    }
                }
            }
            

            foreach (var item in prodId)
            {
                var product = db.Products.Find(item);
                productList.Add(product);
            }

            return productList;
        }

        /// <summary>
        /// Cart information
        /// </summarys       
        /// <returns></returns>
        public IActionResult CartInformation(int? orderId)
        {
            
            var getLastOrder = db.Orders.OrderBy(x=>x.Id).Last();
            if (orderId == 0)
            {
                orderId = getLastOrder.Id;
            }
            List<Products> productList = GetProductsForBasket(orderId);

            var saveData = TempData["basketX"].ToString();

            string[] itemsInBasket = saveData.Split(";");
            List<int> tmpQuantity = new List<int>();

            Dictionary<int, string> productDic = new Dictionary<int, string>();

            foreach (string x in itemsInBasket)
            {
                string[] item = x.Split(":");

                if (!productDic.ContainsKey(int.Parse(item[0])))
                {
                    productDic.Add(int.Parse(item[0]), item[1]);
                    tmpQuantity.Add(int.Parse(item[1]));
                }
            }

            var myBasket = new Models.MyBasket
            {
                ProductList = productList,
                Quantity = tmpQuantity
            };

            TempData["basketX"] = saveData;




            CartInformation cartInformation = new CartInformation
            {
                Orders = getLastOrder,
                Products = productList,
                MyBasket = myBasket
            };
            
            return View(cartInformation);
        }

        /// <summary>
        /// Cart shipping
        /// </summary>
        /// <returns></returns>
        public IActionResult CartShipping() 
        {
            var getLastOrder = db.Orders.OrderBy(x => x.Id).Last();
            List<Products> productList = GetProductsForBasket(getLastOrder.Id);

            var saveData = TempData["basketX"].ToString();

            string[] itemsInBasket = saveData.Split(";");
            List<int> tmpQuantity = new List<int>();

            Dictionary<int, string> productDic = new Dictionary<int, string>();

            foreach (string x in itemsInBasket)
            {
                string[] item = x.Split(":");

                if (!productDic.ContainsKey(int.Parse(item[0])))
                {
                    productDic.Add(int.Parse(item[0]), item[1]);
                    tmpQuantity.Add(int.Parse(item[1]));
                }
            }

            var myBasket = new Models.MyBasket
            {
                ProductList = productList,
                Quantity = tmpQuantity
            };

            TempData["basketX"] = saveData;


            CartInformation cartInformation = new CartInformation
            {
                Orders = getLastOrder,
                Products = productList,
                MyBasket = myBasket
            };
            return View(cartInformation);
        }

        /// <summary>
        /// Cart payment
        /// </summary>
        /// <returns></returns>
        public IActionResult CartPayment() 
        {
            var getLastOrder = db.Orders.OrderBy(x => x.Id).Last();
            List<Products> productList = GetProductsForBasket(getLastOrder.Id);

            var getBasket = db.Basket.Where(i => i.OrderId == getLastOrder.Id).ToList();

            var saveData = TempData["basketX"].ToString();

            string[] itemsInBasket = saveData.Split(";");
            List<int> tmpQuantity = new List<int>();

            Dictionary<int, string> productDic = new Dictionary<int, string>();

            foreach (string x in itemsInBasket)
            {
                string[] item = x.Split(":");

                if (!productDic.ContainsKey(int.Parse(item[0])))
                {
                    productDic.Add(int.Parse(item[0]), item[1]);
                    tmpQuantity.Add(int.Parse(item[1]));
                }
            }

            var myBasket = new Models.MyBasket
            {
                ProductList = productList,
                Quantity = tmpQuantity
            };

            TempData["basketX"] = saveData;


            foreach (var item in getBasket)
            {
                var getQuantity = productDic[item.ProductId];
                var orderedBasket = new Data.OrderedBasket
                {
                    OrderId = item.OrderId,
                    ProductId = item.ProductId,
                    Quantity = int.Parse(getQuantity)

                };



                db.OrderedBasket.Add(orderedBasket);
                db.SaveChanges();
            }

            foreach (var item in db.Basket)
            {
                db.Basket.Remove(item);
            }

            db.SaveChanges();
            TempData.Clear();
            return View(myBasket);
        }



        /// <summary>
        ///  Vysype  kosik
        /// </summary>
        /// <returns></returns>
        public IActionResult ClearCart() 
        {
            TempData.Clear();

            foreach (var item in db.Basket)
            {
                db.Basket.Remove(item);
            }
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BeforeAddToCart(int id, int quantity) 
        {
            return RedirectToAction("AddToCart", new {id = id, quantity = quantity });
        }


        /// <summary>
        /// Add  product to cart
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public IActionResult AddToCart(int id, int quantity) 
        {
            if (TempData["MyBasket"] == null)
            {
                if (TempData["basketX"] != null)
                {
                    string temp = TempData["basketX"].ToString();
                    TempData["MyBasket"] = temp;
                }
            }


            if (TempData["MyBasket"] != null)
            {
                string addProductToBasket = TempData["MyBasket"].ToString();
                string newBasket = addProductToBasket + ";" + id + ":" + quantity;

                // create new basket  from old basket
                TempData["MyBasket"] = newBasket;
            }
            else 
            {
                // create  my basket       
                string tmpBasket = id + ":" + quantity;

                TempData["MyBasket"] = tmpBasket;
            }
            

            return RedirectToAction("Index");
        }

       

    }
}
