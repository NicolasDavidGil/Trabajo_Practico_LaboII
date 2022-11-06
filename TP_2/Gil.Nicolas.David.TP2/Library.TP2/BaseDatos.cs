using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2
{
    public class BaseDatos
    {
        public static List<Usuario> ObtenerJugadores()
        {
            List<Usuario> jugadoresActivos = new();

            string connectionString = "Server = .\\; Database = Gil.Nicolas.TP2; Trusted_Connection = True;";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Usuarios";

            SqlDataReader reader = command.ExecuteReader();

            jugadoresActivos.Clear();
            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                int edad = reader.GetInt32(1);
                int dni = reader.GetInt32(2);            
                string apodo = reader.GetString(3);
                string contraseña = reader.GetString(4);
                string acceso = reader.GetString(5);
                int puntaje = reader.GetInt32(6);
                int victorias = reader.GetInt32(7);
                int derrotas = reader.GetInt32(8);

                Usuario auxJugador = new(nombre, edad, dni, apodo, contraseña, acceso, puntaje, victorias, derrotas);

                jugadoresActivos.Add(auxJugador);
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

            return jugadoresActivos;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> jugadoresActivos = new();

            string connectionString = "Server = .\\; Database = Gil.Nicolas.TP2; Trusted_Connection = True;";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Usuarios";

            SqlDataReader reader = command.ExecuteReader();

            jugadoresActivos.Clear();
            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                int edad = reader.GetInt32(1);
                int dni = reader.GetInt32(2);
                string apodo = reader.GetString(3);
                string contraseña = reader.GetString(4);
                string acceso = reader.GetString(5);
                int puntaje = reader.GetInt32(6);
                int victorias = reader.GetInt32(7);
                int derrotas = reader.GetInt32(8);

                Usuario auxJugador = new(nombre, edad, dni, apodo, contraseña, acceso, puntaje, victorias, derrotas);

                jugadoresActivos.Add(auxJugador);
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

            return jugadoresActivos;
        }

        public static bool AgregarUsuario(Usuario newPlayer)
        {
            bool retorno = false;

            try
            {
                SqlConnection connection = new SqlConnection("Server = .\\; Database = Gil.Nicolas.TP2; Trusted_Connection = True;");

                connection.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                //nombre, edad, dni, apodo, contraseña, acceso, puntaje, victorias, derrotas
                command.CommandText = "INSERT INTO Usuarios VALUES(@Nombre, @Edad, @Documento, @ApodoJugador, @Contraseña, @Acceso " +
                                                                "@PuntajeJugador, @CantidadVictorias, @CantidadDerrotas)";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", newPlayer.NombrePersona);
                command.Parameters.AddWithValue("@Edad", newPlayer.EdadPersona);
                command.Parameters.AddWithValue("@Documento", newPlayer.DocumentoPersona);
                command.Parameters.AddWithValue("@ApodoJugador", newPlayer.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", newPlayer.Password);
                command.Parameters.AddWithValue("@Acceso", newPlayer.NivelAcceso);
                command.Parameters.AddWithValue("@PuntajeJugador", newPlayer.PuntajeJugador);
                command.Parameters.AddWithValue("@CantidadVictorias", newPlayer.CantidadVictorias);
                command.Parameters.AddWithValue("@CantidadDerrotas", newPlayer.CantidadDerrotas);

                command.ExecuteNonQuery();

                retorno = true;

                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {

            }
            return retorno;
        }

        public static List<Carta> ObtenerMazo()
        {
            List<Carta> miMazo = new();

            string connectionString = "Server = .\\; Database = Gil.Nicolas.TP2; Trusted_Connection = True;";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Mazo";

            SqlDataReader reader = command.ExecuteReader();

            miMazo.Clear();
            while (reader.Read())
            {
                string letraCarta = reader.GetString(0);
                int numeroCarta = reader.GetInt32(1);
                string colorCarta = reader.GetString(2);

                Carta auxCarta = new(letraCarta, numeroCarta, colorCarta);

                miMazo.Add(auxCarta);
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

            return miMazo;
        }

        public static List<Partida> ObtenerHistorialPartidas()
        {
            List<Partida> miPartida = new();

            string connectionString = "Server = .\\; Database = Gil.Nicolas.TP2; Trusted_Connection = True;";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM HistorialPartidas";

            SqlDataReader reader = command.ExecuteReader();

            miPartida.Clear();
            while (reader.Read())
            {
                DateTime fecha = reader.GetDateTime(0);
                string jugador1 = reader.GetString(1);
                string jugador2 = reader.GetString(2);
                string ganador = reader.GetString(3);
                Usuario auxJug1 = new("", 0, 0, "", "", "", 0, 0, 0);
                Usuario auxJug2 = new("", 0, 0, "", "", "", 0, 0, 0);

                foreach (Usuario item in ObtenerUsuarios())
                {
                    if (item.NombreUsuario == jugador1)
                    {
                        auxJug1 = item;
                    }
                    if (item.NombreUsuario == jugador2)
                    {
                        auxJug2 = item;
                    }
                }

                Partida auxPartida = new(fecha, auxJug1, auxJug2, ganador);

                miPartida.Add(auxPartida);
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return miPartida;
        }
    }
}

