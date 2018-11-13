using _06_CRUDPersonas_DAL.List;
using _06_CRUDPersonas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CRUDPersonas_BL.Lists {
    public class clsListadoDepartamentos_BL {
        public List<clsDepartamento> listadoDepartamentos_BL() {

            clsListadoDepartamentos_DAL clsListDAL = new clsListadoDepartamentos_DAL();
            List<clsDepartamento> lista = new List<clsDepartamento>();

            lista = clsListDAL.listadoDepartamentosDAL();

            return lista;
        }
    }
}
