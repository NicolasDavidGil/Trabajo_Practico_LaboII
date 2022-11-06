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
    public partial class frmVuelosActivos : Form
    {
        public frmVuelosActivos()
        {
            InitializeComponent();
        }

        private void frmVuelosActivos_Load(object sender, EventArgs e)
        {
            lblVueloVacio.Visible = true;
            for(int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                cobVuelosActivos.Items.Add(Aerolinea.vuelosActivos[i].Codigo);
            }            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void RefreshLabels()
        {       
            lblTotalPasajeros.Refresh();
            lblPasajerosTurista.Refresh();
            lblPasajerosPrimera.Refresh();
            lblTotalMaletas.Refresh();
            lblPesoTotal.Refresh();      
            lblCapacidadLibreBodega.Refresh();
        }

        private void cobVuelosActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLabels();
            for (int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                if(cobVuelosActivos.Text == Aerolinea.vuelosActivos[i].Codigo.ToString())
                {
                    lblVueloVacio.Visible = false;
                    CargarLabels(i);
                    dgvPasajeros.DataSource = null;
                    dgvPasajeros.DataSource = Aerolinea.vuelosActivos[i].ListaPasajero;
                    break;
                }
            }
        }

        private void CargarLabels(int index)
        {
            int cantTurista, cantPrimera, contadorMaletas;
            float acumuladorBodega;
            cantTurista = 0;
            cantPrimera = 0;
            contadorMaletas = 0;
            acumuladorBodega = 0;

            for (int i = 0; i < Aerolinea.vuelosActivos[index].ListaPasajero.Count; i++)
            {
                if (Aerolinea.vuelosActivos[index].ListaPasajero[i].ClaseVuelo == "Turista")
                {
                    cantTurista++;
                    acumuladorBodega += Aerolinea.vuelosActivos[index].ListaPasajero[i].EquipajeBodega;
                    contadorMaletas += Aerolinea.vuelosActivos[index].ListaPasajero[i].CantidadMaletas;
                }
                else
                {
                    cantPrimera++;
                    acumuladorBodega += Aerolinea.vuelosActivos[index].ListaPasajero[i].EquipajeBodega;
                    contadorMaletas += Aerolinea.vuelosActivos[index].ListaPasajero[i].CantidadMaletas;
                }
            }
            lblVueloELegido.Text = Aerolinea.vuelosActivos[index].ToString();
            lblTotalPasajeros.Text = (cantPrimera + cantTurista).ToString();
            lblPasajerosTurista.Text = cantTurista.ToString();
            lblPasajerosPrimera.Text = cantPrimera.ToString();
            lblTotalMaletas.Text = contadorMaletas.ToString();
            lblPesoTotal.Text = acumuladorBodega.ToString() + " kg.";
            lblCapacidadLibreBodega.Text = (Aerolinea.vuelosActivos[index].AeronaveAsig.CapacidadBodega - acumuladorBodega).ToString() + " kg.";            
        }
    }
}
