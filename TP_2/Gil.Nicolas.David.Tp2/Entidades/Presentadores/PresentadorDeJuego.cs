using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public class PresentadorDeJuego
    {        
        Partida? match;
        Task? tarea;

        public PresentadorDeJuego()
        {
            
        }

        public Partida? Match { get => match; set => match = value; }

        public event Action<Partida>? EventoTerminarPartida;
        public event Action<Partida>? EventoPartida;
        
        
        
        public void IniciarPartida(Usuario jugadorUno, Usuario jugadorDos, string aux)
        {
            match = new Partida(DateTime.Now, jugadorUno, jugadorDos, aux);
            tarea = new Task(IniciarPartidaAdmin);
            if (Match != null)
            {
                PresentadorPrincipal.partidasActivas?.Add(Match);
            }
        }

        private void IniciarPartidaAdmin()
        {
            match?.EmpezarPartida();
            while (match?.Ganador == "vacio")
            {
                Thread.Sleep(3000);

                EventoPartida?.Invoke(match);

                match.AnalizarTurnos();//inicia                
            }
            if (Match != null)
            {                
                GuardarPartida(Match);
                if(Match.Ganador == Match.JugadorUno.NombreUsuario)
                {
                    Match.JugadorUno.Puntaje += 100;
                    Match.JugadorUno.Victorias++;
                    Match.JugadorDos.Puntaje -= 50;
                    Match.JugadorDos.Derrotas++;
                }
                else
                {
                    Match.JugadorDos.Puntaje += 100;
                    Match.JugadorDos.Victorias++;
                    Match.JugadorUno.Puntaje -= 50;
                    Match.JugadorUno.Derrotas++;
                }
                PresentadorPrincipal.partidasActivas?.Remove(Match);
                Match.JugadorUno.EstadoCuenta = 1;
                Match.JugadorDos.EstadoCuenta = 1;
            }
        }

        public void GuardarPartida(Partida nueva)
        {
            new RepositorioDeAcceso().SaveMatch(nueva);
        }
        public async Task IniciarTarea()
        {
            tarea?.Start();
        }
    }
}
