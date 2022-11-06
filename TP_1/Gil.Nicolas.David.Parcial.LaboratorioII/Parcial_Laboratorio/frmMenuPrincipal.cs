using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Library;

namespace Parcial_Laboratorio
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Aerolinea.vendedorActivo.NombrePersona;
        }

        private void tmrMenuPrincipal_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();    
        }

        private void btnMenuCrearCliente_Click(object sender, EventArgs e)
        {
            bool vengoMenu = true;
            frmCrearCliente nuevoCliente = new(vengoMenu);
            this.Hide();
            nuevoCliente.ShowDialog();
            this.Show();
        }

        private void btnMenuBaseDatosCliente_Click(object sender, EventArgs e)
        {
            bool existente = true;
            frmBaseDatosClientes clientes = new(existente);
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            frmNuevoVuelo nuevoVuelo = new();
            this.Hide();
            nuevoVuelo.ShowDialog();
            this.Show();
        }

        private void btnVuelosProgramados_Click(object sender, EventArgs e)
        {
            frmVuelosActivos vuelosActivos = new();
            this.Hide();
            vuelosActivos.ShowDialog();
            this.Show();
        }

        private void btnEditarVuelo_Click(object sender, EventArgs e)
        {
            frmEdicionVuelo editarVuelo = new();
            this.Hide();
            editarVuelo.ShowDialog();
            this.Show();
        }

        private void btnHistorialVuelo_Click(object sender, EventArgs e)
        {
            frmHistorialVuelos historial = new();
            this.Hide();
            historial.ShowDialog();
            this.Show();
        }

        private void btnPersonalEmpresa_Click(object sender, EventArgs e)
        {
            frmPersonal staff = new();
            this.Hide();
            staff.ShowDialog();
            this.Show();
        }

        private void btnEstadisticasEmpresa_Click(object sender, EventArgs e)
        {
            frmEstadisticasEmpresa estadisticas = new();
            this.Hide();
            estadisticas.ShowDialog();
            this.Show();
        }

        private void btnSitioWeb_Click(object sender, EventArgs e)
        {
            VisitLink();
        }

        private void btnEstadoFlota_Click(object sender, EventArgs e)
        {
            frmEstadoFlota estadoFlota = new();
            this.Hide();
            estadoFlota.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void VisitLink()
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://632e2af6c37b4.site123.me/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnVentaClienteNuevo_Click(object sender, EventArgs e)
        {
            bool venta = false;
            frmCrearCliente crear = new(venta);
            this.Hide();
            crear.ShowDialog();
            this.Show();
        }

        private void btnVentaClienteExistente_Click(object sender, EventArgs e)
        {
            bool existente = false;
            frmBaseDatosClientes clientes = new(existente);
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }
    }
}
