﻿using _07_ApiRest_Personas_DAL.connections;
using _07_ApiRest_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ApiRest_Personas_DAL.List {
    public class clsListadoPersonasDAL {

        /// <summary>
        /// El método devuelve una lista de todas las personas de la base de datos, en caso
        /// de que no haya filas en la consulta, la lista la devuelve vacía
        /// </summary>
        /// <returns>una lista de personas</returns>
        public List<clsPersona> listadoCompletoPersonasDAL() {
            //Variables
            List<clsPersona> listaPersonas = new List<clsPersona>();
            SqlConnection miConexion;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();
            clsPersona persona;

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            miComando.CommandText = "SELECT * FROM Personas";
            miComando.Connection = miConexion;

            miLector = miComando.ExecuteReader();

            if (miLector.HasRows) {
                while (miLector.Read()) {
                    persona = new clsPersona();
                    persona.idPersona = (int) miLector["idPersona"];
                    persona.nombre = (String) miLector["nombrePersona"];
                    persona.apellidos = (String) miLector["apellidosPersona"];
                    persona.fechaNacimiento = (DateTime) miLector["fechaNacimiento"];
                    persona.telefono = (String) miLector["telefono"];
                    persona.direccion = (String) miLector["direccion"];
                    persona.idDepartamento = (int) miLector["idDepartamento"];

                    listaPersonas.Add(persona);
                }
            }

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);
            miLector.Close();

            return listaPersonas;
        }
        /// <summary>
        /// Devuelve una lista de personas que pertenecen a un departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>
        public List<clsPersona> listadoPersonasDepartamentoDAL(int idDepartamento) {
            //Variables
            List<clsPersona> listaPersonas = new List<clsPersona>();
            SqlConnection miConexion;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();
            clsMyConnection gestoraConexion = new clsMyConnection();
            clsPersona persona;

            //Algoritmo
            miConexion = gestoraConexion.getConnection(); //No es necesario poner try/catch porque myConnection ya lo gestiona

            miComando.Parameters.Add("@IDDepartamento", SqlDbType.Int).Value = idDepartamento;
            miComando.CommandText = "SELECT * FROM Personas WHERE IDDepartamento = @IDDepartamento";
            miComando.Connection = miConexion;

            miLector = miComando.ExecuteReader();

            if (miLector.HasRows) {
                while (miLector.Read()) {
                    persona = new clsPersona();
                    persona.idPersona = (int)miLector["idPersona"];
                    persona.nombre = (String)miLector["nombrePersona"];
                    persona.apellidos = (String)miLector["apellidosPersona"];
                    persona.fechaNacimiento = (DateTime)miLector["fechaNacimiento"];
                    persona.telefono = (String)miLector["telefono"];
                    persona.direccion = (String)miLector["direccion"];
                    persona.idDepartamento = (int)miLector["idDepartamento"];

                    listaPersonas.Add(persona);
                }
            }

            //Cerrar conexion
            gestoraConexion.closeConnection(ref miConexion);
            miLector.Close();

            return listaPersonas;
        }

    }
}
