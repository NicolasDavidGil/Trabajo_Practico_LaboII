using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista
{
    public partial class frmVerPartida : Form, IVistaVerPartida
    {
        Image? image;
        PresentadorDeJuego? admin;
        delegate void EstablecerVisual(Partida juego);
        public frmVerPartida(PresentadorDeJuego enJuego)
        {
            InitializeComponent();
            admin = enJuego;
            admin.EventoPartida += Visualizacion;                     
        }                               

        private void frmVerPartida_Load(object sender, EventArgs e)
        {
            Chat += "\n" + admin.Match?.JugadorUno.NombreUsuario + " dice: Buenas, " + admin.Match?.JugadorDos.NombreUsuario + " mucha suerte!!";
            Chat += "\n" + admin.Match?.JugadorDos.NombreUsuario + " dice: Gracias " + admin.Match?.JugadorUno.NombreUsuario + " igualmente!";
            JugadorUno = admin.Match?.JugadorUno.NombreUsuario + "\nScore: " + admin.Match?.JugadorUno.Puntaje.ToString();
            JugadorDos = admin.Match?.JugadorDos.NombreUsuario + "\nScore: " + admin.Match?.JugadorDos.Puntaje.ToString();
        }

        public string Chat { get => rtbChatPartida.Text; set => rtbChatPartida.Text = value; }
        public string JugadorUno { get => btnJugadorUno.Text; set => btnJugadorUno.Text = value; }
        public string JugadorDos { get => btnJugadorDos.Text; set => btnJugadorDos.Text = value; }
        public string ManoEnJuego { get => lblManos.Text; set => lblManos.Text = value; }

        public void Visualizacion(Partida nueva)
        {

            if (lblInvoke.InvokeRequired)
            {
                EstablecerVisual d = new EstablecerVisual(Visualizacion);
                this.Invoke(d, new object[] { nueva });
            }
            else
            {             
                if (nueva.TurnoJuego == 1)
                {
                    btnJuegoUno.Visible = true;
                    btnJuegaDos.Visible = false;
                }
                else
                {
                    btnJuegoUno.Visible = false;
                    btnJuegaDos.Visible = true;
                }
                lblManos.Text = "Manos jugadas: " + nueva.CantidadManos.ToString();
                AsignarImagenNacion(nueva.JugadorUno.Nacionalidad);
                ptbFlagJugadorUno.Image = image;
                AsignarImagenNacion(nueva.JugadorDos.Nacionalidad);
                ptbFlagJugadorDos.Image = image;
                MostrarCartaEnMesa(nueva);
                MostrarCartasManos(nueva);
                if (nueva.JugadorUno.ManoJugador.Count == 1)
                {
                    Chat += "\n" + nueva.JugadorUno.NombreUsuario + " dice: UNOOOOOOO!!!!";
                }
                else
                {
                    if (nueva.JugadorDos.ManoJugador.Count == 1)
                    {
                        Chat += "\n" + nueva.JugadorDos.NombreUsuario + " dice: UNOOOOOOO!!!!";
                    }
                }
            }
        }
        public void MostrarCartasManos(Partida part)
        {
            switch (part.JugadorUno.ManoJugador.Count)
            {
                case 1:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = false;
                    ptbJugUno_Tres.Visible = false;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = false;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 2:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = false;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = false;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 3:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = false;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 4:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = true;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 5:
                    ptbJugUno_Uno.Visible = true;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = true;
                    ptbJugUno_Mas.Visible = false;
                    break;
                default:
                    ptbJugUno_Uno.Visible = true;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = true;
                    ptbJugUno_Mas.Visible = true;
                    break;
            }
            switch (part.JugadorDos.ManoJugador.Count)
            {
                case 1:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = false;
                    ptbJugUno_Tres.Visible = false;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = false;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 2:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = false;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = false;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 3:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = false;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 4:
                    ptbJugUno_Uno.Visible = false;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = true;
                    ptbJugUno_Mas.Visible = false;
                    break;
                case 5:
                    ptbJugUno_Uno.Visible = true;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = true;
                    ptbJugUno_Mas.Visible = false;
                    break;
                default:
                    ptbJugUno_Uno.Visible = true;
                    ptbJugUno_Dos.Visible = true;
                    ptbJugUno_Tres.Visible = true;
                    ptbJugUno_Cuatro.Visible = true;
                    ptbJugUno_Cinco.Visible = true;
                    ptbJugUno_Mas.Visible = true;
                    break;
            }
        }
        public void MostrarCartaEnMesa(Partida esta)
        {
            if (esta.CartaMesa.ColorCarta == "Rojo")
            {
                switch (esta.CartaMesa.NumeroCarta)
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
            }
        }
        public void AsignarImagenNacion(string nacion)
        {
            switch (nacion)
            {
                case "Argentina":
                    image = Resources.Argentina;
                    break;
                case "Belice":
                    image = Resources.Belice;
                    break;
                case "Bolivia":
                    image = Resources.Bolivia;
                    break;
                case "Brasil":
                    image = Resources.Brasil;
                    break;
                case "Canadá":
                    image = Resources.Canada;
                    break;
                case "Chile":
                    image = Resources.Chile;
                    break;
                case "Colombia":
                    image = Resources.Colombia;
                    break;
                case "Costa Rica":
                    image = Resources.CostaRica;
                    break;
                case "Cuba":
                    image = Resources.Cuba;
                    break;
                case "Ecuador":
                    image = Resources.Ecuador;
                    break;
                case "Estados Unidos":
                    image = Resources.EstadosUnidos;
                    break;
                case "El Salvador":
                    image = Resources.ElSalvador;
                    break;
                case "Guatemala":
                    image = Resources.Guatemala;
                    break;
                case "Haití":
                    image = Resources.Haiti;
                    break;
                case "Honduras":
                    image = Resources.Honduras;
                    break;
                case "Jamaica":
                    image = Resources.Argentina;
                    break;
                case "México":
                    image = Resources.Mexico;
                    break;
                case "Panamá":
                    image = Resources.Panama;
                    break;
                case "Paraguay":
                    image = Resources.Paraguay;
                    break;
                case "Porú":
                    image = Resources.Peru;
                    break;
                case "Puerto Rico":
                    image = Resources.PuertoRico;
                    break;
                case "República Dominicana":
                    image = Resources.RepublicaDominicana;
                    break;
                case "Uruguay":
                    image = Resources.Uruguay;
                    break;
                case "Venezuela":
                    image = Resources.Venezuela;
                    break;
                case "Europa":
                    image = Resources.Europa;
                    break;
                case "Asia":
                    image = Resources.Asia;
                    break;
                case "Oceania":
                    image = Resources.Oceania;
                    break;
                case "África":
                    image = Resources.Africa;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
