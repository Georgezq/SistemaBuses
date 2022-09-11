using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class PermisosE
    {
        private int idPermiso;
        private int idRol;
        private string nombreMenu;

        public PermisosE()
        {
        }

        public PermisosE(int idPermiso, int idRol, string nombreMenu)
        {
            this.idPermiso = idPermiso;
            this.idRol = idRol;
            this.nombreMenu = nombreMenu;
        }

        public int IdPermiso { get => idPermiso; set => idPermiso = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreMenu { get => nombreMenu; set => nombreMenu = value; }
    }
}
