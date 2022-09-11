using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class TurnoE
    {
        private int idTurno;
        private string tipo;
        private string descripcion;
        private string hora_Inicio;
        private string hora_Terminacion;

        public TurnoE()
        {
        }

        public TurnoE(string tipo, string descripcion, string hora_Inicio, string hora_Terminacion)
        {
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.hora_Inicio = hora_Inicio;
            this.hora_Terminacion = hora_Terminacion;
        }

        public TurnoE(int idTurno, string tipo, string descripcion, string hora_Inicio, string hora_Terminacion)
        {
            this.idTurno = idTurno;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.hora_Inicio = hora_Inicio;
            this.hora_Terminacion = hora_Terminacion;
        }

        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Hora_Inicio { get => hora_Inicio; set => hora_Inicio = value; }
        public string Hora_Terminacion { get => hora_Terminacion; set => hora_Terminacion = value; }
    }
}
