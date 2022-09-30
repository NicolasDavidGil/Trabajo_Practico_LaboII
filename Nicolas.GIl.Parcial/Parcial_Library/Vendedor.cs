namespace Parcial_Library
{
    public class Vendedor : Persona
    {
        private string usuarioLogin;
        private string usuarioPassword;
        private string nivelAcceso;        

        public Vendedor(string usuarioLogin, string usuarioPassword, string nombreVendedor, int documentoVendedor, int edad, string nivelAcceso) 
                        : base(nombreVendedor, documentoVendedor, edad)
        {
            this.usuarioLogin = usuarioLogin;
            this.usuarioPassword = usuarioPassword;
            this.nivelAcceso = nivelAcceso;
        }

        public string UsuarioLogin
        {
            get { return usuarioLogin; }
            set { usuarioLogin = value; }
        }
        public string UsuarioPassword
        {
            get { return usuarioPassword; }
            set { usuarioPassword = value; }
        }
        public string NivelAcceso
        {
            get { return nivelAcceso;}
            set
            {
                nivelAcceso = value;
            }
        }
    }
}