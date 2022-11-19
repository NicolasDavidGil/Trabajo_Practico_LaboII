using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorios;
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
    public partial class frmEstadisticas : Form, IEstadisticas
    {
        public static frmEstadisticas? instance;

        public string ComboBox { get => cmbEstadisticas.Text; set => cmbEstadisticas.Text = value; }
        public string LabelToStr { get => lblInformacion.Text; set => lblInformacion.Text = value; }
        public string LabelPrimero { get => lblPrimero.Text; set => lblPrimero.Text = value; }
        public string LabelSegundo { get => lblSegundo.Text; set => lblSegundo.Text = value; }
        public string LabelTercero { get => lblTercero.Text; set => lblTercero.Text = value; }

        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            cmbEstadisticas.Items.Add("**HISTORIAL PARTIDAS**");
            cmbEstadisticas.Items.Add("**JUGADORES**");
            LlenarPodio();
            LlenarDataGrid();
        }              

        public static frmEstadisticas GetInstance(Form padreContenedor)
        {
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
        public void LlenarPodio()
        {
            List<Usuario> misJugadores = new RepositorioUsuarios().GetByScore();
            LabelPrimero = "Nombre: " + misJugadores[0].NombreUsuario + "\nScore: " + misJugadores[0].Puntaje;
            LabelSegundo = "Nombre: " + misJugadores[1].NombreUsuario + "\nScore: " + misJugadores[1].Puntaje;
            LabelTercero = "Nombre: " + misJugadores[2].NombreUsuario + "\nScore: " + misJugadores[2].Puntaje;
        }
        public void LlenarDataGrid()
        {
            if(cmbEstadisticas.Text == "Historial Partidas")
            {
                dgvEstadisticas.DataSource = null;
                dgvEstadisticas.DataSource = new RepositorioPartidas().GetAll();
                dgvEstadisticas.Refresh();
            }
            else
            {
                if (cmbEstadisticas.Text == "Jugadores")
                {
                    dgvEstadisticas.DataSource = null;
                    dgvEstadisticas.DataSource = new RepositorioUsuarios().GetAll();
                    dgvEstadisticas.Refresh();
                }
            }
        }
       
        private void dgvEstadisticas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
