using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.Repositorio;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vista
{
    public partial class frmLogin : Form
    {
        int k = 0;
        frmCargando? load;
        public static Usuario? logeado;
        List<Usuario> usuarios;
        DatosIncorrectosException errorLogeo;
        public frmLogin()
        {
            InitializeComponent();
            errorLogeo = new DatosIncorrectosException("ERROR EN LA OPERACION DE INICIAR");
            usuarios = new RepositorioDeAcceso().GetUsers();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            bool pepe;
            try
            {
                pepe = VerificarUsuario(txtUserName.Text, txtPassword.Text);
                if (pepe)
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
            }catch(DatosIncorrectosException ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            List<Usuario> auxUser = new List<Usuario>();
            try
            {                
                foreach (Usuario it in usuarios)
                {
                    if (it.NivelAcceso == "Admin")
                    {
                        auxUser.Add(it);
                    }
                }
                for (int i = k; i < auxUser.Count; i++)
                {
                    txtUserName.Text = auxUser[i].NombreUsuario;
                    txtPassword.Text = auxUser[i].Contraseña;
                    k++;
                    break;
                }
                if (k == auxUser.Count)
                {
                    k = 0;
                }                
            }
            catch (DatosIncorrectosException ex)
            {
                lblError.Text = ex.Message;
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
        public bool VerificarUsuario(string name, string pass)
        {
            bool entro = false;
            try
            {                
                foreach (Usuario item in usuarios)
                {
                    if ((name == item.NombreUsuario && pass == item.Contraseña) && item.NivelAcceso == "Admin")
                    {
                        entro = true;
                        logeado = item;
                        break;
                    }
                }                            
            }
            catch (DatosIncorrectosException ex)
            {
                lblError.Text = ex.Message;
            }
            return entro;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}