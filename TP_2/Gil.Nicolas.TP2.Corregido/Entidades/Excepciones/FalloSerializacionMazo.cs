using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloSerializacionMazo : Exception
    {
        public FalloSerializacionMazo(string mensaje) : base(mensaje)
        {

        }
        public FalloSerializacionMazo(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
