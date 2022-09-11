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
    public class PermisosLN
    {
        public List<PermisosE> viewPermisos(string val)
        {
            List<PermisosE> list = new List<PermisosE>();
            PermisosE ot = null;
            try
            {
                List<SP_ListarPermisos_FiltroResult> auxList = PermisosD.ListarPermisosFiltro(val);
                foreach (SP_ListarPermisos_FiltroResult auc in auxList)
                {

                    ot = new PermisosE(auc.IdPermiso, auc.IdRol.Value, auc.NombreMenu);
                    list.Add(ot);
                }
                return list;
            }
            catch (ArgumentException ex)
            {

                throw new Exception("Error" + ex);
            }
            finally
            {
                list = null;
            }
        }
    }
}
