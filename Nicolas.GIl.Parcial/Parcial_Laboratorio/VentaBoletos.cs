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

        private void btn_confirmarVenta_Click(object sender, EventArgs e)
        {
            int contador = 0;

            while(contador < int.Parse(txt_cantidadPasajeros.Text))
            {
                if(txt_nombrePasajero.Text != String.Empty && txt_documentoPasajero.Text != String.Empty &&
                    txt_edadPasajero.Text != String.Empty && cmb_pesoTotal.Text != String.Empty &&
                    cmb_clasePasajero.Text != String.Empty)
                {
                    if (Validador.ValidadarIngresaString(txt_nombrePasajero.Text) && Validador.ValidarIngresoNumero(txt_documentoPasajero.Text) &&
                        Validador.ValidarIngresoNumero(txt_edadPasajero.Text) && Validador.ValidadarIngresaString(cmb_pesoTotal.Text))
                    {
                        if (Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero is not null)
                        {
                            Pasajero pasajeroAux = new Pasajero(cmb_clasePasajero.Text, float.Parse(cmb_pesoTotal.Text),
                                                                bool.Parse(cb_equipajeMano.Text), int.Parse(txt_edadPasajero.Text),
                                                                txt_nombrePasajero.Text, int.Parse(txt_documentoPasajero.Text),
                                                                int.Parse(nud_cantidadMaletas.ToString()));
                            Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero.Add(pasajeroAux);                            
                        } else
                        {
                            List<Pasajero> lista = new List<Pasajero>();
                            Pasajero pasajeroAux = new Pasajero(cmb_clasePasajero.Text, float.Parse(cmb_pesoTotal.Text),
                                                                bool.Parse(cb_equipajeMano.Text), int.Parse(txt_edadPasajero.Text),
                                                                txt_nombrePasajero.Text, int.Parse(txt_documentoPasajero.Text),
                                                                int.Parse(nud_cantidadMaletas.ToString()));
                            lista.Add(pasajeroAux);
                            Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero = lista;
                        }
                    }
                }
                contador++;
            }
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cb_clasePasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_clasePasajero.Text == "Primera")
            {
                nud_cantidadMaletas.Maximum = 2;      
            }else
            {
                nud_cantidadMaletas.Maximum = 1;
            }                        
        }

        private void VentaBoletos_Load(object sender, EventArgs e)
        {                
            for(int i = 0; i < Aerolinea.clasesVuelo.Count; i++)
            {
                cmb_clasePasajero.Items.Add(Aerolinea.clasesVuelo[i]);
            }            
        }
    
        private void cmb_pesoTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_clasePasajero.Text == "Turista" && nud_cantidadMaletas.Value == 1)
            {
                cmb_pesoTotal.ResetText();
                for (int i = 0; i < 25; i++)
                {
                    cmb_pesoTotal.Items.Add(i + " kg.");
                }
            }
            if (cmb_clasePasajero.Text == "Primera" && nud_cantidadMaletas.Value == 1)
            {
                cmb_pesoTotal.ResetText();
                for (int i = 1; i <= 21; i++)
                {
                    cmb_pesoTotal.Items.Add(i + " kg");
                }
            }
            if (cmb_clasePasajero.Text == "Primera" && nud_cantidadMaletas.Value == 2)
            {
                cmb_pesoTotal.ResetText();
                for (int i = 1; i <= 42; i++)
                {
                    cmb_pesoTotal.Items.Add(i + " kg");
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
                    cmb_pesoTotal.Items.Add(i + " kg.");
                }
            }
            if(nud_cantidadMaletas.Value == 2)
            {
                for (int i = 1; i < 43; i++)
                {
                    cmb_pesoTotal.Items.Add(i + " kg.");
                }
            }
        }
    }
}
