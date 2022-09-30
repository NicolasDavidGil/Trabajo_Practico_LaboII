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
    public partial class EditarVuelo : Form
    {
        public EditarVuelo()
        {
            InitializeComponent();
        }

        private void EditarVuelo_Load(object sender, EventArgs e)
        {
            InicializarEdicion();
        }

        private void InicializarEdicion()
        {
            pnlConfirmacionFinalizar.Visible = false;
            lblNombreUsuario.Text = Aerolinea.vendedorActivo.UsuarioLogin.ToString();
            lblIndiceVacio.Visible = false;
            lblSalioOk.Visible = false;
            int contadorVuelosLibres = 0;
            for(int i = 0; i < Aerolinea.misAviones.Count; i++)
            {
                if (Aerolinea.misAviones[i].EstadoAvion == false)
                {
                    contadorVuelosLibres++;
                }
            }
            lblNumeroDeVuelos.Text = contadorVuelosLibres.ToString();
            dtgVuelosActivos.DataSource = null;
            dtgVuelosActivos.DataSource = Aerolinea.vuelosActivos;
        }

        private void btnFinalizarVuelo_Click(object sender, EventArgs e)
        {
            if(Aerolinea.index != -1)
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
            if(Aerolinea.index != -1)
            {
                Aerolinea.vuelosActivos[Aerolinea.index].Estado = "Lleno";
                dtgVuelosActivos.Refresh();
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
            if (Aerolinea.index != -1)
            {
                string auxS;
                string auxDateTime;

                Aerolinea.vuelosActivos[Aerolinea.index].Duracion = Aerolinea.CalcularDuracionVuelo(Aerolinea.vuelosActivos[Aerolinea.index].Destinos);
                auxDateTime = DateTime.Parse(Aerolinea.vuelosActivos[Aerolinea.index].HoraPartida).ToString("hh");
                auxS = Vuelo.CalcularHorarioLLegada(auxDateTime,
                                                    Aerolinea.vuelosActivos[Aerolinea.index].FechaPartida,
                                                    Aerolinea.vuelosActivos[Aerolinea.index].Duracion);
                Aerolinea.vuelosActivos[Aerolinea.index].HoraArribo = auxS;
                dtgVuelosActivos.Refresh();
                lblSalioOk.Text = "Duracion del vuelo modificada";
                lblSalioOk.Visible = true;
                lblIndiceVacio.Visible = false;
            }
            else
            {
                lblIndiceVacio.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aerolinea.index = -1;
            DialogResult = DialogResult.Cancel;
        }

        private void dtgVuelosActivos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aerolinea.index = e.RowIndex;
        }

        private void btnConfirmarFinalizacion_Click(object sender, EventArgs e)
        {
            Aerolinea.vuelosActivos[Aerolinea.index].Estado = "Finalizado";
            Aerolinea.vuelosFinalizados.Add(Aerolinea.vuelosActivos[Aerolinea.index]);
            Aerolinea.vuelosActivos.Remove(Aerolinea.vuelosActivos[Aerolinea.index]);
            dtgVuelosActivos.DataSource = null;
            dtgVuelosActivos.DataSource = Aerolinea.vuelosActivos;
            lblSalioOk.Text = "Vuelo Finalizado";
            lblSalioOk.Visible = true;
            lblIndiceVacio.Visible = false;
            pnlConfirmacionFinalizar.Visible = false;
        }

        private void btnCarcelarFinalizacion_Click(object sender, EventArgs e)
        {
            pnlConfirmacionFinalizar.Visible = false;
        }
    }
}
