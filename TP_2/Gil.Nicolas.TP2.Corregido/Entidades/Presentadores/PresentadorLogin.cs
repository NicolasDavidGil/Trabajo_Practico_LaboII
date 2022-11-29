using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades.Presentadores
{
    public class PresentadorLogin
    {
        IVistaLogin _login;

        public PresentadorLogin(IVistaLogin login)
        {
            _login = login;  
        }

        public bool VerificarDatos(string nombre, string contra, List<Usuario> lista)
        {
            bool entro = false;
        
            foreach (Usuario item in lista)
            {
                if ((nombre == item.NombreUsuario && contra == item.Contraseña) && item.NivelAcceso == "Admin")
                {
                    entro = true;
                    PresentadorPrincipal.logueado = item;
                    break;
                }
            }            
            return entro;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return new RepositorioDeAcceso().ObtenerUsuarios();
        }


    }
}
