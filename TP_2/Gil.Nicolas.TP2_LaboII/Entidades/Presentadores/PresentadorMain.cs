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
    public class PresentadorMain : PresentadorDeAcceso
    {
        IMainView _userView;
        List<Usuario> misJugadores;
        List<Partida> miHistorial;
        List<Carta> miMazo;
        public PresentadorMain(IMainView userView)
        {
            _userView = userView;
            this.misJugadores = ObtenerUsuariosDesdeBase();
            this.miHistorial = ObtenerHistorialDesdeBase();
            this.miMazo = ObtenerMazoDesdeBase();
        }

        public override void LlenarDatos()
        {
            try
            {
                foreach (Usuario us in misJugadores)
                {
                    if (us.NombreUsuario == PresentadorLogin.logeado?.NombreUsuario)
                    {
                        misJugadores.Remove(us);
                    }
                }
            }
            catch
            {
                Exception exception = new Exception();
            }
            _userView.SetListInDataGrid(misJugadores);
        }

        public void EscribirEnChat(string str)
        {
            _userView.Chat = str;
        }

        public override List<Partida> ObtenerHistorialDesdeBase()
        {
            RepositorioPartidas historial = new RepositorioPartidas();
            return historial.GetAll();
        }

        public override List<Carta> ObtenerMazoDesdeBase()
        {
            RepositorioMazo mazo = new RepositorioMazo();
            return mazo.GetMazo();
        }

        public override List<Usuario> ObtenerUsuariosDesdeBase()
        {
            RepositorioUsuarios repo = new RepositorioUsuarios();
            return repo.GetAll();
        }

        public override void GuardarHistorialEnBase(List<Usuario> usuarios)
        {
            throw new NotImplementedException();
        }

        public override void GuardarUsuariosEnBase(List<Usuario> usuarios)
        {
            throw new NotImplementedException();
        }

        public void CrearArchivoUsuarios()
        {
            Serializadora<Usuario> json  = new Serializadora<Usuario>();
            json.EscribirJson("JugadoresUno", misJugadores);
            //foreach (Usuario item in misJugadores)
            //{
            //    json.EscribirJson("JugadoresUno", (Usuario)item);
            //}
        }
        public void CrearArchivoHistorial()
        {
            Serializadora<Partida> json = new Serializadora<Partida>();
            json.EscribirJson("PartidasUno", miHistorial);
            //foreach (Partida item in miHistorial)
            //{
            //    json.EscribirJson("PartidasUno", (Partida)item);
            //}
        }
    }
}
