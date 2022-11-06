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
    public partial class frmBaseDatosClientes : Form
    {
        private bool acceso;
        private int indexCliente;
        public frmBaseDatosClientes()
        {
            InitializeComponent();
        }        
        public frmBaseDatosClientes(bool acceso) : this()
        {            
            this.acceso = acceso;   
        }

        private void frmBaseDatosClientes_Load(object sender, EventArgs e)
        {
            indexCliente = -1;
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Aerolinea.clienteHistorial;
            if(!acceso)
            {
                btnVender.Visible = true;
                btnVender.Enabled = false;
            }
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
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaAux;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {                  
            frmVentaPasaje venta = new(indexCliente);
            this.Hide();
            venta.ShowDialog();
            this.Close();          
        }

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexCliente = e.RowIndex;
            if(indexCliente != -1)
            {
                btnVender.Enabled = true;
            }
        }

     
    }
}
