using _04_MVC_mandandoPersona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_MVC_mandandoPersona.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsPersona p = new clsPersona();

            p.nombre = "Luis";
            p.apellidos = "Zumarraga";
            p.telefono = "6665666";
            p.direccion = "Calle Falsa 12";
            p.fechaNacimiento = new DateTime(1995, 10, 14);

            return View(p);
        }

        [HttpPost]
        public ActionResult Index(clsPersona p)
        {
            return View("personaModificada",p);
        }
    }
}