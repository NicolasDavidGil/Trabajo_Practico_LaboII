using Library.TP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.TP2.Properties;

namespace Vista.TP2
{
    public partial class frmPartida : Form
    {
        Partida viendo;
        DateTime hora = new();
        bool primeraMano = true;
        public frmPartida(Partida nueva)
        {
            InitializeComponent();
            viendo = nueva;
            
        }

        private void frmPartida_Load(object sender, EventArgs e)
        {
            tmrJugada.Start();
            lblJugadorUno.Text = viendo.JugadorUno.NombreUsuario;
            lblJugadorDos.Text = viendo.JugadorDos.NombreUsuario;
            ptbJugUnoCantoUno.Visible = false;
            ptbJugDosCantoUno.Visible = false;
            if(viendo.TurnoJuego == 1)
            {
                ptbManoJugadorUno.Visible = true;
                ptbManoJugadorDos.Visible = false;
            }
            else
            {
                ptbManoJugadorUno.Visible = false;
                ptbManoJugadorDos.Visible = true;
            }
        }

        private void tmrJugada_Tick(object sender, EventArgs e)
        {                        
            if (viendo is not null)
            {
                hora = hora.AddSeconds(1);
                int horaInt = int.Parse(hora.ToString("ss"));
                if (horaInt % 4 == 0)
                {
                    viendo.JugarPartida(primeraMano);
                    primeraMano = false;
                    lblcartaMesa.Text = viendo.CartaMesa.NumeroCarta + " " + viendo.CartaMesa.ColorCarta + " " + viendo.CartaMesa.SimboloCarta;
                    lblCartasDos.Text = "Cartas restantes: " + viendo.JugadorDos.ManoJugador.Count.ToString();
                    lblCartasUno.Text = "Cartas restantes: " + viendo.JugadorUno.ManoJugador.Count.ToString();
                    if(viendo.TurnoJuego == 1)
                    {
                        pnlJuega1.Visible = true;
                        pnlJuega2.Visible = false;
                    }
                    else
                    {
                        pnlJuega1.Visible = false;
                        pnlJuega2.Visible = true;
                    }
                    MostrarCartaEnMesa(viendo);
                    if(viendo.JugadorUno.ManoJugador.Count == 1)
                    {
                        ptbJugUnoCantoUno.Visible = true;
                    }
                    else
                    {
                        ptbJugUnoCantoUno.Visible = false;
                    }
                    if (viendo.JugadorDos.ManoJugador.Count == 1)
                    {
                        ptbJugDosCantoUno.Visible = true;
                    }
                    else
                    {
                        ptbJugDosCantoUno.Visible = false;
                    }
                    if (viendo.JugadorUno.ManoJugador.Count == 0)
                    {
                        viendo.Ganador = viendo.JugadorUno.NombreUsuario;
                        lblcartaMesa.Text = "Ganador: " + viendo.Ganador;
                        tmrJugada.Stop();
                    }
                    if (viendo.JugadorDos.ManoJugador.Count == 0)
                    {
                        viendo.Ganador = viendo.JugadorDos.NombreUsuario;
                        lblcartaMesa.Text = "Ganador: " + viendo.Ganador;
                        tmrJugada.Stop();
                    }
                }
            }
        }

