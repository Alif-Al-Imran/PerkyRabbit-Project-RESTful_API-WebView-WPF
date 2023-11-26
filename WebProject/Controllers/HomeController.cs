using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var Pass = user.password;
            try
            {
                var db = new UserContext();
                var u = db.Users.Find(user.uname);
                if(u != null && u.password == user.password)
                {
                    TempData["msg"] = "Login successful!";
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    TempData["msg"] = "Login failed!";
                    return RedirectToAction("Login");
                }    
            }
            catch (Exception e)
            {
                TempData["msg"] = "Error" + e;
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(User user)
        {
            try
            {
                var db = new UserContext();
                db.Users.Add(user);
                db.SaveChanges();
                TempData["msg"] = "Create successful!";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["msg"] = "Error";
                return RedirectToAction("Index");
            }
        }
    }
}