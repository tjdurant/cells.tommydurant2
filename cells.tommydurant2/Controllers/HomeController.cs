using cells.tommydurant2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cells.tommydurant2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public PartialViewResult ImageOpen()
        {
            ImgParameters ip = new ImgParameters();
            ip.ImageFile = "C:/Users/thoma/Documents/00GitHub/Cellavision_Trial_images/rbcs/681904686HV_002.jpg";

            return PartialView("_ImageOpen", ip);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}