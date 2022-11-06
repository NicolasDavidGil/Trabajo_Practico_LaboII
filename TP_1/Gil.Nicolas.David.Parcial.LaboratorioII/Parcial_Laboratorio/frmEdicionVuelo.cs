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
    public partial class frmEdicionVuelo : Form
    {
        private int index;
        public frmEdicionVuelo()
        {
            InitializeComponent();
        }

        private void frmEdicionVuelo_Load(object sender, EventArgs e)
        {
            index = -1;
            InicializarEdicion();
        }
        private void InicializarEdicion()
        {
            pnlConfirmacionFinalizar.Visible = false;
            lblNombreUsuario.Text = Aerolinea.vendedorActivo.NombrePersona.ToString();
            lblIndiceVacio.Visible = false;
            lblSalioOk.Visible = false;
            int contadorVuelosLibres = 0;
            for (int i = 0; i < Aerolinea.misAviones.Count; i++)
            {
                if (Aerolinea.misAviones[i].EstadoAvion == false)
                {
                    contadorVuelosLibres++;
                }
            }
            lblNumeroDeVuelos.Text = contadorVuelosLibres.ToString();
            dgvVuelosActivos.DataSource = null;
            dgvVuelosActivos.DataSource = Aerolinea.vuelosActivos;
        }

        private void btnFinalizarVuelo_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                pnlConfirmacionFinalizar.Visible = true;
            }
            else
            {
                lblIndiceVacio.Visible = true;
            }
        }

        private void btnCerrarLista_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                Aerolinea.vuelosActivos[index].Estado = "Lleno";
                dgvVuelosActivos.Refresh();
                lblSalioOk.Text = "Lista cerrada";
                lblSalioOk.Visible = true;
                lblIndiceVacio.Visible = false;
            }
            else
            {
                lblIndiceVacio.Visible = true;
            }
        }

        private void btnCambiarDuracion_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                string auxS;
                string auxDateTime;

                Aerolinea.vuelosActivos[index].Duracion = Vuelo.CalcularDuracionVuelo(Aerolinea.vuelosActivos[index].Destinos);
                auxDateTime = DateTime.Parse(Aerolinea.vuelosActivos[index].HoraPartida).ToString("hh");
                auxS = Vuelo.CalcularHorarioLLegada(auxDateTime,
                                                    Aerolinea.vuelosActivos[index].FechaPartida,
                                                    Aerolinea.vuelosActivos[index].Duracion);
                Aerolinea.vuelosActivos[index].HoraArribo = auxS;
                dgvVuelosActivos.Refresh();
                lblSalioOk.Text = "Duracion del vuelo modificada";
                lblSalioOk.Visible = true;
                lblIndiceVacio.Visible = false;
            }
            else
            {
                lblIndiceVacio.Visible = true;
            }
        }
        private void btnCarcelarFinalizacion_Click(object sender, EventArgs e)
        {
            pnlConfirmacionFinalizar.Visible = false;
        }

        private void btnConfirmarFinalizacion_Click(object sender, EventArgs e)
        {
            Aerolinea.vuelosActivos[index].Estado = "Finalizado";
            Aerolinea.vuelosFinalizados.Add(Aerolinea.vuelosActivos[index]);
            Aerolinea.vuelosActivos.Remove(Aerolinea.vuelosActivos[index]);
            dgvVuelosActivos.DataSource = null;
            dgvVuelosActivos.DataSource = Aerolinea.vuelosActivos;
            lblSalioOk.Text = "Vuelo Finalizado";
            lblSalioOk.Visible = true;
            lblIndiceVacio.Visible = false;
            pnlConfirmacionFinalizar.Visible = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgvVuelosActivos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
