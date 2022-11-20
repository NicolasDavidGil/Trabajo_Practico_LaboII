using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using Entidades.Repositorio;

namespace Vista
{    
    public partial class frmPrincipal : Form, IPrincipalView
    {
        List<PresentadorDeJuego> hilosJuegos;
        PresentadorPrincipal main;
        RowIndexException errorRow;
        public static int indexPartida;
        frmVerPartida? visual;
        List<Usuario>? data;
        DateTime hora = new DateTime();
        public event EventHandler? EscribirChatEvento;
  
        public frmPrincipal()
        {
            InitializeComponent();
            AsociarEventosALaVista();
            main = new PresentadorPrincipal(this);
            data = main.ObtenerUsuarios();
            hilosJuegos = new List<PresentadorDeJuego>();            
            Mazo mazoJuegos = new Mazo();
            errorRow = new RowIndexException("Error en la lectura del indice");
            mazoJuegos.MiMazo = main.ObtenerMazo();
            Serializadora<Mazo>.EscribirJson("MazoCartas", mazoJuegos);
        }

        public string JugadorUno { get => cmbJugadorUno.Text; set => cmbJugadorUno.Items.Add(value); }
        public string JugadorDos { get => cmbJugadorDos.Text; set => cmbJugadorDos.Items.Add(value); }
        public string TipoPartida { get => cmbTipoPartida.Text; set => cmbTipoPartida.Items.Add(value); }
        public string Usuario { get => lblUsuario.Text; set => lblUsuario.Text = value; }
        public string Hora { get => lblHora.Text; set => lblHora.Text = value; }
        public string Fecha { get => lblFecha.Text; set => lblFecha.Text = value; }
        public string Chat { get => rtbChatPrincipal.Text; set => rtbChatPrincipal.Text = value; }
        public string TextoParaChat { get => txtEscribirChat.Text; set => txtEscribirChat.Text = value; }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
            LLenarForm();
            dgvPartidasActivas.DataSource = null;
            pnlNuevaPartida.Visible = false;
            lblErrores.Visible = false;
            pnlMain.Visible = true;
            btnObservar.Enabled = true;
            Usuario = frmLogin.logeado.Nombre;
            Chat += "Atentos todos, " + frmLogin.logeado?.NombreUsuario + " acaba de llegar!! \n Demosle una cálida bienvenida!!";
            TipoPartida = "Partida Completa";
            TipoPartida = "Partida Espress";
        }  
        /// <summary>
        /// Asocia el boton buscar y el apretar la tecla enter en la barra de escribir chat
        /// </summary>
        private void AsociarEventosALaVista()
        {
            btnEnviar.Click += delegate { EscribirChatEvento?.Invoke(this, EventArgs.Empty); };
            txtEscribirChat.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                    EscribirChatEvento?.Invoke(this, EventArgs.Empty);
            };
        }

        private void btnCrearPartida_Click(object sender, EventArgs e)
        {
            pnlNuevaPartida.Visible = true;            
        }

        private void btnJugarPartida_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            frmJugarPartida jugar = frmJugarPartida.GetInstance(this);
            jugar.MdiParent = this;
            this.MdiChildren.Append(jugar);
            jugar.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            frmUsuarios user = frmUsuarios.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            LLenarForm();
            pnlMain.Visible = false;
            frmEstadisticas user = frmEstadisticas.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);            
            user.Show();              
        }

        public void RefrescarForm()
        {
            pnlMain.Visible = true;
        }      

        private void btnReglas_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            frmReglas user = frmReglas.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }        
        private async Task<bool> CrearPartida()
        {            
            if(!String.IsNullOrWhiteSpace(JugadorUno) && !String.IsNullOrWhiteSpace(JugadorDos) && !String.IsNullOrWhiteSpace(TipoPartida))
            {
                Usuario uno = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0);
                Usuario dos = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0);

                foreach (Usuario it in data)
                {
                    if (JugadorUno == it.NombreUsuario)
                    {
                        uno = it;
                        it.EstadoCuenta = 0;
                        JugadorUno = "";
                    }
                    if (JugadorDos == it.NombreUsuario)
                    {
                        dos = it;
                        it.EstadoCuenta = 0;
                        JugadorDos = "";
                    }
                }
                //No verifico los usuarios porque se que los combobox tiene solo usuarios libres
                PresentadorDeJuego gameAdmin = new PresentadorDeJuego();
                hilosJuegos.Add(gameAdmin);
                gameAdmin.IniciarPartida(uno, dos, TipoPartida);
                Chat += "\n" + dos.NombreUsuario + " y " + uno.NombreUsuario + " mediran su destreza en una nueva partida, puedes observalos y darles tu apoyo!!\n";
                await gameAdmin.IniciarTarea();                
                return true;
            }            
            return false;
        }

        private void btnSalirNuevaPartida_Click(object sender, EventArgs e)
        {
            pnlNuevaPartida.Visible = false;
        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            if(visual == null || visual.IsDisposed)
            {
                visual = new frmVerPartida(hilosJuegos[indexPartida]);
                visual.Show();
            }
            else
            {
                if(visual.WindowState == FormWindowState.Minimized)
                {
                    visual.BringToFront();
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SetTextToChat(TextoParaChat);
        }
      
        public void LLenarForm()
        {           
            List<Usuario> filtrada = new List<Usuario>();
            foreach (Usuario it in data)
            {
                if (it.EstadoCuenta == 1 && it.Nombre != Usuario)
                {
                    JugadorUno = it.NombreUsuario;
                    filtrada.Add(it);                    
                }
            }
            dgvJugadoresOnline.DataSource = null;
            dgvJugadoresOnline.DataSource = filtrada;
        }

        public void SetTextToChat(string mensaje)
        {
            if (!String.IsNullOrWhiteSpace(TextoParaChat))
            {
                Chat += "\n" + TextoParaChat;
                rtbChatPrincipal.Refresh();
                txtEscribirChat.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tmrPrincipal_Tick(object sender, EventArgs e)
        {            
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            hora = hora.AddSeconds(1);
            int horaInt = int.Parse(hora.ToString("ss"));

            if (horaInt % 5 == 0)
            {
                lblErrores.Visible = false;
                LLenarForm();

                if (PresentadorPrincipal.partidasActivas?.Count < 1)
                    dgvPartidasActivas.DataSource = null;
                else
                    dgvPartidasActivas.DataSource = PresentadorPrincipal.partidasActivas;
                
            }
        }

        private void dgvPartidasActivas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            try
            {
                indexPartida = e.RowIndex;
                if (PresentadorPrincipal.partidasActivas?[e.RowIndex] != null && PresentadorPrincipal.partidasActivas.Count > 0)
                {
                    if (indexPartida != -1)
                    {
                        btnObservar.Enabled = true;
                    }
                }
            }
            catch (RowIndexException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnCrearNuevaPartida_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(JugadorUno) && !String.IsNullOrWhiteSpace(JugadorDos) && !String.IsNullOrWhiteSpace(TipoPartida))
            {
                await CrearPartida();
                dgvPartidasActivas.DataSource = null;
                if (PresentadorPrincipal.partidasActivas?.Count > 0)
                    dgvPartidasActivas.DataSource = PresentadorPrincipal.partidasActivas;
                pnlNuevaPartida.Visible = false;
                cmbJugadorDos.Text = "";
                cmbJugadorDos.Text = "";
                cmbTipoPartida.Text = "";
            }else
            {                
                lblErrores.Visible = true;
            }
        }

        private void cmbJugadorUno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data != null)
            {
                data.ForEach((X) =>
                {
                    if (JugadorUno != X.NombreUsuario && X.EstadoCuenta == 1 && X.NombreUsuario != frmLogin.logeado?.NombreUsuario)
                    {
                        JugadorDos = X.NombreUsuario;
                    }
                });
            }
        }
    }
}
