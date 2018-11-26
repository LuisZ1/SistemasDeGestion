using _07_ApiRest_Personas_BL.Lists;
using _07_ApiRest_Personas_BL.Management;
using _07_ApiRest_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _07_ApiRest_Personas_API.Controllers
{
    public class PersonasController : ApiController {

        /// <summary>
        /// Verbo Get para peticiones de un listado completo de personas
        /// </summary>
        /// <returns>Listado completo de personas</returns>
        public List<clsPersona> Get() {
            clsListadoPersonas_BL oListado = new clsListadoPersonas_BL();
            return oListado.listadoCompletoPersonas_BL();
        }

        /// <summary>
        /// devuelve una persona segun una id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>clsPersona</returns>
        public clsPersona Get(int id) {
            mngPersonas_BL manejadora = new mngPersonas_BL();
            clsPersona oPersona = manejadora.getPersonoID_BL(id);
            return oPersona;
        }

        public void Post() {

        }

    }
}
