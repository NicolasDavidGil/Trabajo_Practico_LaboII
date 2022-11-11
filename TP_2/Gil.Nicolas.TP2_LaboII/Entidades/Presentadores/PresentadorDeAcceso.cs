using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades.Presentadores
{
    public abstract class PresentadorDeAcceso
    {
        public virtual void LlenarDatos()
        {

        }
        public virtual List<Usuario> ObtenerUsuariosDesdeBase()
        {
            return new List<Usuario>();
        }

        public virtual List<Partida> ObtenerHistorialDesdeBase()
        {
            return new List<Partida>();
        }

        public virtual List<Carta> ObtenerMazoDesdeBase()
        {
            return new List<Carta>();
        }

        public virtual void GuardarUsuariosEnBase(List<Usuario> usuarios)
        {

        }
        public virtual void GuardarHistorialEnBase(List<Usuario> usuarios)
        {

        }

    }
}
