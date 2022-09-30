using System;
using System.Collections.Generic;

namespace Parcial_Library
{
    public class Aerolinea
    {
        private string razonSocial;
        private int cantidadVuelosTotal;
        private int cantidadPasajerosTotal;
        private float cantidadRecaudacionTotal;
        private int codigoIrrepetible;
        private string destinoMasElejido;
        private int contadorDestino;
        public static int index = -1;
        public static int indexCliente = -1;
        public static int indexVendedor = -1;
        public static bool flagVentaNuevoCliente = false;

        public static Vendedor vendedorActivo;
        public static List<Cliente> clienteHistorial = new();
        public static List<Vuelo> vuelosActivos = new();
        public static List<Vuelo> vuelosFinalizados = new();
        public static Aerolinea nuestraAerolinea = new(0, 0, 0, 1000, "UTN AirLines S.R.L.", "Incierto", 0);
        public static List<Aeronave> misAviones = new();
        public static List<string> misDestinos = new();
        public static List<string> clasesVuelo = new();
        public static Dictionary<int, Vendedor> Usuarios = new();

        public Aerolinea(int cantidadVuelosTotal, int cantidadPasajerosTotal, float cantidadRecaudacionTotal, int codigoIrrepetible, string razonSocial, string destinoMasElejido, int contadorDestino)
        {
            this.cantidadVuelosTotal = cantidadVuelosTotal;
            this.cantidadPasajerosTotal = cantidadPasajerosTotal;
            this.cantidadRecaudacionTotal = cantidadRecaudacionTotal;
            this.codigoIrrepetible = codigoIrrepetible;
            this.razonSocial = razonSocial;
            this.destinoMasElejido = destinoMasElejido;
            this.contadorDestino = contadorDestino;
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

        public static float CalcularRecaudacionTotal()
        {
            float costoTotalActivos;
            float costoTotalFinalizados;                        
            costoTotalActivos = 0;
            costoTotalFinalizados = 0;

            for (int i = 0; i < vuelosActivos.Count; i++)
            {                         
                for(int j = 0; j < vuelosActivos[i].ListaPasajero.Count; j++)
                {
                    if (vuelosActivos[i].ListaPasajero[j].ClaseVuelo == "Primera")
                    {
                        costoTotalActivos += (vuelosActivos[i].PrecioVuelo * 15) / 100;
                    }
                    else
                    {
                        costoTotalActivos += vuelosActivos[i].PrecioVuelo;
                    }
                }
            }

            for (int i = 0; i < vuelosFinalizados.Count; i++)
            {
                if (vuelosFinalizados[i].ListaPasajero is not null)                    
                {
                    for (int j = 0; j < vuelosActivos[i].ListaPasajero.Count; j++)
                    {
                        if (vuelosActivos[i].ListaPasajero[j].ClaseVuelo == "Primera")
                        {
                            costoTotalFinalizados += (vuelosActivos[i].PrecioVuelo * 15) / 100;
                        }
                        else
                        {
                            costoTotalFinalizados += vuelosActivos[i].PrecioVuelo;
                        }
                    }
                }
            }
            return costoTotalActivos + costoTotalFinalizados;
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
        public string DestinoMasElejido
        {
            get { return destinoMasElejido; }
            set { destinoMasElejido = value; }
        }

        public int ContadosDestino
        {
            get { return contadorDestino; }
            set { contadorDestino = value; }
        }
    }
}
