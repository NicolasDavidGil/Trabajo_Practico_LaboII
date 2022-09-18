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
            this.Close();
        }

        private void DetallesVuelo_Load(object sender, EventArgs e)
        {
            lbl_pasajerosCargados.Visible = false;
            InicializarFormDetalles();
        }

        private void InicializarFormDetalles()
        {
            lbl_codigoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Codigo;
            lbl_origenVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Origen;
            lbl_destinoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Destinos;
            lbl_fechaPartida.Text = Aerolinea.vuelosActivos[Aerolinea.index].FechaPartida;
            lbl_horaPartida.Text = Aerolinea.vuelosActivos[Aerolinea.index].HoraPartida;
            lbl_horaLlegada.Text = Aerolinea.vuelosActivos[Aerolinea.index].HoraArribo;            

            if(Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero is not null)
            {
                dgv_listaPasajeros.DataSource = null;
                dgv_listaPasajeros.DataSource = Aerolinea.vuelosActivos[Aerolinea.index].ListaPasajero; ;
            }else
            {
                lbl_pasajerosCargados.Visible = true;
            }            
        }
    }
}
