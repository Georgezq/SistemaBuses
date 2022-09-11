using System;
using System.Collections.Generic;
using System.Linq;


namespace CapaDatos_.Ingresos
{
    public class PermisosD
    {
        public static List<SP_ListarPermisos_FiltroResult> ListarPermisosFiltro(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarPermisos_Filtro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Permisos, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }
    }
}
