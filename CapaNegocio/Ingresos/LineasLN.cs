using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Ingresos
{
    public class LineasLN
    {
        public List<LineasE> ListarLineas(string val)
        {
            List<LineasE> rolList = new List<LineasE>();
            LineasE op = null;
            try
            {
                List<SP_ListarLineasFiltroResult> auxList = LineasD.ListarLineas(val);
                foreach (SP_ListarLineasFiltroResult olp in auxList)
                {
                    op = new LineasE(olp.IdLinea, olp.IdUnidad.Value, olp.NumLinea.Value ,olp.Estado.Value);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearLineas(LineasE ot)
        {

            try
            {
                LineasD.InsertarLineas(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Lineas" + ex);
            }

        }

        public bool UpdateLineas(LineasE ot)
        {

            try
            {
                LineasD.ActualizarLineas(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Lineas" + ex);
            }
        }

        public bool deleteLineas(LineasE ot)
        {

            try
            {
                LineasD.EliminarLineas(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Lineas" + ex);
            }

        }
    }
}
