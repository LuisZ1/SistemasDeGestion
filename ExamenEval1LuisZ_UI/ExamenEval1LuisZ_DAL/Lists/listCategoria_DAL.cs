using ExamenEval1LuisZ_DAL.connections;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_DAL.Lists {
    public class listCategoria_DAL {

        /// <summary>
        /// Devuelve un listado con todas las categorías de la BBDD
        /// </summary>
        /// <returns>un listado de clsCategoria</returns>
        public List<clsCategoria> listadoCategorias_DAL() {
            List<clsCategoria> miListado = new List<clsCategoria>();
            clsCategoria miCategoria;

            //Variables
            SqlConnection miConexion;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            miComando.CommandText = "SELECT * FROM Categorias";
            miComando.Connection = miConexion;

            miLector = miComando.ExecuteReader();

            if (miLector.HasRows) {
                while (miLector.Read()) {
                    miCategoria = new clsCategoria();
                    miCategoria.idCategoria = (int)miLector["idCategoria"];
                    miCategoria.nombreCategoria = (String)miLector["nombreCategoria"];

                    miListado.Add(miCategoria);
                }
            }

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);
            miLector.Close();

            return miListado;
        }
    }
}
