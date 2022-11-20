using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Partida
    {
        private DateTime fechaPartida;
        private Usuario jugadorUno;
        private Usuario jugadorDos;
        private List<Carta> mazo;
        private List<Carta> mazoAux;
        private string ganador;
        private Carta cartaEnMesa;
        private Carta ultimaJugUno;
        private Carta ultimaJugDos;
        private int turnoJuego;
        private bool juegocarta;
        private bool primeraMano;
        private string tipoPartida;
        private int cantidadManos;

        public Partida(DateTime fechaPartida, Usuario jug1, Usuario jug2, string tipoPartida)
        {
            this.fechaPartida = fechaPartida;
            this.jugadorUno = jug1;
            this.jugadorDos = jug2;
            this.mazo = new List<Carta>();
            this.mazoAux = new List<Carta>();
            this.cartaEnMesa = new("x", 0, "Negro");
            this.ultimaJugUno = new("x", 0, "Negro");
            this.ultimaJugDos = new("x", 0, "Negro");
            this.ganador = "vacio";
            this.juegocarta = false;
            this.primeraMano = true;
            this.cantidadManos = 1;
            this.tipoPartida = tipoPartida;
        }

        public Partida(DateTime fechaPartida, Usuario jugadorUno, Usuario jugadorDos, string ganador, string partida) : this(fechaPartida, jugadorUno, jugadorDos, partida)
        {
            this.ganador = ganador;
        }

        public DateTime FechaPartida { get => fechaPartida; set => fechaPartida = value; }

        public Usuario JugadorUno { get => jugadorUno; set => jugadorUno = value; }

        public Usuario JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public Carta CartaMesa { get => cartaEnMesa; set => cartaEnMesa = value; }
        public Carta UltimaUno { get => ultimaJugUno; set => ultimaJugUno = value; }
        public Carta UltimaDos { get => ultimaJugDos; set => ultimaJugDos = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int TurnoJuego { get => turnoJuego; set => turnoJuego = value; }
        public List<Carta> Mazo { get => mazo; set => mazo = value; }
        public List<Carta> MazoAux { get => mazoAux; set => mazoAux = value; }
        public string TipoPartida { get => tipoPartida; set => tipoPartida = value; }
        public int CantidadManos { get => cantidadManos; set => cantidadManos = value; }

        public void EmpezarPartida()
        {
            this.turnoJuego = 1;
            Mazo newMazo = new Mazo();
            //newMazo = Serializadora<Mazo>.LeerJson("MazoCartas");
            //this.mazo = newMazo.MiMazo;
            this.mazo = new RepositorioDeAcceso().GetMazo();
            RepartirCartas();
            this.mazoAux.Add(cartaEnMesa);            
        }

        public void AnalizarTurnos()
        {
            if (tipoPartida == "Partida Completa")
            {
                JugarPartida();
                if (jugadorUno.ManoJugador.Count == 0)
                {
                    ganador = jugadorUno.NombreUsuario;
                }
                else
                {
                    if (jugadorDos.ManoJugador.Count == 0)
                    {
                        ganador = jugadorDos.NombreUsuario;
                    }
                }
            }
            else
            {
                if (cantidadManos <= 10)
                {
                    JugarPartida();
                }
                else
                {
                    if (jugadorUno.ManoJugador.Count > jugadorDos.ManoJugador.Count)
                    {
                        ganador = jugadorDos.NombreUsuario;
                    }
                    else
                    {
                        ganador = jugadorUno.NombreUsuario;
                    }
                }
            }
        }

        public void JugarPartida()
        {
            if (turnoJuego == 1)
            {
                if (cartaEnMesa == UltimaUno || primeraMano == false) //Si saltee al rival
                {
                    if (cartaEnMesa.NumeroCarta == -4)
                    {
                        cartaEnMesa.NumeroCarta = -1;
                    }
                    else if (cartaEnMesa.NumeroCarta == 22)
                    {
                        cartaEnMesa.NumeroCarta = 2;
                    }
                    else if (cartaEnMesa.SimboloCarta == "p" || cartaEnMesa.SimboloCarta == "s")
                    {
                        cartaEnMesa.SimboloCarta = "n";
                    }
                }
                JugarMano(jugadorUno);
            }
            else
            {
                if (cartaEnMesa == UltimaDos || primeraMano == false)
                {
                    if (cartaEnMesa.NumeroCarta == -4)
                    {
                        cartaEnMesa.NumeroCarta = -1;
                    }
                    else if (cartaEnMesa.NumeroCarta == 22)
                    {
                        cartaEnMesa.NumeroCarta = -1;
                    }
                    else if (cartaEnMesa.SimboloCarta == "p" || cartaEnMesa.SimboloCarta == "s")
                    {
                        cartaEnMesa.SimboloCarta = "n";
                    }
                }
                JugarMano(jugadorDos);
            }
            cantidadManos++;
        }
        public void JugarMano(Usuario jugador)
        {
            primeraMano = false;
            juegocarta = AnalizarCartaMesa(jugador);
            if (juegocarta)
            {
                ultimaJugUno = TirarCarta(jugador);
                if (ultimaJugUno.SimboloCarta != "x")
                {
                    cartaEnMesa = ultimaJugUno;
                    jugador.ManoJugador.Remove(CartaMesa);
                }
                else
                {
                    jugador.ManoJugador.Add(SacarCarta());
                }
            }
            CambiarTurno();
        }
        public bool AnalizarCartaMesa(Usuario esMano)
        {
            bool puedoJugar = false;
            if ((this.cartaEnMesa.SimboloCarta == "n" || cartaEnMesa.NumeroCarta == -1) || 
                (ultimaJugUno == cartaEnMesa && turnoJuego == 1) || (ultimaJugDos == cartaEnMesa && turnoJuego == 2))
            {
                puedoJugar = true;
            }
            else
            {
                    if (this.cartaEnMesa.NumeroCarta == -4)
                    {
                        RecibirMasCuatro(esMano);
                    }
                    else
                    {
                        if (this.cartaEnMesa.NumeroCarta == 22)
                            RecibirMasDos(esMano);
                    }                
            }
            return puedoJugar;
        }

        public void CambiarTurno()
        {
            if (this.turnoJuego == 1)
                this.turnoJuego = 2;
            else
                this.turnoJuego = 1;
        }

        public Carta TirarCarta(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");
            if (cartaEnMesa.ColorCarta != "Comodin")
            {
                foreach (Carta item in jug.ManoJugador)
                {
                    if ((item.SimboloCarta == "p" || item.SimboloCarta == "s") && item.ColorCarta == this.CartaMesa.ColorCarta)
                    {
                        aux = item;
                        break;
                    }
                    else
                    {
                        if ((item.SimboloCarta == "n" && item.ColorCarta == this.CartaMesa.ColorCarta) ||
                            (item.SimboloCarta == "n" && item.NumeroCarta == this.CartaMesa.NumeroCarta))
                        {
                            aux = item;
                        }
                        else
                        {
                            if (item.SimboloCarta == "m" && item.ColorCarta == this.CartaMesa.ColorCarta)
                            {
                                aux = item;
                            }
                            else
                            {
                                if (item.SimboloCarta == "c")
                                {
                                    aux = item;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                RecibirCambioColor(jug);
            }
            return aux;
        }

        public void RecibirMasDos(Usuario recibe)
        {
            for (int i = 0; i < 2; i++)
            {
                Carta aux = SacarCarta();
                recibe.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
            }
        }

        public void RecibirMasCuatro(Usuario recibe)
        {
            for (int i = 0; i < 4; i++)
            {
                Carta aux = SacarCarta();
                recibe.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
            }
        }


        public Carta RecibirCambioColor(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");
            string color = ElejirColor(jug);

            if (color != "false")
            {
                foreach (Carta item in jug.ManoJugador)
                {
                    if ((item.SimboloCarta == "p" || item.SimboloCarta == "s") && item.ColorCarta == color)
                    {
                        aux = item;
                        break;
                    }
                    else
                    {
                        if (item.SimboloCarta == "n" && item.ColorCarta == color)
                        {
                            aux = item;
                        }
                        else
                        {
                            if (item.SimboloCarta == "m" && item.ColorCarta == color)
                            {
                                aux = item;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Carta item in jug.ManoJugador)
                {
                    if (item.SimboloCarta == "p" || item.SimboloCarta == "s")
                    {
                        aux = item;
                        break;
                    }
                    else
                    {
                        if (item.SimboloCarta == "n")
                        {
                            aux = item;
                        }
                        else
                        {
                            if (item.SimboloCarta == "m")
                            {
                                aux = item;
                            }
                        }
                    }
                }
            }
            return aux;
        }


        public string ElejirColor(Usuario auxJug) //devuelve el color o false si no hay mayor
        {
            string colorElejido = "";
            int contaddorV = 0;
            int contaddorR = 0;
            int contadorA = 0;
            int contadorY = 0;

            for (int i = 0; i < auxJug.ManoJugador.Count; i++)
            {
                switch (auxJug.ManoJugador[i].ColorCarta)
                {
                    case "Rojo":
                        contaddorR++;
                        break;
                    case "Verde":
                        contaddorV++;
                        break;
                    case "Azul":
                        contadorA++;
                        break;
                    case "Amarillo":
                        contadorY++;
                        break;
                }
                colorElejido = CompararColores(contadorA, contaddorV, contaddorR, contadorY);
            }
            return colorElejido;
        }


        public static string CompararColores(int azul, int verde, int rojo, int amarillo)
        {
            string retorno = "false";
            if (azul != rojo && rojo != amarillo && azul != verde)
            {
                if (Math.Max(azul, verde) == azul && Math.Max(azul, rojo) == azul && Math.Max(azul, amarillo) == azul)
                {
                    retorno = "Azul";
                }
                if (Math.Max(azul, verde) == verde && Math.Max(verde, rojo) == verde && Math.Max(verde, amarillo) == verde)
                {
                    retorno = "Verde";
                }
                if (Math.Max(rojo, verde) == rojo && Math.Max(azul, rojo) == rojo && Math.Max(rojo, amarillo) == rojo)
                {
                    retorno = "Rojo";
                }
                if (Math.Max(amarillo, verde) == amarillo && Math.Max(amarillo, rojo) == amarillo && Math.Max(azul, amarillo) == amarillo)
                {
                    retorno = "Amarillo";
                }
            }
            return retorno;
        }


        public void RepartirCartas()
        {
            this.jugadorUno.ManoJugador = CrearMano();
            this.jugadorDos.ManoJugador = CrearMano();
            this.cartaEnMesa = SacarCarta();
            this.mazoAux.Add(this.cartaEnMesa);
        }

        public List<Carta> CrearMano()
        {
            List<Carta> mano = new();

            for (int i = 0; i < 7; i++)
            {
                mano.Add(SacarCarta());
            }

            return mano;
        }
        public Carta SacarCarta()
        {
            Carta aux;
            Random r1 = new();
            int k;
            k = r1.Next(0, this.mazo.Count);
            if (this.mazo.Count == 0)
            {
                mazoAux.ForEach((x) => mazo.Add(x));
                this.mazoAux.Clear();
                mazoAux.Add(cartaEnMesa);
            }
            aux = this.mazo[k];
            this.mazo.Remove(aux);

            return aux;
        }
    }
}
