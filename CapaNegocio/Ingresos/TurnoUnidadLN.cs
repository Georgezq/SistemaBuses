using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using CapaEntidades.Clases_Personalizadas;

namespace CapaNegocio.Ingresos
{
    public class TurnoUnidadLN
    {
        //public List<TurnoUnidadE> ListarTurnoUnidad(string val)
        //{
        //    List<TurnoUnidadE> rolList = new List<TurnoUnidadE>();
        //    TurnoUnidadE op = null;
        //    try
        //    {
        //        List<SP_Listar_TurnosUnidadResult> auxList = TurnoUnidadD.ListarTurnoUnidad(val);
        //        foreach (SP_Listar_TurnosUnidadResult olp in auxList)
        //        {
        //            op = new TurnoUnidadE(olp.IdTurnoUnidad, olp.IdTurno, olp.IdUnidad, olp.Estado);
        //            rolList.Add(op);
        //        }
        //        return rolList;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
        //    }

        //}

        public bool crearTurnoUnidad(TurnoUnidadE ot)
        {

            try
            {
                TurnoUnidadD.InsertarTurnoUnidad(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Afiliado" + ex);
            }

        }

        public bool UpdateTurnoUnidad(TurnoUnidadPersonalizadoE ot)
        {

            try
            {
                TurnoUnidadD.ActualizarTurnoUnidad(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Afiliado" + ex);
            }
        }

        public bool deleteTurnoUnidad(TurnoUnidadPersonalizadoE ot)
        {

            try
            {
                TurnoUnidadD.EliminarTurnoUnidad(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar TurnoUnidad" + ex);
            }

        }
    }
}
