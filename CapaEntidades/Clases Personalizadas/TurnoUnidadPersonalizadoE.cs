using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Clases_Personalizadas
{
    public class TurnoUnidadPersonalizadoE
    {
        private int idTurnoUnidad;
        private int idTurno;
        private string tipo;
        private int idUnidad;
        private string marca;
        private string placa;
        private DateTime fecha;
        private int idRecorrido;
        private string descripcion_recorrido;
        private string hora_inicio;
        private string hora_terminacion;


        public TurnoUnidadPersonalizadoE()
        {
        }

        public TurnoUnidadPersonalizadoE(int idTurnoUnidad, int idTurno, int idUnidad, int idRecorrido, DateTime fecha)
        {
            this.idTurnoUnidad = idTurnoUnidad;
            this.idTurno = idTurno;
            this.idUnidad = idUnidad;
            this.idRecorrido = idRecorrido;
            this.fecha = fecha;
        }

        public TurnoUnidadPersonalizadoE(int idTurnoUnidad, int idTurno, string tipo, int idUnidad, string marca, string placa, DateTime fecha, int idRecorrido, string descripcion_recorrido, string hora_inicio, string hora_terminacion)
        {
            this.IdTurnoUnidad = idTurnoUnidad;
            this.IdTurno = idTurno;
            this.Tipo = tipo;
            this.IdUnidad = idUnidad;
            this.Marca = marca;
            this.Placa = placa;
            this.Fecha = fecha;
            this.IdRecorrido = idRecorrido;
            this.Descripcion_recorrido = descripcion_recorrido;
            this.Hora_inicio = hora_inicio;
            this.Hora_terminacion = hora_terminacion;
        }

        public int IdTurnoUnidad { get => idTurnoUnidad; set => idTurnoUnidad = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int IdUnidad { get => idUnidad; set => idUnidad = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdRecorrido { get => idRecorrido; set => idRecorrido = value; }
        public string Descripcion_recorrido { get => descripcion_recorrido; set => descripcion_recorrido = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_terminacion { get => hora_terminacion; set => hora_terminacion = value; }
    }
}
