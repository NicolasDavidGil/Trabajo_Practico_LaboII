using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public static class Validador
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
                    if (!char.IsLetter(cadena[i]) && char.IsWhiteSpace(cadena[i]) != true)
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
                    if (!char.IsLetter(cadena[i]) && !char.IsDigit(cadena[i]) && char.IsWhiteSpace(cadena[i]) != true)
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
    }
}
