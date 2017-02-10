using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsheroveStringCalculator
{
    public class StringCalculator
    {
        public int Add(string texto)
        {
            if (texto == "")
                return 0;

            var delimitersToAdd = new List<string>();
            var changeDelimiter = false;

            if (texto.Length > 2)
                changeDelimiter = (texto[0].ToString() + texto[1].ToString()) == "//";

            string textoSinDelimiter = texto;

            if (changeDelimiter)
            {
                if (texto[2] == '[')
                {
                    var siguienteEsDelimitador = true;
                    textoSinDelimiter = texto.Substring(2);

                    while (siguienteEsDelimitador)
                    {
                        textoSinDelimiter = textoSinDelimiter.Substring(1);

                        string actualDelimiter = "";
                        int index = 0;

                        while (textoSinDelimiter[index] != ']')
                        {
                            actualDelimiter += textoSinDelimiter[index].ToString();
                            index++;
                        };

                        delimitersToAdd.Add(actualDelimiter);
                        textoSinDelimiter = textoSinDelimiter.Substring(index + 1);

                        siguienteEsDelimitador = textoSinDelimiter[0] == '[';
                    };
                }
                else
                {
                    delimitersToAdd.Add(texto[2].ToString());
                    textoSinDelimiter = texto.Substring(3);
                }

            }

            delimitersToAdd.AddRange(new string[] { ",", "\n" });
            var array = textoSinDelimiter.Split(delimitersToAdd.ToArray(), StringSplitOptions.None);

            int suma = 0;
            var negatives = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                var n = Convert.ToInt32(array[i]);
                if (n < 0)
                    negatives.Add(n);
                else if (n <= 1000)
                    suma += n;
            }

            if (negatives.Count > 0)
            {
                string message = "";

                foreach (var negative in negatives)
                {
                    message += negative.ToString() + " - ";
                }

                throw new Exception("Numeros negativos: " + message);
            }


            return suma;
        }
    }
}
