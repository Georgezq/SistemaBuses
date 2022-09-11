using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_.Clase_Personalizada
{
    public class UsuarioRolD
    {
        public static List<SP_ListarViewUsuarioFiltroResult> ListarUsuarioRol(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarViewUsuarioFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Usuario, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }
    }
}
