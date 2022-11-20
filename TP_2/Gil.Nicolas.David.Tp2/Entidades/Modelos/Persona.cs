using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;
        private int dni;
        private string nacionalidad;

        protected Persona(string nombre, int edad, int dni, string nacionalidad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.nacionalidad = nacionalidad;
        }

        //[Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Debe tener entre 3 y 50 caracteres")]
        public string Nombre { get => nombre; set => nombre = value; }

        //[Required(ErrorMessage = "La edad es obligatoria")]
        //[StringLength(3, MinimumLength = 1, ErrorMessage = "Debe tener entre 1 y 3 caracteres")]
        public int Edad { get => edad; set => edad = value; }

        //[Required(ErrorMessage = "El documento es obligatorio")]
        //[StringLength(8, MinimumLength = 7, ErrorMessage = "Debe tener 7 o 8 caracteres")]
        public int Documento { get => dni; set => dni = value; }

        // [DisplayN*/ame("País")]
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
