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
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente()
        {
            InitializeComponent();
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            dtgClientes.DataSource = null;
            dtgClientes.DataSource = Aerolinea.clienteHistorial; 
            if(Aerolinea.index != -1)
            {                
                btnVenderPasaje.Visible = true;
            }else
            {
                btnVenderPasaje.Visible = false;
            }
        }

        private void dtgClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            Aerolinea.indexCliente = e.RowIndex;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Aerolinea.indexCliente = -1;
            DialogResult = DialogResult.Cancel;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaAux = new();
            string nombreAux, txtAux;
            for (int i = 0; i < Aerolinea.clienteHistorial.Count; i++)
            {
                nombreAux = Aerolinea.clienteHistorial[i].NombrePersona.ToLower();
                txtAux = txtBusqueda.Text.ToLower();
                
                if (nombreAux.Contains(txtAux) ||
                    Aerolinea.clienteHistorial[i].DocumentoPersona.ToString().Contains(txtBusqueda.Text))
                {
                    listaAux.Add(Aerolinea.clienteHistorial[i]);
                }
            }
            dtgClientes.DataSource = null;
            dtgClientes.DataSource = listaAux;
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            VentaBoletos nuevaBoletos = new();
            this.Hide();           
            if(nuevaBoletos.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }    
    }
}
