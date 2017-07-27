using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PopupBoostrap.Process;

namespace PopupBoostrap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PopupBoostrap()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult PopupDesdePartial()
        {
            Procesor p = new Procesor();
            return PartialView(p.FillEquipos());
        }
    }
}