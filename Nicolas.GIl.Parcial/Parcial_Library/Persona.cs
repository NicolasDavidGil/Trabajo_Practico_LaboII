namespace Parcial_Library
{
    public class Persona
    {
        private string nombrePersona;
        private int documentoPersona;

        public Persona(string nombrePersona, int documentoPersona)
        {
            this.nombrePersona = nombrePersona;
            this.documentoPersona = documentoPersona;
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

    }
}