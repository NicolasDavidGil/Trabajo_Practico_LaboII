using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Library
{
    public class Pasajero
    {
        Cliente clientePasajero;
        private string claseVuelo;
        private float equipajeBodega;
        private bool equipajeMano;        
        private int cantidadMaletas;
        private float precioVuelo;

        public Pasajero(string claseVuelo, float equipajeBodega, bool equipajeMano, int cantidadMaletas, Cliente clientePasajero)             
        {
            this.claseVuelo = claseVuelo;
            this.equipajeBodega = equipajeBodega;
            this.equipajeMano = equipajeMano;
            this.cantidadMaletas = cantidadMaletas;
            this.clientePasajero = clientePasajero;
        } 
        
        public Pasajero(string claseVuelo, float equipajeBodega, bool equipajeMano, int cantidadMaletas, Cliente clientePasajero, float precioVuelo) :
            this(claseVuelo, equipajeBodega, equipajeMano, cantidadMaletas, clientePasajero)
        {
            this.precioVuelo = precioVuelo;
        }

        public string ClienteNombre
        {
            get { return clientePasajero.NombrePersona; }
            set { clientePasajero.NombrePersona = value; }
        }

        public string ClienteDocumento
        {
            get { return clientePasajero.DocumentoPersona.ToString(); }
        }

        public string ClienteEdad
        {
            get { return clientePasajero.EdadPersona.ToString(); }
        }


        public string ClaseVuelo
        {
            get { return claseVuelo; }
        }

        public float EquipajeBodega
        {
            get { return equipajeBodega;}
            set { equipajeBodega = value; }
        }

        public bool EquipajeMano
        {
            get { return equipajeMano;}
        }
       
        public int CantidadMaletas
        {
            get { return cantidadMaletas; }
            set { cantidadMaletas = value; }
        }

        public float PrecioVuelo
        {
            get { return precioVuelo;}
            set { precioVuelo = value; }
        }

        public static float CalcularPrecioNeto(float precioBruto, string auxTipoPasajero)
        {
            float precioFinal;

            precioFinal = (float)(precioBruto * 1.21);

            if ("Primera".Equals(auxTipoPasajero))
            {
                precioFinal *= (float)1.15;                
            }
            return precioFinal;
        }

    }
}
