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
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            bool entroOk = false;
         
            foreach (KeyValuePair<int, Vendedor> i in Aerolinea.Usuarios)
            {
                if (txt_userName.Text == i.Value.UsuarioLogin
                    && txt_password.Text == i.Value.UsuarioPassword)
                {
                    entroOk = true;
                    Aerolinea.vendedorActivo = new Vendedor(i.Value.UsuarioLogin,
                                                            i.Value.UsuarioPassword,
                                                            i.Value.NombrePersona,
                                                            i.Value.DocumentoPersona,
                                                            i.Value.EdadPersona,
                                                            i.Value.NivelAcceso);
                    UserMenu userMenu = new();
                    this.Hide();
                    userMenu.ShowDialog();
                    this.Show();
                    break;
                }
            }
            if (entroOk == false)
            {
                lbl_datosIncorrectos.Visible = true;
            }          
        }

        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= contadorAutocompletar; i++)
            {                
                txt_userName.Text = Aerolinea.Usuarios[i].UsuarioLogin;
                txt_password.Text = Aerolinea.Usuarios[i].UsuarioPassword;
            }
            contadorAutocompletar++;
            if (contadorAutocompletar > Aerolinea.Usuarios.Count)
            {
                contadorAutocompletar = 1;                
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            HardCodeo.InicializarDatos();
            contadorAutocompletar = 1;
            lbl_datosIncorrectos.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
