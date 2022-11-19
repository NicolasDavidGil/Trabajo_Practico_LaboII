using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Interfaces;
using Entidades.Presentadores;
using Entidades.Repositorios;

namespace Vista.Vistas
{
    public partial class frmLogin : Form, ILoginView
    {
        frmCargando load;
        PresentadorLogin loginAdmin;        

        public frmLogin()
        {
            InitializeComponent();
            loginAdmin = new PresentadorLogin(this);    
            lblError.Visible = false;
            Titulo = "BIENVENIDO A UTN UNO MASTERS";
        }

        public string UserName { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string Error { get => lblError.Text; set => lblError.Text = value; }
        public string Titulo { get => lblTitulo.Text; set => lblTitulo.Text = value; }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            bool pepe;
            pepe = loginAdmin.VerificarUsuario(UserName, Password);
            if (pepe)
            {
                this.Hide();
                MostrarCargando();
                Task gitCarga = new Task(EsperaLoad);
                gitCarga.Start();
                await gitCarga;
                OcultarCargando();
                
                frmPrincipal principal = new frmPrincipal();                
                principal.ShowDialog();
                this.Show();
            }
            else
            {
                lblError.Visible = true;
                Error = "DATOS INVALIDOS";
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            loginAdmin.LlenarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EsperaLoad()
        {
            Thread.Sleep(6000);
        }
        private void MostrarCargando()
        {
            load = new frmCargando();            
            load.Show();            
        }
        private void OcultarCargando()
        {
            if (load != null)
                load.Close();
        }
    }
}
