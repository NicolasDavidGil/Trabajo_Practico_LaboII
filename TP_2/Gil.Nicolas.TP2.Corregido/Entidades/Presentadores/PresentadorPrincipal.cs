using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public class PresentadorPrincipal
    {
        IVistaPrincipal _main;
        public static List<Partida>? partidasActivas = new List<Partida>();
        public static Usuario? logueado;
        private List<Usuario>? misUsuarios;
        private List<Partida>? miHistorial;
        private List<Carta>? miMazo;

        public List<Carta>? MiMazo { get => miMazo;}
        public List<Usuario>? MisUsuarios { get => misUsuarios;}
        public List<Partida>? MiHistorial { get => miHistorial; } 
        //public Usuario UsuarioOn { get => logueado; set => logueado = value; }

        public PresentadorPrincipal(IVistaPrincipal prin)
        {
            _main = prin;
            this._main.EscribirChatEvento += SetTexto;
        }

        private void SetTexto(object? sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(_main.TextoParaChat))
                _main.Chat += "\n" + _main.Usuario + " dice: " + _main.TextoParaChat + "\n";
            _main.TextoParaChat = "";
        }

        public void ObtenerDatos()
        {
            misUsuarios = new RepositorioDeAcceso().ObtenerUsuarios();
            miHistorial = new RepositorioDeAcceso().ObtenerHistorial();
            miMazo = new RepositorioDeAcceso().ObtenerMazo();
        }

    }
}
