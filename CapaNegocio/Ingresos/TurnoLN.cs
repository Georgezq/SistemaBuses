using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
namespace CapaNegocio.Ingresos
{
    public class TurnoLN
    {
        public List<TurnoE> ListarTurno(string val)
        {
            List<TurnoE> rolList = new List<TurnoE>();
            TurnoE op = null;
            try
            {
                List<SP_Listar_TurnosResult> auxList = TurnoD.ListarTurno(val);
                foreach (SP_Listar_TurnosResult olp in auxList)
                {
                    op = new TurnoE(olp.IdTurno, olp.Tipo, olp.Descripcion, olp.Hora_Inicio, olp.Hora_terminacion);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearTurno(TurnoE ot)
        {

            try
            {
                TurnoD.InsertarTurno(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Turno" + ex);
            }

        }

        public bool UpdateTurno(TurnoE ot)
        {

            try
            {
                TurnoD.ActualizarTurno(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Turno" + ex);
            }
        }

        public bool deleteTurno(TurnoE ot)
        {

            try
            {
                TurnoD.EliminarTurno(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Turno" + ex);
            }

        }
    }
}
