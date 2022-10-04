using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public class Aeronave
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadBaños;
        private float capacidadBodega;
        private bool accesoWifi;
        private bool servicioCatering;
        private int asientosTurista;
        private int asientosPrimera;
        private bool vueloAsignado;
        private float tiempoDeVuelo;

        public Aeronave()
        {

        }
        public Aeronave(string matricula, int cantidadAsientos, int cantidadBaños, float capacidadBodega, bool accesoWifi, bool servicioCatering, float tiempoDeVuelo)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.capacidadBodega = capacidadBodega;
            this.accesoWifi = accesoWifi;
            this.servicioCatering = servicioCatering;
            this.tiempoDeVuelo = tiempoDeVuelo;
        }

        public Aeronave(string matricula, int cantidadAsientos, int cantidadBaños, float capacidadBodega, bool accesoWifi, 
                        bool servicioCatering, float tiempoVuelo, int asientosTurista, int asientosPrimera, bool vueloAsignado = false)
            : this(matricula, cantidadAsientos, cantidadBaños, capacidadBodega, accesoWifi, servicioCatering, tiempoVuelo)
        {
            this.asientosPrimera = asientosPrimera;
            this.asientosTurista = asientosTurista;
            this.vueloAsignado = vueloAsignado;           
        }

        public string Matricula
        {
            get { return matricula; }           
        }
        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
        }

        public int CantidadBaños
        {
            get { return cantidadBaños; }
        }

        public float CapacidadBodega
        {
            get { return capacidadBodega; }
        }

        public bool AccesoWifi
        {
            get { return accesoWifi; }
        }

        public bool ServicioCatering
        {
            get { return servicioCatering; }
        }

        public int AsientosTurista
        {
            get { return asientosTurista; }
            set { asientosTurista = value; }
        }

        public int AsientosPrimera
        {
            get { return asientosPrimera; }
            set { asientosPrimera = value; }
        }

        public bool EstadoAvion
        {
            get { return vueloAsignado; }
            set { vueloAsignado = value; }
        }
        public float TiempoVuelo
        {
            get { return tiempoDeVuelo; }
            set { tiempoDeVuelo = value; }
        }

        public override string ToString()
        {
            return ("Matricula: " + Matricula + "\nCantidad de asientos: " + CantidadAsientos + "\nCantidad de asientos primera: " + AsientosPrimera +
                    "\nCantidad de asientos turista: " + AsientosTurista + "\nCantidad de baños: " + CantidadBaños + "\n Tiempo de vuelo: " + TiempoVuelo +
                    "\nCapacidad de almacenamiento: " + CapacidadBodega);
        }
    }
}
