using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public class PresentadorDeJuego
    {
        Partida? match;
        Task? tarea;
        

        public Partida? Match { get => match; set => match = value; }

        public event Action<Partida>? EventoTerminarPartida;
        public event Action<Partida>? EventoPartida;
        
        
        
        public void IniciarPartida(Usuario jugadorUno, Usuario jugadorDos, string aux)
        {
            match = new Partida(DateTime.Now, jugadorUno, jugadorDos, aux);
            tarea = new Task(IniciarPartidaAdmin);
            PresentadorPrincipal.partidasActivas?.Add(Match);
        }

        private void IniciarPartidaAdmin()
        {
            match?.EmpezarPartida();
            while(match?.Ganador == "vacio")
            {
                Thread.Sleep(3000);
         
                EventoPartida?.Invoke(match);

                match.AnalizarTurnos();//inicia                
            }
            EventoTerminarPartida?.Invoke(match);
        }

        public async Task IniciarTarea()
        {
            tarea.Start();
        }

        public void GuardarPartida(Partida match)
        {
            
        }

    }
}
