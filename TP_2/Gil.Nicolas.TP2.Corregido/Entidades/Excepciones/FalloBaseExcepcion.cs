using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloBaseExcepcion : Exception
    {
        public FalloBaseExcepcion(string mensaje) : base(mensaje)
        {

        }
        public FalloBaseExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
