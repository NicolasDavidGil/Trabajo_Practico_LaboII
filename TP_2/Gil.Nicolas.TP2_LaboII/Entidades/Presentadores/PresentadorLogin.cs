using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorios;
using Entidades.Excepciones;
using System;
using static System.Exception;
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
        private ILoginView vista;
        int k;

        public PresentadorLogin(ILoginView vista)
        {
            this.vista = vista;
            k = 0;          
            //throw new ErrorBaseDatosException("Se produjo un error en la base de Usuarios");
            //throw new DatosIncorrectosException("Los datos ingresados no son válidos");
        }

        public override void LlenarDatos()
        {
            List<Usuario> auxUser = new List<Usuario>();
            try
            {
                if (GameManager.misJugadores != null)
                {
                    foreach (Usuario it in GameManager.misJugadores)
                    {
                        if (it.NivelAcceso == "Admin")
                        {
                            auxUser.Add(it);
                        }
                    }
                    for (int i = k; i < auxUser.Count; i++)
                    {
                        vista.UserName = auxUser[i].NombreUsuario;
                        vista.Password = auxUser[i].Contraseña;
                        k++;
                        break;
                    }
                    if (k == auxUser.Count)
                    {
                        k = 0;
                    }
                }
            }
            catch(ErrorBaseDatosException ex)
            {
                vista.Error = ex.Message;
            }
        }
   
        public bool VerificarUsuario(string name, string pass)
        {            
            bool entro = false;
            try
            {
                if (GameManager.misJugadores != null)
                {
                    foreach (Usuario item in GameManager.misJugadores)
                    {
                        if ((name == item.NombreUsuario && pass == item.Contraseña) && item.NivelAcceso == "Admin")
                        {
                            entro = true;
                            GameManager.managerOn = item;
                            break;
                        }
                    }
                }
            }
            catch(DatosIncorrectosException ex)
            {
                vista.Error = ex.Message;
            }
            return entro;
        }
    }
}
