using CapaDatos_.Clase_Personalizada;
using CapaDatos_;
using CapaEntidades.Clases_Personalizadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class viewChoferTurnoLN
    {

        public List<viewChoferTurnoE> ListarChoferTurno(string val)
        {
            List<viewChoferTurnoE> rolList = new List<viewChoferTurnoE>();
            viewChoferTurnoE op = null;
            try
            {
                List<SP_Listar_ChoferTurnoFiltroResult> auxList = viewChoferTurnoD.ListarTurnoChofer(val);
                foreach (SP_Listar_ChoferTurnoFiltroResult olp in auxList)
                {
                    op = new viewChoferTurnoE(olp.Nombre, olp.Apellido, olp.Edad.Value, olp.Sexo.Value, olp.Placa, olp.Modelo, olp.Capacidad.Value, olp.Tipo, olp.Hora_Inicio, olp.Hora_terminacion, olp.Origen, olp.Destino, olp.NumLinea.Value, olp.Fecha.Value);
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
