using _07_ApiRest_Personas_DAL.List;
using _07_ApiRest_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ApiRest_Personas_BL.Lists {
    public class clsListadoPersonas_BL {

        /// <summary>
        /// devuelve un listado de personas completo de la base de datos, llamando al metodo
        /// de la capa DAL
        /// </summary>
        /// <returns>un listado de personas</returns>
        public List<clsPersona> listadoCompletoPersonas_BL() {

            clsListadoPersonasDAL clsListDAL = new clsListadoPersonasDAL();
            List<clsPersona> lista = new List<clsPersona>();

            lista = clsListDAL.listadoCompletoPersonasDAL();

            return lista;
        }

        public List<clsPersona> listadoPersonasDepartamento_BL(int idDepartamento) {

            clsListadoPersonasDAL clsListDAL = new clsListadoPersonasDAL();
            List<clsPersona> lista = new List<clsPersona>();

            lista = clsListDAL.listadoPersonasDepartamentoDAL(idDepartamento);

            return lista;
        }
    }
}
