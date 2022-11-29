using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades;
using Entidades.Interfaces;
using Entidades.Presentadores;
using Vista;

namespace Vistas
{
    public partial class frmLogin : Form, IVistaLogin
    {
        int k;
        frmCargando? load;
        PresentadorLogin admin;    
        DatosIncorrectosException errorLogeo;
        public frmLogin()
        {
            InitializeComponent();
            k = 0;
            admin = new PresentadorLogin(this);
            errorLogeo = new DatosIncorrectosException("Datos ingresados no válidos, revisar!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        public string Usuario { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Contraseña { get => txtContraseña.Text; set => txtContraseña.Text = value; }
        public string Error { get => lblError.Text; set => lblError.Text = value; }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {            
            bool confirmado = false;            
            try
            {
                List<Usuario> usuarios = admin.ObtenerUsuarios();
                if (usuarios != null)
                {                    
                    confirmado = admin.VerificarDatos(Usuario, Contraseña, usuarios);
                    if (confirmado)
                    {
                        this.Hide();
                        MostrarCargando();
                        Task gitCarga = new Task(EsperaLoad);
                        gitCarga.Start();
                        await gitCarga;
                        OcultarCargando();

                        frmPrincipal principal = new frmPrincipal();
                        principal.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        Error = errorLogeo.Message;
                        lblError.Visible = true;
                    }
                    
                }
            }
            catch
            {                
                if(MessageBox.Show("Error en la base de datos. Comuniquese con soporte. \nEl programa se cerrara", "Error Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }                                                
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {            
            try
            {
                List<Usuario> auxUser = new List<Usuario>();
                foreach (Usuario it in admin.ObtenerUsuarios())
                {
                    if (it.NivelAcceso == "Admin" && it.EstadoCuenta == 1)
                    {
                        auxUser.Add(it);
                    }
                }
                for (int i = k; i < auxUser.Count; i++)
                {
                    Usuario = auxUser[i].NombreUsuario;
                    Contraseña = auxUser[i].Contraseña;
                    k++;
                    break;
                }
                if (k == auxUser.Count)
                {
                    k = 0;
                }
            }
            catch 
            {
                if (MessageBox.Show("Error en la base de datos. Comuniquese con soporte. \nEl programa se cerrara", "Error Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        private void EsperaLoad()
        {
            Thread.Sleep(6000);
        }
        private void MostrarCargando()
        {
            load = new frmCargando();
            load.Show();
        }
        private void OcultarCargando()
        {
            if (load != null)
                load.Close();
        }      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}