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
            Aerolinea.nuestraAerolinea.RecaudacionTotal = Aerolinea.CalcularRecaudacionTotal(Aerolinea.vuelosActivos);
        }

        private void btn_cerrarPestaña_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            txt_totalPasajeros.Text = Aerolinea.nuestraAerolinea.Pasajeros.ToString();
            txt_totalVuelos.Text = Aerolinea.nuestraAerolinea.CantidadVuelos.ToString();
            txt_totalRecaudacion.Text = Aerolinea.nuestraAerolinea.RecaudacionTotal.ToString();
        }
    }
}
