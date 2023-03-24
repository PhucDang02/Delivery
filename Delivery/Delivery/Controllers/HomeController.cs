using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delivery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            string a = System.Web.HttpContext.Current.Session["ChucNang"].ToString();

            dt = dt;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}