using _06_CRUDPersonas_BL.Lists;
using _06_CRUDPersonas_BL.Management;
using _06_CRUDPersonas_Entities;
using _06_CRUDPersonas_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_CRUDPersonas_UI.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        /// <summary>
        /// devuelve una lista para rellenar la vista
        /// </summary>
        /// <returns>una lista</returns>
        public ActionResult listadoCompleto()
        {
            clsListadoPersonas_BL controller = new clsListadoPersonas_BL();
            List<clsPersona> lista = new List<clsPersona>();

            try
            {
                lista = controller.listadoCompletoPersonas_BL();
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(lista);
        }

        public ActionResult vistaExamen(int? id) {
            clsListadoPersonasDepartamento miViewModel = null;
            try {
                if (id == null) {
                    miViewModel = new clsListadoPersonasDepartamento();
                } else {
                    clsListadoPersonas_BL gestoraPersonas = new clsListadoPersonas_BL();
                    miViewModel.listaPersonasPorDepartamento = gestoraPersonas.listadoPersonasDepartamento_BL((int)id);
                }
            } catch (Exception) {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(miViewModel);
        }
        [HttpPost]
        public ActionResult vistaExamen(clsListadoPersonasDepartamento oViewModel) {

            clsListadoPersonas_BL controller = new clsListadoPersonas_BL();
            //clsListadoDepartamentos_BL controllerDepartamentos = new clsListadoDepartamentos_BL();

            //clsListadoPersonasDepartamento miViewModel = new clsListadoPersonasDepartamento();

            try {

                oViewModel.listaPersonasPorDepartamento = controller.listadoPersonasDepartamento_BL(oViewModel.idDepartamentoSeleccionado);

            } catch (Exception) {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(oViewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {

            clsPersona persona = new clsPersona();
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();
            try
            {
                persona = manejadoraPersonas.getPersonoID_BL(id);
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(persona);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {

            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();
            int numberOfDeletes = -2;
            try
            {
                numberOfDeletes = manejadoraPersonas.dropPersonoID_BL(id);
                ViewData["filasAfectadas"] = $"Filas afectadas:{numberOfDeletes}";
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            //Para volver a la vista del listado completo
            clsListadoPersonas_BL controller = new clsListadoPersonas_BL();
            List<clsPersona> lista = new List<clsPersona>();

            try
            {
                lista = controller.listadoCompletoPersonas_BL();
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View("listadoCompleto", lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// inserta una persona en la bbdd
        /// </summary>
        /// <param name="personaAInsertar"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Create")]
        public ActionResult CreatePost(clsPersona personaAInsertar)
        {

            int numberOfRows = -1;
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();
            try
            {
                numberOfRows = manejadoraPersonas.insertPersona_BL(personaAInsertar);
                ViewData["filasAfectadas"] = $"Filas afectadas:{numberOfRows}";
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            //Para volver a la vista del listado completo
            clsListadoPersonas_BL controller = new clsListadoPersonas_BL();
            List<clsPersona> lista = new List<clsPersona>();

            try
            {
                lista = controller.listadoCompletoPersonas_BL();
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View("listadoCompleto", lista);
        }

        /// <summary>
        /// muestra todas las columnas de la tabla persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns>la vista con todos los datos de la persona</returns>
        public ActionResult Details(int id)
        {

            clsPersona persona = new clsPersona();
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();
            try
            {
                persona = manejadoraPersonas.getPersonoID_BL(id);
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(persona);
        }

        public ActionResult Edit(int id)
        {

            clsPersona persona = new clsPersona();
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();
            try
            {
                persona = manejadoraPersonas.getPersonoID_BL(id);
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(persona);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditPost(clsPersona persona)
        {

            int numberOfRows = -1;
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();

            try
            {
                numberOfRows = manejadoraPersonas.alterPersona_BL(persona);
                ViewData["filasAfectadas"] = $"Filas afectadas:{numberOfRows}";
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            //Para volver a la vista del listado completo
            clsListadoPersonas_BL controller = new clsListadoPersonas_BL();
            List<clsPersona> lista = new List<clsPersona>();

            try
            {
                lista = controller.listadoCompletoPersonas_BL();
            }
            catch (Exception)
            {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View("listadoCompleto", lista);
        }

        public ActionResult EditOnlyTlf(int id) {

            clsPersona persona = new clsPersona();
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();
            try {
                persona = manejadoraPersonas.getPersonoID_BL(id);
            } catch (Exception) {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View(persona);
        }

        [HttpPost, ActionName("EditOnlyTlf")]
        public ActionResult EditOnlyTlfPost(clsPersona persona) {

            int numberOfRows = -1;
            mngPersonas_BL manejadoraPersonas = new mngPersonas_BL();

            try {
                numberOfRows = manejadoraPersonas.alterPersona_BL(persona);
                ViewData["filasAfectadas"] = $"Filas afectadas:{numberOfRows}";
            } catch (Exception) {
                ViewData["Error"] = "Excepcion no controlada";
            }

            //Para volver a la vista del listado completo
            clsListadoPersonas_BL controller = new clsListadoPersonas_BL();
            List<clsPersona> lista = new List<clsPersona>();

            try {
                lista = controller.listadoCompletoPersonas_BL();
            } catch (Exception) {
                ViewData["Error"] = "Excepcion no controlada";
            }

            return View("vistaExamen", lista);
        }
    }
}