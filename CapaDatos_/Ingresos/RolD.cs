using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos_.Ingresos
{
    public class RolD
    {
        public static List<SP_ListarRolesResult> ListarRol()
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarRoles().ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Roles, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }
    }
}
