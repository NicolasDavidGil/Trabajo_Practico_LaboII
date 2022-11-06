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
    public partial class frmInicio : Form
    {
        private int contadorAutocompletar;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            HardCodeo.InicializarDatos();
            lblDatosIncorrectos.Visible = false;
            contadorAutocompletar = 1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool entroOk = false;

            foreach (KeyValuePair<int, Usuario> i in Aerolinea.Usuarios)
            {
                if (txtUserName.Text == i.Value.UsuarioLogin
                    && txtPassword.Text == i.Value.UsuarioPassword)
                {
                    entroOk = true;
                    Aerolinea.vendedorActivo = new Usuario(i.Value.UsuarioLogin,
                                                            i.Value.UsuarioPassword,
                                                            i.Value.NombrePersona,
                                                            i.Value.DocumentoPersona,
                                                            i.Value.EdadPersona,
                                                            i.Value.NivelAcceso,
                                                            i.Value.Sueldo);
                    frmMenuPrincipal userMenu = new();
                    this.Hide();
                    userMenu.ShowDialog();
                    this.Show();
                    break;
                }
                if (entroOk == false)
                {
                    lblDatosIncorrectos.Visible = true;
                }
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= contadorAutocompletar; i++)
            {
                txtUserName.Text = Aerolinea.Usuarios[i].UsuarioLogin;
                txtPassword.Text = Aerolinea.Usuarios[i].UsuarioPassword;
            }
            contadorAutocompletar++;
            if (contadorAutocompletar > Aerolinea.Usuarios.Count)
            {
                contadorAutocompletar = 1;
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmReestablecerContraseña contra = new();
            this.Hide();
            contra.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrFrmInicio_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
