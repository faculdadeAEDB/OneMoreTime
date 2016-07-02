using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OneMoreTime.Models;

namespace OneMoreTime.Controllers
{
    public class HomeController : Controller
    {
        private ClienteDBContext db = new ClienteDBContext();

        public ActionResult Index()
        {
            ViewBag.clientes = db.Clientes.ToList<Cliente>();
            return View(ViewBag);
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