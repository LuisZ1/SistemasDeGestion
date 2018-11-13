using _06_CRUDPersonas_BL.Lists;
using _06_CRUDPersonas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_CRUDPersonas_UI.ViewModels {
    public class clsListadoPersonasDepartamento {

        public List<clsPersona> listaPersonasPorDepartamento { get; set; }
        public List<clsDepartamento> listaDepartamentos { get; set; }
        public int idDepartamentoSeleccionado { get; set; }

        public clsListadoPersonasDepartamento(List<clsPersona> listPersonaDepartamento, List<clsDepartamento> listDepartamentos) {
            this.listaDepartamentos = listDepartamentos;
            this.listaPersonasPorDepartamento = listaPersonasPorDepartamento;
        }
        
        public clsListadoPersonasDepartamento() {
            clsListadoDepartamentos_BL gestoraDepartamentos = new clsListadoDepartamentos_BL();
            this.listaDepartamentos = gestoraDepartamentos.listadoDepartamentos_BL();
            listaPersonasPorDepartamento = new List<clsPersona>();
        }

    }
}