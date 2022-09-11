using System;
using System.Collections.Generic;
using CapaDatos_;
using CapaDatos_.Ingresos;
using CapaEntidades.Ingresos;

namespace CapaNegocio.Ingresos
{
    public class AfiliadosLN
    {
        public List<AfiliadoE> ListarAfiliado(string val)
        {
            List<AfiliadoE> rolList = new List<AfiliadoE>();
            AfiliadoE op = null;
            try
            {
                List<SP_ListarAfiliadosFiltroResult> auxList = AfiliadoD.ListarAfiliados(val);
                foreach (SP_ListarAfiliadosFiltroResult olp in auxList)
                {
                    op = new AfiliadoE(olp.IdAfiliado, olp.Nombre, olp.Direccion, olp.Celular, olp.Cedula, olp.Sexo.Value, olp.Correo, olp.Edad.Value, olp.EstadoCivil, olp.Estado.Value);
                    rolList.Add(op);
                }
                return rolList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearAfiliado(AfiliadoE ot)
        {

            try
            {
                AfiliadoD.InsertarAfiliados(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Afiliado" + ex);
            }

        }

        public bool UpdateAfiliado(AfiliadoE ot)
        {

            try
            {
                AfiliadoD.ActualizarAfiliados(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Afiliado" + ex);
            }
        }

        public bool deleteAfiliado(AfiliadoE ot)
        {

            try
            {
                AfiliadoD.EliminarAfiliados(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Afiliado" + ex);
            }

        }
    }
}
