using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03_MVC_Act1.Models {
    public class clsDepartamento {

        public String nombreDepartamento { get; set; }
        public int idDepartamento { get; set; }

        public clsDepartamento() {
            this.nombreDepartamento = "";
            this.idDepartamento = 0;
        }

        public clsDepartamento(String nombre, int idDepartamento) {
            this.nombreDepartamento = nombre;
            this.idDepartamento = idDepartamento;
        }

    }
}