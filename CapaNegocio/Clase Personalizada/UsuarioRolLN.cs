using CapaDatos_.Ingresos;
using CapaDatos_;
using CapaEntidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Clases_Personalizadas;
using CapaDatos_.Clase_Personalizada;

namespace CapaNegocio.Clase_Personalizada
{
    public class UsuarioRolLN
    {
        public List<UsuarioRolE> Listar(string val)
        {
            List<UsuarioRolE> usuarioList = new List<UsuarioRolE>();
            UsuarioRolE op = null;
            try
            {
                List<SP_ListarViewUsuarioFiltroResult> auxList = UsuarioRolD.ListarUsuarioRol(val);
                foreach (SP_ListarViewUsuarioFiltroResult olp in auxList)
                {
                    op = new UsuarioRolE(olp.IdUsuario, olp.IdRol.Value, olp.Usuario, olp.Tipo, olp.Contraseña);
                    usuarioList.Add(op);
                }
                return usuarioList;
            }
            catch (Exception ex)
            {

                throw new LogicaExcepciones("Error al mostrar datos. Tipo de error:" + ex);
            }

        }
    }
}
