using CapaDatos_;
using CapaDatos_.Ingresos;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Ingresos
{
    public class RolLN
    {
        public List<RolE> ListarRol()
        {
            List<RolE> rolList = new List<RolE>();
            RolE op = null;
            try
            {
                List<SP_ListarRolesResult> auxList = RolD.ListarRol();
                foreach (SP_ListarRolesResult olp in auxList)
                {
                    op = new RolE(olp.IdRol, olp.Tipo, olp.Descripcion);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }
    }
}
