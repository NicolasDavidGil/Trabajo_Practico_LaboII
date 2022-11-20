using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using Entidades.Repositorio;
using static System.Net.Mime.MediaTypeNames;
using Vista.Properties;
using System.Collections;

namespace Vista
{
    public partial class frmEstadisticas : Form, IEstadisticas
    {
        public static frmEstadisticas? instance;
        public static frmPrincipal? principal;
        public PresentadorEstadisticas admin;
        public static int indexPartida;
        public string Chat { get => rtbEstadisticas.Text; set => rtbEstadisticas.Text = value; }
        public string TopUno { get => lblTopUno.Text; set => lblTopUno.Text = value; }
        public string TopDos { get => lblTopDos.Text; set => lblTopDos.Text = value; }
        public string TopTres { get => lblTopTres.Text; set => lblTopTres.Text = value; }

        public frmEstadisticas()
        {
            InitializeComponent();
            admin = new PresentadorEstadisticas(this);
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            admin.LLenarDatos();
            dgvEstadisticas.DataSource = null;
            dgvEstadisticas.DataSource = admin.ObtenerHistorial();
        }

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

        private void btnSalirEstadisticas_Click(object sender, EventArgs e)
        {
            if(principal != null)
            principal.RefrescarForm();
            this.Close();
        }

        private void dgvEstadisticas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexPartida = e.RowIndex;
            if(indexPartida != -1)
                admin.DataGridIndexChange(indexPartida);         
        }
    }
}
