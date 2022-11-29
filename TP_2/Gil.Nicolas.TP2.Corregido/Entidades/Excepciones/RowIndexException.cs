using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class RowIndexException : Exception
    {
        public RowIndexException(string mensaje) : base(mensaje)
        {

        }
        public RowIndexException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
