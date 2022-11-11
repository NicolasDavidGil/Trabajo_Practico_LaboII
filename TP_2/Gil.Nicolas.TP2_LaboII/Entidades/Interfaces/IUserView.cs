using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IUserView
    {        
        string Nombre { get; set; }
        string Edad { get; set; }
        string Dni { get; set; }
        string Nacionalidad { get; set; }
        string UserName { get; set; }
        string Contraseña { get; set; }
        string NivelAcceso { get; set; }
        string Puntaje { get; set; }
        string TextoRazon { get; set; }
        string RazonEliminacion { get; set; }
        string EstadoCuenta { get; set; }
        string ValorBusqueda { get; set; }
        bool IsDone { get; set; }
        string Mensaje { get; set; }


        void SetListInDataGrid(List<Usuario> miLista);        
    }
}
