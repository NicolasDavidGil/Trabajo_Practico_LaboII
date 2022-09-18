using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Library
{
    public class Pasajero : Persona
    {
        private string claseVuelo;
        private float equipajeBodega;
        private bool equipajeMano;
        private int edadPasajero;
        private int cantidadMaletas;
        public Pasajero(string claseVuelo, float equipajeBodega, bool equipajeMano, int edadPasajero, string nombrePasajero, int documentoPasajero, int cantidadMaletas) : base(nombrePasajero, documentoPasajero)
        {
            this.claseVuelo = claseVuelo;
            this.equipajeBodega = equipajeBodega;
            this.equipajeMano = equipajeMano;
            this.edadPasajero = edadPasajero;
            this.cantidadMaletas = cantidadMaletas;
        }

        public string ClaseVuelo
        {
            get { return claseVuelo; }
        }

        public float EquipajeBodega
        {
            get { return equipajeBodega;}
        }

        public bool EquipajeMano
        {
            get { return equipajeMano;}
        }

        public int EdadPasajero
        {
            get { return edadPasajero;}
        }

    }
}
