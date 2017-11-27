using System;
using System.Web;
using System.Web.Mvc;
using JISProject.App.Models;


namespace JISProject.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(CalcModel Model)
        {
            return View();
        }

    }
}