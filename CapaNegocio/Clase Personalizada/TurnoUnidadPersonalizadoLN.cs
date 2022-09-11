using CapaDatos_.Clase_Personalizada;
using CapaDatos_;
using CapaEntidades.Clases_Personalizadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clase_Personalizada
{
    public class TurnoUnidadPersonalizadoLN
    {
        public List<TurnoUnidadPersonalizadoE> ListarTurnoUnidadPersonalizado(string val)
        {
            List<TurnoUnidadPersonalizadoE> rolList = new List<TurnoUnidadPersonalizadoE>();
            TurnoUnidadPersonalizadoE op = null;
            try
            {
                List<SP_Listar_TurnosUnidadResult> auxList = TurnoUnidadPersonalizoD.ListarTurnoUnidad(val);
                foreach (SP_Listar_TurnosUnidadResult olp in auxList)
                {
                    op = new TurnoUnidadPersonalizadoE(olp.IdTurnoUnidad, olp.IdTurno, olp.Tipo, olp.IdUnidad, olp.Marca, olp.Placa, olp.Fecha.Value, olp.IdRecorrido, olp.Descripcion_Recorrido, olp.Hora_Inicio, olp.Hora_terminacion);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool deleteTurnoUnidadPersonalizado(TurnoUnidadPersonalizadoE ot)
        {

            try
            {
                TurnoUnidadPersonalizoD.EliminarTurnoUnidadPersonalizado(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Turno Unidad" + ex);
            }

        }
    }
}
