using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_HelloWorld_MVC.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Producos
        /// <summary>
        /// Accion del controlador de productos que devuelve la vista Listado
        /// </summary>
        /// <returns></returns>
        public ActionResult listado()
        {
            return View();
        }
    }
}