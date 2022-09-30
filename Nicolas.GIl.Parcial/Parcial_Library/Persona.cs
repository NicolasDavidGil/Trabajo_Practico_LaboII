namespace Parcial_Library
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
        }

        public int DocumentoPersona
        {
            get { return documentoPersona; }
        }

        public int EdadPersona
        {
            get { return edadPersona; }
        }
    }
}