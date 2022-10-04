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
    public partial class frmCrearCliente : Form
    {
        private bool acceso;
        public frmCrearCliente()
        {
            InitializeComponent();
        }

        public frmCrearCliente(bool dondeVengo) : this()
        {
            acceso = dondeVengo;
        }
        private void frmCrearCliente_Load(object sender, EventArgs e)
        {
            cobEstadoCivil.Items.Add("Soltero");
            cobEstadoCivil.Items.Add("Casado");
            cobEstadoCivil.Items.Add("Divorciado");            
            lblUsuario.Text = Aerolinea.vendedorActivo.UsuarioLogin;
            if(!acceso)
            {
                btnCrearCliente.Text = "PROCEDER VENTA";
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtNombreCliente.Text) && !String.IsNullOrEmpty(txtDniCliente.Text) &&
                !String.IsNullOrEmpty(txtEdadCliente.Text) && !String.IsNullOrEmpty(txtCiudad.Text) &&
                !String.IsNullOrEmpty(txtDireccion.Text) && !String.IsNullOrEmpty(txtLocalidad.Text) &&
                !String.IsNullOrEmpty(txtNacionalidad.Text))
            {
                try
                {
                    ValidacionGeneralCliente(txtNombreCliente.Text, txtDniCliente.Text, txtEdadCliente.Text, txtDireccion.Text,
                                            txtLocalidad.Text, txtCiudad.Text, txtNacionalidad.Text);

                    Cliente nuevoAux = new Cliente(txtNombreCliente.Text, int.Parse(txtDniCliente.Text),
                                                    int.Parse(txtEdadCliente.Text), txtDireccion.Text, txtCiudad.Text,
                                                    txtLocalidad.Text, txtNacionalidad.Text, cobEstadoCivil.Text, 0);
                    
                    foreach(Cliente nuevo in Aerolinea.clienteHistorial)
                    {
                        if (nuevoAux.Equals(nuevo))
                        {
                            throw new Exception("Ese DNI ya pertenece a un cliente");                            
                        }                     
                    }
                    Aerolinea.clienteHistorial.Add(nuevoAux);

                    if (acceso)
                    {
                        DialogResult = DialogResult.OK;
                    }else
                    {
                        frmVentaPasaje frmVentaPasaje = new(Aerolinea.clienteHistorial.Count - 1);
                        this.Close();
                        frmVentaPasaje.Show();
                    }
                    
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            }
            else
            {
                lblError.Text = "Se deben completar todos los campos.";
            }         
        }

        private void ValidacionGeneralCliente(string nombre, string documento, string edad, string direccion, string localidad, string ciudad, string nacionalidad)
        {
            if (Validador.ValidadarIngresaString(nombre))
            {
                if (Validador.ValidarIngresoNumero(documento))
                {
                    if (Validador.ValidarIngresoNumero(edad))
                    {
                        if (Validador.ValidarIngresoCodigo(direccion))
                        {
                            if (Validador.ValidadarIngresaString(localidad))
                            {
                                if (Validador.ValidadarIngresaString(ciudad))
                                {
                                    if (Validador.ValidadarIngresaString(nacionalidad))
                                    {

                                    }
                                    else
                                    {
                                        throw new Exception("Error en el campo: Nacionalidad");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Error en el campo: Ciudad");
                                }
                            }
                            else
                            {
                                throw new Exception("Error en el campo: Localidad");
                            }
                        }
                        else
                        {
                            throw new Exception("Error en el campo: Direccion");
                        }
                    }
                    else
                    {
                        throw new Exception("Error en el campo: Edad");
                    }
                }
                else
                {
                    throw new Exception("Error en el campo: Documento");
                }
            }
            else
            {
                throw new Exception("Error en el campo: Nombre");
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
