using Library.TP2;

namespace Vista.TP2
{
    public partial class frmInicioSesion : Form
    {       
        private int autocompletar;
        PresentadorLogin presentador;
        public frmInicioSesion()
        {
            InitializeComponent();           
            autocompletar = 1; 
            presentador = new PresentadorLogin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblErrores.Visible = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(presentador.VerificarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                frmMenuPrincipal principal = new frmMenuPrincipal();
                this.Hide();
                principal.ShowDialog();
                this.Show();
            }
            else
            {
                lblErrores.Text = "Datos Incorrectos";
                lblErrores.Visible = true;
            }
            
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {   
            List<Usuario> nueva = new List<Usuario>();
            nueva = BaseDatos.ObtenerUsuarios();
            
            for (int i = 0; i < autocompletar; i++)
            {                              
                txtUsuario.Text = nueva[i].NombreUsuario;
                txtContraseña.Text = nueva[i].Password;
                autocompletar++;
                if (autocompletar > nueva.Count)
                {
                    autocompletar = 1;
                }
            }
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}