using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new HomeViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            
            return View(vm);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}