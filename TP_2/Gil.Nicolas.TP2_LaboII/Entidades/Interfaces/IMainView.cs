using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IMainView
    {      
        string Chat { get; set; }
        void SetListInDataGrid(List<Usuario> miLista);
        void SetChat();
        void SetPlayerNames(); 
    }
}
