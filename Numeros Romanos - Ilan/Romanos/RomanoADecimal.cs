using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Romanos
{
    public class RomanoADecimal
    {
        private enum NumeroRomano
        {
            M = 1000,
            CM = 900,
            D = 500,
            CD = 400,
            C = 100,
            XC = 90,
            L = 50,
            XL = 40,
            X = 10,
            IX = 9,
            V = 5,
            IV = 4,
            I = 1
        }

        public int Convertir(string r)
        {
            var pattern = "^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

            if (!rgx.IsMatch(r))
                return 0;

            var array = r.ToCharArray();

            var i = 0;

            var agrupado = new List<string>();

            while (i < array.Length)
            {
                if (i == array.Length - 1)
                {
                    agrupado.Add(array[i].ToString());
                    i++;
                }
                else
                {
                    if (array[i].ValorRomano() > array[i + 1].ValorRomano())
                    {
                        agrupado.Add(array[i].ToString());
                        i++;
                    }
                    else if (array[i].ValorRomano() == array[i + 1].ValorRomano())
                    {
                        if (i + 2 < array.Length)
                        {
                            if (array[i].ValorRomano() == array[i + 2].ValorRomano())
                            {
                                agrupado.Add(array[i].ToString() + array[i + 1].ToString() + array[1 + 2].ToString());
                                i += 3;
                            }
                            else
                            {
                                agrupado.Add(array[i].ToString() + array[i + 1].ToString());
                                i += 2;
                            }
                        }
                        else
                        {
                            agrupado.Add(array[i].ToString() + array[i + 1].ToString());
                            i += 2;
                        }
                    }
                    else if (array[i].ValorRomano() < array[i + 1].ValorRomano())
                    {
                        agrupado.Add(array[i].ToString() + array[i + 1].ToString());
                        i += 2;
                    }
                }
            };

            var n = 0;

            foreach (var grupo in agrupado)
            {
                if (grupo.Length == 1)
                    n += grupo[0].ValorRomano();

                else if (grupo.Length == 2)
                {
                    if (grupo[0].ValorRomano() == grupo[1].ValorRomano())
                        n += grupo[0].ValorRomano() * 2;
                    else
                        n += (grupo[1].ValorRomano() - grupo[0].ValorRomano());
                }

                else if (grupo.Length == 3)
                    n += grupo[0].ValorRomano() * 3;
            }

            return n;
        }
    }
}
