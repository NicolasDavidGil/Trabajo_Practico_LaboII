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
using static System.Net.Mime.MediaTypeNames;
using Vista.Properties;
using Image = System.Drawing.Image;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;

namespace Vista.Vistas
{
    public partial class frmUsuarios : Form, IUserView
    {
        Image? image;
        Image? estado;
        PresentadorUsuarios userPresenter;
        public static frmUsuarios? instance;
        public static string modiciacion = "false";
        private bool seRealizaronCambios;
        int index;
        public frmUsuarios()
        {
            InitializeComponent();
            userPresenter = new PresentadorUsuarios(this);
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            userPresenter.LlenarDatos();
            pageDetalles.Hide();
            CargarDatosForm();
            btnBorrar.Visible = false;
            btnEditar.Visible = false;
        }
        public string Nombre { get => txtNombre.Text; set => txtNombre.Text = value; }
        public string Edad { get => txtEdad.Text; set => txtEdad.Text = value; }
        public string Dni { get => txtDocumento.Text; set => txtDocumento.Text = value; }
        public string Nacionalidad { get => cmbNacion.Text; set => cmbNacion.Text = value; }
        public string UserName { get => txtApodo.Text; set => txtApodo.Text = value; }
        public string Contraseña { get => txtContraseña.Text; set => txtContraseña.Text = value; }
        public string NivelAcceso { get => cmbAcceso.Text; set => cmbAcceso.Text = value; }
        public string Puntaje { get => lblPuntaje.Text; set => lblPuntaje.Text = value; }
        public string TextoRazon { get => lblEliminacion.Text; set => lblEliminacion.Text = value; }
        public string RazonEliminacion { get => cmbRazonEliminacion.Text; set => cmbRazonEliminacion.Text = value; }
        public string EstadoCuenta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ValorBusqueda { get => txtBusqueda.Text; set => txtBusqueda.Text = value; }
        public bool IsDone { get => seRealizaronCambios; set => seRealizaronCambios = value; }
        public string Mensaje { get => lblCambios.Text; set => lblCambios.Text = value; }

        public void SetListInDataGrid(List<Usuario> miLista)
        {
            this.dgvListadoJugadores.Rows.Clear();
            DataGridViewTextBoxColumn colText;
            DataGridViewImageColumn colImagen;

            colText = new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                HeaderText = "NOMBRE USUARIO",
            };
            this.dgvListadoJugadores.Columns.Add(colText);

            colText = new DataGridViewTextBoxColumn()
            {
                Name = "Puntaje",
                HeaderText = "PUNTAJE",
            };
            this.dgvListadoJugadores.Columns.Add(colText);

            colImagen = new DataGridViewImageColumn()
            {
                Name = "Pais",
                HeaderText = "NACIONALIDAD",
            };
            this.dgvListadoJugadores.Columns.Add(colImagen);

            colImagen = new DataGridViewImageColumn()
            {
                Name = "Estado",
                HeaderText = "ESTADO",
            };
            this.dgvListadoJugadores.Columns.Add(colImagen);

            foreach (Usuario item in miLista)
            {                
                DataGridViewRow rows = new DataGridViewRow();
                DataGridViewTextBoxCell cell;
                DataGridViewImageCell cell2;
                
                cell = new DataGridViewTextBoxCell()
                {
                    Value = item.NombreUsuario
                };
                rows.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Puntaje
                };
                rows.Cells.Add(cell);

                AsignarImagenNacion(item.Nacionalidad);

                cell2 = new DataGridViewImageCell()
                {
                    Value = image                  
                };
                rows.Cells.Add(cell2);

                if (item.EstadoCuenta == 1)
                {
                    estado = Resources.activo;
                }else if(item.EstadoCuenta == 0)
                {
                    estado = Resources.Ocupado;
                }

                cell2 = new DataGridViewImageCell()
                {
                   Value = estado
                };
                rows.Cells.Add(cell2);

                this.dgvListadoJugadores.Rows.Add(rows);
            }
        }
      
        public static frmUsuarios GetInstance(Form padreContenedor)
        {
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

        public void CargarDatosForm()
        {
            tabListado.TabPages.Remove(pageDetalles);
            foreach(string it in userPresenter.misPaises)
            {
                cmbNacion.Items.Add(it);
            }
            cmbRazonEliminacion.Items.Add("Inactividad");
            cmbRazonEliminacion.Items.Add("Violación de normas");
            cmbRazonEliminacion.Items.Add("Sospecha de amenaza");
            cmbRazonEliminacion.Items.Add("Baneo por trampas");
        }
        public void AsignarImagenNacion(string nacion)
        {
            switch (nacion)
            {
                case "Argentina":
                    image = Resources.Argentina;
                    break;
                case "Belice":
                    image = Resources.Belice;
                    break;
                case "Bolivia":
                    image = Resources.Bolivia;
                    break;
                case "Brasil":
                    image = Resources.Brasil;
                    break;
                case "Canadá":
                    image = Resources.Canada;
                    break;
                case "Chile":
                    image = Resources.Chile;
                    break;
                case "Colombia":
                    image = Resources.Colombia;
                    break;
                case "Costa Rica":
                    image = Resources.CostaRica;
                    break;
                case "Cuba":
                    image = Resources.Cuba;
                    break;
                case "Ecuador":
                    image = Resources.Ecuador;
                    break;
                case "Estados Unidos":
                    image = Resources.EstadosUnidos;
                    break;
                case "El Salvador":
                    image = Resources.ElSalvador;
                    break;
                case "Guatemala":
                    image = Resources.Guatemala;
                    break;
                case "Haití":
                    image = Resources.Haiti;
                    break;
                case "Honduras":
                    image = Resources.Honduras;
                    break;
                case "Jamaica":
                    image = Resources.Argentina;
                    break;
                case "México":
                    image = Resources.Mexico;
                    break;
                case "Panamá":
                    image = Resources.Panama;
                    break;
                case "Paraguay":
                    image = Resources.Paraguay;
                    break;
                case "Porú":
                    image = Resources.Peru;
                    break;
                case "Puerto Rico":
                    image = Resources.PuertoRico;
                    break;
                case "República Dominicana":
                    image = Resources.RepublicaDominicana;
                    break;
                case "Uruguay":
                    image = Resources.Uruguay;
                    break;
                case "Venezuela":
                    image = Resources.Venezuela;
                    break;
                case "Europa":
                    image = Resources.Europa;
                    break;
                case "Asia":
                    image = Resources.Asia;
                    break;
                case "Oceania":
                    image = Resources.Oceania;
                    break;
                case "África":
                    image = Resources.Africa;
                    break;
            }
        }
        public void ActivarDetalles()
        {
            if(pageDetalles.IsAccessible)
                pageDetalles.BringToFront();
            else
            {
                tabListado.TabPages.Add(pageDetalles);                        
            }
        }
        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            ActivarDetalles();
            cmbRazonEliminacion.Visible = false;
            userPresenter.LLamarUsuarioNuevo();
            modiciacion = "Nuevo";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario edicion = userPresenter.misJugadores[index];
            userPresenter.LLamarEditarUsuario(edicion);
            cmbRazonEliminacion.Visible = false;
            modiciacion = "Editar";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Usuario borrado = userPresenter.misJugadores[index];
            cmbRazonEliminacion.Visible = true;
            modiciacion = "Borrar";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListadoJugadores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index != -1)
            {
                btnBorrar.Visible = true;
                btnEditar.Visible = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pageLista.Show();
            tabListado.TabPages.Remove(pageDetalles);
        }
    }
}
