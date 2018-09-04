using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalQ2.ViewModels;
using FinalQ2.DAL;

namespace FinalQ2.Controllers
{
    public class HomeController : Controller
    {
        NorthwindDB db = new NorthwindDB();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult CustomerView(CustomerViewModel customer)
        {
            return View(customer);
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