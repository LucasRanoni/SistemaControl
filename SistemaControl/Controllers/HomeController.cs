using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaControl.Models;
namespace SistemaControl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario) {
            if (ModelState.IsValid) {
                return View();
            }
            return View();
        }
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
    }
}