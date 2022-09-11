using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_
{
    public class DatosExepciones : ApplicationException
    {
        public DatosExepciones(string mensaje, Exception original)
            : base(mensaje, original)
        {

        }
        public DatosExepciones(string mensaje)
            : base(mensaje)
        {

        }
    }
}
