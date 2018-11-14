using ExamenEval1LuisZ_DAL.Manage;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_BL.Manage {
    public class mngPersonajes_BL {

        /// <summary>
        /// Devuelve un objeto tipo clsPersonaje obtenido de la capa DAL cuyo
        /// id coincida con el recibido por parametros
        /// </summary>
        /// <param name="id"></param>
        /// <returns>el personaje cuyo id coincida</returns>
        public clsPersonaje getPersonajePorID(int id) {
            clsPersonaje miPersonaje = new clsPersonaje();
            mngPersonajes_DAL manejadora = new mngPersonajes_DAL();

            miPersonaje = manejadora.getPersonajePorID_DAL(id);

            return miPersonaje;
        }

        /// <summary>
        /// Actualiza los valores de la persona recibida en la base de datos
        /// </summary>
        /// <param name="personaje"></param>
        /// <returns>el numero de filas afectadas, -1 en caso de error</returns>
        public int updatePersonaje_BL(clsPersonaje personaje) {
            int rows = -1;

            mngPersonajes_DAL manejadora = new mngPersonajes_DAL();
            rows = manejadora.updatePersonaje_DAL(personaje);

            return rows;
        }

    }
}
