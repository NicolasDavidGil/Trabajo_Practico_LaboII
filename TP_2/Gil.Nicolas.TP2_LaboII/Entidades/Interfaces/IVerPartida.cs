using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVerPartida
    {
        int CantCartasJugadorUno { get;  }
        int CantCartasJugadorDos { get; }
        string Chat { get; set; }        
        Usuario JugadorUno { get; set; }
        Usuario JugadorDos { get; set; }
        List<Carta> MazoEnUso { get; set; }
        List<Carta> MazoAuxiliar { get; set; }
        
        void IniciarPartida();
        void FinalizarPartida();
    }
}
