using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ErrorBaseDatosException : Exception
    {
        public ErrorBaseDatosException(string mensaje) : base(mensaje)
        {

        }
        public ErrorBaseDatosException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
