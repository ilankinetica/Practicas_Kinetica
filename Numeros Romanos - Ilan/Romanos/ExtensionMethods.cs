using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanos
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Determina si el numero esta entre dos valores (inclusive ambos).
        /// </summary>
        /// <param name="valor">Valor a comparar</param>
        /// <param name="min">Mayor que</param>
        /// <param name="max">Menor que</param>
        /// <returns></returns>
        public static bool Entre(this int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        /// <summary>
        /// Devuelve el valor n en numeros romanos.
        /// </summary>
        /// <param name="n">Valor a convertir</param>
        /// <returns></returns>
        public static string DecimalARomanos(this int n)
        {
            var service = new DecimalARomano();
            return service.ConvertirComoArray(n);
        }

        public static int RomanoAdDecimal(this string r)
        {
            var service = new RomanoADecimal();
            return service.Convertir(r);
        }

        public static int ValorRomano(this char x)
        {
            switch (x)
            {
                case 'M':
                    return 1000;
                case 'D':
                    return 500;
                case 'C':
                    return 100;
                case 'L':
                    return 50;
                case 'X':
                    return 10;
                case 'V':
                    return 5;
                case 'I':
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
