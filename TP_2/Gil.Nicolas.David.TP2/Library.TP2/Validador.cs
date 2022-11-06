using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TP2
{
    public class Validador
    {
        public static bool ValidarIngresoNumero(string numero)
        {
            bool validado = false;

            if (numero is not null && ValidarNumero(numero))
            {
                validado = true;
            }

            return validado;
        }
        public static bool ValidadarIngresaString(string cadena)
        {
            bool validador = false;

            if (cadena is not null && ValidarLetra(cadena))
            {
                validador = true;
            }
            return validador;
        }

        public static bool ValidarIngresoCodigo(string cadena)
        {
            bool validador = false;

            if (cadena is not null && ValidarNumeroYLetra(cadena))
            {
                validador = true;
            }
            return validador;
        }

        private static bool ValidarLetra(string cadena)
        {
            bool validacionLetra = true;

            if (cadena is not null)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (!char.IsLetter(cadena[i]))
                    {
                        validacionLetra = false;
                        break;
                    }
                }
            }
            return validacionLetra;
        }

        private static bool ValidarNumeroYLetra(string cadena)
        {
            bool validacionLetra = true;

            if (cadena is not null)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (!char.IsLetter(cadena[i]) && !char.IsDigit(cadena[i]))
                    {
                        validacionLetra = false;
                        break;
                    }
                }
            }
            return validacionLetra;
        }

        private static bool ValidarNumero(string ingresoAValidar)
        {
            bool validacion = false;
            float numero;

            if (ingresoAValidar is not null)
            {
                if (float.TryParse(ingresoAValidar, out numero))
                {
                    validacion = true;
                }
            }
            return validacion;
        }

        public static string CompararColores(int azul, int verde, int rojo, int amarillo)
        {
            string retorno = "false";
            if (azul != rojo && rojo != amarillo && azul != verde)
            {
                if (Math.Max(azul, verde) == azul && Math.Max(azul, rojo) == azul && Math.Max(azul, amarillo) == azul)
                {
                    retorno = "Azul";
                }
                if (Math.Max(azul, verde) == verde && Math.Max(verde, rojo) == verde && Math.Max(verde, amarillo) == verde)
                {
                    retorno = "Verde";
                }
                if (Math.Max(rojo, verde) == rojo && Math.Max(azul, rojo) == rojo && Math.Max(rojo, amarillo) == rojo)
                {
                    retorno = "Rojo";
                }
                if (Math.Max(amarillo, verde) == amarillo && Math.Max(amarillo, rojo) == amarillo && Math.Max(azul, amarillo) == amarillo)
                {
                    retorno = "Amarillo";
                }
            }
            return retorno;
        }
    }
}

