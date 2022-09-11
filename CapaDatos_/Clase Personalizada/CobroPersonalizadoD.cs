using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_.Clase_Personalizada
{
    public class CobroPersonalizadoD
    {
        public static List<SP_ListarVistaPersonalizadaCobroResult> ListarCobroPersonalizado(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarVistaPersonalizadaCobro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar cobro, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void EliminarCobros(viewUsuarioAfiliadoCobro ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_CobroPersonalizado(ob.IdCobro);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Cobros", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
