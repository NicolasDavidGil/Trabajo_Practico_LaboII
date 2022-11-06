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
    public partial class frmNuevoVuelo : Form
    {
        public frmNuevoVuelo()
        {
            InitializeComponent();
        }

        private void frmNuevoVuelo_Load(object sender, EventArgs e)
        {
            lblCamposVacios.Visible = false;
            for (int i = 0; i < Aerolinea.misDestinos.Count; i++)
            {
                cobOrigen.Items.Add(Aerolinea.misDestinos[i]);
            }
            dtpFechaSalida.MinDate = DateTime.Now;
        }

        private void cobOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cobDestino.Items.Clear();
            cobDestino.Text = "";
            for (int i = 0; i < Aerolinea.misDestinos.Count; i += 1)
            {
                if (cobOrigen.Text == "Buenos Aires")
                {
                    if (Aerolinea.misDestinos[i] != "Buenos Aires")
                    {
                        cobDestino.Items.Add(Aerolinea.misDestinos[i]);
                    }
                }
                else
                {
                    if (Aerolinea.misDestinos[i] != "Recife" && Aerolinea.misDestinos[i] != "Miami" &&
                        Aerolinea.misDestinos[i] != "Acapulco" && Aerolinea.misDestinos[i] != "Roma" &&
                        Aerolinea.misDestinos[i] != cobOrigen.Text)
                    {
                        cobDestino.Items.Add(Aerolinea.misDestinos[i]);
                    }
                }
            }
        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            Aeronave designada = new ();
            int duracionVuelo;
            string fechaSalida;
            string horaLlegada;

            for (int i = 0; i < Aerolinea.misAviones.Count; i++)
            {
                if (cobAviones.Text == Aerolinea.misAviones[i].Matricula)
                {
                    designada = Aerolinea.misAviones[i];
                    Aerolinea.misAviones[i].EstadoAvion = false;
                }
            }

            if (cobOrigen.Text != String.Empty && cobDestino.Text != String.Empty && cobHoraSalida.Text != String.Empty && cobAviones.Text != String.Empty)
            {
                duracionVuelo = Vuelo.CalcularDuracionVuelo(cobDestino.Text);
                fechaSalida = dtpFechaSalida.Value.Date.ToShortDateString();
                horaLlegada = Vuelo.CalcularHorarioLLegada(DateTime.Parse(cobHoraSalida.Text).ToString("hh"), fechaSalida, duracionVuelo);

                Vuelo nuevoVuelo = new Vuelo(cobOrigen.Text, 
                                        cobDestino.Text,
                                        cobHoraSalida.Text,
                                        duracionVuelo,
                                        designada.AsientosTurista,
                                        "Disponible",
                                        designada.AsientosPrimera,
                                        designada,
                                        fechaSalida,
                                        horaLlegada, 0);

                Aerolinea.vuelosActivos.Add(nuevoVuelo);
                designada.TiempoVuelo += duracionVuelo;
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblCamposVacios.Visible = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            DateTime ahora = new(); 

            if (String.Compare(dtpFechaSalida.Value.Day.ToString(), DateTime.Today.Day.ToString()) == 0)
            {
                ahora = DateTime.Now;
                ahora = ahora.AddHours(1);
                cobHoraSalida.Items.Clear();
                int x = int.Parse(DateTime.Now.Hour.ToString());
                for (int i = x + 1; i < 24; i++)
                {
                    cobHoraSalida.Items.Add(ahora.ToString("hh:00 tt"));
                    ahora = ahora.AddHours(1);
                }
            }
            else if (String.Compare(dtpFechaSalida.Value.Day.ToString(), DateTime.Today.Day.ToString()) > 0)
            {
                cobHoraSalida.Items.Clear();
                for (int i = 0; i < 24; i++)
                {
                    cobHoraSalida.Items.Add(ahora.ToString("hh:mm tt"));
                    ahora = ahora.AddHours(1);
                }
            }

            if (String.Compare(dtpFechaSalida.Value.Day.ToString(), DateTime.Today.Day.ToString()) == 0)
            {
                cobAviones.Items.Clear();
                for (int i = 0; i < Aerolinea.misAviones.Count; i++)
                {
                    if (Aerolinea.misAviones[i].EstadoAvion == true)
                    {
                        cobAviones.Items.Add(Aerolinea.misAviones[i].Matricula);
                    }
                }
            }
            else if (dtpFechaSalida.Value.Day > DateTime.Today.Day)
            {
                cobAviones.Items.Clear();
                Vuelo.ReiniciarVuelo();
                for (int i = 0; i < Aerolinea.misAviones.Count; i++)
                {
                    if (Aerolinea.misAviones[i].EstadoAvion == true)
                    {
                        cobAviones.Items.Add(Aerolinea.misAviones[i].Matricula);
                    }
                }
            }
        }
    }
}
