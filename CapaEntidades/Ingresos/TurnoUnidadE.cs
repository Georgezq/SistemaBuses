using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class TurnoUnidadE
    {
        private int idTurnoUnidad;
        private int idTurno;
        private int idUnidad;
        private int idRecorrido;
        private DateTime fecha;
        private bool estado;

        public TurnoUnidadE()
        {
        }

        public TurnoUnidadE(int idUnidad, int idTurno, int idRecorrido ,DateTime fecha)
        {
            this.idUnidad = idUnidad;
            this.idTurno = idTurno;
            this.IdRecorrido = idRecorrido;
            this.fecha = fecha;
        }

        public TurnoUnidadE(int idTurnoUnidad, int idTurno, int idUnidad, int idRecorrido, DateTime fecha)
        {
            this.IdTurnoUnidad = idTurnoUnidad;
            this.IdTurno = idTurno;
            this.IdUnidad = idUnidad;
            this.IdRecorrido = idRecorrido;
            this.Fecha = fecha;
        }

        public int IdTurnoUnidad { get => idTurnoUnidad; set => idTurnoUnidad = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdUnidad { get => idUnidad; set => idUnidad = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdRecorrido { get => idRecorrido; set => idRecorrido = value; }
    }
}
