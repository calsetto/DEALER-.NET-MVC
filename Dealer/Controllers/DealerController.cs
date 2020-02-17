using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dealer.Controllers
{
    public class DealerController : Controller
    {
        // GET: Dealer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Vehiculo(string ID, string Nombre, string Chasis, string Marca, string Color)
        {
            string[] vehiculo;
            vehiculo = new string[5];

            ViewBag.id = vehiculo[0] = ID;
            ViewBag.nombre = vehiculo[1] = Nombre;
            ViewBag.chasis = vehiculo[2] = Chasis;
            ViewBag.marca = vehiculo[3] = Marca;
            ViewBag.color = vehiculo[4] = Color;

            return View();
        }
    }
}