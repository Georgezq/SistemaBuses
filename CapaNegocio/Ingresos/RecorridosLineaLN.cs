using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Ingresos
{
    public class RecorridosLineaLN
    {
        public List<RecorridosE> ListarRecorridosLineas(string val)
        {
            List<RecorridosE> rolList = new List<RecorridosE>();
            RecorridosE op = null;
            try
            {
                List<SP_ListarRecorridoLineasResult> auxList = RecorridosLineasD.ListarRecoridosLineas(val);
                foreach (SP_ListarRecorridoLineasResult olp in auxList)
                {
                    op = new RecorridosE(olp.IdRecorrido, olp.Descripcion, olp.Origen, olp.Destino,olp.Estado.Value);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearRecorridosLineas(RecorridosE ot)
        {

            try
            {
                RecorridosLineasD.InsertarRecoridosLineas(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar RecorridosLineas" + ex);
            }

        }

        public bool UpdateRecorridosLineas(RecorridosE ot)
        {

            try
            {
                RecorridosLineasD.ActualizarRecoridosLineas(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar RecorridosLineas" + ex);
            }
        }

        public bool deleteRecorridosLineas(RecorridosE ot)
        {

            try
            {
                RecorridosLineasD.EliminarRecoridosLineas(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar RecorridosLineas" + ex);
            }

        }
    }
}
