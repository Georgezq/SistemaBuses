using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos_.Ingresos
{
    public class TurnoD
    {
        public static List<SP_Listar_TurnosResult> ListarTurno(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_Listar_Turnos(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Turno, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarTurno(TurnoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Turnos(ob.Tipo, ob.Descripcion, ob.Hora_Inicio, ob.Hora_Terminacion);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Turno", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarTurno(TurnoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Turno(ob.IdTurno, ob.Tipo, ob.Descripcion, ob.Hora_Inicio, ob.Hora_Terminacion);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Turno", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarTurno(TurnoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Turno(ob.IdTurno);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Turno", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
