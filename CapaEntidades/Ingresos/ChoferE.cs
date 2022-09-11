using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class ChoferE
    {
        private int idChofer;
        private string nombre;
        private string apellido;
        private char sexo;
        private string tipoLicencia;
        private int edad;
        private bool estado;
        private DateTime fechaIngreso;

        public ChoferE()
        {
        }

        public ChoferE(string nombre, string apellido, char sexo, string tipoLicencia, int edad, bool estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.tipoLicencia = tipoLicencia;
            this.edad = edad;
            this.estado = estado;
        }

        public ChoferE(int idChofer, string nombre, string apellido, char sexo, string tipoLicencia, int edad, bool estado)
        {
            this.idChofer = idChofer;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.tipoLicencia = tipoLicencia;
            this.edad = edad;
            this.estado = estado;

        }

        public int IdChofer { get => idChofer; set => idChofer = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string TipoLicencia { get => tipoLicencia; set => tipoLicencia = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    }
}
