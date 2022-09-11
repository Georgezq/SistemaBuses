using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Clases_Personalizadas
{
    public class viewUsuarioAfiliadoCobro
    {
        private int idCobro;
        private string nombreU;
        private string nombre;
        private decimal total;
        private string descripcion;
        private bool estado;
        private DateTime fecha;
        private int idUsuario;
        private int idAfiliado;

        public viewUsuarioAfiliadoCobro()
        {
        }

        public viewUsuarioAfiliadoCobro(int idCobro, int idUsuario, int idAfiliado, decimal total, string descripcion, bool estado, DateTime fecha)
        {
            this.idCobro = idCobro;
            this.idUsuario = idUsuario;
            this.idAfiliado = idAfiliado;
            this.total = total;
            this.descripcion = descripcion;
            this.estado = estado;
            this.fecha = fecha;
        }

        public viewUsuarioAfiliadoCobro(int idCobro, string nombreU, string nombre, decimal total, string descripcion, bool estado, DateTime fecha, int idUsuario, int idAfiliado)
        {
            this.IdCobro = idCobro;
            this.NombreU = nombreU;
            this.Nombre = nombre;
            this.Total = total;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.Fecha = fecha;
            this.IdUsuario = idUsuario;
            this.IdAfiliado = idAfiliado;
        }

        public int IdCobro { get => idCobro; set => idCobro = value; }
        public string NombreU { get => nombreU; set => nombreU = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Total { get => total; set => total = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdAfiliado { get => idAfiliado; set => idAfiliado = value; }
    }
}
