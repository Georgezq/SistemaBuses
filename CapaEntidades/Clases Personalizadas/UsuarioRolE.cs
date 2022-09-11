using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Clases_Personalizadas
{
    public class UsuarioRolE
    {
        private int idUsuario;
        private int idRol;
        private string usuario;
        private string tipo;
        private string contraseña;

        public UsuarioRolE()
        {
        }

        public UsuarioRolE(int idUsuario, int idRol, string usuario, string tipo, string contraseña)
        {
            this.IdUsuario = idUsuario;
            this.IdRol = idRol;
            this.Usuario = usuario;
            this.Tipo = tipo;
            this.Contraseña = contraseña;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
