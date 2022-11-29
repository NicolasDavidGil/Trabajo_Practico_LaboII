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
    public partial class frmReadme : Form
    {
        public static frmReadme? instance;
        public static frmPrincipal? principal;
        public frmReadme()
        {
            InitializeComponent();
            string reglamento = new ArchivoTxT().LeerTxt("Readme");
            rtbReadme.Text = reglamento;
        }


        public static frmReadme ObtenerInstancia(frmPrincipal padreContenedor)
        {
            principal = padreContenedor;
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmReadme();
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
