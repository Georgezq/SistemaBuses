using CapaDatos_;
using CapaDatos_.Ingresos;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;


namespace CapaNegocio.Ingresos
{
    public class UsuariosLN
    {
        public List<UsuarioE> Listar(string val)
        {
            List<UsuarioE> usuarioList = new List<UsuarioE>();
            UsuarioE op = null;
            try
            {
                List<SP_ListarUsuarioFiltroResult> auxList = UsuariosD.ListarUsuario(val);
                foreach (SP_ListarUsuarioFiltroResult olp in auxList)
                {
                    op = new UsuarioE(olp.IdUsuario, olp.IdRol.Value, olp.Usuario, olp.Nombre, olp.Contraseña, olp.Apellido, olp.Edad.Value ,olp.Correo, olp.Sexo.Value , olp.Estado.Value);
                    usuarioList.Add(op);
                }
                return usuarioList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }

        public bool crearUsuario(UsuarioE ot)
        {

            try
            {
                UsuariosD.InsertarUsuario(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Usuario" + ex);
            }

        }

        public bool UpdateUsuario(UsuarioE ot)
        {

            try
            {
                UsuariosD.ActualizarUsuario(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar Usuario" + ex);
            }
        }

        public bool deleteUsuario(UsuarioE ot)
        {

            try
            {
                UsuariosD.EliminarUsuario(ot);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Usuario" + ex);
            }

        }

    }
}
