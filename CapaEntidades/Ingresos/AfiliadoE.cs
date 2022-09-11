using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class AfiliadoE
    {
        private int idAfiliado;
        private string nombre;
        private string direccion;
        private string celular;
        private string cedula;
        private char sexo;
        private string correo;
        private int edad;
        private string estadoCivil;
        private bool estado;
        private DateTime fechaIngreso;

        public AfiliadoE()
        {
        }

        public AfiliadoE(string nombre, string direccion, string celular, string cedula, char sexo, string correo, int edad, string estadoCivil, bool estado)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.celular = celular;
            this.cedula = cedula;
            this.sexo = sexo;
            this.correo = correo;
            this.edad = edad;
            this.estadoCivil = estadoCivil;
            this.estado = estado;
        }

        public AfiliadoE(int idAfiliado, string nombre, string direccion, string celular, string cedula, char sexo, string correo, int edad, string estadoCivil, bool estado)
        {
            this.IdAfiliado = idAfiliado;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Celular = celular;
            this.Cedula = cedula;
            this.Sexo = sexo;
            this.Correo = correo;
            this.Edad = edad;
            this.EstadoCivil = estadoCivil;
            this.Estado = estado;

        }


        public int IdAfiliado { get => idAfiliado; set => idAfiliado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    }

}
