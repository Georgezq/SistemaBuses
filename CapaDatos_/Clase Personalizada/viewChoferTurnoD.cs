using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_.Clase_Personalizada
{
    public class viewChoferTurnoD
    {

        public static List<SP_Listar_ChoferTurnoFiltroResult> ListarTurnoChofer(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_Listar_ChoferTurnoFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar el turno del Chofer, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

    }
}
