using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVerPartida
    {
        string Chat { get; set; }
        string JugadorUno { get; set; }
        string JugadorDos { get; set; }        
    }
}
