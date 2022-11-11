using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista.Vistas
{
    public partial class frmCargando : Form
    {
        public frmCargando()
        {
            InitializeComponent();
        }

        private void frmCargando_Load(object sender, EventArgs e)
        {
            ptbLoading.Image = Image.FromFile(@"C:\Users\gpnic\Desktop\Gil.Nicolas.TP2_LaboII\Vista\Resources\cargando.gif");
            ptbLoading.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
