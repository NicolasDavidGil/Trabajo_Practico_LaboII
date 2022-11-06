using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public abstract class Persona
    {
        private string nombrePersona;
        private int documentoPersona;
        private int edadPersona;

        public Persona(string nombrePersona, int documentoPersona, int edadPersona)
        {
            this.nombrePersona = nombrePersona;
            this.documentoPersona = documentoPersona;
            this.edadPersona = edadPersona;
        }

        public string NombrePersona
        {
            get { return nombrePersona; }
            set { nombrePersona = value; }
        }

        public int DocumentoPersona
        {
            get { return documentoPersona; }
            set { documentoPersona = value; }
        }

        public int EdadPersona
        {
            get { return edadPersona; }
            set { edadPersona = value; }
        }

        public abstract void RealizarCalculos(float valor);      
    }
}
