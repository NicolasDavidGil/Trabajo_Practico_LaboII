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
    public partial class EditarVuelo : Form
    {
        public EditarVuelo()
        {
            InitializeComponent();
        }

        private void EditarVuelo_Load(object sender, EventArgs e)
        {
            InicializarEdicion();
        }

        private void InicializarEdicion()
        {
            lblCodigoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Codigo;
            lblOrigenVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Origen;
            lblDestinoVuelo.Text = Aerolinea.vuelosActivos[Aerolinea.index].Destinos;
            lblDuracion.Text = Aerolinea.vuelosActivos[Aerolinea.index].Duracion.ToString();
            lblNombreUsuario.Text = Aerolinea.vendedorActivo.UsuarioLogin.ToString();
        }

        private void btnFinalizarVuelo_Click(object sender, EventArgs e)
        {
            Aerolinea.vuelosActivos[Aerolinea.index].Estado = "Finalizado";
        }

        private void btnCerrarLista_Click(object sender, EventArgs e)
        {
            Aerolinea.vuelosActivos[Aerolinea.index].Estado = "Lleno";
        }

        private void btnCambiarDuracion_Click(object sender, EventArgs e)
        {
            string auxS;
            string auxDateTime;

            Aerolinea.vuelosActivos[Aerolinea.index].Duracion = Aerolinea.CalcularDuracionVuelo(Aerolinea.vuelosActivos[Aerolinea.index].Destinos);
            auxDateTime = DateTime.Parse(Aerolinea.vuelosActivos[Aerolinea.index].HoraPartida).ToString("hh");
            auxS = Vuelo.CalcularHorarioLLegada(auxDateTime,
                                                Aerolinea.vuelosActivos[Aerolinea.index].FechaPartida,
                                                Aerolinea.vuelosActivos[Aerolinea.index].Duracion);
            Aerolinea.vuelosActivos[Aerolinea.index].HoraArribo = auxS;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
