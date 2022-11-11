using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Vistas
{
    public partial class frmPrincipal : Form
    {
        public static List<Task> misTareas = new List<Task>();
        public frmPrincipal()
        {
            InitializeComponent();                     
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Hola  " + PresentadorLogin.logeado?.Nombre;
            CargarDefecto();
        }

        private void CargarDefecto()
        {
            frmMain user = frmMain.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void btnCrearPartida_Click(object sender, EventArgs e)
        {
            frmCrearPartida user = frmCrearPartida.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }

        private void btnJugarPartida_Click(object sender, EventArgs e)
        {
     
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios user = frmUsuarios.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas user = new frmEstadisticas();
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }
     
        private void btnReglas_Click(object sender, EventArgs e)
        {
            frmReglamento reglas = frmReglamento.GetInstance(this);
            reglas.MdiParent = this;
            this.MdiChildren.Append(reglas);
            reglas.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
