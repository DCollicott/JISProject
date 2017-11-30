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
            var model = new CalcModel();

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CalcModel model)
        {
            model.Process();

            return View(model);
        }

    }
}