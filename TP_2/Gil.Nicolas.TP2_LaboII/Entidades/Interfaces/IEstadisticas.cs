using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IEstadisticas
    {
        string ComboBox { get; set; }
        string LabelToStr { get; set; }
        string LabelPrimero { get; set; }
        string LabelSegundo { get; set; }
        string LabelTercero { get; set; }

        public void LlenarPodio();
        public void LlenarDataGrid();


    }
}
