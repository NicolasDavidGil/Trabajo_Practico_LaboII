using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades.Presentadores
{
    public class PresentadorUsuarios : PresentadorDeAcceso
    {        
        IUserView userView;
        public List<Usuario> misJugadores;
        public List<string> misPaises;

        public PresentadorUsuarios(IUserView userView)
        {
            this.userView = userView;                        
            this.misJugadores = ObtenerUsuariosDesdeBase();
            this.misPaises = ObtenerPaises();
        }        

        public override void LlenarDatos()
        {            
            try
            {
                foreach (Usuario us in misJugadores)
                {
                    if (us.NombreUsuario == PresentadorLogin.logeado?.NombreUsuario)
                    {
                        misJugadores.Remove(us);
                    }
                }
            }
            catch
            {
                Exception exception = new Exception();
            }
            userView.SetListInDataGrid(misJugadores);            
        }

        public override List<Usuario> ObtenerUsuariosDesdeBase()
        {
            RepositorioUsuarios repo = new RepositorioUsuarios();
            return repo.GetAll();
        }

        public List<string> ObtenerPaises()
        {
            RepositorioPaises repo = new RepositorioPaises();
            return repo.GetPaises();
        }

        public void LLamarUsuarioNuevo()
        {
            userView.Puntaje = "";
            userView.RazonEliminacion = "";
            userView.TextoRazon = "";
        }

        public void LLamarEditarUsuario(Usuario user)
        {
            userView.Puntaje = user.Puntaje.ToString();
            userView.RazonEliminacion = "";
            userView.TextoRazon = "";
            userView.Nombre = user.Nombre;
            userView.Edad = user.Edad.ToString();
            userView.Dni = user.Documento.ToString();
            userView.UserName = user.NombreUsuario;
            userView.Contraseña = user.Contraseña;
            userView.NivelAcceso = user.NivelAcceso;
            userView.Nacionalidad = user.Nacionalidad;            
        }

        public void LLamarBorrarUsuario(Usuario us)
        {

        }
    }
}
