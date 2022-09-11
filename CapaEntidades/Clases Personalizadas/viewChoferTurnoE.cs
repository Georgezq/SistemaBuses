using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Clases_Personalizadas
{
    public class viewChoferTurnoE
    {
        private string nombre;
        private string apellido;
        private int edad;
        private char sexo;
        private string placa;
        private string modelo;
        private int capacidad;
        private string tipo;
        private string hora_inicio;
        private string hora_terminacion;
        private string origen;
        private string destino;
        private int numLinea;
        private DateTime fecha;

        public viewChoferTurnoE()
        {
        }

        public viewChoferTurnoE(string nombre, string apellido, int edad, char sexo, string placa, string modelo, int capacidad, string tipo, string hora_inicio, string hora_terminacion, string origen, string destino, int numLinea, DateTime fecha)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Capacidad = capacidad;
            this.Tipo = tipo;
            this.Hora_inicio = hora_inicio;
            this.Hora_terminacion = hora_terminacion;
            this.Origen = origen;
            this.Destino = destino;
            this.NumLinea = numLinea;
            this.Fecha = fecha;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_terminacion { get => hora_terminacion; set => hora_terminacion = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public int NumLinea { get => numLinea; set => numLinea = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
