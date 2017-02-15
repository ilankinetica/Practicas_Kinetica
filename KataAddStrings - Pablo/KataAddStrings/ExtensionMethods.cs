using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAddStrings
{
    public static class ExtensionMethods
    {
        public static int ConvertirAEntero(this char x)
        {
            int a;

            a = (int)char.GetNumericValue(x);

            if (a < 0)
            {
                throw new Exception("No se permiten números negativos");
            }

            return a;

        }

        public static int ConvertirAEntero(this string x)
        {
            int a;

            a = Convert.ToInt32(x);

            //if (a < 0)
            //{
            //    throw new Exception("No se permiten números negativos: " + a);
            //}

            return a;


        }
    }
}
