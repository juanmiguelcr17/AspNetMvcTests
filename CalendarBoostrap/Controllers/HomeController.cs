using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace CalendarBoostrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var result = new Utils().getData().Select(e => new SelectListItem { Text = e.Descripcion, Value = e.Id }).ToList<SelectListItem>();
            ViewBag.Estados = result;
            
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Season()
        {
            return View();
        }
    }
    public class Utils
    {
        public List<Estado> getData()
        {
            List<Estado> items = new List<Estado>();

            items.Add(new Estado { Id = "1", Descripcion = "Jalisco" });
            items.Add(new Estado { Id = "2", Descripcion = "Aguascalientes" });
            items.Add(new Estado { Id = "3", Descripcion = "Guanajuato" });

            return items;
        }
    }

    public class Estado
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
    }
}