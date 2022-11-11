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
using Entidades.Repositorios;

namespace Vista.Vistas
{
    public partial class frmReglamento : Form
    {
        public static frmReglamento? instance;
        public frmReglamento()
        {
            InitializeComponent();
        }

        private void frmReglamento_Load(object sender, EventArgs e)
        {
            string reglamento = new ArchivoTxT().LeerTxt("ReglasUno");
            rtbReglamento.Text += reglamento;
        }

        public static frmReglamento GetInstance(Form padreContenedor)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmReglamento();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
