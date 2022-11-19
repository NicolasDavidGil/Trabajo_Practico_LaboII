using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Usuario : Persona
    {
        private string nombreUsuario;
        private string contraseñaUsuario;
        private string nivelAcceso;
        private int puntaje;
        private int victorias;
        private int derrotas;
        private int estadoCuenta; // 1 Libre 0 ocupado -1 Eliminada
        private List<Carta> manoJugador;

        public Usuario(string nombre, int edad, int dni, string nacion,
                            string nombreUsuario, string contraseñaUsuario, string nivelAcceso,
                            int puntaje, int victorias, int derrotas, int estadoCuenta) :
                            base(nombre, edad, dni, nacion)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            this.nivelAcceso = nivelAcceso;
            this.puntaje = puntaje;
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.estadoCuenta = estadoCuenta;
            this.manoJugador = new List<Carta>();
        }

        //[DisplayName("Usuario")]
        //[Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        //[StringLength(25, ErrorMessage = "El máximo de caracteres es 25")]
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        //[Required(ErrorMessage = "La contraseña es obligatoria")]
        //[StringLength(25, ErrorMessage = "El máximo de caracteres es 25")]
        public string Contraseña { get => contraseñaUsuario; set => contraseñaUsuario = value; }

        public string NivelAcceso { get => nivelAcceso; set => nivelAcceso = value; }    
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int Victorias { get => victorias; set => victorias = value; }
        public int Derrotas { get => derrotas; set => derrotas = value; }
        public int EstadoCuenta { get => estadoCuenta; set => estadoCuenta = value; }

        public List<Carta> ManoJugador { get => manoJugador; set => manoJugador = value; }
    
    }
}
