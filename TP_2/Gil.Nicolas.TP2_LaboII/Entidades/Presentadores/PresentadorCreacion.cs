using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public class PresentadorCreacion
    {
        ICrearPartida view;
        List<Usuario> jugadores = new List<Usuario>();

        public PresentadorCreacion(ICrearPartida view)
        {
            this.view = view;
            if(GameManager.misJugadores != null)
            jugadores = GameManager.misJugadores;
        }

        public List<Usuario> Jugadores { get => jugadores; set => jugadores = value; }

        public void LLenarDatos()
        {
            view.CargarUsuarios(jugadores);            
        }

        public Partida IniciarPartida()
        {            
            Usuario auxUno = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0);
            Usuario auxDos = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0);
            if (view.VerificarDatos())
            {                
                foreach (Usuario it in Jugadores)
                {
                    if (view.BoxJugadorUno == it.NombreUsuario)
                    {
                        auxUno = it;
                    }
                    if (view.BoxJugadorDos == it.NombreUsuario)
                    {
                        auxDos = it;
                    }
                }                
            }
            Partida nueva = new Partida(DateTime.Now, auxUno, auxDos, view.TipoPartida);
            return nueva;           
        }

    }
}
