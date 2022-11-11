using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class ArchivoTxT
    {
        public static string? ruta;

        public ArchivoTxT()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void EscribirTxt(string nombreArchivo, string datoAGuardar)
        {
            string rutaCompleta = ruta + nombreArchivo + ".txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    if (ruta is not null)
                    {
                        Directory.CreateDirectory(ruta);
                    }
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    sw.WriteLine(datoAGuardar);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir archivo en {rutaCompleta}", ex);
            }
        }
        public string LeerTxt(string nombreArchivo)
        {
            string rutaCompleta = ruta + nombreArchivo + ".txt";
            string dato = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    string line;

                    line = sr.ReadToEnd();

                    dato += "\n" + line;
                }
                return dato;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer archivo en {rutaCompleta}", ex);
            }
        }
    }
}
