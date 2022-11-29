using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;

namespace Vista
{
    public partial class frmPrincipal : Form, IVistaPrincipal
    {
        List<PresentadorDeJuego> hilosJuegos;
        public static List<CancellationTokenSource> canceladores;
        PresentadorPrincipal principal;
        RowIndexException errorRow;
        FalloSerializacionMazo errorSerial;
        frmVerPartida? visual;
        public static int indexPartida;
        //frmVerPartida? visual;        
        DateTime hora = new DateTime();
        public event EventHandler? EscribirChatEvento;

        public frmPrincipal()
        {
            InitializeComponent();
            AsociarEventosALaVista();            
            hilosJuegos = new List<PresentadorDeJuego>();
            errorRow = new RowIndexException("Partida no disponible!");
            errorSerial = new FalloSerializacionMazo("Error al escribir Json con el mazo.");
            hilosJuegos = new List<PresentadorDeJuego>();
            canceladores = new List<CancellationTokenSource>();
            principal = new PresentadorPrincipal(this);
            principal.ObtenerDatos();            
            Mazo mazoSerial = new Mazo();            
            try
            {
                if(principal.MiMazo != null)
                    mazoSerial.MiMazo = principal.MiMazo;
                Serializadora<Mazo>.EscribirJson("MazoCartas", mazoSerial);
            }
            catch(FalloSerializacionMazo ex)
            {
                lblError.Visible = true;
                Error = ex.Message;
            }
            LLenarForm();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            pnlNuevaPartida.Visible = false;
            lblErroresPnlNueva.Visible = false;
            btnObservar.Visible = false;
            btnCancelar.Visible = false;
        }

        public string JugadorUno { get => cmbJugadorUno.Text; set => cmbJugadorUno.Items.Add(value); }
        public string JugadorDos { get => cmbJugadorDos.Text; set => cmbJugadorDos.Items.Add(value); }
        public string TipoPartida { get => cmbTipoPartida.Text; set => cmbTipoPartida.Items.Add(value); }
        public string Usuario { get => lblUsuario.Text; set => lblUsuario.Text = value; }
        public string Hora { get => lblHora.Text; set => lblHora.Text = value; }
        public string Fecha { get => lblFecha.Text; set => lblFecha.Text = value; }
        public string Chat { get => rtbChat.Text; set => rtbChat.Text += value; }
        public string TextoParaChat { get => txtChat.Text; set => txtChat.Text = value; }
        public string Error { get => lblError.Text; set => lblError.Text = value; }

        private void AsociarEventosALaVista()
        {
            btnEnviar.Click += delegate { EscribirChatEvento?.Invoke(this, EventArgs.Empty); };
            txtChat.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    EscribirChatEvento?.Invoke(this, EventArgs.Empty);
            };
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wm, int wp, int lp);

        public void LLenarForm()
        {
            List<Usuario> filtrada = new List<Usuario>();
            if (principal.MisUsuarios != null)
            {
                foreach (Usuario it in principal.MisUsuarios)
                {
                    if (it.EstadoCuenta == 1 && it.Documento != PresentadorPrincipal.logueado?.Documento)
                    {
                        JugadorUno = it.NombreUsuario;
                        filtrada.Add(it);                        
                    }
                }
            }
            if(PresentadorPrincipal.logueado != null)
                Usuario = PresentadorPrincipal.logueado.Nombre;
            TipoPartida = "Partida Completa";
            TipoPartida = "Partida Express";
            dgvJugadoresOnline.DataSource = null;
            dgvJugadoresOnline.DataSource = filtrada;
        }
       
        public void SetTextToChat(string mensaje)
        {
            if (!String.IsNullOrWhiteSpace(TextoParaChat))
            {
                Chat += "\n" + TextoParaChat;
                rtbChat.Refresh();
                txtChat.Text = "";
            };
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            pnlNuevaPartida.Visible = true;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = false;
            frmAdministracion user = frmAdministracion.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {          
            pnlPrincipal.Visible = false;
            frmEstadisticas user = frmEstadisticas.GetInstance(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }

        private void btnReglasJuego_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = false;
            frmReglas user = frmReglas.ObtenerInstancia(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);            
            user.Show();
        }
        private void tmbPrincipal_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            hora = hora.AddSeconds(1);
            int horaInt = int.Parse(hora.ToString("ss"));

            if (horaInt % 5 == 0)
            {
                lblError.Visible = false;                

                if (PresentadorPrincipal.partidasActivas?.Count < 1)
                {
                    dgvPartidasActivas.Visible = false;
                    dgvPartidasActivas.DataSource = null;
                }
                else
                {
                    dgvPartidasActivas.Visible = true;
                    dgvPartidasActivas.DataSource = PresentadorPrincipal.partidasActivas;
                }                    
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
                cmbJugadorUno.Text = "";
                cmbJugadorDos.Text = "";
                cmbTipoPartida.Text = "";
            }
            else
            {
                lblErroresPnlNueva.Visible = true;
            }
        }

