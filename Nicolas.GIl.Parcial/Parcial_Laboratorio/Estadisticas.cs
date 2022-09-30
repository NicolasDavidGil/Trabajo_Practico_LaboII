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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void btn_cerrarPestaña_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            Aerolinea.nuestraAerolinea.CantidadVuelos = Aerolinea.vuelosActivos.Count + Aerolinea.vuelosFinalizados.Count;
            AveriguarDestinoMasElejido();
            Aerolinea.nuestraAerolinea.RecaudacionTotal += Aerolinea.CalcularRecaudacionTotal();  
            txt_totalRecaudacion.Text = Aerolinea.nuestraAerolinea.RecaudacionTotal.ToString();
            txt_totalPasajeros.Text = Aerolinea.nuestraAerolinea.Pasajeros.ToString();
            txt_totalVuelos.Text = Aerolinea.nuestraAerolinea.CantidadVuelos.ToString();
            txtDestinoMasELejido.Text = Aerolinea.nuestraAerolinea.DestinoMasElejido;
            txtContadorDestinoElej.Text = Aerolinea.nuestraAerolinea.ContadosDestino.ToString();
        }

        public void AveriguarDestinoMasElejido()
        {
            string destinoAuxActivos;
            string seteoAux = "";
            string destinoAuxFinalizados;
            int contUnoActivos = 0;
            int contUnoFinalizados = 0;
            int contDosAvtivos = 0;
            int contDosFinalizados = 0;

            for(int i = 0; i < Aerolinea.misDestinos.Count; i++)
            {
                destinoAuxActivos = Aerolinea.misDestinos[i];
                for (int j = 0; j < Aerolinea.vuelosActivos.Count; j++)
                {                    
                    if (Aerolinea.vuelosActivos[j].Destinos == destinoAuxActivos)
                    {
                        contUnoActivos++;
                    }
                }
                if(contUnoActivos > contDosAvtivos)
                {
                    Aerolinea.nuestraAerolinea.DestinoMasElejido = destinoAuxActivos;
                    Aerolinea.nuestraAerolinea.ContadosDestino = contUnoActivos;
                    contDosAvtivos = contUnoActivos;
                }                
                contUnoActivos = 0;
            }
            
            for(int i = 0; i < Aerolinea.misDestinos.Count; i++)
            {
                destinoAuxFinalizados = Aerolinea.misDestinos[i];
                for (int j = 0; j < Aerolinea.vuelosFinalizados.Count; j++)
                {                    
                    if (Aerolinea.vuelosFinalizados[j].Destinos == destinoAuxFinalizados)
                    {
                        contUnoFinalizados++;
                    }
                }
                if(contUnoFinalizados > contDosFinalizados)
                {
                    seteoAux = destinoAuxFinalizados;
                    contDosFinalizados = contUnoFinalizados;
                }                
                contUnoFinalizados = 0;
            }            

            if(!String.Equals(Aerolinea.nuestraAerolinea.DestinoMasElejido, seteoAux))     
            {
                if(contDosFinalizados > Aerolinea.nuestraAerolinea.ContadosDestino)
                {
                    Aerolinea.nuestraAerolinea.ContadosDestino = contDosFinalizados;
                    Aerolinea.nuestraAerolinea.DestinoMasElejido = seteoAux;
                    for(int k = 0; k < Aerolinea.vuelosActivos.Count; k++)
                    {
                        if(Aerolinea.nuestraAerolinea.DestinoMasElejido == Aerolinea.vuelosActivos[k].Destinos)
                        {
                            Aerolinea.nuestraAerolinea.ContadosDestino++;
                        }
                    }
                }
            }
            else
            {
                Aerolinea.nuestraAerolinea.ContadosDestino += contDosFinalizados;
            }
        }
    }
}
