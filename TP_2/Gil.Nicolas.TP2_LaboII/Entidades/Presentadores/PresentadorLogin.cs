using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml.Linq;

namespace Entidades.Presentadores
{
    public class PresentadorLogin : PresentadorDeAcceso
    {
        public static Usuario? logeado;
        private ILoginView vista;
        List<Usuario> usuarios;
        int k;

        public PresentadorLogin(ILoginView vista)
        {
            this.vista = vista;
            this.usuarios = ObtenerUsuariosDesdeBase();
            k = 0;
        }

        public override void LlenarDatos()
        {
            List<Usuario> auxUser = new List<Usuario>();
            foreach(Usuario it in usuarios)
            {
                if(it.NivelAcceso == "Admin")
                {
                    auxUser.Add(it);
                }
            }
            for(int i = k; i < auxUser.Count; i++)
            {
                vista.UserName = auxUser[i].NombreUsuario;
                vista.Password = auxUser[i].Contraseña;
                k++;
                break;
            }
            if(k == auxUser.Count)
            {
                k = 0;
            }
        }
   
        public bool VerificarUsuario(string name, string pass)
        {            
            bool entro = false;
            foreach (Usuario item in usuarios)
            {
                if ((name == item.NombreUsuario && pass == item.Contraseña) && item.NivelAcceso == "Admin")
                {
                    entro = true;
                    logeado = item;
                    break;
                }
            }
            return entro;
        }

        public override List<Usuario> ObtenerUsuariosDesdeBase()
        {            
            RepositorioUsuarios usuariosBase = new RepositorioUsuarios();
            usuarios = usuariosBase.GetAll();

            return usuarios;
        }
    }
}
