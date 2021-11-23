using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Models.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    public class AutenticationController : Controller
    {
        /// <summary>
        /// Instance of db
        /// </summary>
        private EshopDbContext db = new EshopDbContext();

        /// <summary>
        /// Admin  Controller
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(string username, string password)
        {
            if (username != string.Empty && password != string.Empty)
            {
                Admin admin = db.Admin.FirstOrDefault(x => x.Login == username);
                if (admin != null)
                {
                    if (admin.Password == password)
                    {
                        ViewBag.User = admin.Login;
                        HttpContext.Session.Set(admin.Login, JsonSerializer.SerializeToUtf8Bytes(admin.Login));
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["ErrorAuthentication"] = "Užívatelské jméno nebo heslo je nesprávně!";
                        return RedirectToAction("Login");
                    }

                }
            }


            TempData["ErrorAuthentication"] = "Užívatelské jméno nebo heslo je nesprávně!";
            return RedirectToAction("Login");
        }

        /// <summary>
        /// Sign out
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public IActionResult SignOut(string loginName) 
        {
            HttpContext.Session.Remove(loginName);
            return RedirectToAction("Login");
        }


    }
}
