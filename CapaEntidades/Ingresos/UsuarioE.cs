using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class UsuarioE
    {
        private int idUsuario;
        private int idRol;
        private string usuario;
        private string nombre;
        private string contraseña;
        private string apellido;
        private int edad;
        private string correo;
        private char sexo;
        private bool estado;
        private DateTime fechaIngreso;
    

        public UsuarioE()
        {
        }

        public UsuarioE(int idRol, string usuario, string nombre, string contraseña, string apellido, int edad, string correo, char sexo, bool estado)
        {
            this.idRol = idRol;
            this.usuario = usuario;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.apellido = apellido;
            this.edad = edad;
            this.correo = correo;
            this.sexo = sexo;
            this.estado = estado;
        }

        public UsuarioE(int idUsuario, int idRol, string usuario, string nombre, string contraseña, string apellido, int edad, string correo, char sexo, bool estado)
        {
            this.IdUsuario = idUsuario;
            this.IdRol = idRol;
            this.Usuario = usuario;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Correo = correo;
            this.Sexo = sexo;
            this.Estado = estado;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

    }
}
