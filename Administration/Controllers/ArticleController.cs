using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Data;

namespace Administration.Controllers
{
    public class ArticleController : Controller
    {

        private EshopDbContext db = new EshopDbContext();


        public IActionResult Index()
        {
            return View(db.Article.ToList());
        }


        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Article model) 
        {
            if (ModelState.IsValid)
            {
                db.Article.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id) 
        {
            Article model = db.Article.Find(id);

            db.Article.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            Article article = db.Article.Find(id);
            if (article != null)
            {
                return View(article);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Article model) 
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
