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
using Parcial_Library;

namespace Parcial_Laboratorio
{
    public partial class UserMenu : Form
    {
        public bool flagHardCodeo = false;
        public UserMenu()
        {
            InitializeComponent();   
        }

     
        private void btn_ventaPasajes_Click(object sender, EventArgs e)
        {
            if (Aerolinea.vuelosActivos[Aerolinea.index].AsientosLibresP > 0 
                && Aerolinea.vuelosActivos[Aerolinea.index].AsientosLibresT > 0)
            {
                VentaBoletos nuevaVenta = new();
                this.Hide();
                nuevaVenta.ShowDialog();
                this.Show();              
            }          
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas estaAero = new();       
            this.Hide();
            estaAero.ShowDialog();
            this.Show();
        }

        private void btn_nuevoVuelo_Click(object sender, EventArgs e)
        {            
            CreacionVuelo vueloNuevo = new();
            this.Hide();
            vueloNuevo.ShowDialog();
            this.Show();            
        }

        private void btn_informacionVuelos_Click(object sender, EventArgs e)
        {
            InfoVuelos infoVuelos = new InfoVuelos();
            this.Hide();
            infoVuelos.ShowDialog();
            this.Show();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {         
            lbl_userName.Text = Aerolinea.vendedorActivo.UsuarioLogin;
            lbl_nombreVendedor.Text = Aerolinea.vendedorActivo.NombrePersona;
            lbl_acceso.Text = Aerolinea.vendedorActivo.NivelAcceso;
            pnlVuelosActivos.Visible = false;
            lblVueloLLeno.Visible = false;  
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            DetallesVuelo nuevaVentana = new DetallesVuelo();
            nuevaVentana.Show();
        }

        private void btnEditarVuelo_Click(object sender, EventArgs e)
        {
            EditarVuelo nuevaVentana = new EditarVuelo();
            this.Hide();
            nuevaVentana.ShowDialog();
            this.Show();
        }
        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;  
           this.Hide();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            BusquedaCliente busqueda = new();
            this.Hide();
            busqueda.ShowDialog();
            this.Show();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {

        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }             

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlVuelosActivos.Visible = false;
            Aerolinea.flagVentaNuevoCliente = false;
        }

        private void dtgVueloActivos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aerolinea.index = e.RowIndex;
            if (Aerolinea.index != -1)
            {
                btnProceder.Enabled = true;               
            }
        }

        private void MenuVentaNuevoCliente_Click(object sender, EventArgs e)
        {
            Aerolinea.flagVentaNuevoCliente = true;
            pnlVuelosActivos.Visible = true;
            dtgVueloActivos.DataSource = null;
            dtgVueloActivos.DataSource = Aerolinea.vuelosActivos;
            btnProceder.Enabled = false;
            btnProceder.Text = "CREAR CLIENTE";
        }

        private void MenuVentaClienteExistente_Click(object sender, EventArgs e)
        {
            pnlVuelosActivos.Visible = true;
            dtgVueloActivos.DataSource = null;
            dtgVueloActivos.DataSource = Aerolinea.vuelosActivos;
            btnProceder.Enabled = false;
            btnProceder.Text = "ELEGIR CLIENTE";
        }

        private void MenuAgregarCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente newCli = new();
            this.Hide();
            newCli.ShowDialog();
            this.Show();
        }

        private void btnMenuVerVuelosActivos_Click(object sender, EventArgs e)
        {
            DetallesVuelo detalles = new();
            this.Hide();
            detalles.ShowDialog();
            this.Show();
        }

        private void btnProceder_Click(object sender, EventArgs e)
        {
            if (Aerolinea.vuelosActivos[Aerolinea.index].Estado == "Disponible")
            {
                if (Aerolinea.flagVentaNuevoCliente == true)
                {                   
                    NuevoCliente nuevoCliente = new();
                    this.Hide();
                    nuevoCliente.ShowDialog();
                    this.Show();
                    Aerolinea.flagVentaNuevoCliente = false;
                }
                else
                {                   
                    BusquedaCliente busquedaCliente = new();
                    this.Hide();
                    busquedaCliente.ShowDialog();
                    this.Show();
                    Aerolinea.flagVentaNuevoCliente = false;
                }
            }
            else
            {
                lblVueloLLeno.Visible = true;
            }
        }

        private void btnMenuEditarVendedor_Click(object sender, EventArgs e)
        {
            EdicionVendedores editor = new();
            this.Hide();
            editor.ShowDialog();
            this.Show();
        }

        private void btnMenuSitioWeb_Click(object sender, EventArgs e)
        {
            VisitLink();
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
    }
}
