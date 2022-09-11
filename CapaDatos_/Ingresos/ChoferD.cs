using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CapaDatos_.Ingresos
{
    public class ChoferD
    {
        public static List<SP_ListarChoferFiltroResult> ListarChoferes(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarChoferFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Choferes, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarChoferes(ChoferE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Chofer(ob.Nombre, ob.Apellido, ob.Sexo, ob.TipoLicencia, ob.Edad, ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Choferes", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarChoferes(ChoferE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Chofer(ob.IdChofer, ob.Nombre, ob.Apellido, ob.Sexo, ob.TipoLicencia, ob.Edad, ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Choferes", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarChoferes(ChoferE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Afiliado(ob.IdChofer);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Choferes", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
