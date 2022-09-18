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
    public partial class MainMenu : Form
    {
        private int contadorAutocompletar;
        public MainMenu()
        {
            InitializeComponent();
            HardCodeo.InicializarVendedores(Aerolinea.listadoVendedores);
            contadorAutocompletar = 1;
            lbl_datosIncorrectos.Visible = false;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            bool entroOk = false;

            for(int i = 0; i < Aerolinea.listadoVendedores.Count; i++)
            {
                if(txt_userName.Text == Aerolinea.listadoVendedores[i].UsuarioLogin
                    && txt_password.Text == Aerolinea.listadoVendedores[i].UsuarioPassword)
                {
                    entroOk = true;
                    Aerolinea.vendedorActivo = new Vendedor(Aerolinea.listadoVendedores[i].UsuarioLogin,
                                                            Aerolinea.listadoVendedores[i].UsuarioPassword,
                                                            Aerolinea.listadoVendedores[i].NombrePersona,
                                                            Aerolinea.listadoVendedores[i].DocumentoPersona,
                                                            Aerolinea.listadoVendedores[i].NivelAcceso);
                    UserMenu userMenu = new UserMenu();
                    userMenu.Show();
                    this.Hide();
                    break;
                }
            }
            if(entroOk == false)
            {
                lbl_datosIncorrectos.Visible = true;
            }
        }

        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contadorAutocompletar; i++)
            {
                txt_userName.Text = Aerolinea.listadoVendedores[i].UsuarioLogin;
                txt_password.Text = Aerolinea.listadoVendedores[i].UsuarioPassword;
            }
            contadorAutocompletar++;
            if (contadorAutocompletar > Aerolinea.listadoVendedores.Count)
            {
                contadorAutocompletar = 1;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
