using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2
{
    public class Carta
    {
        private string simboloCarta;
        private int numeroCarta;
        private string colorCarta;

        public Carta(string simboloCarta, int numeroCarta, string colorCarta)
        {
            this.simboloCarta = simboloCarta;
            this.numeroCarta = numeroCarta;
            this.colorCarta = colorCarta;
        }

        public string SimboloCarta { get => simboloCarta; set => simboloCarta = value; }
        public int NumeroCarta { get => numeroCarta; set => numeroCarta = value; }
        public string ColorCarta { get => colorCarta; }
    }
}
