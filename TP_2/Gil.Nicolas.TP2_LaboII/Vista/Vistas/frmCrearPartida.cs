using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using Entidades.Repositorios;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Excepciones;

namespace Vista.Vistas
{
    public partial class frmCrearPartida : Form, ICrearPartida
    {
        public static List<Task>? misTareas = new List<Task>();
        public static frmCrearPartida? instance;
        PresentadorCreacion adminCreacion;
        public string Errores { get => lblErrores.Text; set => lblErrores.Text = value; }
        public string TipoPartida { get => cmbTipoPartida.Text; set => cmbTipoPartida.Text = value; }
        public string BoxJugadorUno { get => cmbJugadorUno.Text; set => cmbJugadorUno.Text = value; }
        public string BoxJugadorDos { get => cmbJugadorDos.Text; set => cmbJugadorDos.Text = value; }

        public frmCrearPartida()
        {
            InitializeComponent();
            adminCreacion = new PresentadorCreacion(this);            
        }

        private void frmCrearPartida_Load(object sender, EventArgs e)
        {
            lblErrores.Visible = false;
            adminCreacion.LLenarDatos();
        }

        public void CargarUsuarios(List<Usuario> nono)
        {
            cmbTipoPartida.Items.Add("Partida normal");
            cmbTipoPartida.Items.Add("Partida corta");

            nono.ForEach((x) =>
            {
                if (x.EstadoCuenta == 1)
                {
                    cmbJugadorDos.Items.Add(x.NombreUsuario);
                    cmbJugadorUno.Items.Add(x.NombreUsuario);
                }
            });
        }

        public static frmCrearPartida GetInstance(Form padreContenedor)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmCrearPartida();
                instance.MdiParent = padreContenedor;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
     
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Partida pichicha = new PresentadorCreacion(this).IniciarPartida();
            misTareas.Add(new Task(() =>
            {
                Partida puchicha = pichicha;
                frmVerPartida nuevo = new frmVerPartida(puchicha);
                puchicha.EmpezarPartida();
                nuevo.ShowDialog();
                GameManager.misActivas?.Add(puchicha);
            }));
            misTareas.Last().Start();
            this.Close();
        }
    
        public bool VerificarDatos()
        {
            bool retorno = false;
            if(!String.IsNullOrWhiteSpace(BoxJugadorUno) && !String.IsNullOrWhiteSpace(BoxJugadorDos) &&
                !String.IsNullOrWhiteSpace(TipoPartida))
            {
                retorno = true;
            }
            return retorno;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
