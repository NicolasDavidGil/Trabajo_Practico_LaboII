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
    public partial class UserMenu : Form
    {
        public bool flagHardCodeo = false;
        public UserMenu()
        {
            InitializeComponent();   
        }

        private void btn_hardCodeo_Click(object sender, EventArgs e)
        {            
            if(flagHardCodeo == false)
            {
                HardCodeo.InicializarVuelos();
                HardCodeo.InicializarPasajeros();
                lbl_primeraCarga.Visible = true;
                flagHardCodeo = true; 
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Aerolinea.vuelosActivos;
                lbl_vuelosActivos.Visible = false;
            }
            else
            {
                lbl_datosYaCargados.Visible = true;
                lbl_primeraCarga.Visible = false;
            }
        }

        private void btn_ventaPasajes_Click(object sender, EventArgs e)
        {
            if (Aerolinea.vuelosActivos[Aerolinea.index].AsientosLibresP > 0 && Aerolinea.vuelosActivos[Aerolinea.index].AsientosLibresT > 0)
            {
                VentaBoletos nuevaVenta = new VentaBoletos();
                this.Hide();
                nuevaVenta.ShowDialog();
                this.Show();
              
            }else
            {
                lbl_vueloLleno.Visible = true;
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
            if(vueloNuevo.DialogResult == DialogResult.OK)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Aerolinea.vuelosActivos;
                lbl_vuelosActivos.Visible = false;
            }

        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_informacionVuelos_Click(object sender, EventArgs e)
        {

        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            HardCodeo.InicializarAeronaves();
            HardCodeo.InicializarDestinos();
            HardCodeo.InicializarClasesVuelo();
            lbl_datosYaCargados.Visible = false;
            lbl_vuelosActivos.Visible = false;
            lbl_primeraCarga.Visible = false;
            lbl_vueloLleno.Visible = false;
            lbl_userName.Text = Aerolinea.vendedorActivo.UsuarioLogin;
            lbl_nombreVendedor.Text = Aerolinea.vendedorActivo.NombrePersona;
            lbl_acceso.Text = Aerolinea.vendedorActivo.NivelAcceso;
            if (Aerolinea.vuelosActivos.Count == 0)
            {
                lbl_vuelosActivos.Visible = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Aerolinea.vuelosActivos;
            }


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aerolinea.index = e.RowIndex;
            if (Aerolinea.index != 0)
            {
                btn_ventaPasajes.Enabled = true;
                btn_detalles.Enabled = true;
            }
        }

        private void lbl_vuelosActivos_Click(object sender, EventArgs e)
        {

        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            DetallesVuelo nuevaVentana = new DetallesVuelo();
            nuevaVentana.Show();
        }
    }
}
