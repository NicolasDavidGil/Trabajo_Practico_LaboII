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
        IVistaEstadisticas _stat;
        public List<Partida> partidas;
        public List<Usuario> usuarios;

        public PresentadorEstadisticas(IVistaEstadisticas stats)
        {
            this._stat = stats;
            partidas = ObtenerHistorial();
            usuarios = new RepositorioDeAcceso().ObtenerUsuariosPorPuntaje();
        }      

        public List<Partida> ObtenerHistorial()
        {
            return new RepositorioDeAcceso().ObtenerHistorial();
        }

        public void LLenarDatos()
        {
            int completas = 0;
            int express = 0;
            _stat.Chat = "Bienvenidos a las estadisticas de UTN UNO MASTERS\n\nSelecciones partidas del historial o jugadores de la lista para ver detalles de los mismos.";
            _stat.PartidasTotales = partidas.Count.ToString();

            partidas.ForEach((x) =>
            {
                if(x.TipoPartida == "Partida Completa")
                    completas++;
                else
                    express++;                
            });
            _stat.PartidasCompletas = completas.ToString();
            _stat.PartidasExpress = express.ToString();
            _stat.JugadoresTotales = usuarios.Count.ToString();
            int activos = 0;
            usuarios.ForEach((x) =>
            {
                if(x.EstadoCuenta == 1)
                    activos++;
            });
            _stat.JugadoresActivos = activos.ToString();
        }
    }
}
