using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Ingresos
{
    public class PagosLN
    {
        public List<PagosE> ListarPagos(string val)
        {
            List<PagosE> rolList = new List<PagosE>();
            PagosE op = null;
            try
            {
                List<SP_ListarPagoFiltroResult> auxList = PagosD.ListarPagos(val);
                foreach (SP_ListarPagoFiltroResult olp in auxList)
                {
                    op = new PagosE(olp.IdPago, olp.Valor.Value, olp.Descripcion, olp.IdUsuario.Value, olp.IdChofer.Value, olp.Estado.Value, olp.Fecha);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearPagos(PagosE ot)
        {

            try
            {
                PagosD.InsertarPagos(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Pagos" + ex);
            }

        }

        public bool UpdatePagos(PagosE ot)
        {

            try
            {
                PagosD.ActualizarPagos(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Pagos123" + ex);
            }
        }

        public bool deletePagos(PagosE ot)
        {

            try
            {
                PagosD.EliminarPagos(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Pagos" + ex);
            }

        }
    }
}
