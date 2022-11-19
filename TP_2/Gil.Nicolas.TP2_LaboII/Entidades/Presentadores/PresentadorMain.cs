using Entidades.Interfaces;
using Entidades.Modelos;
using Entidades.Repositorios;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades.Presentadores
{
    public class PresentadorMain : PresentadorDeAcceso
    {
        IMainView _userView;
        public PresentadorMain(IMainView userView)
        {
            _userView = userView;
            //throw new ErrorBaseDatosException("Estamos teniendo dificultades al obtener los datos desde la base");
        }

        public override void LlenarDatos()
        {
            List<Usuario> misJugadores = new List<Usuario>();
            try
            {
                if (GameManager.misJugadores != null)
                {
                    GameManager.misJugadores.ForEach((x)=>misJugadores.Add(x));
                    foreach (Usuario us in GameManager.misJugadores)
                    {
                        if (us.NombreUsuario == GameManager.managerOn?.NombreUsuario)
                        {
                            misJugadores.Remove(us);
                        }
                    }
                    _userView.SetListInDataGrid(misJugadores);
                    if(GameManager.miHistorial != null)
                    _userView.SetMatchInDataGrid();
                }
            }
            catch(ErrorBaseDatosException ex)
            {
                EscribirEnChat(ex.Message);
            }            
        }

        public void EscribirEnChat(string str)
        {
            _userView.Chat = str;
        }       
    }
}
