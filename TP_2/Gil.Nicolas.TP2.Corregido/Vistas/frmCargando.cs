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
    public partial class frmCargando : Form
    {
        public frmCargando()
        {
            InitializeComponent();
        }

        private void frmCargando_Load(object sender, EventArgs e)
        {
            ptbCargando.Image = Resources.cargando;
        }
    }
}
