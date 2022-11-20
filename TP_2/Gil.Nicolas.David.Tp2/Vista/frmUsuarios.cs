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
using Entidades.Modelos;
using Entidades.Presentadores;
using Entidades.Repositorio;

namespace Vista
{
    public partial class frmUsuarios : Form, IUsuarios
    {
        public static int indexRow;
        public static frmUsuarios? instance;
        public static frmPrincipal? main;
        PresentadorUsuarios admin;
        public event Action? FiltrarDataGridEvento;
        public static List<Usuario>? miListaMain;
        public string NombreNuevo { get => txtNombreNuevo.Text; set => txtNombreNuevo.Text = value; }
        public string EdadNuevo { get => txtEdadNuevo.Text; set => txtEdadNuevo.Text = value; }
        public string DniNuevo { get => txtDocumentoNuevo.Text; set => txtDocumentoNuevo.Text = value; }
        public string ApodoNuevo { get => txtApodoNuevo.Text; set => txtApodoNuevo.Text = value; }
        public string ContraseñaNuevo { get => txtContraseñaNuevo.Text; set => txtContraseñaNuevo.Text = value; }
        public string AccesoNuevo { get => cmbAccesoNuevo.Text; set => cmbAccesoNuevo.Items.Add(value); }
        public string NacionNuevo { get => cmbNacionNuevo.Text; set => cmbNacionNuevo.Items.Add(value); }
        public string NombreEditar { get => txtUserEditar.Text; set => txtUserEditar.Text = value; }
        public string AccesoEditar { get => cmbAccesoEditar.Text; set => cmbAccesoEditar.Items.Add(value); }
        public string NacionEditar { get => cmbNacionEditar.Text; set => cmbNacionEditar.Items.Add(value); }
        public string NombreBorrar { get => txtUserBorrar.Text; set => txtUserBorrar.Text = value; }
        public string EdadBorrar { get => txtEdadBorrar.Text; set => txtEdadBorrar.Text = value; }
        public string DniBorrar { get => txtDniBorrar.Text; set => txtDniBorrar.Text = value; }
        public string ApodoBorrar { get => txtNombreBorrar.Text; set => txtNombreBorrar.Text = value; }
        public string PuntajeBorrar { get => lblPuntajeBorrar.Text; set => lblPuntajeBorrar.Text = value; }
        public string RazonEliminacion { get => cmbRazonEliminacion.Text; set => cmbRazonEliminacion.Items.Add(value); }
        public string ValorBusqueda { get => txtBusqueda.Text; set => txtBusqueda.Text = value; }

        public frmUsuarios()
        {
            InitializeComponent();
            admin = new PresentadorUsuarios(this);
            AsociarEventosVista();
            miListaMain = admin.TraerUsuariosDesdeBase();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DesactivarVista();
            LLenarCMD();
            if(miListaMain != null)
            {
                List<Usuario> verificada = new List<Usuario>();
                miListaMain.ForEach((x) =>
                {
                    if(x.EstadoCuenta == 1)
                        verificada.Add(x);
                });
                SetDataGridList(verificada);
            }            
        }

        public void LLenarCMD()
        {
            List<string> naciones = admin.TraerPaisesDesdeBase();
            AccesoNuevo = "Admin";
            AccesoNuevo = "Jugador";
            AccesoEditar = "Admin";
            AccesoEditar = "Jugador";
            naciones.ForEach((x) =>
            {
                NacionNuevo = x;
                NacionEditar = x;
            });
        }

        public void DesactivarVista()
        {
            tabControl1.TabPages.Remove(pageNuevo);
            tabControl1.TabPages.Remove(pageEditar);
            tabControl1.TabPages.Remove(pageBorrar);
            btnBorrarUsuario.Enabled = false;
            btnEditarUsuario.Enabled = false;
            btnDatosModificados.Visible = false;
            btnErrorNuevo.Visible = false;
        }

