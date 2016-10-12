using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult theSearch()
        {
            return View();
        }


        public ActionResult Search()
        {
            string Data = Request["Data"];
            if (Data != "反社会"&&Data!="反地球"&&Data!="反人类")
            {
                return Content(Data);
            }
            else return Content("0");
        }
    }
}
