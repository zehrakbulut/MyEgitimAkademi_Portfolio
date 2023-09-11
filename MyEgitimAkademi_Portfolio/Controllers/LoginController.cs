using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = db.Admin.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["username"] = values.Username.ToString();
                return RedirectToAction("Index", "Service");
            }
            return View();
        }
    }
}