        public void MostrarCartaEnMesa(Partida esta)
        {
            if(esta.CartaMesa.ColorCarta == "Rojo")
            {
                switch(esta.CartaMesa.NumeroCarta)
                {
                    case 0:
                        ptbCartaEnMesa.Image = Resources._0Rojo;
                        break;
                    case 1:
                        ptbCartaEnMesa.Image = Resources._1Rojo;
                        break;
                    case 2:
                        ptbCartaEnMesa.Image = Resources._2Rojo;
                        break;
                    case 3:
                        ptbCartaEnMesa.Image = Resources._3Rojo;
                        break;
                    case 4:
                        ptbCartaEnMesa.Image = Resources._4Rojo;
                        break;
                    case 5:
                        ptbCartaEnMesa.Image = Resources._5Rojo;
                        break;
                    case 6:
                        ptbCartaEnMesa.Image = Resources._6Rojo;
                        break;
                    case 7:
                        ptbCartaEnMesa.Image = Resources._7Rojo;
                        break;
                    case 8:
                        ptbCartaEnMesa.Image = Resources._8Rojo;
                        break;
                    case 9:
                        ptbCartaEnMesa.Image = Resources._9Rojo;
                        break;
                    case -10:
                        ptbCartaEnMesa.Image = Resources.SalteaRojo;
                        break;
                    case -15:
                        ptbCartaEnMesa.Image = Resources.GiraRojo;
                        break;
                    case 22:
                        ptbCartaEnMesa.Image = Resources.MasDosRojo;
                        break;
                }
                ptbCartaEnMesa.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (esta.CartaMesa.ColorCarta == "Azul")
            {
                switch (esta.CartaMesa.NumeroCarta)
                {
                    case 0:
                        ptbCartaEnMesa.Image = Resources._0Azul;
                        break;
                    case 1:
                        ptbCartaEnMesa.Image = Resources._1Azul;
                        break;
                    case 2:
                        ptbCartaEnMesa.Image = Resources._2Azul;
                        break;
                    case 3:
                        ptbCartaEnMesa.Image = Resources._3Azul;
                        break;
                    case 4:
                        ptbCartaEnMesa.Image = Resources._4Azul;
                        break;
                    case 5:
                        ptbCartaEnMesa.Image = Resources._5Azul;
                        break;
                    case 6:
                        ptbCartaEnMesa.Image = Resources._6Azul;
                        break;
                    case 7:
                        ptbCartaEnMesa.Image = Resources._7Azul;
                        break;
                    case 8:
                        ptbCartaEnMesa.Image = Resources._8Azul;
                        break;
                    case 9:
                        ptbCartaEnMesa.Image = Resources._9Azul;
                        break;
                    case -10:
                        ptbCartaEnMesa.Image = Resources.SalteaAzul;
                        break;
                    case -15:
                        ptbCartaEnMesa.Image = Resources.GiraAzul;
                        break;
                    case 22:
                        ptbCartaEnMesa.Image = Resources.MasDosAzul;
                        break;
                }
                ptbCartaEnMesa.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (esta.CartaMesa.ColorCarta == "Verde")
            {
                switch (esta.CartaMesa.NumeroCarta)
                {
                    case 0:
                        ptbCartaEnMesa.Image = Resources._0Verde;
                        break;
                    case 1:
                        ptbCartaEnMesa.Image = Resources._1Verde;
                        break;
                    case 2:
                        ptbCartaEnMesa.Image = Resources._2Verde;
                        break;
                    case 3:
                        ptbCartaEnMesa.Image = Resources._3Verde;
                        break;
                    case 4:
                        ptbCartaEnMesa.Image = Resources._4Verde;
                        break;
                    case 5:
                        ptbCartaEnMesa.Image = Resources._5Verde;
                        break;
                    case 6:
                        ptbCartaEnMesa.Image = Resources._6Verde;
                        break;
                    case 7:
                        ptbCartaEnMesa.Image = Resources._7Verde;
                        break;
                    case 8:
                        ptbCartaEnMesa.Image = Resources._8Verde;
                        break;
                    case 9:
                        ptbCartaEnMesa.Image = Resources._9Verde;
                        break;
                    case -10:
                        ptbCartaEnMesa.Image = Resources.SalteaVerde;
                        break;
                    case -15:
                        ptbCartaEnMesa.Image = Resources.GiraVerde;
                        break;
                    case 22:
                        ptbCartaEnMesa.Image = Resources.MasDosVerde;
                        break;
                }
                ptbCartaEnMesa.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (esta.CartaMesa.ColorCarta == "Amarillo")
            {
                switch (esta.CartaMesa.NumeroCarta)
                {
                    case 0:
                        ptbCartaEnMesa.Image = Resources._0Amarillo;
                        break;
                    case 1:
                        ptbCartaEnMesa.Image = Resources._1Amarillo;
                        break;
                    case 2:
                        ptbCartaEnMesa.Image = Resources._2Amarillo;
                        break;
                    case 3:
                        ptbCartaEnMesa.Image = Resources._3Amarillo;
                        break;
                    case 4:
                        ptbCartaEnMesa.Image = Resources._4Amarillo;
                        break;
                    case 5:
                        ptbCartaEnMesa.Image = Resources._5Amarillo;
                        break;
                    case 6:
                        ptbCartaEnMesa.Image = Resources._6Amarillo;
                        break;
                    case 7:
                        ptbCartaEnMesa.Image = Resources._7Amarillo;
                        break;
                    case 8:
                        ptbCartaEnMesa.Image = Resources._8Amarillo;
                        break;
                    case 9:
                        ptbCartaEnMesa.Image = Resources._9Amarillo;
                        break;
                    case -10:
                        ptbCartaEnMesa.Image = Resources.SalteaAmarillo;
                        break;
                    case -15:
                        ptbCartaEnMesa.Image = Resources.GiraAmarillo;
                        break;
                    case 22:
                        ptbCartaEnMesa.Image = Resources.MasDosAmarillo;
                        break;
                }
                ptbCartaEnMesa.BackgroundImageLayout = ImageLayout.Stretch;              
            }
            if (esta.CartaMesa.SimboloCarta == "c")
            {
                switch (esta.CartaMesa.NumeroCarta)
                {
                    case -1:
                        ptbCartaEnMesa.Image = Resources.CambiaColor;
                        break;
                    case -4:
                        ptbCartaEnMesa.Image = Resources.MasCuatro;
                        break;
                }
                ptbCartaEnMesa.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
