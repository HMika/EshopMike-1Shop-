using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace Models.Controllers
{
    public class ContactController : Controller
    {
        private EshopDbContext db = new EshopDbContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostComment(Data.Feedback  feedback) 
        {
            if (feedback != null)
            {
                db.Feedback.Add(feedback);
                db.SaveChanges();
                return View();
            }

            return NotFound();
        }
    }
}
