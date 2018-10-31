using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using _04_MVC_mandandoPersona.Models;

namespace _05_ConexionConBBDD.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost() {
            SqlConnection miConexion = new SqlConnection();

            try {
                miConexion.ConnectionString =
                    "server=serverpersonasdamlz.database.windows.net;" +
                    "database=personasDB;" +
                    "uid=Prueba;" +
                    "pwd=123qweasd!;"; //Pass: 123qweasd!

                miConexion.Open();

                ViewData["Estado"] = miConexion.State;

            } catch (SqlException e) {
                ViewData["Estado"] = e;
                //"Error al conectarse a la BBDD";
            } finally {
                miConexion.Close();
            }

            return View();
        }

        public ActionResult listadoPersonas() {

            SqlCommand miComando = new SqlCommand();
            SqlConnection miConexion = new SqlConnection();
            SqlDataReader miLector = null;

            clsPersona oPersona;
            List<clsPersona> listadoPersonas = new List<clsPersona>();

            miConexion.ConnectionString =
                    "server=serverpersonasdamlz.database.windows.net;" +
                    "database=personasDB;" +
                    "uid=Prueba;" +
                    "pwd=123qweasd!;"; //Pass: 123qweasd!

            try {

                miConexion.Open();

                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y lo ejecutamos)
                miComando.CommandText = "SELECT * FROM [dbo].[Personas]";
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();

                //Si hay lineas en el lector
                if (miLector.HasRows) {
                    while (miLector.Read()) {
                        oPersona = new clsPersona();
                        oPersona.idPersona = (int)miLector["IDPersona"];
                        oPersona.nombre = (string)miLector["nombre"];
                        oPersona.apellidos = (string)miLector["apellidos"];
                        oPersona.fechaNacimiento = (DateTime)miLector["fechaNac"];
                        oPersona.direccion = (string)miLector["direccion"];
                        oPersona.telefono = (string)miLector["telefono"];
                        listadoPersonas.Add(oPersona);
                    }
                }

            } catch (SqlException exSql) {

            } finally {
                miLector.Close();
                miConexion.Close();
            }
            return View();
        }
    }
}