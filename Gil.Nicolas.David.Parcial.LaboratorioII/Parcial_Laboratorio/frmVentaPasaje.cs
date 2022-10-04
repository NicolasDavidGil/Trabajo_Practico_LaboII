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
    public partial class frmVentaPasaje : Form
    {
        private int index;
        private int indexCliente;
        private Pasajero? auxPasajero;
        public frmVentaPasaje()
        {
            InitializeComponent();
        }
        public frmVentaPasaje(int indexCliente) : this()
        {
            this.indexCliente = indexCliente;
        }

        private void frmVentaPasaje_Load(object sender, EventArgs e)
        {
            BuscarPasajero();
            cobClasePasajero.Items.Add(EClaseVuelo.Turista);
            cobClasePasajero.Items.Add(EClaseVuelo.Primera);
            index = -1;
            btnContinuar.Enabled = false;
            dgvVuelosDisponibles.DataSource = null;
            dgvVuelosDisponibles.DataSource = Aerolinea.vuelosActivos;            
        }

        private void cobClasePasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobClasePasajero.Text == "Primera")
            {
                numudCantidadMaletas.Maximum = 2;                
            }
            else
            {
                numudCantidadMaletas.Maximum = 1;
            }
            cobPesoTotal.Items.Clear();
            if (cobClasePasajero.Text == "Turista" && numudCantidadMaletas.Value == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    cobPesoTotal.Items.Add(i);
                }
            }
            if (cobClasePasajero.Text == "Primera" && numudCantidadMaletas.Value == 1)
            {
                for (int i = 1; i <= 21; i++)
                {
                    cobPesoTotal.Items.Add(i);
                }
            }
            if (cobClasePasajero.Text == "Primera" && numudCantidadMaletas.Value == 2)
            {
                for (int i = 1; i <= 42; i++)
                {
                    cobPesoTotal.Items.Add(i);
                }
            }
        }

        private void cobPesoTotal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscarPasajero()
        {
            for (int i = 0; i < Aerolinea.vuelosActivos[index].ListaPasajero.Count; i++)
            {
                if (Aerolinea.clienteHistorial[indexCliente].DocumentoPersona == Aerolinea.vuelosActivos[index].ListaPasajero[i].GetHashCode())
                {
                    auxPasajero = Aerolinea.vuelosActivos[index].ListaPasajero[i];
                    break;
                }
            }
        }

        private void dgvVuelosDisponibles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index != -1)
            {
                lblPasajeroElegido.Text = auxPasajero.ToString();
                btnContinuar.Enabled = true;
            }
        }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string destino = Aerolinea.vuelosActivos[index].Destinos;
            int duracion = Aerolinea.vuelosActivos[index].Duracion;
            float precio = Pasajero.CalcularPrecioVuelo(destino, duracion, cobClasePasajero.Text); 

            if (!String.IsNullOrEmpty(cobClasePasajero.Text) && !String.IsNullOrEmpty(cobPesoTotal.Text))
            {               
                Pasajero auxPasajero;

                auxPasajero = new Pasajero(cobClasePasajero.Text, float.Parse(cobPesoTotal.Text),
                                            chkEquipajeMano.Checked, (int)numudCantidadMaletas.Value,
                                            Aerolinea.clienteHistorial[indexCliente],
                                            precio);
                if (auxPasajero != null)
                {
                    Aerolinea.vuelosActivos[index].ListaPasajero.Add(auxPasajero);
                    Aerolinea.clienteHistorial[indexCliente].CantidadVuelos++;
                    Aerolinea.vendedorActivo.RealizarCalculos(precio);
                    Aerolinea.clienteHistorial[indexCliente].RealizarCalculos(precio);
                    if (cobClasePasajero.Text == "Primera")
                    {
                        Aerolinea.vuelosActivos[index].AsientosLibresP--;
                    }
                    else
                    {
                        Aerolinea.vuelosActivos[index].AsientosLibresT--;
                    }

                    DialogResult = DialogResult.OK;
                }                               
            }else
            {
                lblError.Text = "Se deben completar todos los campos";
            }
        }        

        private void numudCantidadMaletas_ValueChanged(object sender, EventArgs e)
        {
            cobPesoTotal.Items.Clear();
            if (numudCantidadMaletas.Value == 1)
            {
                for (int i = 1; i < 26; i++)
                {
                    cobPesoTotal.Items.Add(i);
                }
            }
            if (numudCantidadMaletas.Value == 2)
            {
                for (int i = 1; i < 43; i++)
                {
                    cobPesoTotal.Items.Add(i);
                }
            }
        }  

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
