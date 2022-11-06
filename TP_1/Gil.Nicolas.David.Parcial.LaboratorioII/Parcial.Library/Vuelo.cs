using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public class Vuelo
    {
        private int codigo;
        private string origen;
        private string fechaPartida;
        private string horaPartida;
        private string horaArribo;
        private int duracion;
        private int asientosLibresTurista;
        private int asientosLibresPrimera;
        private string estado;
        private string destinos;
        Aeronave aeronaveDesignada;
        List<Pasajero> pasajeroList;
        private float gananciaVuelo;

        public Vuelo(string origen, string destinos, string horaPartida, int duracion, int asientosLibresTurista,
                    string estado, int asientosLibresPrimera, Aeronave aeronaveDesignada, string fechaPartida, string horaArribo)
        {
            this.codigo = GetHashCode();
            this.origen = origen;
            this.destinos = destinos;
            this.horaPartida = horaPartida;
            this.duracion = duracion;
            this.asientosLibresTurista = asientosLibresTurista;
            this.estado = estado;
            this.asientosLibresPrimera = asientosLibresPrimera;
            this.aeronaveDesignada = aeronaveDesignada;
            this.fechaPartida = fechaPartida;
            this.horaArribo = horaArribo;            
            this.pasajeroList = new List<Pasajero>();
        }

        public Vuelo(string origen, string destinos, string horaPartida, int duracion, int asientosLibresTurista,
                    string estado, int asientosLibresPrimera, Aeronave aeronaveDesignada, string fechaPartida, string horaArribo, float ganancia) :
            this(origen, destinos, horaPartida, duracion, asientosLibresTurista, estado, asientosLibresPrimera, aeronaveDesignada, fechaPartida, horaArribo)
        {
            this.gananciaVuelo = ganancia;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public string Origen
        {
            get { return origen; }
        }

        public string Destinos
        {
            get { return destinos; }
        }
        public string HoraPartida
        {
            get { return horaPartida; }
        }
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int AsientosLibresT
        {
            get { return asientosLibresTurista; }
            set { asientosLibresTurista = value; }
        }
        public int AsientosLibresP
        {
            get { return asientosLibresPrimera; }
            set { asientosLibresPrimera = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public bool AeronaveEstado
        {
            get { return aeronaveDesignada.EstadoAvion; }
            set { aeronaveDesignada.EstadoAvion = value; }
        }
        public string AeronaveMatricula
        {
            get { return aeronaveDesignada.Matricula; }
        }

        public Aeronave AeronaveAsig
        {
            get { return aeronaveDesignada; }
            set { aeronaveDesignada = value; }
        }

        public List<Pasajero> ListaPasajero
        {
            get { return pasajeroList; }
            set { pasajeroList = value; }
        }
        public string HoraArribo
        {
            get { return horaArribo; }
            set { horaArribo = value; }
        }

        public string FechaPartida
        {
            get { return fechaPartida; }
            set { fechaPartida = value; }
        }

        public float Ganancia
        { 
            get { return gananciaVuelo; }
            set { gananciaVuelo = value; }
        }

        public override string ToString()
        {
            return ("Codigo: " + Codigo + "\nOrigen: " + Origen + "\nDestino: " + Destinos + "\nHora de partida: " + HoraPartida + 
                    "\nDuración: " + Duracion + "\nAsientos libres turista: " + AsientosLibresT + "\nAsientos libres primera: " + AsientosLibresP + 
                    "\nEstado: " + Estado + "\nEstado aeronave: " + AeronaveEstado + "\nMatricula aeronave: " + AeronaveMatricula + "\nHora arribo: " + 
                    HoraArribo + "\nFecha partida: " + FechaPartida + "\nGanancia: " + Ganancia);
        }
        public static void ReiniciarVuelo()
        {
            for (int i = 0; i < Aerolinea.vuelosActivos.Count; i++)
            {
                Aerolinea.vuelosActivos[i].AeronaveAsig.EstadoAvion = true;
            }
        }

        public static int CalcularDuracionVuelo(string destino)
        {
            Random duracion = new Random();
            int retorno;

            if (destino == "Miami" || destino == "Recife" || destino == "Roma" || destino == "Acapulco")
            {
                retorno = duracion.Next(8, 12);
            }
            else
            {
                retorno = duracion.Next(2, 4);
            }
            return retorno;
        }
        public static string CalcularHorarioLLegada(string horaSalida, string diaSalida, int duracionVuelo)
        {
            string horaLlegada = "Nada";
            int llegadaInt = 0;


            if (horaSalida is not null)
            {
                llegadaInt = int.Parse(horaSalida);
                llegadaInt += duracionVuelo;

                if (horaSalida.Contains('p'))
                {
                    if (llegadaInt > 12)
                    {
                        llegadaInt -= 12;
                        horaLlegada = llegadaInt.ToString() + ":00 am";
                    }
                    else
                    {
                        horaLlegada = llegadaInt.ToString() + ":00 pm";
                    }
                }
                else
                {
                    if (llegadaInt > 12)
                    {
                        llegadaInt -= 12;
                        horaLlegada = llegadaInt.ToString() + ":00 pm";
                    }
                    else
                    {
                        horaLlegada = llegadaInt.ToString() + ":00 am";
                    }
                }
            }
            return horaLlegada;
        }

        public static string CambiarFechaVuelo(string fecha)
        {
            DateTime fechaAux = new();

            fechaAux = DateTime.Parse(fecha);

            fechaAux.AddDays(1);

            return fechaAux.ToShortDateString();
        }

        public static float GananciasVuelo(List<Pasajero> lista)
        {
            float ganancias = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                ganancias += lista[i].PrecioVuelo;
            }              
            return ganancias;   
        }
    }
}
