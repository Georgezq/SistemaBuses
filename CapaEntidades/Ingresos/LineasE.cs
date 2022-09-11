using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Ingresos
{
    public class LineasE
    {
        private int idLinea;
        private int idUnidad;
        private int numLinea;
        private bool estado;

        public LineasE()
        {
        }

        public LineasE(int idLinea, int idUnidad, int numLinea ,bool estado)
        {
            this.idLinea = idLinea;
            this.idUnidad = idUnidad;
            this.numLinea = numLinea;
            this.estado = estado;
        }

        public LineasE(int idUnidad, int numLinea, bool estado)
        {
            this.idUnidad = idUnidad;
            this.numLinea = numLinea;
            this.estado = estado;
        }


        public int IdLinea { get => idLinea; set => idLinea = value; }
        public int NumLinea { get => numLinea; set => numLinea = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int IdUnidad { get => idUnidad; set => idUnidad = value; }
    }
}
