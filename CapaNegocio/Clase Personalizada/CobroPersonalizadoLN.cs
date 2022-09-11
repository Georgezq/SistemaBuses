using CapaDatos_.Clase_Personalizada;
using CapaEntidades.Clases_Personalizadas;
using CapaDatos_;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Clase_Personalizada
{
    public class CobroPersonalizadoLN
    {
        public List<viewUsuarioAfiliadoCobro> ListarCobroPersonalizado(string val)
        {
            List<viewUsuarioAfiliadoCobro> rolList = new List<viewUsuarioAfiliadoCobro>();
            viewUsuarioAfiliadoCobro op = null;
            try
            {
                List<SP_ListarVistaPersonalizadaCobroResult> auxList = CobroPersonalizadoD.ListarCobroPersonalizado(val);
                foreach (SP_ListarVistaPersonalizadaCobroResult olp in auxList)
                {
                    op = new viewUsuarioAfiliadoCobro(olp.IdCobros,olp.Nombre_Usuario, olp.Nombre, olp.Total.Value, olp.Descripcion, olp.Estado.Value, olp.Fecha, olp.IdUsuario, olp.IdAfiliado);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool deleteCobroPersonalizado(viewUsuarioAfiliadoCobro ot)
        {

            try
            {
                CobroPersonalizadoD.EliminarCobros(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar cobro" + ex);
            }

        }
    }
}