        private async Task<bool> CrearPartida()
        {
            if (!String.IsNullOrWhiteSpace(JugadorUno) && !String.IsNullOrWhiteSpace(JugadorDos) && !String.IsNullOrWhiteSpace(TipoPartida))
            {
                Usuario uno = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0);
                Usuario dos = new Usuario("", 0, 0, "", "", "", "", 0, 0, 0, 0);
                if (principal.MisUsuarios != null)
                {
                    foreach (Usuario it in principal.MisUsuarios)
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
                }
                //No verifico los usuarios porque se que los combobox tiene solo usuarios libres
                PresentadorDeJuego gameAdmin = new PresentadorDeJuego();
                hilosJuegos.Add(gameAdmin);
                canceladores.Add(new CancellationTokenSource());
                gameAdmin.IniciarPartida(uno, dos, TipoPartida, canceladores.Last().Token);
                Chat += "\n" + dos.NombreUsuario + " y " + uno.NombreUsuario + " mediran su destreza en una nueva partida, puedes observalos y darles tu apoyo!!\n";
                await gameAdmin.IniciarTarea();
                return true;
            }
            return false;
        }

        public void RefrescarForm()
        {
            pnlPrincipal.Visible = true;
        }

        private void btnSalirNuevaPartida_Click(object sender, EventArgs e)
        {
            cmbJugadorUno.Text = "";
            cmbJugadorDos.Text = "";
            pnlNuevaPartida.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmbJugadorUno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbJugadorDos.Items.Clear();
            cmbJugadorDos.SelectedIndex = -1;
            if (principal.MisUsuarios != null)
            {
                principal.MisUsuarios.ForEach((x) =>
                {
                    if (x.EstadoCuenta == 1 && x.NombreUsuario != JugadorUno)
                    {
                        JugadorDos = x.NombreUsuario;
                    }
                });
            }
        }

        private void cmbJugadorUno_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbJugadorDos.Items.Clear();
            cmbJugadorDos.SelectedIndex = -1;
            if (principal.MisUsuarios != null)
            {
                principal.MisUsuarios.ForEach((x) =>
                {
                    if (x.EstadoCuenta == 1 && x.NombreUsuario != JugadorUno)
                    {
                        JugadorDos = x.NombreUsuario;
                    }
                });
            }
        }
        private void cmbJugadorDos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (visual == null || visual.IsDisposed)
                {
                    visual = new frmVerPartida(hilosJuegos[indexPartida]);
                    visual.Show();
                }
                else
                {
                    if (visual.WindowState == FormWindowState.Minimized)
                    {
                        visual.BringToFront();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No hay partidas activas");
            }
        }

        private void dgvPartidasActivas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexPartida = e.RowIndex;
            try
            {
                if (indexPartida != -1 && hilosJuegos.Count > 0)
                {
                    btnObservar.Visible = true;
                    btnCancelar.Visible = true;
                }
                else
                {
                    btnObservar.Visible = false;
                    btnCancelar.Visible = false;
                }
            }catch(Exception ex)
            {                
                MessageBox.Show("No hay partidas activas");
            }
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            if (pnlMenuPrincipal.Width == 250)
                pnlMenuPrincipal.Width = 85;
            else
                pnlMenuPrincipal.Width = 250;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.indexPartida != -1)
            {
                canceladores[indexPartida].Cancel();
                hilosJuegos.RemoveAt(indexPartida);
                dgvPartidasActivas.Refresh();
                btnCancelar.Visible = false;
                btnObservar.Visible = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReadme_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = false;
            frmReadme user = frmReadme.ObtenerInstancia(this);
            user.MdiParent = this;
            this.MdiChildren.Append(user);
            user.Show();
        }
    }
}
