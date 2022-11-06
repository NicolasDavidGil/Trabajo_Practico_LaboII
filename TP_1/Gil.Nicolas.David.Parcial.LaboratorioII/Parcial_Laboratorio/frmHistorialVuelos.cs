using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Library;

namespace Parcial_Laboratorio
{
    public partial class frmHistorialVuelos : Form
    {
        public frmHistorialVuelos()
        {
            InitializeComponent();
        }

        private void frmHistorialVuelos_Load(object sender, EventArgs e)
        {
            int vuelosTotales;

            lblNombreUsuario.Text = Aerolinea.vendedorActivo.UsuarioLogin;
            lblVuelosActivos.Text = Aerolinea.vuelosActivos.Count.ToString();
            lblVuelosFinalizados.Text = Aerolinea.vuelosFinalizados.Count.ToString();
            vuelosTotales = Aerolinea.vuelosActivos.Count + Aerolinea.vuelosFinalizados.Count;
            lblVuelosTotales.Text = vuelosTotales.ToString();           
            dgvHistorialVuelos.DataSource = null;
            dgvHistorialVuelos.DataSource = Aerolinea.vuelosFinalizados;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
