using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades.Interfaces;
using Entidades.Modelos;

namespace Entidades.Repositorios
{
    public class RepositorioUsuarios : RepositorioBase, IUsuarioRepo
    {
        
        //Metodos
        public void Add(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Edit(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> misUsuarios = new List<Usuario>();            
            using (var conexion = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from UsuariosUno";
                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
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

        public List<Usuario> GetByValue(string value) //35394776
        {
            List<Usuario> misUsuarios = new List<Usuario>();
            string name = value;
            string userName = value;
            int documento = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText =   "Select * from UsuariosUno" +
                                        "where Nombre = @name or Usuario = @userName or Dni = @documento";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
                command.Parameters.Add("@documento", SqlDbType.Int).Value = documento;
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


        public List<Usuario> GetByScore()
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
    }
}
