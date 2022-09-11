using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Ingresos
{
    public class UnidadLN
    {
        public List<UnidadE> ListarUnidad(string val)
        {
            List<UnidadE> rolList = new List<UnidadE>();
            UnidadE op = null;
            try
            {
                List<SP_ListarUnidadFiltroResult> auxList = UnidadD.ListarUnidad(val);
                foreach (SP_ListarUnidadFiltroResult olp in auxList)
                {
                    op = new UnidadE(olp.IdUnidad, olp.IdChofer.Value, olp.Placa, olp.Modelo, olp.Marca, olp.FechaFabricacion.Value, olp.Capacidad.Value, olp.Estado.Value);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearUnidad(UnidadE ot)
        {

            try
            {
                UnidadD.InsertarUnidad(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar unidad" + ex);
            }

        }

        public bool UpdateUnidad(UnidadE ot)
        {

            try
            {
                UnidadD.ActualizarUnidad(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar unidad" + ex);
            }
        }

        public bool deleteUnidad(UnidadE ot)
        {

            try
            {
                UnidadD.EliminarUnidad(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Unidad" + ex);
            }

        }
    }
}
