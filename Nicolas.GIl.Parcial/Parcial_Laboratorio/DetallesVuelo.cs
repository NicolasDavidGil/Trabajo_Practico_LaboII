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
    public partial class DetallesVuelo : Form
    {
        public DetallesVuelo()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Aerolinea.index = -1;
            DialogResult = DialogResult.Cancel;
        }

        private void DetallesVuelo_Load(object sender, EventArgs e)
        {
            lblVueloVacio.Visible = true;
            dtgCodigoVuelos.DataSource = null;
            dtgCodigoVuelos.DataSource = Aerolinea.vuelosActivos;
        }

        private void InicializarFormDetalles()
        {
            int cantTurista, cantPrimera, contadorMaletas;
            float acumuladorBodega;
            cantTurista = 0;
            cantPrimera = 0;
            contadorMaletas = 0;
            acumuladorBodega = 0;

            for(int i = 0; i < Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero.Count; i++)
            {
                if (Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero[i].ClaseVuelo == "Turista")
                {
                    cantTurista++;
                    acumuladorBodega += Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero[i].EquipajeBodega;
                    contadorMaletas += Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero[i].CantidadMaletas;
                }
                else
                {
                    cantPrimera++;
                    acumuladorBodega += Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero[i].EquipajeBodega;
                    contadorMaletas += Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero[i].CantidadMaletas;
                }
            }

            lblOrigenVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Origen;
            lblDestinoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Destinos;
            lblFechaPartida.Text = Aerolinea.vuelosActivos[Aerolinea.index].FechaPartida;
            lblHoraPartida.Text = Aerolinea.vuelosActivos[Aerolinea.index].HoraPartida;
            lblHoraLlegada.Text = Aerolinea.vuelosActivos[Aerolinea.index].HoraArribo;
            lblTotalPasajeros.Text = (cantPrimera + cantTurista).ToString();
            lblPasajerosTurista.Text = cantTurista.ToString();
            lblPasajerosPrimera.Text = cantPrimera.ToString();
            lblTotalMaletas.Text = contadorMaletas.ToString();
            lblPesoTotal.Text = acumuladorBodega.ToString();
            lblAvionDesignada.Text = Aerolinea.vuelosActivos[Aerolinea.index].AeronaveMatricula;
        }

        private void RefreshLabels()
        {
            lblOrigenVuelo.Refresh();
            lblDestinoVuelo.Refresh();
            lblFechaPartida.Refresh();
            lblHoraPartida.Refresh();
            lblHoraLlegada.Refresh();
            lblTotalPasajeros.Refresh();
            lblPasajerosTurista.Refresh();
            lblPasajerosPrimera.Refresh();
            lblTotalMaletas.Refresh();
            lblPesoTotal.Refresh();
            lblAvionDesignada.Refresh();
        }

            private void dtgCodigoVuelos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aerolinea.index = e.RowIndex;
            if(Aerolinea.index != -1)
            {                                
                lblVueloVacio.Visible = false;
                dtgListaPasajeros.Refresh();
                RefreshLabels();
                InicializarFormDetalles();
                dtgListaPasajeros.DataSource = null;
                dtgListaPasajeros.DataSource = Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero;
            }
        }
    }
}
