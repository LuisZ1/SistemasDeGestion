using _07_ApiRest_Personas_DAL.List;
using _07_ApiRest_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ApiRest_Personas_BL.Lists {
    public class clsListadoDepartamentos_BL {
        public List<clsDepartamento> listadoDepartamentos_BL() {

            clsListadoDepartamentos_DAL clsListDAL = new clsListadoDepartamentos_DAL();
            List<clsDepartamento> lista = new List<clsDepartamento>();

            lista = clsListDAL.listadoDepartamentosDAL();

            return lista;
        }
    }
}
