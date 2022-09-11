using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class RolE
    {
        private int idRol;
        private string tipo;
        private string descripcion;

        public RolE()
        {
        }

        public RolE(int idRol, string tipo, string descripcion)
        {
            this.idRol = idRol;
            this.tipo = tipo;
            this.descripcion = descripcion;
        }

        public int IdRol { get => idRol; set => idRol = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
