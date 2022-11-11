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
    public partial class frmEstadisticas : Form
    {
        public static frmEstadisticas? instance;
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {

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

    }
}
