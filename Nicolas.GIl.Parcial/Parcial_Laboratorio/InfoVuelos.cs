using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_Library;

namespace Parcial_Laboratorio
{
    public partial class InfoVuelos : Form
    {
        public InfoVuelos()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void InfoVuelos_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                if (Aerolinea.vuelosActivos[i].Estado == "Finalizado")
                {
                    dtgInfoVuelosTerminados.DataSource = Aerolinea.vuelosActivos[i];
                }else
                {
                    dtgInfoVuelosActivos.DataSource = Aerolinea.vuelosActivos[i];
                }
            }
        }
    }
}
