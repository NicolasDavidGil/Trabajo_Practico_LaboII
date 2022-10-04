using System;
using System.Collections.Generic;
using Parcial.Library;

namespace Parcial.Library
{
    public static class Aerolinea
    {       
        public static Usuario vendedorActivo;
        public static List<Cliente> clienteHistorial = new();
        public static List<Vuelo> vuelosActivos = new();
        public static List<Vuelo> vuelosFinalizados = new();
        public static List<Aeronave> misAviones = new();
        public static List<string> misDestinos = new();        
        public static Dictionary<int, Usuario> Usuarios = new();
    }
}
