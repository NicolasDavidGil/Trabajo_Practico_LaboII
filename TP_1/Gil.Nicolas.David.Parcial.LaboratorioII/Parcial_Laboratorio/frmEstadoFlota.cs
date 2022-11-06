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
    public partial class frmEstadoFlota : Form
    {
        private int contadorLibres;
        private int contadorOcupadas;
        private float promedioVolado;
        private Aeronave auxMasHs = new();

        public frmEstadoFlota()
        {
            InitializeComponent();            
        }

        private void frmEstadoFlota_Load(object sender, EventArgs e)
        {
            contadorLibres = 0;
            contadorOcupadas = 0;
            promedioVolado = 0;
            dgvAviones.DataSource = null;
            dgvAviones.DataSource = Aerolinea.misAviones;
            RealizarCalculos();
            IniciarLabels();
        }

        private void RealizarCalculos()
        {
            for(int i = 0; i < Aerolinea.misAviones.Count; i++)
            {                
                promedioVolado += Aerolinea.misAviones[i].TiempoVuelo;
                if(Aerolinea.misAviones[i].EstadoAvion == true)
                {
                    contadorLibres++;
                }else
                {
                    contadorOcupadas++;
                }
                if(auxMasHs.TiempoVuelo < Aerolinea.misAviones[i].TiempoVuelo)
                {
                    auxMasHs = Aerolinea.misAviones[i];
                }
            }
            promedioVolado /= Aerolinea.misAviones.Count;
        }

        private void IniciarLabels()
        {
            lblAvionesLibres.Text = contadorLibres.ToString();
            lblAvionesVolando.Text = contadorOcupadas.ToString();
            lblAvionMasTiempoVolado.Text = auxMasHs.Matricula;
            lblPromedioVuelo.Text = promedioVolado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvAviones_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblAvionElegido.Text = Aerolinea.misAviones[e.RowIndex].ToString();
        }
    }
}
