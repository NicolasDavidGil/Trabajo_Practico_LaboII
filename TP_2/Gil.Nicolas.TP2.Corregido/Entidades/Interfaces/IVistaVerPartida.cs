using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVistaVerPartida
    {
        string Chat { get; set; }
        string JugadorUno { get; set; }
        string JugadorDos { get; set; }        
        string ManoEnJuego { get; set; }
    }
}
