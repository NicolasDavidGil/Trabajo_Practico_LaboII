using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2
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
        private int turnoJuego;
        private int acumulacionMasDos;
        private bool primerCartaMas;

        public Partida(DateTime fechaPartida, Usuario jug1, Usuario jug2)
        {
            this.fechaPartida = fechaPartida;
            this.jugadorUno = jug1;
            this.jugadorDos = jug2;
            this.mazo = new List<Carta>();
            this.mazoAux = new List<Carta>();
            this.cartaEnMesa = new("x", 0, "Negro");
            this.ganador = "vacio";
        }

        public Partida(DateTime fechaPartida, Usuario jugadorUno, Usuario jugadorDos, string ganador) : this(fechaPartida, jugadorUno, jugadorDos)
        {
            this.ganador = ganador;
        }

        public DateTime FechaPartida { get => fechaPartida; set => fechaPartida = value; }

        public Usuario JugadorUno { get => jugadorUno; set => jugadorUno = value; }

        public Usuario JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public Carta CartaMesa { get => cartaEnMesa; set => cartaEnMesa = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int TurnoJuego { get => turnoJuego; set => turnoJuego = value; }

        public List<Carta> Mazo { get => mazo; set => mazo = value; }

        public void JugarPartida(bool primera)
        {            
            int turnoAux = 0;           
            Carta aux;
            Carta auxReseteo;
            this.primerCartaMas = false;
            
            if (primera) //empieza 1er mano - Controlo carta que se da vuelta al azar
            {
                this.turnoJuego = ElegirMano();
                turnoAux = this.turnoJuego;
                this.mazo = BaseDatos.ObtenerMazo();
                RepartirCartas(); //las 2 manos y carta en mesa
                auxReseteo = this.cartaEnMesa;

                RecibirMasDos();
                RecibirMasCuatro();
                if(primerCartaMas)
                {
                    this.turnoJuego = AsignarTurno();
                }
                
                aux = JugarCartas();

                if (aux.SimboloCarta != "x")
                {
                    this.cartaEnMesa = aux;
                    this.mazoAux.Add(aux);
                    if (this.turnoJuego == 1)
                    {
                        this.JugadorUno.ManoJugador.Remove(aux);
                        this.turnoJuego = 2;
                    }
                    else
                    {
                        this.JugadorDos.ManoJugador.Remove(aux);
                        this.turnoJuego = 1;
                    }
                }
                else
                {
                    this.cartaEnMesa = auxReseteo;
                    aux = SacarCarta();
                    if (this.turnoJuego == 1)
                    {
                        this.JugadorUno.ManoJugador.Add(aux);
                    }
                    else
                    {
                        this.JugadorDos.ManoJugador.Add(aux);
                    }
                    aux = JugarCartas();
                    if (aux.SimboloCarta != "x")
                    {
                        this.cartaEnMesa = aux;
                        this.mazoAux.Add(aux);
                        if (this.turnoJuego == 1)
                        {
                            this.JugadorUno.ManoJugador.Remove(aux);
                            this.turnoJuego = 2;
                        }
                        else
                        {
                            this.JugadorDos.ManoJugador.Remove(aux);
                            this.turnoJuego = 1;
                        }
                    }
                }
                
            }
            else // Empieza aca a partir de la 2da mano en adelante
            {
                RecibirMasDos();
                RecibirMasCuatro();
                if (primerCartaMas)
                {
                    this.turnoJuego = AsignarTurno();
                }
                aux = JugarCartas(); //ACA QUEDAMOS

                if (aux.SimboloCarta != "x")
                {
                    this.cartaEnMesa = aux;
                    this.mazoAux.Add(aux);
                    if (this.turnoJuego == 1)
                    {
                        this.JugadorUno.ManoJugador.Remove(aux);
                    }
                    else
                    {
                        this.JugadorDos.ManoJugador.Remove(aux);
                    }
                }
                else
                {
                    aux = SacarCarta();
                    if (this.turnoJuego == 1)
                    {
                        this.JugadorUno.ManoJugador.Add(aux);
                    }
                    else
                    {
                        this.JugadorDos.ManoJugador.Add(aux);
                    }
                    aux = JugarCartas();
                    if (aux.SimboloCarta != "x")
                    {
                        this.cartaEnMesa = aux;
                        this.mazoAux.Add(aux);
                        if (this.turnoJuego == 1)
                        {
                            this.JugadorUno.ManoJugador.Remove(aux);
                        }
                        else
                        {
                            this.JugadorDos.ManoJugador.Remove(aux);
                        }
                    }
                    else
                    {
                        if(this.turnoJuego == 1)
                        {
                            this.turnoJuego = 2;
                        }
                        else
                        {
                            this.turnoJuego = 1;
                        }
                    }
                }                                
            }                   
        }

        public void RecibirMasDos()
        {
            Carta aux;
            if (this.cartaEnMesa.NumeroCarta == 22 && this.turnoJuego == 1) //Si primer carta es un +2
            {
                aux = SacarCarta();
                this.jugadorUno.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorUno.ManoJugador.Add(aux);
                this.mazo.Remove(aux);                
                this.cartaEnMesa.NumeroCarta = 1;
                this.cartaEnMesa.SimboloCarta = "n";
                this.primerCartaMas = true;
            }
            if(this.cartaEnMesa.NumeroCarta == 22 && this.turnoJuego == 2)
            {
                aux = SacarCarta();
                this.jugadorDos.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorDos.ManoJugador.Add(aux);
                this.mazo.Remove(aux);                
                this.cartaEnMesa.NumeroCarta = 1;
                this.cartaEnMesa.SimboloCarta = "n";
                this.primerCartaMas = true;
            }        
        }

        public void RecibirMasCuatro()
        {
            Carta aux;
            if (this.cartaEnMesa.NumeroCarta == -4 && this.turnoJuego == 1) //Si primer carta es un +4
            {                
                aux = SacarCarta();
                this.jugadorUno.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorUno.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorUno.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorUno.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                this.cartaEnMesa.NumeroCarta = -1;
                this.primerCartaMas = true;
            }

            if(this.cartaEnMesa.NumeroCarta == -4 && this.turnoJuego == 2)
            {                
                aux = SacarCarta();
                this.jugadorDos.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorDos.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorDos.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                aux = SacarCarta();
                this.jugadorDos.ManoJugador.Add(aux);
                this.mazo.Remove(aux);
                this.cartaEnMesa.NumeroCarta = -1;
                this.primerCartaMas = true;
            }   
        }

        public int ElegirMano()
        {
            Random random = new Random();
            int num = random.Next(1, 100);
            if (num % 2 == 0)
            {
                num = 1;
            }
            else
            {
                num = 2;
            }
            return num;
        }

        public int AsignarTurno()
        {
            int retorno;

            if (this.turnoJuego == 1 && !(this.cartaEnMesa.SimboloCarta == "p"  && this.cartaEnMesa.SimboloCarta == "s" ))
            {
                retorno = 2;
            }
            else
            {
                retorno = 1;
            }

            if (this.turnoJuego == 2 && !(this.cartaEnMesa.SimboloCarta == "p"  && this.cartaEnMesa.SimboloCarta == "s" ))
            {
                retorno = 1;
            }
            else
            {
                retorno = 2;
            }
            return retorno;
        }

        public Carta JugarCartas()
        {
            Carta aux = new("x", 1000, "Negro");
            Usuario auxJug;
                        
            if (this.turnoJuego == 2)
            {
                auxJug = this.JugadorDos;
            }
            else
            {
                auxJug = this.JugadorUno;
            }

            switch (this.CartaMesa.SimboloCarta)
            {
                case "n":
                    aux = RecibirNumero(auxJug);
                    break;
                case "p":
                    aux = RecibirPierdeTurno(auxJug);
                    break;
                case "s":
                    aux = RecibirSaltea(auxJug);
                    break;
                case "c":
                    if (this.CartaMesa.NumeroCarta == -1)
                    {
                        aux = RecibirCambioColor(auxJug);
                    }
                    break;
            }
            return aux;
        }
        private Carta RecibirNumero(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");

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
            return aux;
        }

        private Carta RecibirCambioColor(Usuario jug)
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

        private Carta RecibirPierdeTurno(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");
            
            foreach (Carta item in jug.ManoJugador)
            {
                if (item == this.cartaEnMesa)// pierde verde
                {
                    aux = item;
                    break;
                }
                else
                {
                    if (item.SimboloCarta == this.cartaEnMesa.SimboloCarta)
                    {
                        aux = item;
                        break;
                    }
                    else
                    {
                        if ((item.SimboloCarta == "s" || item.SimboloCarta == "n") && item.ColorCarta == this.cartaEnMesa.ColorCarta)
                        {
                            aux = item;
                            break;
                        }
                        else
                        {
                            if(item.ColorCarta == this.cartaEnMesa.ColorCarta && item.SimboloCarta == "m")
                            {
                                aux = item;
                                break;
                            }
                        }
                    }
                }                
            }          
            return aux;
        }
        private Carta RecibirSaltea(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");

            foreach (Carta item in jug.ManoJugador)
            {
                if (item == this.cartaEnMesa)
                {
                    aux = item;
                    break;
                }
                else
                {
                    if (item.SimboloCarta == this.cartaEnMesa.SimboloCarta)
                    {
                        aux = item;
                        break;
                    }
                    else
                    {
                        if ((item.SimboloCarta == "p" || item.SimboloCarta == "n") && item.ColorCarta == this.cartaEnMesa.ColorCarta)
                        {
                            aux = item;
                        }
                        else
                        {
                            if (item.ColorCarta == this.cartaEnMesa.ColorCarta && item.SimboloCarta == "m")
                            {
                                aux = item;
                                break;
                            }
                        }
                    }
                }              
            }
            return aux;
        }

        private Carta RecibirMasDosPropio(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");
            foreach (Carta item in jug.ManoJugador)
            {
                if (item.SimboloCarta == "m")
                {
                    aux = item;
                    break;
                }
                else
                {
                    if (item.ColorCarta == this.cartaEnMesa.ColorCarta)
                    {
                        aux = item;
                        break;
                    }
                    else
                    {
                        if (aux.SimboloCarta == "x" && item.SimboloCarta == "c")
                        {
                            aux = item;
                            break;
                        }
                    }
                }
            }
            return aux;
        }

        private Carta RecibirMasDosRival(Usuario jug)
        {
            Carta aux = new("x", 1000, "Negro");

            foreach (Carta item in jug.ManoJugador)
            {
                if (item.SimboloCarta == "m")// busco +2
                {
                    aux = item;
                    this.acumulacionMasDos += 2;
                    break;
                }
                else
                {
                    for (int i = 0; i < this.acumulacionMasDos; i++)
                    {
                        aux = SacarCarta();
                        jug.ManoJugador.Add(aux);
                        this.mazo.Remove(aux);
                    }
                    this.acumulacionMasDos = 2;
                    aux = this.cartaEnMesa;
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
                colorElejido = Validador.CompararColores(contadorA, contaddorV, contaddorR, contadorY);
            }
            return colorElejido;
        }


        public Carta SacarCarta()
        {
            Carta aux;
            Random r1 = new();
            int k;
            k = r1.Next(1, this.mazo.Count);

            aux = this.mazo[k];
            this.mazo.Remove(aux);

            return aux;
        }

        public void RepartirCartas()
        {
            this.jugadorUno.ManoJugador = CrearMano();
            this.jugadorDos.ManoJugador = CrearMano();
            this.cartaEnMesa = SacarCarta();
            this.mazoAux.Add(this.cartaEnMesa);
        }

        private List<Carta> CrearMano()
        {
            List<Carta> mano = new();

            for (int i = 0; i < 7; i++)
            {
                mano.Add(SacarCarta());
            }

            return mano;
        }
    }
}

