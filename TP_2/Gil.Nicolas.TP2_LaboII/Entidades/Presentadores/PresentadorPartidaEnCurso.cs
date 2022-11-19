using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades.Presentadores
{
    public class PresentadorPartidaEnCurso
    {
        Partida partida;
        IVerPartida partidaView;

        public PresentadorPartidaEnCurso(Partida partida, IVerPartida partidaView)
        {
            this.partida = partida;
            this.partidaView = partidaView;
        }

        public void IniciarPartida(Partida match)
        {            
            
        }

        public void ActualizarChat(string mensaje)
        {
            partidaView.Chat += mensaje;
        }

        public void FinalizarPartida()
        {
            //salvar partida en historial
        }

    }
}
