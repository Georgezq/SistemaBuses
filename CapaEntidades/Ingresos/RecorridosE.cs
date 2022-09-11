using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class RecorridosE
    {
        private int idRecorridoLinea;
        private string descripcion;
        private string origen;
        private string destino;
        private bool estado;

        public RecorridosE()
        {
        }

        public RecorridosE(string descripcion, string origen, string destino, bool estado)
        {
            this.descripcion = descripcion;
            this.origen = origen;
            this.destino = destino;
           
            this.estado = estado;
        }

        public RecorridosE(int idRecorridoLinea, string descripcion, string origen, string destino, bool estado)
        {
            this.IdRecorridoLinea = idRecorridoLinea;
            this.Descripcion = descripcion;
            this.Origen = origen;
            this.Destino = destino;
            this.Estado = estado;
        }

        public int IdRecorridoLinea { get => idRecorridoLinea; set => idRecorridoLinea = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public bool Estado { get => estado; set => estado = value; }

    }
}
