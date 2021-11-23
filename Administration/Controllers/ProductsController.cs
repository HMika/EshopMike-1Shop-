using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Data;

namespace Administration.Controllers
{
    public class ProductsController : Controller
    {
        private EshopDbContext db = new EshopDbContext();

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }


        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            Products products = db.Products.Find(id);
            if (products != null)
            {
                return View(products);
            }

            return NotFound();
        }



        [HttpPost]
        public IActionResult Edit(Products model) 
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View("Detail", new { id = model.Id});
        }



        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            Products model = db.Products.Find(id);
            var orderedBasket = db.OrderedBasket.Where(x => x.ProductId == model.Id).ToList();
            if (orderedBasket.Count() > 0)
            {
                foreach (var item in orderedBasket)
                {
                    db.OrderedBasket.Remove(item);
                    db.SaveChanges();
                }
            }
            
            db.Products.Remove(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Products model) 
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
