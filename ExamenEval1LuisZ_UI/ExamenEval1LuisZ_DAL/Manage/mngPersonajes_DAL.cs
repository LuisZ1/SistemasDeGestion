using ExamenEval1LuisZ_DAL.connections;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEval1LuisZ_DAL.Manage {
    public class mngPersonajes_DAL {

        /// <summary>
        /// devuelve el objeto personaje cuyo id corresponda con el de laBBDD
        /// </summary>
        /// <param name="id">el id del personaje</param>
        /// <returns>un objeto personaje</returns>
        public clsPersonaje getPersonajePorID_DAL(int id) {
            clsPersonaje miPersonaje = new clsPersonaje();

            SqlConnection miConexion;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            SqlParameter idPersonajeSQL = new SqlParameter();
            idPersonajeSQL.SqlDbType = System.Data.SqlDbType.Int;
            idPersonajeSQL.ParameterName = "@id";
            idPersonajeSQL.Value = id;
            miComando.Parameters.Add(idPersonajeSQL);
                       
            miComando.CommandText = "SELECT * FROM Personajes WHERE idPersonaje = @id";
            miComando.Connection = miConexion;

            miLector = miComando.ExecuteReader();

            if (miLector.HasRows) {
                miLector.Read();
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
            }

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);
            miLector.Close();

            return miPersonaje;
        }

        /// <summary>
        /// Método para actualizar un personaje de la base de datos
        /// </summary>
        /// <param name="personaje">Personaje al que se le quieren actualizar los valores</param>
        /// <returns>Devuelve el numero de filas afectadas, -1 en caso de error</returns>
        public int updatePersonaje_DAL(clsPersonaje personaje) {

            int numberOfRows = -1;

            SqlConnection miConexion;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            //Otra manera de declarar un parametro SQL, para intentar evitar SQL injection
            miComando.Parameters.Add("@idPersonaje", System.Data.SqlDbType.Int).Value = personaje.idPersonaje;
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = personaje.nombre;
            miComando.Parameters.Add("@alias", System.Data.SqlDbType.VarChar).Value = personaje.alias;
            miComando.Parameters.Add("@vida", System.Data.SqlDbType.Float).Value = personaje.vida;
            miComando.Parameters.Add("@regeneracion", System.Data.SqlDbType.Float).Value = personaje.regeneracion;
            miComando.Parameters.Add("@danno", System.Data.SqlDbType.Float).Value = personaje.danno;
            miComando.Parameters.Add("@armadura", System.Data.SqlDbType.Float).Value = personaje.armadura;
            miComando.Parameters.Add("@velAtaque", System.Data.SqlDbType.Float).Value = personaje.velAtaque;
            miComando.Parameters.Add("@resistencia", System.Data.SqlDbType.Float).Value = personaje.resistencia;
            miComando.Parameters.Add("@velMovimiento", System.Data.SqlDbType.Float).Value = personaje.velMovimiento;
            miComando.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int).Value = personaje.idCategoria;

            // miComando.CommandText = "INSERT INTO [Personas] VALUES (@nombre, @apellidos, @fechaNacimiento, @telefono, @direccion, @idDepartamento)";
            miComando.CommandText = "UPDATE [dbo].[Personajes] SET [nombre] = @nombre ,[alias] = @alias ,[vida] = @vida ,[regeneracion] = @regeneracion ,[danno] = @danno ,[armadura] = @armadura ,[velAtaque] = @velAtaque ,[resistencia] = @resistencia ,[velMovimiento] = @velMovimiento ,[idCategoria] = @idCategoria WHERE idPersonaje = @idPersonaje";
            //TODO ALTER
            miComando.Connection = miConexion;

            numberOfRows = miComando.ExecuteNonQuery();

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);

            return numberOfRows;
        }

    }
}
