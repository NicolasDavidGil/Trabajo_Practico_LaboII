using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CamposVaciosException : Exception
    {
        public CamposVaciosException(string mensaje) : base(mensaje)
        {

        }
        public CamposVaciosException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
