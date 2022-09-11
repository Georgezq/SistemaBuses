using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class CobroE
    {
        private int idCobro;
        private int idUsuario;
        private int idAfiliado;
        private decimal total;
        private string descripcion;
        private bool estado;
        private DateTime fecha;

        public CobroE()
        {
        }

        public CobroE(int idUsuario, int idAfiliado, decimal total, string descripcion, bool estado, DateTime fecha)
        {
            this.idUsuario = idUsuario;
            this.idAfiliado = idAfiliado;
            this.total = total;
            this.descripcion = descripcion;
            this.estado = estado;
            this.fecha = fecha;
        }

        public CobroE(int idCobro, int idUsuario, int idAfiliado, decimal total, string descripcion, bool estado, DateTime fecha)
        {
            this.idCobro = idCobro;
            this.idUsuario = idUsuario;
            this.idAfiliado = idAfiliado;
            this.total = total;
            this.descripcion = descripcion;
            this.estado = estado;
            this.fecha = fecha;
        }

        public int IdCobro { get => idCobro; set => idCobro = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdAfiliado { get => idAfiliado; set => idAfiliado = value; }
        public decimal Total { get => total; set => total = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
