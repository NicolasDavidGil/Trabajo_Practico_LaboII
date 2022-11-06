namespace Library.TP2
{
    public class Persona
    {
        private string nombrePersona;
        private int edadPersona;
        private int documentoPersona;

        protected Persona(string nombrePersona, int edadPersona, int documentoPersona)
        {
            this.nombrePersona = nombrePersona;
            this.edadPersona = edadPersona;
            this.documentoPersona = documentoPersona;
        }

        public string NombrePersona { get => nombrePersona; set => nombrePersona = value; }
        public int EdadPersona { get => edadPersona; set => edadPersona = value; }
        public int DocumentoPersona { get => documentoPersona; set => documentoPersona = value; }
    }
}