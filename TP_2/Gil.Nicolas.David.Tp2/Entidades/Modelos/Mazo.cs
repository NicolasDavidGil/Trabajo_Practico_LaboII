using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Mazo
    {
        private List<Carta> miMazo;

        public Mazo()
        {
            this.miMazo = new List<Carta>();
        }

        public List<Carta> MiMazo { get => miMazo; set => miMazo = value; }

        public Carta Carta
        {
            get => default;
            set
            {
            }
        }
    }
}
