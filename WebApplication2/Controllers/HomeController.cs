using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IntPage1(string val)
        {
            TempData["w"] = val;
            return View("IntPage1");
        }
        public ActionResult IntPage2(string val)
        {
            TempData["w"] = val;
            return View("IntPage2");
        }
        public ActionResult IntPage()
        {
            string key = Request.Path.Substring(Request.Path.LastIndexOf('/') + 1);
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\NStone\\source\\repos\\WebApplication2\\WebApplication2\\App_Data\\Data.txt");
            string thisLine = lines.Where(a => a.StartsWith(key)).First();
            string val = thisLine.Split(',')[1];
            string type = thisLine.Split(',')[2];
            switch (type)
            {
                case "F":
                    return IntPage2(val);
                default:
                    return IntPage1(val);
            }
        }



    }
}