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

        public void IniciarPartida()
        {
            partidaView.IniciarPartida();
        }

        public void FinalizarPartida()
        {
            //salvar partida en historial
        }

    }
}
