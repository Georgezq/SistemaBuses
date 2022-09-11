using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CapaDatos_.Ingresos
{
    public class CobroD
    {
        public static List<SP_ListarCobrosFiltroResult> ListarCobros(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarCobrosFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Cobros, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarCobros(CobroE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Cobro(ob.IdUsuario, ob.IdAfiliado, ob.Total, ob.Descripcion, ob.Estado, ob.Fecha);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Cobros", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarCobros(viewUsuarioAfiliadoCobro ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Cobros(ob.IdCobro, ob.IdUsuario, ob.IdAfiliado, ob.Total, ob.Descripcion, ob.Estado, ob.Fecha);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Cobros", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarCobros(viewUsuarioAfiliadoCobro ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Cobros(ob.IdCobro);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Cobros", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
