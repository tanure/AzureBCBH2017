using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureBootcampBH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Erro forçado"); 
            ViewBag.Ambiente = ConfigurationManager.AppSettings["Ambiente"];
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