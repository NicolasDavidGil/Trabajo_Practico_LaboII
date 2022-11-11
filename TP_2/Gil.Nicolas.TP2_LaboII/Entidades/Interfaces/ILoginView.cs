using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ILoginView
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Error { get; set; }
        string Titulo { get; set; }
    }
}
