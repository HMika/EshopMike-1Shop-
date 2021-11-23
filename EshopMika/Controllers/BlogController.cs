using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Data;
using Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Models.Controllers
{
    public class BlogController : Controller
    {
        private EshopDbContext db = new EshopDbContext();

        public IActionResult Index()
        {
            List<Article> articles = new List<Article>();

            if (db.Article.Count() > 0)
            {
                foreach (var item in db.Article)
                {
                    articles.Add(item);
                }
            }
            return View(articles);
        }

        /// <summary>
        /// Show detail of article // READ MORE btn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Detail(int? id)
        {
            Article article = db.Article.Find(id);
            if (article != null)
            {
                return View(article);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult PostComment(Data.CustomerComments commentModel)
        {
            Data.CustomerComments dataModel = new Data.CustomerComments();
            if (commentModel != null)
            {
                dataModel.Firstname = commentModel.Firstname;
                dataModel.Email = commentModel.Email;
                dataModel.Message = commentModel.Message;

                db.CustomerComments.Add(dataModel);
                db.SaveChanges();
            }

            return View();

        }

    }
}
