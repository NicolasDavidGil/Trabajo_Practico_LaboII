using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Library
{
    public class Cliente : Persona
    {
        string direccion;
        string ciudad;
        string localidad;
        string nacionalidad;
        string estadoCivil;
        int cantidadVuelos;
        List<Vuelo> vueloConcurridos;

        public Cliente(string nombre, int documento, int edad, string direccion, string ciudad, string localidad, string nacionalidad, string estadoCivil, int cantidadVuelos)
            : base(nombre, documento, edad)
        {
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.localidad = localidad;
            this.nacionalidad = nacionalidad;
            this.estadoCivil = estadoCivil;
            this.cantidadVuelos = cantidadVuelos;
        }

        public Cliente(string nombre, int documento, int edad, string direccion, string ciudad, string localidad, string nacionalidad, string estadoCivil, int cantidadVuelos, List<Vuelo> vuelos)
           : base(nombre, documento, edad)
        {
            this.vueloConcurridos = vuelos;
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public string EstadoCivil
        {
            get { return estadoCivil;}
            set { estadoCivil = value; }
        }
        public int CantidadVuelos
        {
            get { return cantidadVuelos;}
            set { cantidadVuelos = value; }
        }
        public List<Vuelo> Vuelos
        {
            get { return vueloConcurridos; }
            set { vueloConcurridos = value; }
        }
    }



}
