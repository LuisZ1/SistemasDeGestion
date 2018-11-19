using ExamenEval1LuisZ_DAL.connections;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_DAL.Lists {
    public class listPersonajes_DAL {

        /// <summary>
        /// el método devolverá un listado de personajes completo de la base de datos
        /// </summary>
        /// <returns>un listado de todos los personajes</returns>
        public List<clsPersonaje> listadoPersonajes_DAL() {
            List<clsPersonaje> miListado = new List<clsPersonaje>();
            clsPersonaje miPersonaje;

            //Variables
            SqlConnection miConexion;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            miComando.CommandText = "SELECT * FROM Personajes";
            miComando.Connection = miConexion;

            miLector = miComando.ExecuteReader();

            if (miLector.HasRows) {
                while (miLector.Read()) {
                    miPersonaje = new clsPersonaje();
                    miPersonaje.idPersonaje = (int)miLector["idPersonaje"];
                    miPersonaje.nombre = (String)miLector["nombre"];
                    miPersonaje.alias = (String)miLector["alias"];
                    miPersonaje.vida = (double)miLector["vida"];
                    miPersonaje.regeneracion = (double)miLector["regeneracion"];
                    miPersonaje.danno = (double)miLector["danno"];
                    miPersonaje.armadura = (double)miLector["armadura"];
                    miPersonaje.velAtaque = (double)miLector["velAtaque"];
                    miPersonaje.resistencia = (double)miLector["resistencia"];
                    miPersonaje.velMovimiento = (double)miLector["velMovimiento"];
                    miPersonaje.idCategoria = (int)miLector["idCategoria"];

                    miListado.Add(miPersonaje);
                }
            }

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);
            miLector.Close();

            return miListado;
        }

    }
}
