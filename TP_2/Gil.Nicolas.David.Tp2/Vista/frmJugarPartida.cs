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
    public partial class frmJugarPartida : Form
    {
        public static frmJugarPartida? instance;
        public static frmPrincipal? principal;
        public frmJugarPartida()
        {
            InitializeComponent();
        }

        private void frmJugarPartida_Load(object sender, EventArgs e)
        {

        }

        public static frmJugarPartida GetInstance(frmPrincipal padreContenedor)
        {
            principal = padreContenedor;
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmJugarPartida();
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
            this.Close();
        }
    }
}
