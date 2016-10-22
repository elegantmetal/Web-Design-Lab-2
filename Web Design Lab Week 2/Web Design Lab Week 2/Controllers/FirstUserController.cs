using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Design_Lab_Week_2.Models;
using Web_Design_Lab_Week_2.Data;

namespace Web_Design_Lab_Week_2.Controllers
{
    public class FirstUserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var Users = WebAppDatabase.m_users;

            return View(Users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create (User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            WebAppDatabase.m_users.Add(user);

            return RedirectToAction("Index");
        }
    }
}