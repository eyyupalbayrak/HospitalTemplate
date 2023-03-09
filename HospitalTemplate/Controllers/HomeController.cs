using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalTemplate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Anasayfa = "active";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Hakkinda = "active";
            return View();
        }
        public ActionResult Service()
        {
            ViewBag.Hizmetler = "active";
            return View();
        }
        public ActionResult Pricing()
        {
            ViewBag.Fiyatlandirma = "active";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.İletisim = "active";
            return View();
        }
    }
}