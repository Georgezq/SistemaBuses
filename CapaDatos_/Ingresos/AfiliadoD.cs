using System;
using System.Collections.Generic;
using System.Linq;
using CapaEntidades.Ingresos;

namespace CapaDatos_.Ingresos
{
    public class AfiliadoD
    {
        public static List<SP_ListarAfiliadosFiltroResult> ListarAfiliados(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarAfiliadosFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar afiliado, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        public static void InsertarAfiliados(AfiliadoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Afiliado(ob.Nombre, ob.Direccion, ob.Celular, ob.Cedula, ob.Sexo, ob.Correo, ob.Edad, ob.EstadoCivil,ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Afiliados", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarAfiliados(AfiliadoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Afiliado(ob.IdAfiliado, ob.Nombre, ob.Direccion, ob.Celular, ob.Cedula, ob.Sexo, ob.Correo, ob.Edad, ob.EstadoCivil,ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Afiliados", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarAfiliados(AfiliadoE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Afiliado(ob.IdAfiliado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Afiliados", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
