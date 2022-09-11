using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class PagosE
    {
        private int idPago;
        private decimal valor;
        private string descripcion;
        private int idUsuario;
        private int idChofer;
        private bool estado;
        private DateTime fecha;

        public PagosE()
        {
        }

        public PagosE(decimal valor, string descripcion, int idUsuario, int idChofer, bool estado, DateTime fecha)
        {
            this.valor = valor;
            this.descripcion = descripcion;
            this.idUsuario = idUsuario;
            this.idChofer = idChofer;
            this.estado = estado;
            this.fecha = fecha;
        }

        public PagosE(int idPago, decimal valor, string descripcion, int idUsuario, int idChofer, bool estado, DateTime fecha)
        {
            this.idPago = idPago;
            this.valor = valor;
            this.descripcion = descripcion;
            this.idUsuario = idUsuario;
            this.idChofer = idChofer;
            this.estado = estado;
            this.fecha = fecha;
        }

        public int IdPago { get => idPago; set => idPago = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdChofer { get => idChofer; set => idChofer = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
