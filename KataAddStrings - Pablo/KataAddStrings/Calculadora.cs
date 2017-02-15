using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAddStrings
{
    public class Calculadora
    {
        int num = 0;
        

        public int Add(string numeros)
        {
            int length = numeros.Length;
            char[] array = new char[length];
            array = numeros.ToCharArray();
            char del = ',';
            string concat;
                       
            if (numeros == "")
            {                
                num = 0;
                return num;
            }            

            if (array.Length == 1)
            {
                num = Convert.ToInt32(numeros);
                return num;
            }

            for (int i = 0; i < length; i++)
            {
                if (array[i] == '/')
                {
                    del = array[2];
                    i += 3;
                }

                if (array[i] != ',' && array[i] != del)
                {
                    if (array[i] == '-')
                    {
                        concat = array[i].ToString() + array[i + 1].ToString();
                        concat.ConvertirAEntero();
                    }

                    else
                    {
                        num += array[i].ConvertirAEntero();
                    }
                    
                }                           
            }

            return num;

           




        }
    }
}
