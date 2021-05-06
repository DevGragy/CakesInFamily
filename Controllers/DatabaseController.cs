using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login3Mayo.Controllers
{
    public class DatabaseController : Controller
    {
        public ActionResult Productos() 
        {
            return View();
        }

        public ActionResult Facturas()
        {
            return View();
        }

        public ActionResult Proveedores()
        {
            return View();
        }
        public ActionResult Compras()
        {
            return View();
        }

        public ActionResult Ventas()
        {
            return View();
        }

        public ActionResult Carrito()
        {
            return View();
        }

    }
}
