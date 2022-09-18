using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Library
{  
    public class Vuelo
    {
        private string codigo;
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


        public Vuelo(string codigo, string origen, string destinos, string horaPartida, int duracion, int asientosLibresTurista, 
                    string estado, int asientosLibresPrimera, Aeronave aeronaveDesignada, string fechaPartida, string horaArribo)
        {
            this.codigo = codigo;
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
        }
        public Vuelo(string codigo, string origen, string destinos, string horaPartida, int duracion, int asientosLibresTurista, string estado, int asientosLibresPrimera, 
                    Aeronave aeronaveDesignada, string fechaPartida, string horaArribo, List<Pasajero> pasajeroList) 
                    : this(codigo, origen, destinos, horaPartida, duracion, asientosLibresTurista, estado, asientosLibresPrimera, aeronaveDesignada, fechaPartida, horaArribo)
        {
            this.pasajeroList = pasajeroList;
        }


        public string Codigo
        {
            get { return codigo; }
        }

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public string Destinos
        {
            get { return destinos; }
            set { destinos = value; }
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

        public static string CalcularHorarioLLegada(string horaSalida, string diaSalida, int duracionVuelo)//17/09/2022 08:00 am
        {
            string horaLlegada = "Nada";           
            int llegadaInt = 0;
                        

            if(horaSalida is not null)
            {                                  
                llegadaInt = int.Parse(horaSalida);
                llegadaInt += duracionVuelo; // +12 am a pm o si pasa de dia)

                if (horaSalida.Contains('p'))
                {
                    if(llegadaInt > 12)
                    {
                        llegadaInt -= 12;
                        horaLlegada = llegadaInt.ToString() + ":00 am";                        
                    }else
                    {
                        horaLlegada = llegadaInt.ToString() + ":00 pm";// 11 + 3 = 14 -12 = 2
                    }
                }else
                {
                    if (llegadaInt > 12)
                    {
                        llegadaInt -= 12;
                        horaLlegada = llegadaInt.ToString() + ":00 pm";
                    }else
                    {
                        horaLlegada = llegadaInt.ToString() + ":00 am";
                    }
                }
            }            
            return horaLlegada;
        }

        public static string CambiarFechaVuelo(string fecha)
        {
            DateTime fechaAux = new DateTime();

            fechaAux = DateTime.Parse(fecha);

            fechaAux.AddDays(1);                      

            return fechaAux.ToShortDateString();
        }

    }
}
