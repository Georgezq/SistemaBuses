using System;
using System.Collections.Generic;
using CapaDatos_;
using CapaDatos_.Ingresos;
using CapaEntidades.Ingresos;

namespace CapaNegocio.Ingresos
{
    public class ChoferLN
    {
        public List<ChoferE> ListarChofer(string val)
        {
            List<ChoferE> rolList = new List<ChoferE>();
            ChoferE op = null;
            try
            {
                List<SP_ListarChoferFiltroResult> auxList = ChoferD.ListarChoferes(val);
                foreach (SP_ListarChoferFiltroResult olp in auxList)
                {
                    op = new ChoferE(olp.IdChofer, olp.Nombre, olp.Apellido, olp.Sexo.Value, olp.TipoLicencia, olp.Edad.Value, olp.Estado.Value);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearChofer(ChoferE ot)
        {

            try
            {
                ChoferD.InsertarChoferes(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Chofer" + ex);
            }

        }

        public bool UpdateChofer(ChoferE ot)
        {

            try
            {
                ChoferD.ActualizarChoferes(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Chofer" + ex);
            }
        }

        public bool deleteChofer(ChoferE ot)
        {

            try
            {
                ChoferD.EliminarChoferes(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Chofer" + ex);
            }

        }
    }
}
