using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_SEO.Controllers
{
    public class HomeController : Controller
    {
        //Trang chủ váy cưới
        public ActionResult Index()
        {
            return View();
        }

        //Shop hay Váy cưới
        public ActionResult Shop()
        {
            return View();
        }

        //Testimonial hay Chứng nhận, nhận xét 
        public ActionResult Testimonial()
        {
            return View();
        }

        //Contact hay liên hệ  
        public ActionResult Contact()
        {
            return View();
        }

      
    }
}