using ExamenEval1LuisZ_DAL.Lists;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_BL.Lists {
    public class listCategoria_BL {

        /// <summary>
        /// Devuelve un listado de Categorias obtenido de la capa DAL
        /// </summary>
        /// <returns>un listado de clsCategoria</returns>
        public List<clsCategoria> listadoCategorias_BL() {
            List<clsCategoria> miListado = new List<clsCategoria>();
            listCategoria_DAL gestoraListado = new listCategoria_DAL();

            miListado = gestoraListado.listadoCategorias_DAL();

            return miListado;
        }
    }
}
