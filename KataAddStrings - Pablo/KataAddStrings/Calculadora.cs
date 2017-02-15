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
            string concat, error = string.Empty;
            //IList<int> intList = new List<int>();

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
                        error += concat + " , ";
                        //intList.Add(concat.ConvertirAEntero());                        
                        i++;
                    }

                    else
                    {
                        num += array[i].ConvertirAEntero();
                    }
                    
                }
                                     
            }

            if (array.Contains('-'))
            {
                throw new Exception("No se permiten números negativos: " + error);
            }

            //if (intList.Count > 0)
            //{

            //}

            return num;

           




        }
    }
}
