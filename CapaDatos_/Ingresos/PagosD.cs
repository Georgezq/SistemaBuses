using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos_.Ingresos
{
    public class PagosD
    {
        public static List<SP_ListarPagoFiltroResult> ListarPagos(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarPagoFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Pagos, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarPagos(PagosE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Pagos(ob.Valor, ob.Descripcion, ob.IdUsuario, ob.IdChofer, ob.Estado, ob.Fecha);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Pagos", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarPagos(PagosE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Pagos(ob.IdPago, ob.Valor, ob.Descripcion, ob.IdUsuario, ob.IdChofer, ob.Estado, ob.Fecha);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Pagos", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarPagos(PagosE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Afiliado(ob.IdPago);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Pagos", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
