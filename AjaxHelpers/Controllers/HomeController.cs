using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjaxCall()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxCalling()
        {
            return Json(new { status = "success", data = new { Message = "Exito" } }, JsonRequestBehavior.AllowGet);
        }
    }
}