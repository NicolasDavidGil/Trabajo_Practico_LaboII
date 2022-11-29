using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVistaUsuarios
    {
        string NombreNuevo { get; set; }
        string EdadNuevo { get; set; }
        string DniNuevo { get; set; }
        string ApodoNuevo { get; set; }
        string ContraseñaNuevo { get; set; }
        string AccesoNuevo { get; set; }
        string NacionNuevo { get; set; }
        string NombreEditar { get; set; }
        string AccesoEditar { get; set; }
        string NacionEditar { get; set; }
        string NombreBorrar { get; set; }
        string EdadBorrar { get; set; }
        string DniBorrar { get; set; }
        string ApodoBorrar { get; set; }
        string PuntajeBorrar { get; set; }
        string RazonEliminacion { get; set; }
        string ValorBusqueda { get; set; }

        public event Action FiltrarDataGridEvento;

        void LlenarDataGridView();              
    }
}
