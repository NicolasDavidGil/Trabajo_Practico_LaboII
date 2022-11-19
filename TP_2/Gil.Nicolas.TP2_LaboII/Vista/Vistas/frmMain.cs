using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Vista.Vistas
{
    public partial class frmMain : Form, IMainView
    {
        public static frmMain? instance;
        Image? image;
        Image? estado;
        PresentadorMain mainPresenter;
        int indexPartida;
        public frmMain()
        {
            InitializeComponent();
            image = new Bitmap(16, 10);
            mainPresenter = new PresentadorMain(this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            mainPresenter.LlenarDatos();
            mainPresenter.EscribirEnChat("Atentos todos, " + GameManager.managerOn?.NombreUsuario + " acaba de llegar!! \n Demosle una cálida bienvenida!!");
            SetMatchInDataGrid();
        }                       

        public string Chat { get => rtbChat.Text; set => rtbChat.Text = value; }

        public static frmMain GetInstance(Form padreContenedor)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmMain();
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
            instance.SetMatchInDataGrid();
            return instance;
        }        
        public void SetMatchInDataGrid()
        {
            dgvPartidasEnJuego.DataSource = null;
            dgvPartidasEnJuego.DataSource = GameManager.misActivas;            
        }
        public void SetListInDataGrid(List<Usuario> miLista)
        {
            this.dgvJugadoresOnline.Rows.Clear();
            DataGridViewTextBoxColumn colText;
            DataGridViewImageColumn colImagen;

            colText = new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                HeaderText = "NOMBRE USUARIO",
            };
            this.dgvJugadoresOnline.Columns.Add(colText);

            colText = new DataGridViewTextBoxColumn()
            {
                Name = "Puntaje",
                HeaderText = "PUNTAJE",
            };
            this.dgvJugadoresOnline.Columns.Add(colText);

            colImagen = new DataGridViewImageColumn()
            {
                Name = "Pais",
                HeaderText = "NACIONALIDAD",
            };
            this.dgvJugadoresOnline.Columns.Add(colImagen);

            colImagen = new DataGridViewImageColumn()
            {
                Name = "Estado",
                HeaderText = "ESTADO",
            };
            this.dgvJugadoresOnline.Columns.Add(colImagen);

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
                }
                else if (item.EstadoCuenta == 0)
                {
                    estado = Resources.Ocupado;
                }

                cell2 = new DataGridViewImageCell()
                {
                    Value = estado
                };
                rows.Cells.Add(cell2);

                this.dgvJugadoresOnline.Rows.Add(rows);
            }
        }
        public void SetChat(string mensaje)
        {
            rtbChat.Text += mensaje;
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

        private async void btnObservar_Click(object sender, EventArgs e)
        {
            await Devolver();            
        }

        private async Task Devolver()
        {
        //    frmCrearPartida.misTareas?[indexPartida].Start();
        }

        private void dgvPartidasEnJuego_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            indexPartida = e.RowIndex;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
