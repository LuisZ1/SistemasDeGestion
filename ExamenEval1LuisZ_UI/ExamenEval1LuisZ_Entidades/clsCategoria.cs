using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_Entidades {
    public class clsCategoria {

        #region Atributos
        public int idCategoria { get; set; }
        public String nombreCategoria { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, inicializa los númericos a -1 y las cadenas a cadena vacía
        /// </summary>
        public clsCategoria() {
            this.idCategoria = -1;
            this.nombreCategoria = "";
        }

        /// <summary>
        /// Cosntructor con parámetros, recibe todos los valores de los atributos de la clase
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <param name="nombre"></param>
        public clsCategoria(int idCategoria, String nombre) {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombre;
        }
        #endregion
    }
}
