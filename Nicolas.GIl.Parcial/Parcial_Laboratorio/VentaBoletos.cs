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
    public partial class VentaBoletos : Form
    {
        public VentaBoletos()
        {
            InitializeComponent();
        }

        private void VentaBoletos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Aerolinea.clasesVuelo.Count; i++)
            {
                cmb_clasePasajero.Items.Add(Aerolinea.clasesVuelo[i]);
            }

            lblNombrePasajero.Text = Aerolinea.clienteHistorial[Aerolinea.indexCliente].NombrePersona;
            lblDniPasajero.Text = Aerolinea.clienteHistorial[Aerolinea.indexCliente].DocumentoPersona.ToString();
            lblEdadPasajero.Text = Aerolinea.clienteHistorial[Aerolinea.indexCliente].EdadPersona.ToString();
            lblCodigoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Codigo;
            lblOrigenVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Origen;
            lblDestinoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Destinos;
        }

        private void btn_confirmarVenta_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmb_clasePasajero.Text) && !String.IsNullOrEmpty(cmb_pesoTotal.Text) &&
                !String.IsNullOrEmpty(nud_cantidadMaletas.ToString()))
            {
                Pasajero auxPasajero;

                auxPasajero = new Pasajero(cmb_clasePasajero.Text, float.Parse(cmb_pesoTotal.Text), 
                                            cb_equipajeMano.Checked, (int)nud_cantidadMaletas.Value, 
                                            Aerolinea.clienteHistorial[Aerolinea.indexCliente]);
                if (auxPasajero != null)
                {
                    Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero.Add(auxPasajero);
                    Aerolinea.index = -1;
                    Aerolinea.indexCliente = -1;
                    DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void btn_cancelarVenta_Click(object sender, EventArgs e)
        {
            Aerolinea.index = -1;
            Aerolinea.indexCliente = -1;
            this.Close();
        }

        private void cb_clasePasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_clasePasajero.Text == "Primera")
            {
                nud_cantidadMaletas.Maximum = 2;
                lblPrecioBruto.Refresh();
                lblPrecioBruto.Text = Aerolinea.vuelosActivos[Aerolinea.index].PrecioVuelo.ToString();
                lblPrecioFinal.Refresh();
                lblPrecioFinal.Text = Pasajero.CalcularPrecioNeto(Aerolinea.vuelosActivos[Aerolinea.index].PrecioVuelo, cmb_clasePasajero.Text).ToString();
            }else
            {
                nud_cantidadMaletas.Maximum = 1;
                lblPrecioBruto.Refresh();
                lblPrecioBruto.Text = Aerolinea.vuelosActivos[Aerolinea.index].PrecioVuelo.ToString();
                lblPrecioFinal.Refresh();
                lblPrecioFinal.Text = Pasajero.CalcularPrecioNeto(Aerolinea.vuelosActivos[Aerolinea.index].PrecioVuelo, cmb_clasePasajero.Text).ToString();
            }                        
        }

       
    
        private void cmb_pesoTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_clasePasajero.Text == "Turista" && nud_cantidadMaletas.Value == 1)
            {
                cmb_pesoTotal.ResetText();
                for (int i = 0; i < 25; i++)
                {
                    cmb_pesoTotal.Items.Add(i);
                }
            }
            if (cmb_clasePasajero.Text == "Primera" && nud_cantidadMaletas.Value == 1)
            {
                cmb_pesoTotal.ResetText();
                for (int i = 1; i <= 21; i++)
                {
                    cmb_pesoTotal.Items.Add(i);
                }
            }
            if (cmb_clasePasajero.Text == "Primera" && nud_cantidadMaletas.Value == 2)
            {
                cmb_pesoTotal.ResetText();
                for (int i = 1; i <= 42; i++)
                {
                    cmb_pesoTotal.Items.Add(i);
                }
            }
        }

        private void nud_cantidadMaletas_ValueChanged(object sender, EventArgs e)
        {
            cmb_pesoTotal.Items.Clear();
            if (nud_cantidadMaletas.Value == 1)
            {
                for (int i = 1; i < 26; i++)
                {
                    cmb_pesoTotal.Items.Add(i);
                }
            }
            if(nud_cantidadMaletas.Value == 2)
            {
                for (int i = 1; i < 43; i++)
                {
                    cmb_pesoTotal.Items.Add(i);
                }
            }
        }
    }
}
