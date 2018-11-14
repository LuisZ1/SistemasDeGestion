using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_Entidades {
    public class clsPersonaje {

        #region Atributos
        public int idPersonaje { get; set; }
        public String nombre { get; set; }
        public String alias { get; set; }
        public double vida { get; set; }
        public double regeneracion { get; set; }
        public double danno { get; set; }
        public double armadura { get; set; }
        public double velAtaque { get; set; }
        public double resistencia { get; set; }
        public double velMovimiento { get; set; }
        public int idCategoria { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, inicializa los atributos cadena a cadena vacía y los numéricos a -1
        /// </summary>
        public clsPersonaje() {
            this.idPersonaje = -1;
            this.nombre = "";
            this.alias = "";
            this.vida = -1;
            this.regeneracion = -1;
            this.danno = -1;
            this.armadura = -1;
            this.velAtaque = -1;
            this.resistencia = -1;
            this.velMovimiento = -1;
            this.idCategoria = -1;
        }

        /// <summary>
        /// Constructor con parámetros, recibe todos los valores de todos los atributos del objeto
        /// </summary>
        /// <param name="idPersonaje"></param>
        /// <param name="nombre"></param>
        /// <param name="alias"></param>
        /// <param name="vida"></param>
        /// <param name="regeneracion"></param>
        /// <param name="danno"></param>
        /// <param name="armadura"></param>
        /// <param name="velAtaque"></param>
        /// <param name="resistencia"></param>
        /// <param name="velMovimiento"></param>
        /// <param name="idCategoria"></param>
        public clsPersonaje(int idPersonaje, String nombre, String alias, float vida, float regeneracion,
            float danno, float armadura, float velAtaque, float resistencia, float velMovimiento, int idCategoria) {
            this.idPersonaje = idPersonaje;
            this.nombre = nombre;
            this.alias = alias;
            this.vida = vida;
            this.regeneracion = regeneracion;
            this.danno = danno;
            this.armadura = armadura;
            this.velAtaque = velAtaque;
            this.resistencia = resistencia;
            this.velMovimiento = velMovimiento;
            this.idCategoria = idCategoria;
        }

        #endregion
    }
}
