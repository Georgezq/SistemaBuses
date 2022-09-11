using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using CapaEntidades.Clases_Personalizadas;

namespace CapaNegocio.Ingresos
{
    public class CobrosLN
    {
        public List<CobroE> ListarCobros(string val)
        {
            List<CobroE> rolList = new List<CobroE>();
            CobroE op = null;
            try
            {
                List<SP_ListarCobrosFiltroResult> auxList = CobroD.ListarCobros(val);
                foreach (SP_ListarCobrosFiltroResult olp in auxList)
                {
                    op = new CobroE(olp.IdCobros, olp.IdUsuario.Value, olp.IdAfiliado.Value, olp.Total.Value, olp.Descripcion, olp.Estado.Value, olp.Fecha.Value);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearCobros(CobroE ot)
        {

            try
            {
                CobroD.InsertarCobros(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar cobros" + ex);
            }

        }

        public bool UpdateCobros(viewUsuarioAfiliadoCobro ot)
        {

            try
            {
                CobroD.ActualizarCobros(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Cobros" + ex);
            }
        }

        public bool deleteCobros(viewUsuarioAfiliadoCobro ot)
        {

            try
            {
                CobroD.EliminarCobros(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Cobros" + ex);
            }

        }
    }
}
