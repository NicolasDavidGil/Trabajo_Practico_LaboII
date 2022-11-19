using Entidades.Modelos;
using Entidades.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public static class GameManager
    {
        public static Usuario? managerOn;
        public static List<Task>? misTareas = new List<Task>();
        public static List<Carta>? mazoDeJuego = new RepositorioMazo().GetMazo();
        public static List<Usuario>? misJugadores = new RepositorioUsuarios().GetAll();
        public static List<Partida>? miHistorial = new RepositorioPartidas().GetAll();
        public static List<Partida>? misActivas = new List<Partida>();
        public static List<string>? misPaises = new RepositorioPaises().GetPaises();

        public static void ComenzarPartida(Partida match)
        {
            
        }
    }
}
