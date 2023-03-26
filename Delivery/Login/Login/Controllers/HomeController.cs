using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;

namespace Login.Controllers
{
    public class HomeController : Controller
    {

        QLGHEntities db = new QLGHEntities();
        public ActionResult Index()
        {
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

        public ActionResult Login()
        {
            if (Session["User"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            var username = user.userName;
            var pass = user.userPass;
            var check = db.Users.SingleOrDefault(c => c.userName.Equals(username) && c.userPass.Equals(pass));
            if (ModelState.IsValid && username != null && pass != null)
            {
                if (check != null)
                {
                    Session["User"] = check;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng !");
                    return View("Login");
                }
            }
            else
            {
                ModelState.AddModelError("", "Chưa nhập tài khoản hoặc mật khẩu !");
                return View("Login");
            }
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return View("Index");
        }
    }
}