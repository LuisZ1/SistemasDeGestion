using ExamenEval1LuisZ_BL.Lists;
using ExamenEval1LuisZ_BL.Manage;
using ExamenEval1LuisZ_Entidades;
using ExamenEval1LuisZ_UI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenEval1LuisZ_UI.Controllers
{
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index(int id = 0) {
            clsListadoPersonajesCategoria miViewModel = null;
            miViewModel = new clsListadoPersonajesCategoria();
            try {
                if (id != 0) {
                    listPersonajes_BL gestoraPersonas = new listPersonajes_BL();
                    miViewModel.listadoPersonajes = gestoraPersonas.listadoPersonajes_BL();
                    mngPersonajes_BL manejadoraPersonas = new mngPersonajes_BL();
                    clsPersonaje miPersonaje = manejadoraPersonas.getPersonajePorID(miViewModel.idPersonajeSeleccionado);
                }
            } catch (Exception) {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(miViewModel);
        }

        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost(clsListadoPersonajesCategoria miViewModel, string boton) {

            if (boton.Equals("Editar")) {
                mngPersonajes_BL manejadoraPersonas = new mngPersonajes_BL();
                clsPersonaje miPersonaje = manejadoraPersonas.getPersonajePorID(miViewModel.idPersonajeSeleccionado);

                miViewModel.personajeSeleccionado = miPersonaje;
            } else {
                if (boton.Equals("Guardar")) {
                    mngPersonajes_BL manejadoraPersonas = new mngPersonajes_BL();
                    manejadoraPersonas.updatePersonaje_BL(miViewModel.personajeSeleccionado);
                }
            }
            return View(miViewModel);
        }

        
        //[HttpPost, ActionName("guardar")]
        //public ActionResult IndexGuardar(string guardar, clsListadoPersonajesCategoria miViewModel) {

        //    mngPersonajes_BL miManejadora = new mngPersonajes_BL();
        //    int rows = miManejadora.updatePersonaje_BL(miViewModel.personajeSeleccionado);

        //    ViewData["Mensaje"] = "Filas: " + rows;

        //    return View(miViewModel);
        //}

        /*
         Debemos escribir [HttpPost] antes del controlador para indicar que estamos recibiendo una petición POST.
        El parámetro nombre tomará el valor que se ha escrito dentro del textbox.
        */


    }
}