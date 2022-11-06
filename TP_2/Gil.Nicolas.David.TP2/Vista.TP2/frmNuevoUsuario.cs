using Library.TP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.TP2
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            cmbAcceso.Items.Add("Admin");
            cmbAcceso.Items.Add("Jugador");
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            bool seCreoOk = false;
            bool noExiste = true;
            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtEdad.Text) && !String.IsNullOrEmpty(txtDocumento.Text) && !String.IsNullOrEmpty(txtApodo.Text) &&
                !String.IsNullOrEmpty(txtContraseña.Text) && !String.IsNullOrEmpty(cmbAcceso.Text))
            {
                if (Validador.ValidadarIngresaString(txtNombre.Text) && Validador.ValidarIngresoNumero(txtEdad.Text) && Validador.ValidarIngresoNumero(txtDocumento.Text) 
                    && Validador.ValidarIngresoCodigo(txtApodo.Text) && Validador.ValidarIngresoCodigo(txtContraseña.Text))
                {
                    foreach(Usuario item in BaseDatos.ObtenerUsuarios())
                    {
                        if(int.Parse(txtDocumento.Text) == item.DocumentoPersona)
                        {
                            lblError.Text = "Ya existe un usuario con ese dni";
                            lblError.Visible = true;
                            noExiste = false;
                        }
                        if(txtApodo.Text == item.NombreUsuario)
                        {
                            lblError.Text = "Ese Nick name ya esta en uso";
                            lblError.Visible = true;
                            noExiste = false;
                        }
                    }
                    if (noExiste)
                    {
                        Usuario newPlayer = new(txtNombre.Text, int.Parse(txtEdad.Text), int.Parse(txtDocumento.Text), txtApodo.Text, txtContraseña.Text, cmbAcceso.Text, 0, 0, 0);

                        seCreoOk = BaseDatos.AgregarUsuario(newPlayer);
                    }
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Error en la creación, revisar los campos";
            }
            if (seCreoOk == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
