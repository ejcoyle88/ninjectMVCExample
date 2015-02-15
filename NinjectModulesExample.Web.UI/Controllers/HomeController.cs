using NinjectModulesExample.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectModulesExample.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private WidgitDiscombobulationManager _widgitDiscombobulationManager;

        public HomeController(WidgitDiscombobulationManager widgitDiscombobulationManager)
        {
            _widgitDiscombobulationManager = widgitDiscombobulationManager;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
