using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Carta
    {
        //Atributos
        private string simbolo;
        private int numero;
        private string color;

        //Constructor
        public Carta(string simbolo, int numero, string color)
        {
            this.simbolo = simbolo;
            this.numero = numero;
            this.color = color;
        }
        //Propiedades
        public string SimboloCarta { get => simbolo; set => simbolo = value; }
        public int NumeroCarta { get => numero; set => numero = value; }
        public string ColorCarta { get => color; set => color = value; }
    }
}
