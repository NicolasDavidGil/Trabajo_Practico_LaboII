using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class DatosIncorrectosException : Exception
    {
        public DatosIncorrectosException(string mensaje) : base(mensaje)
        {

        }
        public DatosIncorrectosException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
