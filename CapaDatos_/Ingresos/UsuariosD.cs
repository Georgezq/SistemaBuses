using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CapaDatos_.Ingresos
{
    public class UsuariosD
    {
        public static List<SP_ListarUsuarioFiltroResult> ListarUsuario(string val)
        {
            bd_SistemaBusesDataContext db = null;
            try
            {
                using (db = new bd_SistemaBusesDataContext())
                {
                    return db.SP_ListarUsuarioFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new DatosExepciones("Error al Listar Usuario, Tipo de error" + ex);
            }
            finally
            {
                db = null;
            }
        }

        

        public static void InsertarUsuario(UsuarioE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Insertar_Usuario(ob.IdRol, ob.Usuario, ob.Nombre, ob.Contraseña, ob.Apellido, ob.Edad,ob.Correo, ob.Sexo ,ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ingresar Usuario", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void ActualizarUsuario(UsuarioE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Actualizar_Usuario(ob.IdUsuario,ob.IdRol, ob.Usuario, ob.Nombre, ob.Contraseña, ob.Apellido, ob.Edad, ob.Correo, ob.Sexo, ob.Estado);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar Usuario", ex);
            }
            finally
            {
                bd = null;
            }
        }

        public static void EliminarUsuario(UsuarioE ob)
        {
            bd_SistemaBusesDataContext bd = null;
            try
            {
                using (bd = new bd_SistemaBusesDataContext())
                {
                    bd.SP_Eliminar_Usuario(ob.IdUsuario);
                    bd.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Usuario", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
