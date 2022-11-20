using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades.Repositorio
{
    public class RepositorioDeAcceso : RepositorioBase
    {
        public RepositorioDeAcceso()
        {

        }

        //Mazo
        public List<Carta> GetMazo()
        {
            List<Carta> miMazo = new List<Carta>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from MazoUno";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string simbolo = reader.GetString(0);
                        int numero = reader.GetInt32(1);
                        string color = reader.GetString(2);


                        Carta auxCarta = new(simbolo, numero, color);
                        miMazo.Add(auxCarta);
                    }
                }
            }
            return miMazo;
        }


        //Usuarios
        public List<Usuario> GetUsers()
        {
            List<Usuario> misUsuarios = new List<Usuario>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from UsuariosUno";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        int edad = reader.GetInt32(1);
                        int dni = reader.GetInt32(2);
                        string nacion = reader.GetString(3);
                        string user = reader.GetString(4);
                        string pass = reader.GetString(5);
                        string access = reader.GetString(6);
                        int puntaje = reader.GetInt32(7);
                        int victorias = reader.GetInt32(8);
                        int derrotas = reader.GetInt32(9);
                        int estado = reader.GetInt32(10);

                        Usuario auxUser = new(nombre, edad, dni, nacion, user, pass, access, puntaje, victorias, derrotas, estado);
                        misUsuarios.Add(auxUser);
                    }
                }
            }
            return misUsuarios;
        }

        public List<Usuario> GetUserByValue(string value) //35394776
        {
            List<Usuario> misUsuarios = new List<Usuario>();                      
            int documento = int.TryParse(value, out _) ? Convert.ToInt32(value) : -1;
            
            GetUsers().ForEach((x) =>
            {
                if (x.Nombre.ToLower().Contains(value.ToLower()) || x.NombreUsuario.ToLower().Contains(value.ToLower()) || 
                    x.Documento.ToString().Contains(documento.ToString()))
                {
                    misUsuarios.Add((Usuario)x);
                }
            });            
            return misUsuarios;
        }

        public List<Usuario> GetUserByScore()
        {
            List<Usuario> misUsuarios = new List<Usuario>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from UsuariosUno as p order by p.Puntaje desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        int edad = reader.GetInt32(1);
                        int dni = reader.GetInt32(2);
                        string nacion = reader.GetString(3);
                        string user = reader.GetString(4);
                        string pass = reader.GetString(5);
                        string access = reader.GetString(6);
                        int puntaje = reader.GetInt32(7);
                        int victorias = reader.GetInt32(8);
                        int derrotas = reader.GetInt32(9);
                        int estado = reader.GetInt32(10);

                        Usuario auxUser = new(nombre, edad, dni, nacion, user, pass, access, puntaje, victorias, derrotas, estado);
                        misUsuarios.Add(auxUser);
                    }
                }
            }
            return misUsuarios;
        }

        public bool AddUserInBase(Usuario nuevo)
        {
            bool retorno = false;

            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Insert into UsuariosUno values(@Nombre, @Edad, @Dni, @Nacion, @Apodo, @Pass," +
                    "@Acceso, @Puntaje, @Victorias, @Derrotas, @Estado)";
                command.Parameters.Clear();
                command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nuevo.Nombre;
                command.Parameters.Add("@Edad", SqlDbType.Int).Value = nuevo.Edad;
                command.Parameters.Add("@Dni", SqlDbType.Int).Value = nuevo.Documento;
                command.Parameters.Add("@Nacion", SqlDbType.VarChar).Value = nuevo.Nacionalidad;
                command.Parameters.Add("@Apodo", SqlDbType.VarChar).Value = nuevo.NombreUsuario;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = nuevo.Contraseña;
                command.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = nuevo.NivelAcceso;
                command.Parameters.Add("@Puntaje", SqlDbType.Int).Value = nuevo.Puntaje;
                command.Parameters.Add("@Victorias", SqlDbType.Int).Value = nuevo.Victorias;
                command.Parameters.Add("@Derrotas", SqlDbType.Int).Value = nuevo.Derrotas;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = nuevo.EstadoCuenta;

                command.ExecuteNonQuery();

                retorno = true;
            }
            return retorno;
        }

        public bool EditUserInBase(Usuario editado)
        {
            bool retorno = false;

            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Update UsuariosUno set(@Nacion, @Apodo, @Acceso)" +
                                        "where Documento = @dni";
                command.Parameters.Clear();                
                command.Parameters.Add("@Nacion", SqlDbType.VarChar).Value = editado.Nacionalidad;
                command.Parameters.Add("@Apodo", SqlDbType.VarChar).Value = editado.NombreUsuario;                
                command.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = editado.NivelAcceso;
                command.Parameters.Add("@dni", SqlDbType.VarChar).Value = editado.Documento.ToString();

                command.ExecuteNonQuery();

                retorno = true;
            }
            return retorno;
        }

        public bool BorrarUsuarioDeLaBase(Usuario aBorrar)
        {
            bool retorno = false;

            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Update UsuariosUno set(@Estado, @Puntaje, @Victorias, @Derrotas)" +
                                        "where Documento = @dni";
                command.Parameters.Clear();
                command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = aBorrar.EstadoCuenta;
                command.Parameters.Add("@Puntaje", SqlDbType.VarChar).Value = aBorrar.Puntaje;
                command.Parameters.Add("@Victorias", SqlDbType.VarChar).Value = aBorrar.Victorias;
                command.Parameters.Add("@Derrotas", SqlDbType.VarChar).Value = aBorrar.Derrotas;
                command.Parameters.Add("@dni", SqlDbType.VarChar).Value = aBorrar.Documento.ToString();

                command.ExecuteNonQuery();

                retorno = true;
            }
            return retorno;
        }

        //Partidas
        public List<Partida> GetMatchs()
        {
            List<Partida> historial = new List<Partida>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from HistorialUno";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fechaStr = reader.GetString(0);
                        string jugador1 = reader.GetString(1);
                        string jugador2 = reader.GetString(2);
                        string ganador = reader.GetString(3);
                        string tipoPartida = reader.GetString(4);
                        DateTime fecha = DateTime.Parse(fechaStr);                        
                        Usuario auxJug1 = new("", 0, 0, "", "", "", "", 0, 0, 0, 0);
                        Usuario auxJug2 = new("", 0, 0, "", "", "", "", 0, 0, 0, 0);

                        foreach (Usuario item in new RepositorioDeAcceso().GetUsers())
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
                        Partida auxPartida = new(fecha, auxJug1, auxJug2, ganador, tipoPartida);

                        historial.Add(auxPartida);
                    }
                }
            }
            return historial;
        }

        public void SaveMatch(Partida match)
        {
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Insert into HistorialUno values(@Date, @JugadorUno, @JugadorDos, @ganador, @tipo)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Date", match.FechaPartida.ToString());
                command.Parameters.AddWithValue("@JugadorUno", match.JugadorUno.NombreUsuario);
                command.Parameters.AddWithValue("@JugadorDos", match.JugadorDos.NombreUsuario);
                command.Parameters.AddWithValue("@ganador", match.Ganador);
                command.Parameters.AddWithValue("@tipo", match.TipoPartida);

                command.ExecuteNonQuery();
            }
        }

        //Paises
        public List<string> GetPaises()
        {
            List<string> misPaises = new List<string>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from PaisesUno";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string pais = reader.GetString(0);
                        int numero = reader.GetInt32(1);


                        string? auxPais = pais;
                        misPaises.Add(auxPais);
                    }
                }
            }
            return misPaises;
        }
    }
}
