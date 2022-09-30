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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
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
                    ValidacionGeneralCliente(txtNombreCliente.Text, txtDniCliente.Text, txtEdadCliente.Text, txtDireccion.Text, txtLocalidad.Text, txtCiudad.Text, txtNacionalidad.Text);

                    Cliente nuevoAux = new Cliente(txtNombreCliente.Text, int.Parse(txtDniCliente.Text),
                      int.Parse(txtEdadCliente.Text), txtDireccion.Text, txtCiudad.Text,
                      txtLocalidad.Text, txtNacionalidad.Text, cboEstadoCivil.Text, 0);

                    Aerolinea.clienteHistorial.Add(nuevoAux);

                    DialogResult = DialogResult.OK;
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

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            cboEstadoCivil.Items.Add("Soltero");
            cboEstadoCivil.Items.Add("Casado");
            cboEstadoCivil.Items.Add("Divorciado");
            lblAccesoUser.Text = Aerolinea.vendedorActivo.NivelAcceso;
            lblUsuario.Text = Aerolinea.vendedorActivo.UsuarioLogin;
            if(Aerolinea.flagVentaNuevoCliente == true)
            {
                btnVentaNuevoCLiente.Visible = true;
                btnCrearCliente.Visible = false;
            }else
            {
                btnVentaNuevoCLiente.Visible = false;
                btnCrearCliente.Visible = true;
            }
            Aerolinea.flagVentaNuevoCliente = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Aerolinea.index = -1;
            Aerolinea.flagVentaNuevoCliente = false;
            DialogResult = DialogResult.Cancel;
        }        

        public void ValidacionGeneralCliente(string nombre, string documento, string edad, string direccion, string localidad, string ciudad, string nacionalidad)
        {
            if(Validador.ValidadarIngresaString(nombre))
            {
                if(Validador.ValidarIngresoNumero(documento))
                {
                    if(Validador.ValidarIngresoNumero(edad))
                    {
                        if(Validador.ValidarIngresoCodigo(direccion))
                        {
                            if(Validador.ValidadarIngresaString(localidad))
                            {
                                if(Validador.ValidadarIngresaString(ciudad))
                                {
                                    if(Validador.ValidadarIngresaString(nacionalidad))
                                    {

                                    }else
                                    {
                                        throw new Exception("Error en el campo: Nacionalidad");
                                    }
                                }else
                                {
                                    throw new Exception("Error en el campo: Ciudad");
                                }
                            }
                            else
                            {
                                throw new Exception("Error en el campo: Localidad");
                            }
                        }else
                        {
                            throw new Exception("Error en el campo: Direccion");
                        }
                    }else
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

        private void btnVentaNuevoCLiente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombreCliente.Text) && !String.IsNullOrEmpty(txtDniCliente.Text) &&
                !String.IsNullOrEmpty(txtEdadCliente.Text) && !String.IsNullOrEmpty(txtCiudad.Text) &&
                !String.IsNullOrEmpty(txtDireccion.Text) && !String.IsNullOrEmpty(txtLocalidad.Text) &&
                !String.IsNullOrEmpty(txtNacionalidad.Text))
            {
                try
                {
                    ValidacionGeneralCliente(txtNombreCliente.Text, txtDniCliente.Text, txtEdadCliente.Text, txtDireccion.Text, txtLocalidad.Text, txtCiudad.Text, txtNacionalidad.Text);

                    Cliente nuevoAux = new Cliente(txtNombreCliente.Text, int.Parse(txtDniCliente.Text),
                                                    int.Parse(txtEdadCliente.Text), txtDireccion.Text, txtCiudad.Text,
                                                    txtLocalidad.Text, txtNacionalidad.Text, cboEstadoCivil.Text, 0);
                    Aerolinea.clienteHistorial.Add(nuevoAux);
                    
                    for(int i = 0; i < Aerolinea.clienteHistorial.Count; i++)
                    {
                        if(Aerolinea.clienteHistorial[i].DocumentoPersona.ToString() == txtDniCliente.Text)
                        {
                            Aerolinea.indexCliente = i;
                            break;
                        }
                    }
                    VentaBoletos nuevaVenta = new();
                    this.Close();
                    nuevaVenta.Show();
                    Aerolinea.flagVentaNuevoCliente = false;
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
    }
}
