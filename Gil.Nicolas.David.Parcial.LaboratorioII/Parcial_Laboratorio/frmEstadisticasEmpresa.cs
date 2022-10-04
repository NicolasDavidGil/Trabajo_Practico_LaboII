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
    public partial class frmEstadisticasEmpresa : Form
    {
        private int cantidadPasajerosTurista = 5430; //Inicializados con la cantidad de pasajeros hardcodeados en vuelos finalizados.
        private int cantidadPasajerosPrimera = 1108; //Inicializados con la cantidad de pasajeros hardcodeados en vuelos finalizados.
        private int cantidadVuelos;
        private float gananciasNacionales;
        private float gananciasInternacionales;
        Dictionary<string, int> destinosMasVisitados = new ();

        public frmEstadisticasEmpresa()
        {
            InitializeComponent();          
        }

        private void frmEstadisticasEmpresa_Load(object sender, EventArgs e)
        {
            AveriguarDestinosMasElejidos();
            ContarPasajeros();
            CalcularGanancias();            
            cantidadVuelos = Aerolinea.vuelosActivos.Count + Aerolinea.vuelosFinalizados.Count;
            cobEstadisticas.Items.Add("Destinos mas solicitados");
            cobEstadisticas.Items.Add("Pasajeros mas frecuentes");
            IniciarLabels();
            pnlCliente.Visible = false;
        }              

        private void IniciarLabels()
        {
            lblVuelosTotales.Text = cantidadVuelos.ToString();
            lblPasajerosTotales.Text = (cantidadPasajerosPrimera + cantidadPasajerosTurista).ToString();
            lblPasajeroTurista.Text = cantidadPasajerosTurista.ToString();
            lblPasajerosPrimera.Text = cantidadPasajerosPrimera.ToString();
            lblRecaudacionInternacional.Text = gananciasInternacionales.ToString();
            lblRecaudacionNacional.Text = gananciasNacionales.ToString();
            lblRecaudacionTotal.Text = (gananciasNacionales + gananciasInternacionales).ToString();
        }

        private void CalcularGanancias()
        {
            for(int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                if (Aerolinea.vuelosActivos[i].Destinos == "Roma" || Aerolinea.vuelosActivos[i].Destinos == "Acapulco" || Aerolinea.vuelosActivos[i].Destinos == "Recife" ||
                    Aerolinea.vuelosActivos[i].Destinos == "Miami")
                {
                    gananciasInternacionales += Aerolinea.vuelosActivos[i].Ganancia;
                }else
                {
                    gananciasNacionales += Aerolinea.vuelosActivos[i].Ganancia;
                }
            }
            for (int j = 0; j < Aerolinea.vuelosFinalizados.Count; j++)
            {
                if (Aerolinea.vuelosFinalizados[j].Destinos == "Roma" || Aerolinea.vuelosFinalizados[j].Destinos == "Acapulco" || Aerolinea.vuelosFinalizados[j].Destinos == "Recife" ||
                    Aerolinea.vuelosFinalizados[j].Destinos == "Miami")
                {
                    gananciasInternacionales += Aerolinea.vuelosFinalizados[j].Ganancia;
                }
                else
                {
                    gananciasNacionales += Aerolinea.vuelosFinalizados[j].Ganancia;
                }
            }
        }

        private void ContarPasajeros()
        {
            for(int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                for(int j = 0; j < Aerolinea.vuelosActivos[i].ListaPasajero.Count; j++)
                {
                    if (Aerolinea.vuelosActivos[i].ListaPasajero[j].ClaseVuelo == "Turista")
                    {
                        cantidadPasajerosTurista++;
                    }
                    else
                    {
                        cantidadPasajerosPrimera++;
                    }
                }

            }          
        }

        private void cobEstadisticas_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            if(cobEstadisticas.Text == "Destinos mas solicitados")
            {
                Aerolinea.misDestinos.Sort();
                dgvEstadisticas.DataSource = null;                
                dgvEstadisticas.DataSource = destinosMasVisitados.OrderByDescending(pair => pair.Value).ToList();
            }
            if(cobEstadisticas.Text == "Pasajeros mas frecuentes")
            {                           
                dgvEstadisticas.DataSource = null;
                dgvEstadisticas.DataSource = CalcularClientesFrecuentes();
                dgvEstadisticas.Sort(dgvEstadisticas.Columns[1], ListSortDirection.Descending);
            }
        }

        public void AveriguarDestinosMasElejidos()
        {
            int value = 0;
            foreach (string aux in Aerolinea.misDestinos)
            {
                foreach(Vuelo unVuelo in Aerolinea.vuelosActivos)
                {
                    if(aux == unVuelo.Destinos)
                    {
                        value++;    
                    }
                }
                destinosMasVisitados.Add(aux, value);
                value = 0;
            }
        }

        public DataTable CalcularClientesFrecuentes()
        {
            DataTable aux = new();
            
            aux.Columns.Add("Nombre Cliente", typeof(string));
            aux.Columns.Add("Cantidad de vuelos", typeof(int));
            aux.Columns.Add("DNI de cliente", typeof(int));

            foreach(Cliente unAux in Aerolinea.clienteHistorial)
            {
                aux.Rows.Add(unAux.NombrePersona, unAux.CantidadVuelos, unAux.GetHashCode());
            }
            return aux;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvEstadisticas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.RowIndex;
            if(x != -1)
            {
                if (cobEstadisticas.Text == "Pasajeros mas frecuentes")
                {
                    pnlCliente.Visible = true;
                    for(int i = 0; i < Aerolinea.clienteHistorial.Count; i++)
                    {
                        if (dgvEstadisticas.CurrentRow.Cells[2].Value.ToString() == Aerolinea.clienteHistorial[i].DocumentoPersona.ToString())
                        {
                            lblClienteElegido.Text = Aerolinea.clienteHistorial[i].ToString();
                            break;
                        }
                    }                    
                }
            }
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
        }
    }
}
