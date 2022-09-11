using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos_.Ingresos
{
    public class RecorridosLineasD
    {
        public static List<SP_ListarRecorridoLineasResult> ListarRecoridosLineas(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarRecorridoLineas(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar RecoridosLineas, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarRecoridosLineas(RecorridosE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_RecorridosLineas(ob.Descripcion, ob.Origen, ob.Destino ,ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar RecoridosLineas", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarRecoridosLineas(RecorridosE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_RecorridosLineas(ob.IdRecorridoLinea, ob.Descripcion,ob.Origen, ob.Destino ,ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar RecoridosLineas", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarRecoridosLineas(RecorridosE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_LineaRecorrido(ob.IdRecorridoLinea);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar RecoridosLineas", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
