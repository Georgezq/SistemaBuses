using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class UnidadE
    {
        private int idUnidad;
        private int idChofer;
        private string placa;
        private string modelo;
        private string marca;
        private DateTime fechaFabricacion;
        private int capacidad;
        private bool estado;

        public UnidadE()
        {

        }

        public UnidadE(int idChofer, string placa, string modelo, string marca, DateTime fechaFabricacion, int capacidad, bool estado)
        {
            this.idChofer = idChofer;
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;      
            this.fechaFabricacion = fechaFabricacion;
            this.capacidad = capacidad;
            this.estado = estado;
        }

        public UnidadE(int idUnidad, int idChofer, string placa, string modelo, string marca, DateTime fechaFabricacion, int capacidad, bool estado)
        {
            this.idUnidad = idUnidad;
            this.idChofer = idChofer;
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;
            this.fechaFabricacion = fechaFabricacion;
            this.capacidad = capacidad;
            this.estado = estado;
        }

        public int IdUnidad { get => idUnidad; set => idUnidad = value; }
        public int IdChofer { get => idChofer; set => idChofer = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public DateTime FechaFabricacion { get => fechaFabricacion; set => fechaFabricacion = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
