using ExamenEval1LuisZ_DAL.Lists;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_BL.Lists {
    public class listPersonajes_BL {

        /// <summary>
        /// El método obtiene de la capa DAL un listado de todos los personajes de la BBDD
        /// </summary>
        /// <returns>Un listado de Personajes</returns>
        public List<clsPersonaje> listadoPersonajes_BL() {
            List<clsPersonaje> miListado = new List<clsPersonaje>();
            listPersonajes_DAL gestora = new listPersonajes_DAL();

            miListado = gestora.listadoPersonajes_DAL();

            return miListado;
        }
    }
}
