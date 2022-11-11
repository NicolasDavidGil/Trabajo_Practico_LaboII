using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class RepositorioPartidas : RepositorioBase, IPartidasRepo
    {
        public RepositorioPartidas()
        {

        }

        public void Add(Partida partida)
        {
            throw new NotImplementedException();
        }

        public List<Partida> GetAll()
        {
            List<Partida> historial = new List<Partida>();
            using (var conexion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conexion.Open();
                command.Connection = conexion;
                command.CommandText = "Select * from HistorialPartidas";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fechaStr = reader.GetString(0);
                        string jugador1 = reader.GetString(1);
                        string jugador2 = reader.GetString(2);
                        string ganador = reader.GetString(3);
                        DateTime fecha = DateTime.Parse(fechaStr);
                        RepositorioUsuarios users = new RepositorioUsuarios();
                        Usuario auxJug1 = new("", 0, 0, "", "", "", "", 0, 0, 0, 0);
                        Usuario auxJug2 = new("", 0, 0, "", "", "", "", 0, 0, 0, 0);

                        foreach (Usuario item in users.GetAll())
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

                        historial.Add(auxPartida);
                    }
                }
            }
            return historial;
        }

        public List<Partida> GetByValue(string value)
        {
            List<Partida> miHistorial = this.GetAll();
            List<Partida> miHistorialRevisado = new List<Partida>();

            foreach (Partida item in miHistorial)
            {
                if((item.JugadorUno.Nombre == value || item.JugadorUno.NombreUsuario == value || item.JugadorUno.Documento.ToString() == value) ||
                   (item.JugadorDos.Nombre == value || item.JugadorDos.NombreUsuario == value || item.JugadorDos.Documento.ToString() == value))
                {
                    miHistorialRevisado.Add(item);
                }
            }
            return miHistorial;
        }
    }
}
