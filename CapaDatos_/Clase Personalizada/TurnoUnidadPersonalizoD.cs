using CapaEntidades.Clases_Personalizadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_.Clase_Personalizada
{
    public class TurnoUnidadPersonalizoD
    {
        public static List<SP_Listar_TurnosUnidadResult> ListarTurnoUnidad(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_Listar_TurnosUnidad(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Turno de Unidad, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void EliminarTurnoUnidadPersonalizado(TurnoUnidadPersonalizadoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_TurnosUnidadView(ob.IdTurnoUnidad);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Turno Unidad", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
