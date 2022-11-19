using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ICrearPartida
    {
        string Errores { get; set; }
        string TipoPartida { get; set; }    
        string BoxJugadorUno { get; set; }
        string BoxJugadorDos { get; set; }

        bool VerificarDatos();

        void CargarUsuarios(List<Usuario> nono);

    }
}
