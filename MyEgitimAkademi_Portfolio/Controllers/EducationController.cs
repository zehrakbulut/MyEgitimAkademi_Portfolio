using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class EducationController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        
        public ActionResult Index()
        {
            var values = db.Education.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(Education education)
        {
            db.Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}