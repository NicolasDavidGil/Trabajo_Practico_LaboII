using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public class Cliente : Persona
    {
        string direccion;
        string ciudad;
        string localidad;
        string nacionalidad;
        string estadoCivil;
        int cantidadVuelos;
        float gastoTotal;

        public Cliente(string nombre, int documento, int edad, string direccion, string ciudad, string localidad, string nacionalidad, string estadoCivil, int cantidadVuelos)
            : base(nombre, documento, edad)
        {
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.localidad = localidad;
            this.nacionalidad = nacionalidad;
            this.estadoCivil = estadoCivil;
            this.cantidadVuelos = cantidadVuelos;
            this.gastoTotal = 0;
        }

        public string Direccion
        {
            get { return direccion; }            
        }

        public string Ciudad
        {
            get { return ciudad; }            
        }
        public string Localidad
        {
            get { return localidad; }           
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }          
        }
        public string EstadoCivil
        {
            get { return estadoCivil; }            
        }
        public int CantidadVuelos
        {
            get { return cantidadVuelos; }
            set { cantidadVuelos = value; }
        }
        public float GastoTotal
        {
            get { return gastoTotal; }
            set { gastoTotal = value; }
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            if(cliente is not null)
            {
                return cliente.DocumentoPersona == this.DocumentoPersona;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return DocumentoPersona;
        }
        public override string ToString()
        {
            return ("Nombre: " + NombrePersona + "\nEdad: " + EdadPersona + "\nDocumento: " + DocumentoPersona + 
                    "\nDirección: " + Direccion + "\nLocalidad: " + Localidad + "\nCiudad: " + Ciudad + "\nNacionalidad: " 
                    + Nacionalidad + "\nEstado Civil: " + EstadoCivil + "\nCantidad de vuelos: " + CantidadVuelos + "\nGasto total: " + GastoTotal);
        }

        public override void RealizarCalculos(float valor)
        {
            this.GastoTotal += valor;
        }
    }
}
