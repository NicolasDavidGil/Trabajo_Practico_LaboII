using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAdministracion : Form, IVistaUsuarios
    {
        PresentadorUsuarios usuarios;
        public static frmAdministracion? instance;
        public static frmPrincipal? principal;
        public static List<Usuario>? miListaMain;
        public static List<Usuario>? miListaActivos;
        public static int indexRow;
        public static string? devolucion;
        DateTime hora = new();

        public frmAdministracion()
        {
            InitializeComponent();
            usuarios = new PresentadorUsuarios(this);
            AsociarEventosVista();
            miListaMain = usuarios.TraerUsuariosDesdeBase();            
        }
        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            LLenarCMD();
            DesactivarVista();
            if(miListaMain != null)
                LlenarDataGridView();
        }

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

        public event Action? FiltrarDataGridEvento;
              
        public void LlenarDataGridView()
        {
            dgvListado.DataSource = null;
            miListaActivos = usuarios.TraerUsuariosActivos();
            dgvListado.DataSource = miListaActivos;                                  
        }
        public static frmAdministracion GetInstance(frmPrincipal padreContenedor)
        {
            principal = padreContenedor;
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmAdministracion();
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
        private void AsociarEventosVista()
        {
            btnBuscar.Click += delegate { FiltrarDataGridEvento?.Invoke(); };
            txtBusqueda.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    FiltrarDataGridEvento?.Invoke();
            };
        }
        public void LLenarCMD()
        {
            List<string> naciones = usuarios.TraerPaisesDesdeBase();
            AccesoNuevo = "Admin";
            AccesoNuevo = "Jugador";
            AccesoEditar = "Admin";
            AccesoEditar = "Jugador";
            naciones.ForEach((x) =>
            {
                NacionNuevo = x;
                NacionEditar = x;
            });
            RazonEliminacion = "Inactividad";
            RazonEliminacion = "Juego Sucio";
            RazonEliminacion = "Falta de Respeto";
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
            btnSiReactivar.Visible = false;
            btnNoReactivar.Visible = false;
        }

        
                   
        private void tmrUsuarios_Tick(object sender, EventArgs e)
        {
            hora = hora.AddSeconds(1);
            int horaInt = int.Parse(hora.ToString("ss"));

            if (horaInt % 15 == 0)
            {
                btnDatosModificados.Visible = false;               
                btnErrorBorrar.Visible = false;
                btnErrorEditar.Visible = false;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarVisual();
            tabControl1.TabPages.Add(pageNuevo);
            tabControl1.TabPages.Remove(pageListado);
        }

        private void LimpiarVisual()
        {
            NombreNuevo = "";
            EdadNuevo = "";
            DniNuevo = "";
            ApodoNuevo = "";
            ContraseñaNuevo = "";
            AccesoNuevo = "";
            NacionNuevo = "";
            NombreEditar = "";
            NombreBorrar = "";
            NacionEditar = "";
            AccesoEditar = "";
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (miListaActivos != null)            
                NombreEditar = miListaActivos[indexRow].NombreUsuario;                
            tabControl1.TabPages.Add(pageEditar);
            tabControl1.TabPages.Remove(pageListado);
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            if (miListaActivos != null)
            {
                NombreBorrar = miListaActivos[indexRow].Nombre;
                EdadBorrar = miListaActivos[indexRow].Edad.ToString();
                DniBorrar = miListaActivos[indexRow].Documento.ToString();
                ApodoBorrar = miListaActivos[indexRow].NombreUsuario;
                PuntajeBorrar = miListaActivos[indexRow].Puntaje.ToString();
            }      
            tabControl1.TabPages.Add(pageBorrar);
            tabControl1.TabPages.Remove(pageListado);
        }

        private void dgvListado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = e.RowIndex;
            if(indexRow != -1)
            {
                btnEditarUsuario.Enabled = true;
                btnBorrarUsuario.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (principal != null)
                principal.RefrescarForm();
            this.Close();
        }

        private void btnConfirmarNuevo_Click(object sender, EventArgs e)
        {            
            if (miListaMain != null)
                devolucion =  usuarios.VerificarDatos(1, miListaMain[0]);
            AnalizarDevolucion(1);
        }

        public void AnalizarDevolucion(int aux)
        {
            switch(aux)
            {
                case 1:
                    switch (devolucion)
                    {
                        case "dni":
                            btnErrorNuevo.Text = "Ya existe un usuario con ese D.N.I.\n¿Desea reactivar esa cuenta?";
                            btnErrorNuevo.Visible = true;
                            EsperarRespuesta();
                            break;
                        case "nombre":
                            btnErrorNuevo.Text = "Ya existe un usuario con ese nombre. \n¿Desea reactivar esa cuenta?";
                            btnErrorNuevo.Visible = true;
                            EsperarRespuesta();
                            break;
                        case "usuario":
                            btnErrorNuevo.Text = "Ya existe un usuario con ese nombre de usuario. \n¿Desea reactivar esa cuenta?";
                            btnErrorNuevo.Visible = true;
                            EsperarRespuesta();
                            break;
                        case "fallo":
                            btnErrorNuevo.Text = "Se deben completar todos los campos!";
                            btnErrorNuevo.Visible = true;
                            break;
                        case "ok":
                            LlenarDataGridView();
                            tabControl1.TabPages.Add(pageListado);
                            tabControl1.TabPages.Remove(pageNuevo);
                            break;
                    }
                    break;
            }
        }

        public void EsperarRespuesta()
        {
            btnSiReactivar.Visible = true;
            btnNoReactivar.Visible = true;

            btnConfirmarNuevo.Enabled = false;
            btnCancelarNuevo.Enabled = false;
            txtApodoNuevo.Enabled = false;
            txtContraseñaNuevo.Enabled = false;
            txtDocumentoNuevo.Enabled = false;
            txtEdadNuevo.Enabled = false;
            txtNombreNuevo.Enabled = false;
            cmbAccesoNuevo.Enabled = false;
            cmbNacionNuevo.Enabled = false;
        }

        public void RecibirNo()
        {
            btnSiReactivar.Visible = false;
            btnNoReactivar.Visible = false;
            btnErrorNuevo.Visible = false;

            btnConfirmarNuevo.Enabled = true;
            btnCancelarNuevo.Enabled = true;
            txtApodoNuevo.Enabled = true;
            txtApodoNuevo.Text = "";
            txtContraseñaNuevo.Enabled = true;
            txtContraseñaNuevo.Text = "";
            txtDocumentoNuevo.Enabled = true;
            txtDocumentoNuevo.Text = "";
            txtEdadNuevo.Enabled = true;
            txtEdadNuevo.Text = "";
            txtNombreNuevo.Enabled = true;
            txtNombreNuevo.Text = "";
            cmbAccesoNuevo.Enabled = true;
            cmbAccesoNuevo.Text = "";
            cmbNacionNuevo.Enabled = true;
            cmbNacionNuevo.Text = "";
        }

        private void btnCancelarNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageNuevo);
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {            
            if (miListaMain != null)
                devolucion = usuarios.VerificarDatos(2, miListaMain[indexRow]);
            switch (devolucion)
            {
                case "fallo":
                    btnErrorEditar.Text = "Aparecio un error al editar el usuario.";
                    btnErrorEditar.Visible = true;
                    break;
                case "vacio":
                    btnErrorEditar.Text = "Se deben completar todos los campos!";
                    btnErrorEditar.Visible = true;
                    break;
                case "ok":
                    tabControl1.TabPages.Add(pageListado);
                    tabControl1.TabPages.Remove(pageEditar);
                    btnDatosModificados.Visible = true;
                    LlenarDataGridView();
                    break;
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageEditar);
        }

        private void btnConfirmarDelete_Click(object sender, EventArgs e)
        {
            if (miListaMain != null)
                devolucion = usuarios.VerificarDatos(3, miListaMain[indexRow]);
            switch (devolucion)
            {
                case "fallo":
                    btnErrorBorrar.Text = "Aparecio un error al agregar el usuario.";
                    btnErrorBorrar.Visible = true;
                    break;
                case "vacio":
                    btnErrorBorrar.Text = "Se deben completar todos los campos!";
                    btnErrorBorrar.Visible = true;
                    break;
                case "ok":
                    RazonEliminacion = "";
                    tabControl1.TabPages.Add(pageListado);
                    tabControl1.TabPages.Remove(pageBorrar);
                    btnDatosModificados.Visible = true;
                    LlenarDataGridView();
                    break;
            }
        }

        private void btnCancelarDelete_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageBorrar);
        }

        private void btnSiReactivar_Click(object sender, EventArgs e)
        {
            if (miListaMain != null)                
                miListaMain.ForEach((x) =>
                {
                    if (x.Documento.ToString() == DniNuevo || x.Nombre == NombreNuevo || x.NombreUsuario == ApodoNuevo)
                    {
                        Usuario aux = x;
                        aux.EstadoCuenta = 1;
                        usuarios.EditarBaseDeUsuarios(2, aux);
                    }
                });
            tabControl1.TabPages.Add(pageListado);
            tabControl1.TabPages.Remove(pageNuevo);
            LlenarDataGridView();
        }

        private void btnNoReactivar_Click(object sender, EventArgs e)
        {
            RecibirNo();
        }
    }
}
