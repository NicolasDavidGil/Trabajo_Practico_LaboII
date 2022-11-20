using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public class PresentadorEstadisticas
    {
        IEstadisticas _stat;
        List<Partida> partidas;
        List<Usuario> usuarios;

        public PresentadorEstadisticas(IEstadisticas stats)
        {
            this._stat = stats;
            partidas = new RepositorioDeAcceso().GetMatchs();
            usuarios = new RepositorioDeAcceso().GetUsers();
        }

        public void LLenarDatos()
        {            
            if(partidas != null)
                _stat.SetDataGrid(partidas);
            _stat.Chat += "Bienvenido a las estadisticas de UTN UNO ROOM";
            _stat.Chat += "\nCantidad de partidas jugadas: " + partidas?.Count;
            _stat.Chat += "\nCantidad de jugadores registrados: " + usuarios?.Count;
            List<Usuario> misJugadores = new RepositorioDeAcceso().GetUserByScore();
            _stat.TopUno = "Nombre: " + misJugadores[0].NombreUsuario + "\nScore: " + misJugadores[0].Puntaje;
            _stat.TopDos = "Nombre: " + misJugadores[1].NombreUsuario + "\nScore: " + misJugadores[1].Puntaje;
            _stat.TopTres = "Nombre: " + misJugadores[2].NombreUsuario + "\nScore: " + misJugadores[2].Puntaje;

        }

        public void DataGridIndexChange(int index)
        {
            _stat.Chat += ("\nFecha: " + partidas[index].FechaPartida + "\nJugador Uno: " + partidas[index].JugadorUno.NombreUsuario + 
                            "\nJugador Dos: " + partidas[index].JugadorDos.NombreUsuario + "\nGanador: " + partidas[index].Ganador);
        }
    }
}
