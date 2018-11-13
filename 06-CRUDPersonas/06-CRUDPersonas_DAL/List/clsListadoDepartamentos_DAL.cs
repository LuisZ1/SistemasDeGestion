using _06_CRUDPersonas_DAL.connections;
using _06_CRUDPersonas_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CRUDPersonas_DAL.List {
    public class clsListadoDepartamentos_DAL {

        public List<clsDepartamento> listadoDepartamentosDAL() {
            //Variables
            List<clsDepartamento> listaDepartamentos = new List<clsDepartamento>();
            SqlConnection miConexion;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();
            clsDepartamento departamento;

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            miComando.CommandText = "SELECT * FROM Departamentos";
            miComando.Connection = miConexion;

            miLector = miComando.ExecuteReader();

            if (miLector.HasRows) {
                while (miLector.Read()) {
                    departamento = new clsDepartamento();
                    departamento.ID = (int)miLector["IDDepartamento"];
                    departamento.nombre = (String)miLector["nombreDepartamento"];

                    listaDepartamentos.Add(departamento);
                }
            }

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);
            miLector.Close();

            return listaDepartamentos;
        }

    }
}
