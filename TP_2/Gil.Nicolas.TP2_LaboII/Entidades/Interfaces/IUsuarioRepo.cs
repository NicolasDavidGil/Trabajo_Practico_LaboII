using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IUsuarioRepo
    {
        void Add(Usuario usuario);
        void Edit(Usuario usuario);
        void Delete(Usuario usuario);

        List<Usuario> GetAll();
        List<Usuario> GetByValue(string value);
    }
}
