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
        IPrincipalView _main;
        public static List<Partida>? partidasActivas = new List<Partida>();

        public PresentadorPrincipal(IPrincipalView prin)
        {
            _main = prin;
            this._main.EscribirChatEvento += SetTexto;
        }

        private void SetTexto(object? sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(_main.TextoParaChat))
                _main.Chat += "\n" + _main.Usuario + " dice: " + _main.TextoParaChat;
            _main.TextoParaChat = "";
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return new RepositorioDeAcceso().ObtenerUsuarios();
        }

        public List<Carta> ObtenerMazo()
        {
            return new RepositorioDeAcceso().ObtenerMazo();
        }     
    }
}
