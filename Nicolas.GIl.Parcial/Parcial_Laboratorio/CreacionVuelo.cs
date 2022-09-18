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
    public partial class CreacionVuelo : Form
    {
        public CreacionVuelo()
        {
            InitializeComponent();            
        }

        private void btn_crearVuelo_Click(object sender, EventArgs e)
        {
            Aeronave designada = new Aeronave();
            int duracionVuelo;
            string fechaSalida;
            string horaLlegada;

            for (int i = 0; i < Aerolinea.misAviones.Count; i++)
            {
                if (comboBox_aviones.Text == Aerolinea.misAviones[i].Matricula)
                {
                    designada = Aerolinea.misAviones[i];
                    Aerolinea.misAviones[i].EstadoAvion = false;
                }
            }

            if (comboBox_origen.Text != String.Empty && comboBox_destino.Text != String.Empty && cmb_horaPartida.Text != String.Empty && comboBox_aviones.Text != String.Empty)
            {
                duracionVuelo = Aerolinea.CalcularDuracionVuelo(comboBox_destino.Text);
                fechaSalida = dtp_fechaSalida.Value.Date.ToShortDateString();
                horaLlegada = Vuelo.CalcularHorarioLLegada(DateTime.Parse(cmb_horaPartida.Text).ToString("hh"), fechaSalida, duracionVuelo);

                Vuelo nuevoVuelo = new Vuelo(Aerolinea.nuestraAerolinea.CodigoAerolinea.ToString(),
                                        comboBox_origen.Text,
                                        comboBox_destino.Text,
                                        cmb_horaPartida.Text,
                                        duracionVuelo,
                                        designada.AsientosTurista,
                                        "Disponible",
                                        designada.AsientosPrimera,
                                        designada,
                                        fechaSalida,
                                        horaLlegada);

                Aerolinea.vuelosActivos.Add(nuevoVuelo);
                Aerolinea.nuestraAerolinea.CantidadVuelos++;
                DialogResult = DialogResult.OK;
            }
            else
            {
                lbl_camposVacios.Visible = true;                
            }
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {                        
            DialogResult = DialogResult.Cancel; 
        }

        private void comboBox_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_destino.Items.Clear();
            comboBox_destino.Text = "";
            for (int i = 0; i < Aerolinea.misDestinos.Count; i += 1)
            {
                if (comboBox_origen.Text == "Buenos Aires")
                {   
                    if(Aerolinea.misDestinos[i] != "Buenos Aires")
                    {
                        comboBox_destino.Items.Add(Aerolinea.misDestinos[i]);
                    }                    
                }
                else
                {                   
                    if (Aerolinea.misDestinos[i] != "Recife" && Aerolinea.misDestinos[i] != "Miami" &&
                        Aerolinea.misDestinos[i] != "Acapulco" && Aerolinea.misDestinos[i] != "Roma" && 
                        Aerolinea.misDestinos[i] != comboBox_origen.Text)
                    {
                        comboBox_destino.Items.Add(Aerolinea.misDestinos[i]);                        
                    }
                }
            }                                              
        }

        private void comboBox_aviones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CreacionVuelo_Load(object sender, EventArgs e)
        {
            lbl_camposVacios.Visible = false;            
            for (int i = 0; i < Aerolinea.misDestinos.Count; i++)
            {
                comboBox_origen.Items.Add(Aerolinea.misDestinos[i]);
            }
            
            dtp_fechaSalida.MinDate = DateTime.Now;
        }

        private void dtm_horaSalida_ValueChanged(object sender, EventArgs e)
        {
            DateTime ahora = new();     
            

            if (String.Compare(dtp_fechaSalida.Value.Day.ToString(), DateTime.Today.Day.ToString()) == 0)
            {
                ahora = DateTime.Now;
                ahora = ahora.AddHours(1);
                cmb_horaPartida.Items.Clear();
                int x = int.Parse(DateTime.Now.Hour.ToString());                
                for (int i = x +1; i < 24; i++)
                {                                        
                    cmb_horaPartida.Items.Add(ahora.ToString("hh:00 tt"));                   
                    ahora = ahora.AddHours(1);
                }                
            }else if (String.Compare(dtp_fechaSalida.Value.Day.ToString(), DateTime.Today.Day.ToString()) > 0)
            {
                cmb_horaPartida.Items.Clear();
                for (int i = 0; i < 24; i++)
                {                    
                    cmb_horaPartida.Items.Add(ahora.ToString("hh:mm tt"));
                    ahora = ahora.AddHours(1);
                }
            }            

            if (String.Compare(dtp_fechaSalida.Value.Day.ToString(), DateTime.Today.Day.ToString()) == 0)
            {
                comboBox_aviones.Items.Clear();
                for (int i = 0; i < Aerolinea.misAviones.Count; i++)
                {
                    if (Aerolinea.misAviones[i].EstadoAvion == true)
                    {
                        comboBox_aviones.Items.Add(Aerolinea.misAviones[i].Matricula);
                    }
                }
            }
            else if (dtp_fechaSalida.Value.Day > DateTime.Today.Day)
            {
                comboBox_aviones.Items.Clear();
                Aerolinea.ReiniciarVuelo();
                for (int i = 0; i < Aerolinea.misAviones.Count; i++)
                {
                    if (Aerolinea.misAviones[i].EstadoAvion == true)
                    {
                        comboBox_aviones.Items.Add(Aerolinea.misAviones[i].Matricula);
                    }
                }
            }


        }
    }
}
