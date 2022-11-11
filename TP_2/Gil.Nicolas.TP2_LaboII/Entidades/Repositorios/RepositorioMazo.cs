using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class RepositorioMazo : RepositorioBase
    {
        public RepositorioMazo()
        {

        }

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
    }
}
