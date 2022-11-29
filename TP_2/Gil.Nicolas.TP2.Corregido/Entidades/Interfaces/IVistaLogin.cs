using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVistaLogin
    {
        string Usuario { get; set; }
        string Contraseña { get; set; }
        string Error { get; set; }
    }
}
