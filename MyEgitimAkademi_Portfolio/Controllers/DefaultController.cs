using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = db.About.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAward()
        {
            var values = db.Award.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCustomer()
        {
            return PartialView();
        }

        public PartialViewResult PartialCustomerStatistic()
        {
            var values = db.Statistic.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCustomerSponsor()
        {
            var values = db.Sponsor.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            var values = db.Footer.ToList();
            return PartialView(values);
        }
    }
}