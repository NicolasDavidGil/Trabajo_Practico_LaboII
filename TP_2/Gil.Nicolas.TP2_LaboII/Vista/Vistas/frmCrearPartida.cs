using Entidades.Modelos;
using Entidades.Presentadores;
using Entidades.Repositorios;
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

namespace Vista.Vistas
{
    public partial class frmCrearPartida : Form
    {
        public static frmCrearPartida? instance;
        List<Usuario> jugadores;
        
        
        public frmCrearPartida()
        {
            InitializeComponent();            
            jugadores = new List<Usuario>();            
        }

        private void frmCrearPartida_Load(object sender, EventArgs e)
        {            
            jugadores.AddRange(new Serializadora<List<Usuario>>().LeerJson("JugadoresUno"));
            foreach(Usuario it in jugadores)
            {
                if(it.EstadoCuenta == 1)
                {
                    cmbJugadorUno.Items.Add(it.NombreUsuario);
                    cmbJugadorDos.Items.Add(it.NombreUsuario);
                }
            }
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
            Usuario auxUno = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0); 
            Usuario auxDos = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0); 
            if(cmbJugadorUno.Items != null && cmbJugadorDos.Items != null)
            {
                foreach(Usuario it in jugadores)
                {
                    if(cmbJugadorUno.Text == it.NombreUsuario)
                    {
                        auxUno = it;
                    }
                    if(cmbJugadorDos.Text == it.NombreUsuario)
                    {
                        auxDos = it;
                    }
                }
                Partida nueva = new Partida(DateTime.Now, auxUno, auxDos);


                frmProbandoPartida prueba = new frmProbandoPartida(nueva);
                this.Hide();
                prueba.ShowDialog();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
