using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2
{
    public class Usuario : Persona
    {
        private string userName;
        private string password;
        private string nivelAcceso;
        private int puntajeJugador;
        private int cantidadVictorias;
        private int cantidadDerrotas;
        List<Carta> manoEnUso;

             
        public Usuario(string nombre, int edad, int dni, string userName, string password, string nivelAcceso, int puntajeJugador, int cantidadVictorias, int cantidadDerrotas) 
                        : base(nombre, edad, dni)
        {
            this.userName = userName;
            this.password = password;
            this.nivelAcceso = nivelAcceso;
            this.puntajeJugador = puntajeJugador;
            this.cantidadVictorias = cantidadVictorias;
            this.cantidadDerrotas = cantidadDerrotas;
            this.manoEnUso = new List<Carta>();            
        }
        public string NivelAcceso { get => nivelAcceso; set => nivelAcceso = value; }

        public string Password { get => password; set => password = value; }

        public string NombreUsuario { get => userName; set => userName = value; }

        public int PuntajeJugador { get => puntajeJugador; set => puntajeJugador = value; }

        public int CantidadVictorias { get => cantidadVictorias; set => cantidadVictorias = value; }

        public int CantidadDerrotas { get => cantidadDerrotas; set => cantidadDerrotas = value; }

        public List<Carta> ManoJugador { get => manoEnUso; set => manoEnUso = value; }

    }
}
