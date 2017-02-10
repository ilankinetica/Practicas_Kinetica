using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanos
{
    public class DecimalARomano
    {
        #region Convertir con if
        public string ConvertirConIf(int n)
        {
            if (n <= 0) return null;

            string r = "";

            if (n.Entre(1, 10))
                r = HastaDiez(n);

            if (n.Entre(11, 20))
            {
                r = "X";
                r += HastaDiez(n - 10);
            }
            if (n.Entre(21, 30))
            {
                r = "XX";
                r += HastaDiez(n - 20);
            }
            if (n.Entre(31, 40))
            {
                r = "XXX";
                r += HastaDiez(n - 30);
            }
            
            return r;
        }

        public string HastaDiez(int n)
        {
            string r = "";

            if (n.Entre(1, 3))
                r = HastaTres(n);

            if (n == 4) r = "IV";

            if (n.Entre(5, 8))
            {
                r = "V";
                r += HastaTres(n - 5);
            }

            if (n == 9) r = "IX";

            if (n.Entre(10, 13))
            {
                r = "X";
                r += HastaTres(n - 10);
            }

            return r;
        }

        private string HastaTres(int resto)
        {
            var x = "";

            for (int i = 0; i < resto; i++)
            {
                x += "I";
            }

            return x;
        }
        #endregion
        #region Convertir como array
        public string ConvertirComoArray(int n)
        {
            var r = "";
            if (!n.Entre(1, 3999)) return null;

            var array = IntToArray(n);
            var length = array.Length;

            var numero = 73;


            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        r = Cadena(array[i], "I", "V", "X");
                        break;
                    case 1:
                        r = Cadena(array[i], "X", "L", "C") + r;
                        break;
                    case 2:
                        r = Cadena(array[i], "C", "D", "M") + r;
                        break;
                    case 3:
                        r = Cadena(array[i], "M", null, null) + r;
                        break;
                }
            }

            return r;
        }

        private int[] IntToArray(int n)
        {
            int length = n.ToString().Length;
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = n % 10;
                n /= 10;
            }

            return array;
        }

        private string Cadena(int n, string uno, string cinco, string diez)
        {
            if (n == 0) return null;

            string r = "";

            if (n.Entre(1, 3))
            {
                for (int i = 0; i < n; i++)
                {
                    r += uno;
                }
            }

            if (n == 4) r = uno + cinco;

            if (n.Entre(5, 8))
            {
                r = cinco;
                for (int i = 0; i < n - 5; i++)
                {
                    r += uno;
                }
            }

            if (n == 9) r = uno + diez;

            return r;
        }

        #endregion
    }
}
