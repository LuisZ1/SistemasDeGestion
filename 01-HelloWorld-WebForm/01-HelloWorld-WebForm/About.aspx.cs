using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _01_HelloWorld_WebForm.Entidades;

namespace _01_HelloWorld_WebForm {
    public partial class About : Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSaludar_Click(object sender, EventArgs e) {
            String nombre = "";
            nombre = txtNombre.Text;
            //nombre = Request.Form["txtNombre"];
            //nombre = Request.Form["ctl00$MainContent$txtNombre"]; //Nombre copiado del HTML generado

            lblResultado.Text = $"hola {nombre}";
        }

        protected void btnSaludar_ClickV2(object sender, EventArgs e) {
            String nombre = "",apellidos = "";
            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;

            clsPersona persona = new clsPersona(nombre, apellidos);

            lblResultado.Text = "hola " + persona.nombre + " " +persona.apellidos;
        }

        protected void limpiarNombre(object sender, EventArgs e) {
            txtNombre.Text = "";
        }
    }
}