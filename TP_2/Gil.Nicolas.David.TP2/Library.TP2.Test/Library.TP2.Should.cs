using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2.Test
{
    [TestClass]
    public class Library
    {
        List<Usuario> listaTest = BaseDatos.ObtenerJugadores();
        Usuario user1;
        Usuario user2;
        Partida partidaTest;
        [TestMethod]

        //PartidaTest

        public void RecibirMasDosTest()
        {
            user1 = listaTest[0];
            user2 = listaTest[1];
            partidaTest = new(DateTime.Now, user1, user2);
            partidaTest.Mazo = BaseDatos.ObtenerMazo();
            partidaTest.RepartirCartas();
            Carta cartaPrueba1 = new("n", 22, "Rojo");
            Carta cartaPrueba2 = new("n", 22, "Rojo");
            Carta cartaPrueba3 = new("n", 5, "Rojo");

            partidaTest.CartaMesa = cartaPrueba1;
            partidaTest.TurnoJuego = 1;
            partidaTest.RecibirMasDos();

            Assert.IsTrue(partidaTest.JugadorUno.ManoJugador.Count > 7);

            partidaTest.CartaMesa = cartaPrueba2;
            partidaTest.TurnoJuego = 2;
            partidaTest.RecibirMasDos();

            Assert.IsTrue(partidaTest.JugadorDos.ManoJugador.Count > 7);

            partidaTest.CartaMesa = cartaPrueba3;
            partidaTest.TurnoJuego = 1;
            partidaTest.RecibirMasDos();

            Assert.IsTrue(partidaTest.JugadorUno.ManoJugador.Count == 9);
        }

        [TestMethod]
        public void RecibirMasCuatroTest()
        {
            user1 = listaTest[0];
            user2 = listaTest[1];
            partidaTest = new(DateTime.Now, user1, user2);
            partidaTest.Mazo = BaseDatos.ObtenerMazo();
            partidaTest.RepartirCartas();
            Carta cartaPrueba1 = new("n", 5, "Rojo");
            Carta cartaPrueba2 = new("n", -4, "Comodin");
            Carta cartaPrueba3 = new("n", -4, "Comodin");

            partidaTest.CartaMesa = cartaPrueba1;
            partidaTest.TurnoJuego = 1;
            partidaTest.RecibirMasCuatro();

            Assert.IsTrue(partidaTest.JugadorUno.ManoJugador.Count == 7);

            partidaTest.CartaMesa = cartaPrueba2;
            partidaTest.TurnoJuego = 2;
            partidaTest.RecibirMasCuatro();

            Assert.IsTrue(partidaTest.JugadorDos.ManoJugador.Count == 11);

            partidaTest.CartaMesa = cartaPrueba3;
            partidaTest.TurnoJuego = 1;
            partidaTest.RecibirMasCuatro();

            Assert.IsTrue(partidaTest.JugadorUno.ManoJugador.Count == 11);
        }

        [TestMethod]
        public void ElegirManoTest()
        {
            user1 = listaTest[0];
            user2 = listaTest[1];
            partidaTest = new(DateTime.Now, user1, user2);
            //GIVEN 
            int numeroPrueba;

            //WHEN

            numeroPrueba = partidaTest.ElegirMano();

            //THEN

            Assert.IsTrue(numeroPrueba >= 1);
            Assert.IsTrue(numeroPrueba <= 100);
        }

        [TestMethod]
        public void AsignarTurnoTest()
        {
            int numeroPrueba;

            Carta cartaPrueba1 = new("n", 4, "Rojo");
            partidaTest = new(DateTime.Now, user1, user2);
            partidaTest.TurnoJuego = 1;
            partidaTest.CartaMesa = cartaPrueba1;

            numeroPrueba = partidaTest.AsignarTurno();

            Assert.IsTrue(numeroPrueba == 2);

        }

        [TestMethod]
        public void SacarCartaTest()
        {
            Carta cartaPrueba1 = new("x", 1000, "Negro"); //No existe en el mazo
            partidaTest = new(DateTime.Now, user1, user2);
            partidaTest.Mazo = BaseDatos.ObtenerMazo();

            cartaPrueba1 = partidaTest.SacarCarta();

            Assert.IsFalse(partidaTest.Mazo.Contains(cartaPrueba1));
        }

        //[TestMethod]
        //public void RecibirNumeroTest()
        //{
        //    Carta cartaPrueba1 = new("n", 4, "Rojo");
        //    partidaTest = new(DateTime.Now, user1, user2);
        //    partidaTest.RepartirCartas();
        //}



        [TestMethod]
        public void CrearManoTest()
        {
            user1 = listaTest[0];
            user2 = listaTest[1];
            partidaTest = new(DateTime.Now, user1, user2);
            partidaTest.Mazo = BaseDatos.ObtenerMazo();
            partidaTest.RepartirCartas();

            Assert.IsTrue(partidaTest.CartaMesa is not null);

        }

        [TestMethod]
        public void RepartirCartasTest()
        {
            user1 = listaTest[0];
            user2 = listaTest[1];
            partidaTest = new(DateTime.Now, user1, user2);
            partidaTest.Mazo = BaseDatos.ObtenerMazo();

            partidaTest.RepartirCartas();

            Assert.IsTrue(partidaTest.JugadorUno.ManoJugador.Count > 0);
        }

    }
}
