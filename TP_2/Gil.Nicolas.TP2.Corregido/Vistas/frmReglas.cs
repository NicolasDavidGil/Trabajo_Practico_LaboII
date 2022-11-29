using Entidades.Repositorio;
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
    public partial class frmReglas : Form
    {
        public static frmReglas? instance;
        public static frmPrincipal? principal;
        public frmReglas()
        {
            InitializeComponent();
        }

        private void frmReglas_Load(object sender, EventArgs e)
        {
            string reglamento = new ArchivoTxT().LeerTxt("ReglasUno");
            rtbLectura.Text = reglamento;
        }

        public static frmReglas ObtenerInstancia(frmPrincipal padreContenedor)
        {
            principal = padreContenedor;
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmReglas();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (principal != null)
                principal.RefrescarForm();
            this.Close();
        }
    }
}
