using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_.Ingresos
{
    public class LineasD
    {
        public static List<SP_ListarLineasFiltroResult> ListarLineas(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarLineasFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Lineas, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarLineas(LineasE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Linea(ob.IdUnidad,ob.NumLinea, ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Lineas", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarLineas(LineasE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Linea(ob.IdLinea,ob.IdUnidad, ob.NumLinea, ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Lineas", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarLineas(LineasE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Linea(ob.IdLinea);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Lineas", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
