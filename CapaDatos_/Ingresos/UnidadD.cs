using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CapaDatos_.Ingresos
{
    public class UnidadD
    {
        public static List<SP_ListarUnidadFiltroResult> ListarUnidad(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarUnidadFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Unidad, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarUnidad(UnidadE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Unidad(ob.IdChofer, ob.Placa, ob.Modelo, ob.Marca, ob.FechaFabricacion, ob.Capacidad,ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Unidad", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarUnidad(UnidadE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Unidad(ob.IdUnidad, ob.IdChofer, ob.Placa, ob.Modelo, ob.Marca, ob.FechaFabricacion, ob.Capacidad, ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Unidad", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarUnidad(UnidadE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Unidad(ob.IdUnidad);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Unidad", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