        private void AsociarEventosVista()
        {
            btnBuscar.Click += delegate { FiltrarDataGridEvento?.Invoke(); };
            txtBusqueda.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                    FiltrarDataGridEvento?.Invoke();
            };
        }
        
        public static frmUsuarios GetInstance(frmPrincipal padreContenedor)
        {
            main = padreContenedor;
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmUsuarios();
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

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageNuevo);
            tabControl1.TabPages.Remove(pageListado);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if(miListaMain != null)
            NombreEditar = miListaMain[indexRow].NombreUsuario;  
            tabControl1.TabPages.Add(pageEditar);
            tabControl1.TabPages.Remove(pageListado);
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            if (miListaMain != null)
            {
                NombreBorrar = miListaMain[indexRow].Nombre;
                EdadBorrar = miListaMain[indexRow].Edad.ToString();
                DniBorrar = miListaMain[indexRow].Documento.ToString();
                ApodoBorrar = miListaMain[indexRow].NombreUsuario;
                PuntajeBorrar = miListaMain[indexRow].Puntaje.ToString();
            }
            cmbRazonEliminacion.Items.Add("Inactividad");
            cmbRazonEliminacion.Items.Add("Juego Sucio");
            cmbRazonEliminacion.Items.Add("Falta de Respeto");
            tabControl1.TabPages.Add(pageBorrar);
            tabControl1.TabPages.Remove(pageListado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {     
            if(main != null)
            main.RefrescarForm();
            this.Close();
        }

        public void SetDataGridList(List<Usuario> lista)
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = lista;
        }

        private void dgvListado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = e.RowIndex;
            if(indexRow != -1)
            {
                btnBorrarUsuario.Enabled = true;
                btnEditarUsuario.Enabled = true;
            }
        }

        private void btnConfirmarNuevo_Click(object sender, EventArgs e)
        {
            if (miListaMain != null)
                admin.VerificarDatos(1, miListaMain[indexRow]);
        }

        private void btnCancelarNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageNuevo);
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            if (miListaMain != null)
                admin.VerificarDatos(2, miListaMain[indexRow]);
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageEditar);
        }

        private void btnConfirmarDelete_Click(object sender, EventArgs e)
        {
            if (miListaMain != null)
                admin.VerificarDatos(3, miListaMain[indexRow]);
        }

        private void btnCancelarDelete_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageBorrar);
        }

        public void AddUser(Usuario player)
        {
            bool okok = admin.EditarBaseDeUsuarios(1, player);
            if (okok)
            {
                tabControl1.TabPages.Add(pageListado);
                tabControl1.TabPages.Remove(pageNuevo);
                btnDatosModificados.Visible = true;
                dgvListado.DataSource = miListaMain;
            }
            else
            {
                btnErrorNuevo.Visible = true;
            }
        }

        public void EditUser(Usuario player)
        {
            bool okok = admin.EditarBaseDeUsuarios(2, player);
            if(okok)
            {
                tabControl1.TabPages.Add(pageListado);
                tabControl1.TabPages.Remove(pageEditar);
                btnDatosModificados.Visible = true;
                dgvListado.DataSource = miListaMain;
            }
            else
            {
                btnErrorNuevo.Visible = true;
            }
        }

        public void DeleteUser(Usuario player)
        {
            bool okok = admin.EditarBaseDeUsuarios(3, player);
            if (okok)
            {
                tabControl1.TabPages.Add(pageListado);
                tabControl1.TabPages.Remove(pageBorrar);
                btnDatosModificados.Visible = true;
                dgvListado.DataSource = miListaMain;
            }
            else
            {
                btnErrorNuevo.Visible = true;
            }
        }


        DateTime hora = new();
        private void tmrUsuarios_Tick(object sender, EventArgs e)
        {
            hora = hora.AddSeconds(1);
            int horaInt = int.Parse(hora.ToString("ss"));

            if (horaInt % 4 == 0)
            {
                btnDatosModificados.Visible = false;
                btnErrorNuevo.Visible = false;
            }
        }        
    }
}
