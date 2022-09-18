using System;
using System.Collections.Generic;

namespace Parcial_Library
{
    public class Aerolinea
    {
        private int cantidadVuelosTotal;
        private int cantidadPasajerosTotal;
        private float cantidadRecaudacionTotal;
        private int codigoIrrepetible;        
        public static int index;

        public static List<Vendedor> listadoVendedores = new List<Vendedor>();
        public static Vendedor vendedorActivo;
        public static List<Vuelo> vuelosActivos = new List<Vuelo>();
        public static Aerolinea nuestraAerolinea = new Aerolinea(0, 0, 0, 1000);
        public static List<Aeronave> misAviones = new List<Aeronave>();
        public static List<string> misDestinos = new List<string>();
        public static List<string> clasesVuelo = new List<string>();

        public Aerolinea(int cantidadVuelosTotal, int cantidadPasajerosTotal, float cantidadRecaudacionTotal, int codigoIrrepetible)
        {
            this.cantidadVuelosTotal = cantidadVuelosTotal;
            this.cantidadPasajerosTotal = cantidadPasajerosTotal;
            this.cantidadRecaudacionTotal = cantidadRecaudacionTotal;
            this.codigoIrrepetible = codigoIrrepetible;
        }

        public static int CalcularDuracionVuelo(string destino)
        {
            Random duracion = new Random();
            int retorno;

            if(destino == "Miami" || destino == "Recife" || destino == "Roma" || destino == "Acapulco")
            {
                retorno = duracion.Next(8, 12);
            }else
            {
                retorno = duracion.Next(2, 4);
            }

            return retorno;
        }

        public static float CalcularRecaudacionTotal(List<Vuelo> vuelos)
        {
            int costoTotal;
            costoTotal = 0;

            for (int i = 0; i < vuelos.Count; i++)
            {
                costoTotal = 50 * vuelos[i].Duracion;
                costoTotal *= vuelos[i].ListaPasajero.Count;
                for(int j = 0; j < vuelos[i].ListaPasajero.Count; j++)
                {
                    if (vuelos[i].ListaPasajero[j].ClaseVuelo == "Primera")
                    {
                        costoTotal += (costoTotal * 15) / 100;
                    }
                }                
            }                        
            return costoTotal;
        }

        public static void ReiniciarVuelo()
        {
            for(int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                Aerolinea.vuelosActivos[i].AeronaveAsig.EstadoAvion = true;                
            }         
        }

        public int CantidadVuelos
        {
            get { return cantidadVuelosTotal; }
            set { cantidadVuelosTotal = value; }
        }
        public int Pasajeros
        {
            get { return cantidadPasajerosTotal; }
            set { cantidadPasajerosTotal = value; }
        }
        public float RecaudacionTotal
        {
            get { return cantidadRecaudacionTotal; }
            set { cantidadRecaudacionTotal = value; }
        }

        public int CodigoAerolinea
        {
            get { return codigoIrrepetible; }
            set { codigoIrrepetible = value; }
        }
    }
}
