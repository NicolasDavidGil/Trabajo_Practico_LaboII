using Entidades.Interfaces;
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

namespace Vista
{
    public partial class frmEstadisticas : Form, IVistaEstadisticas
    {
        public static frmEstadisticas? instance;
        public static frmPrincipal? principal;
        PresentadorEstadisticas presentador;
        public static int indexPartida;
        public static int indexJugador;


        public frmEstadisticas()
        {
            InitializeComponent();
            presentador = new PresentadorEstadisticas(this);
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            presentador.LLenarDatos();
            dgvJugadores.DataSource = presentador.usuarios;
            dgvPartidas.DataSource = presentador.partidas;
        }

        public string Chat { get => rtbEstadisticas.Text; set => rtbEstadisticas.Text += value; }       
        public string PartidasTotales { get => lblPartidasTotales.Text; set => lblPartidasTotales.Text = value; }
        public string PartidasCompletas { get => lblPartidasCompletas.Text; set => lblPartidasCompletas.Text = value; }
        public string PartidasExpress { get => lblPartidasExpress.Text; set => lblPartidasExpress.Text = value; }
        public string JugadoresTotales { get => lblJugadoresTotales.Text; set => lblJugadoresTotales.Text = value; }
        public string JugadoresActivos { get => lblActivos.Text; set => lblActivos.Text = value; }

        public static frmEstadisticas GetInstance(frmPrincipal padreContenedor)
        {
            principal = padreContenedor;
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmEstadisticas();
                instance.MdiParent = padreContenedor;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;                
                instance.BringToFront();
            }
            return instance;
        }

        private void btnCerrarEstadisticas_Click(object sender, EventArgs e)
        {
            if (principal != null)
                principal.RefrescarForm();
            this.Close();
        }

        private void dgvPartidas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexPartida = e.RowIndex;
            if(indexPartida != -1)
            {
                DetallarPartida();
            }
        }

        private void dgvJugadores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexJugador = e.RowIndex;
            if(indexJugador != -1)
            {
                DetallarJugador();
            }
        }

        public void DetallarJugador()
        {
            int partidasTotales = presentador.usuarios[indexJugador].Victorias + presentador.usuarios[indexJugador].Derrotas;
            float promedio = presentador.usuarios[indexJugador].Victorias;
            promedio /= (float) partidasTotales;            
            Chat = "\n----------------------\nNombre: " + presentador.usuarios[indexJugador].Nombre + "\nNombre usuario: " + presentador.usuarios[indexJugador].NombreUsuario +
            "\nPuntaje: " + presentador.usuarios[indexJugador].Puntaje + "\nVictorias: " + presentador.usuarios[indexJugador].Victorias + "\nDerrotas: " + presentador.usuarios[indexJugador].Derrotas + 
            "\nPromedio victoria: " + promedio.ToString("N2") + "\n----------------------\n";
        }

        public void DetallarPartida()
        {
            Chat = "\n----------------------\nFecha: " + presentador.partidas[indexPartida].FechaPartida.ToString() + "\nJugador Uno: " + presentador.partidas[indexPartida].NombreUno +
            "\nJugador Dos: " + presentador.partidas[indexPartida].NombreDos + "\n\nGanador: " + presentador.partidas[indexPartida].Ganador + "\n----------------------\n";
        }
    }
}
