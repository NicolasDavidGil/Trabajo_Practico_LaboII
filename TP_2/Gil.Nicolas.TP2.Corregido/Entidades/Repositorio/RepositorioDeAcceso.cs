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
        public List<Carta> ObtenerMazo()
        {
            List<Carta> miMazo = new List<Carta>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from Mazo";
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
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> misUsuarios = new List<Usuario>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from Usuarios";
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
        public List<Usuario> ObtenerUsuariosPorValor(string value) 
        {
            List<Usuario> misUsuarios = new List<Usuario>();                      
            int documento = int.TryParse(value, out _) ? Convert.ToInt32(value) : -1;
            
            ObtenerUsuarios().ForEach((x) =>
            {
                if (x.Nombre.ToLower().Contains(value.ToLower()) || x.NombreUsuario.ToLower().Contains(value.ToLower()) || 
                    x.Documento.ToString().Contains(documento.ToString()))
                {
                    misUsuarios.Add((Usuario)x);
                }
            });            
            return misUsuarios;
        }
        public List<Usuario> ObtenerUsuariosPorPuntaje()
        {
            List<Usuario> misUsuarios = new List<Usuario>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from Usuarios as p order by p.Puntaje desc";
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
        public bool AgregarUsuarioNuevo(Usuario nuevo)
        {
            bool retorno = false;
            int huboCambios = -1;

            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Insert into Usuarios (Nombre, Edad, Dni, Nacionalidad, Usuario, Contraseña, NivelAcceso, Puntaje, Victorias, Derrotas, EstadoCuenta)" +
                                        " values(@Nombre, @Edad, @Dni, @Nacion, @Apodo, @Pass, @Acceso, @Puntaje, @Victorias, @Derrotas, @Estado)";                
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                command.Parameters.AddWithValue("@Edad", nuevo.Edad);
                command.Parameters.AddWithValue("@Dni", nuevo.Documento);
                command.Parameters.AddWithValue("@Nacion", nuevo.Nacionalidad);
                command.Parameters.AddWithValue("@Apodo", nuevo.NombreUsuario);
                command.Parameters.AddWithValue("@Pass", nuevo.Contraseña);
                command.Parameters.AddWithValue("@Acceso", nuevo.NivelAcceso);
                command.Parameters.AddWithValue("@Puntaje", 0);
                command.Parameters.AddWithValue("@Victorias", 0);
                command.Parameters.AddWithValue("@Derrotas", 0);
                command.Parameters.AddWithValue("@Estado", 1);

                huboCambios = command.ExecuteNonQuery();

                if(huboCambios > 0)
                    retorno = true;
            }
            return retorno;
        }
        public bool EditarUsuario(Usuario editado)
        {
            bool retorno = false;
            int huboCambios = -1;

            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "UPDATE Usuarios SET Nombre = @Nombre, Edad = @Edad, Dni = @Dni, Nacionalidad = @Nacion, Usuario = @Apodo, Contraseña = @Pass, " +
                                                             "NivelAcceso = @Acceso, Puntaje = @Puntaje, Victorias = @Victorias, Derrotas = @Derrotas, EstadoCuenta = @Estado" +
                                        " WHERE Dni = @dni";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", editado.Nombre);
                command.Parameters.AddWithValue("@Edad", editado.Edad);
                command.Parameters.AddWithValue("@Dni", editado.Documento);
                command.Parameters.AddWithValue("@Nacion", editado.Nacionalidad);
                command.Parameters.AddWithValue("@Apodo", editado.NombreUsuario);
                command.Parameters.AddWithValue("@Pass", editado.Contraseña);
                command.Parameters.AddWithValue("@Acceso", editado.NivelAcceso);
                command.Parameters.AddWithValue("@Puntaje", editado.Puntaje);
                command.Parameters.AddWithValue("@Victorias", editado.Victorias);
                command.Parameters.AddWithValue("@Derrotas", editado.Derrotas);
                command.Parameters.AddWithValue("@Estado", editado.EstadoCuenta);
                

                huboCambios = command.ExecuteNonQuery();
                
                if(huboCambios > 0)
                    retorno = true;
            }
            return retorno;
        }
        public bool BorrarUsuarioDeLaBase(Usuario aBorrar)
        {
            bool retorno = false;
            int huboCambios = -1;

            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "UPDATE Usuarios SET EstadoCuenta = @Estado, Puntaje = @Puntaje, Victorias = @Victorias, Derrotas = @Derrotas WHERE Dni = @dni";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@dni", aBorrar.Documento);
                command.Parameters.AddWithValue("@Estado", aBorrar.EstadoCuenta);
                command.Parameters.AddWithValue("@Puntaje", aBorrar.Puntaje);
                command.Parameters.AddWithValue("@Victorias", aBorrar.Victorias);
                command.Parameters.AddWithValue("@Derrotas", aBorrar.Derrotas);
                

                huboCambios = command.ExecuteNonQuery();

                if(huboCambios > 0)
                    retorno = true;
            }
            return retorno;
        }
        //Partidas
        public List<Partida> ObtenerHistorial()
        {
            List<Partida> historial = new List<Partida>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from Historial";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime fecha = reader.GetDateTime(0);
                        string jugador1 = reader.GetString(1);
                        string jugador2 = reader.GetString(2);
                        string ganador = reader.GetString(3);
                        string tipoPartida = reader.GetString(4);                     
                        Usuario auxJug1 = new("", 0, 0, "", "", "", "", 0, 0, 0, 0);
                        Usuario auxJug2 = new("", 0, 0, "", "", "", "", 0, 0, 0, 0);

                        foreach (Usuario item in new RepositorioDeAcceso().ObtenerUsuarios())
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
        public void SalvarPartida(Partida match)
        {
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Insert into Historial values(@Date, @JugadorUno, @JugadorDos, @ganador, @tipo)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Date", match.FechaPartida);
                command.Parameters.AddWithValue("@JugadorUno", match.JugadorUno.NombreUsuario);
                command.Parameters.AddWithValue("@JugadorDos", match.JugadorDos.NombreUsuario);
                command.Parameters.AddWithValue("@ganador", match.Ganador);
                command.Parameters.AddWithValue("@tipo", match.TipoPartida);

                command.ExecuteNonQuery();
            }
        }
        //Paises
        public List<string> ObtenerPaises()
        {
            List<string> misPaises = new List<string>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from Paises";
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
