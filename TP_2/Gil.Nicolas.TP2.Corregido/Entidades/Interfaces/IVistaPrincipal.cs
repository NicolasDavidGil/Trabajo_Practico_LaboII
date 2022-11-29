using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVistaPrincipal
    {
        string JugadorUno { get; set; }
        string JugadorDos { get; set; }
        string TipoPartida { get; set; }
        string Usuario { get; set; }
        string Hora { get; set; }
        string Fecha { get; set; }
        string Chat { get; set; }
        string TextoParaChat { get; set; }
        string Error { get; set; }
        
        void LLenarForm();
        void SetTextToChat(string mensaje);

        public event EventHandler EscribirChatEvento;

    }
}
