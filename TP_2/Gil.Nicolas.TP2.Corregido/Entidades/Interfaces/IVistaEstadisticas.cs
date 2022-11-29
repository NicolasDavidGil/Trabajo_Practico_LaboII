using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Modelos;

namespace Entidades.Interfaces
{
    public interface IVistaEstadisticas
    {
        string Chat { get; set; }        
        string PartidasTotales { get; set; }
        string PartidasCompletas { get; set; }
        string PartidasExpress { get; set; }
        string JugadoresTotales { get; set; }
        string JugadoresActivos { get; set; }


        void DetallarJugador();
        void DetallarPartida();
    }
}
