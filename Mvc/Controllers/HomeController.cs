using BusinessLogicLayer.NTierBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        FacultyBLL _facBll = new FacultyBLL();
        public ActionResult Index()
        {
            var temp = _facBll.Get(1, null);
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
