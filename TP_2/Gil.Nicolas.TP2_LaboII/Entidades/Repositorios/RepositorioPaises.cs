using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class RepositorioPaises : RepositorioBase
    {
        public RepositorioPaises()
        {

        }

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
