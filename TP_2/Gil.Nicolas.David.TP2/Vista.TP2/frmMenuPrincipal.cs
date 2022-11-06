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
    public partial class frmMenuPrincipal : Form
    {
        Partida? nueva;
        List<Partida> partidasActivas;
        int index;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            partidasActivas = new List<Partida>();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            pnlNuevaPartida.Visible = false;
            lblPartidas.Visible = false;
            dgvPartidas.Visible = false;
            btnObservar.Visible = false;
            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = BaseDatos.ObtenerJugadores();
            foreach (Usuario it in BaseDatos.ObtenerJugadores())
            {
                cmbJugadorUno.Items.Add(it.NombreUsuario);
                cmbJugadorDos.Items.Add(it.NombreUsuario);
            }
        }
        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            pnlNuevaPartida.Visible = true;
        }

        private void btnPanelIniciar_Click(object sender, EventArgs e)
        {
            Usuario aux1 = new("", 0, 0, "", "", "", 0, 0, 0);
            Usuario aux2 = new("", 0, 0, "", "", "", 0, 0, 0);

            foreach (Usuario it in BaseDatos.ObtenerJugadores())
            {
                if (cmbJugadorUno.Text == it.NombreUsuario)
                {
                    aux1 = it;
                }
                if (cmbJugadorDos.Text == it.NombreUsuario)
                {
                    aux2 = it;
                }
            }
            nueva = new(DateTime.Now, aux1, aux2);
            partidasActivas.Add(nueva);
            dgvPartidas.DataSource = null;
            dgvPartidas.DataSource = partidasActivas;
            pnlNuevaPartida.Visible = false;
            dgvPartidas.Visible = true;
            lblPartidas.Visible = true;
        }

        private void btnPanelCancelar_Click(object sender, EventArgs e)
        {
            cmbJugadorUno.Text = "";
            cmbJugadorDos.Text = "";
            pnlNuevaPartida.Visible = false;
        }

        private void btnNuevoJugador_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario user = new frmNuevoUsuario();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void dgvPartidas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;

            if(index != -1)
            {
                btnObservar.Visible = true;
            }
        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            if(nueva is not null)
            {
                frmPartida verPartida = new frmPartida(partidasActivas[index]);
                this.Hide();
                verPartida.ShowDialog();
                this.Show();
            }            
        }
    }
}
