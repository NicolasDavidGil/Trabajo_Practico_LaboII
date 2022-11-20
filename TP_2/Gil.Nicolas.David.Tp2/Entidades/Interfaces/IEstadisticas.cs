using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Modelos;

namespace Entidades.Interfaces
{
    public interface IEstadisticas
    {
        string Chat { get; set; }        
        string TopUno { get; set; }
        string TopDos { get; set; }
        string TopTres { get; set; }

        void SetDataGrid(List<Partida> list);
    }
}
