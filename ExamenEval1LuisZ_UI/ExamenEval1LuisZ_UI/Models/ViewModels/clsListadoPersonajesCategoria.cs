using ExamenEval1LuisZ_BL.Lists;
using ExamenEval1LuisZ_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenEval1LuisZ_UI.Models.ViewModels {
    public class clsListadoPersonajesCategoria {

        public List<clsPersonaje> listadoPersonajes { get; set; }
        public List<clsCategoria> listadoCategorias { get; set; }
        public int idPersonajeSeleccionado { get; set; }
        public int idCategoriaSeleccionada { get; set; }
        public clsPersonaje personajeSeleccionado { get; set; }

        public clsListadoPersonajesCategoria() {
            idCategoriaSeleccionada = -1;
            idPersonajeSeleccionado = -1;
            listPersonajes_BL manejadoraPersonajes = new listPersonajes_BL();
            listCategoria_BL manejadoraCategoria = new listCategoria_BL();
            //Rellenar las listas
            listadoPersonajes = manejadoraPersonajes.listadoPersonajes_BL();
            listadoCategorias = manejadoraCategoria.listadoCategorias_BL();
        }

    }
}