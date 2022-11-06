using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2
{
    public class PresentadorLogin
    {
        List<Usuario> usuarios; 
        Serializadora<Usuario> salvado;

        public PresentadorLogin()
        {
            usuarios = new List<Usuario>();
            salvado = new();
        }

        public bool VerificarUsuario(string user, string pass)
        {
            bool encontroOK = false;
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(pass))
            {
                foreach (Usuario item in BaseDatos.ObtenerUsuarios())
                {
                    if (item.NombreUsuario == user && item.Password == pass)
                    {
                        encontroOK = true;
                        break;
                    }
                }
            }
            return encontroOK;
        }

        public void CrearUsuariosXml()
        {
            usuarios = BaseDatos.ObtenerUsuarios();
            foreach (Usuario item in usuarios)
            {
                salvado.EscribirXml("Usuarios", item);
            }
        }

        public void CrearJugadoresXml()
        {
            usuarios = BaseDatos.ObtenerJugadores();
            foreach(Usuario item in usuarios)
            {
                salvado.EscribirXml("Jugadores", item);
            }
        }
    }
}
