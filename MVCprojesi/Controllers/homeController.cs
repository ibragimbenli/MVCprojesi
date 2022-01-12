using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCprojesi.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Header()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult FooterBottom()
        {
            return PartialView();
        }
    }
}