using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Vistas
{
    public partial class frmProbandoPartida : Form
    {
        Partida partida;
        DateTime hora = new();
        public frmProbandoPartida(Partida enJuego)
        {
            InitializeComponent();
            partida = enJuego;
        }

        private void frmProbandoPartida_Load(object sender, EventArgs e)
        {
            lblJugadorUno.Text = partida.JugadorUno.NombreUsuario;
            lblJugadorDos.Text = partida.JugadorDos.NombreUsuario;
            partida.EmpezarPartida();
            ptbUnoJugUno.Visible = false;
            ptbUnoJugDos.Visible = false;
        }

        private void tmrPrueba_Tick(object sender, EventArgs e)
        {
            hora = hora.AddSeconds(1);
            int horaInt = int.Parse(hora.ToString("ss"));            
         
            if (horaInt % 10 == 0)
            {
                lblCartasJugUno.Text = partida.JugadorUno.ManoJugador.Count.ToString();
                lblCartasJugDos.Text = partida.JugadorDos.ManoJugador.Count.ToString();
                partida.JugarPartida();
                lblNumero.Text = partida.CartaMesa.NumeroCarta.ToString();
                lblColor.Text = partida.CartaMesa.ColorCarta;              
                if(partida.JugadorDos.ManoJugador.Count == 1)
                {
                    ptbUnoJugDos.Visible = true;
                }
                else
                {
                    ptbUnoJugDos.Visible = false;
                }
                if (partida.JugadorUno.ManoJugador.Count == 1)
                {
                    ptbUnoJugUno.Visible = true;
                }
                else
                {
                    ptbUnoJugUno.Visible = false;
                }
                if (partida.JugadorUno.ManoJugador.Count == 0)
                {
                    partida.Ganador = partida.JugadorUno.NombreUsuario;
                    lblGanador.Text = "Gano: " + partida.Ganador + " y es el puto amo!!";
                    tmrPrueba.Stop();
                }
                if (partida.JugadorDos.ManoJugador.Count == 0)
                {
                    partida.Ganador = partida.JugadorDos.NombreUsuario;
                    lblGanador.Text = "Ganador: " + partida.Ganador + " y es el puto amo!!";
                    tmrPrueba.Stop();
                }
            }
            
        }
    }
}
