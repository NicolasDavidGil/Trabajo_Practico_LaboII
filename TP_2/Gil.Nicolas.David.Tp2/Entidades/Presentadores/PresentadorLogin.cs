using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentadores
{
    public class PresentadorLogin
    {
        Ilogin _login;

        public PresentadorLogin(Ilogin login)
        {
            _login = login;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return new RepositorioDeAcceso().ObtenerUsuarios();
        }


    }
}
