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
    public partial class frmCargando : Form
    {
        public frmCargando()
        {
            InitializeComponent();
        }

        private void frmCargardo_Load(object sender, EventArgs e)
        {
            ptbCargando.Image = Image.FromFile(@"C:\Users\gpnic\Desktop\Gil.Nicolas.TP2_LaboII\Vista\Resources\cargando.gif");
            ptbCargando.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
