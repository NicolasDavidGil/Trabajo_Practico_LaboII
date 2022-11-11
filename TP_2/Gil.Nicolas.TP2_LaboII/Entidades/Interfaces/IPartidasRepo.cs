using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IPartidasRepo
    {
        void Add(Partida partida);

        List<Partida> GetAll();
        List<Partida> GetByValue(string value);
    }
}
