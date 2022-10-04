using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public enum EClaseVuelo
    {
        Turista,
        Primera
    }
    public class Pasajero
    {           
        Cliente clientePasajero;
        private string claseVuelo;
        private float equipajeBodega;
        private bool equipajeMano;
        private int cantidadMaletas;
        private float precioVuelo;

        public Pasajero(string claseVuelo, float equipajeBodega, bool equipajeMano, int cantidadMaletas, Cliente clientePasajero, float precio)
        {
            this.claseVuelo = claseVuelo;
            this.equipajeBodega = equipajeBodega;
            this.equipajeMano = equipajeMano;
            this.cantidadMaletas = cantidadMaletas;
            this.clientePasajero = clientePasajero;
            this.precioVuelo = precio;
        }
        
        public string ClienteNombre
        {
            get { return clientePasajero.NombrePersona; }
        }

        public int ClienteDocumento
        {
            get { return clientePasajero.DocumentoPersona; }
        }

        public int ClienteEdad
        {
            get { return clientePasajero.EdadPersona; }
        }


        public string ClaseVuelo
        {
            get { return claseVuelo; }
        }

        public float EquipajeBodega
        {
            get { return equipajeBodega; }            
        }

        public bool EquipajeMano
        {
            get { return equipajeMano; }
        }

        public int CantidadMaletas
        {
            get { return cantidadMaletas; }            
        }

        public float PrecioVuelo
        {
            get { return precioVuelo; }            
        }

        public override int GetHashCode()
        {
            return ClienteDocumento;
        }
        public override string ToString()
        {
            return ("Nombre: " + ClienteNombre + "\nDocumento: " + ClienteDocumento + "\nEdad: " + ClienteEdad);
        }
        public static float CalcularPrecioVuelo(string destino, int duracion, string clase)
        {
            float precio;
            if (destino == "Recife" || destino == "Roma" ||
                destino == "Miami" || destino == "Acapulco")
            {
                precio = duracion * 100;         
            }else
            {
                precio = duracion * 50;
            }
            if (clase == "Primera")
            {
                precio *= (float)1.15;
            }
            return precio;
        }

    }
}
