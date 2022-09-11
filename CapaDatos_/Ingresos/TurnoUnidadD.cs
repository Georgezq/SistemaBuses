using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos_.Ingresos
{
    public class TurnoUnidadD
    {
        public static List<SP_Listar_TurnosUnidadResult> ListarTurnoUnidad(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_Listar_TurnosUnidad(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar TurnoUnidad, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarTurnoUnidad(TurnoUnidadE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_TurnosUnidad(ob.IdTurno, ob.IdUnidad, ob.IdRecorrido ,ob.Fecha);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar TurnoUnidad", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarTurnoUnidad(TurnoUnidadPersonalizadoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_TurnosUnidad(ob.IdTurnoUnidad, ob.IdTurno, ob.IdUnidad, ob.IdRecorrido,ob.Fecha);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar TurnoUnidad", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarTurnoUnidad(TurnoUnidadPersonalizadoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_TurnosUnidad(ob.IdTurnoUnidad);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar TurnoUnidad", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
