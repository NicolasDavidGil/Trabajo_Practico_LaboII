namespace Parcial_Library
{
    public class Vendedor : Persona
    {
        private string usuarioLogin;
        private string usuarioPassword;
        private string nivelAcceso;



        public Vendedor(string usuarioLogin, string usuarioPassword, string nombreVendedor, int documentoVendedor, string nivelAcceso) : base(nombreVendedor, documentoVendedor)
        {
            this.usuarioLogin = usuarioLogin;
            this.usuarioPassword = usuarioPassword;
            this.nivelAcceso = nivelAcceso;
        }

        public string UsuarioLogin
        {
            get { return usuarioLogin; }
        }
        public string UsuarioPassword
        {
            get { return usuarioPassword; }
        }
        public string NivelAcceso
        {
            get { return nivelAcceso;}
        }
    }
}