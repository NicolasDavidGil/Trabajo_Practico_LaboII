using Entidades.Modelos;
using Entidades.Repositorio;

namespace Entidades.Test
{
    [TestClass]
    public class PartidaShould
    {
        public static List<Usuario>? testUsers = new RepositorioDeAcceso().ObtenerUsuarios();
        public static Partida testPartida = new Partida(DateTime.Now, testUsers[0], testUsers[1], "Partida Completa");

        [TestMethod]
        public void EmpezarPartidaTest()
        {
            testPartida.EmpezarPartida();
            Assert.IsTrue(testPartida.TurnoJuego == 1);
            Assert.IsNotNull(testPartida.Mazo);
            Assert.IsTrue(testPartida.MazoAux.Count > 0);            
        }

        [TestMethod]
        public void RepartirCartasTest()
        {
            //no llamo al metodo porque ya se llamo dentro de EmpezarPartida

            Assert.IsTrue(testPartida.JugadorUno.ManoJugador.Count > 0);
            Assert.IsTrue(testPartida.JugadorDos.ManoJugador.Count > 0);
        }

        [TestMethod]

        public void SacarCartaTest()
        {
            //no llamo al metodo porque ya se llamo dentro de RepartirCartas

            Assert.IsTrue(testPartida.Mazo.Count < 108);
        }


        [TestMethod]

        public void AnalizarTurnoTest()
        {
            testPartida.AnalizarTurnos();

            Assert.IsTrue(testPartida.Ganador != "false");
        }

        [TestMethod]
        public void JugarPartidaTest()
        {            
            int manoJugadorUno = testPartida.JugadorUno.ManoJugador.Count;
            int manoJugadorDos = testPartida.JugadorDos.ManoJugador.Count;
            int cantidadManos = testPartida.CantidadManos;

            testPartida.AnalizarTurnos(); // este invoca a JugarPartida

            Assert.IsTrue(cantidadManos != testPartida.CantidadManos);
        }

        [TestMethod]
        public void CanbiarTurnoTest()
        {
            int turnoTest = testPartida.TurnoJuego;

            testPartida.CambiarTurno();

            Assert.IsFalse(turnoTest == testPartida.TurnoJuego);
        }

        [TestMethod]        
        public void RecibirMasDosTest()
        {
            int manoCount = testPartida.JugadorUno.ManoJugador.Count;

            testPartida.RecibirMasDos(testPartida.JugadorUno);

            Assert.IsTrue(testPartida.JugadorUno.ManoJugador.Count > manoCount);
        }


    }
}