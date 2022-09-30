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
            int vuelosTotales;

            lblNombreUsuario.Text = Aerolinea.vendedorActivo.UsuarioLogin;
            lblVuelosActivos.Text = Aerolinea.vuelosActivos.Count.ToString();
            lblVuelosFinalizados.Text = Aerolinea.vuelosFinalizados.Count.ToString();
            vuelosTotales = Aerolinea.vuelosActivos.Count + Aerolinea.vuelosFinalizados.Count;
            lblVuelosTotales.Text = vuelosTotales.ToString();
            dtgInfoVuelosActivos.DataSource = null;
            dtgInfoVuelosActivos.DataSource = Aerolinea.vuelosActivos;
            dtgInfoVuelosTerminados.DataSource = null;
            dtgInfoVuelosTerminados.DataSource = Aerolinea.vuelosFinalizados;         
        }

        private void dtgInfoVuelosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
