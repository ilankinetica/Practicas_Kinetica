using System;
using System.Text;
using System.Collections.Generic;


namespace ClassLibrary1
{

    #region Tipos
    enum TipoNumeroRomano
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

    public class ParEnteroRomano
    {
        public int ValorEntero { get; set; }
        public string RepresentacionRomana { get; set; }

    } 
    #endregion

    public class EnteroARomano
    {

        private List<ParEnteroRomano> _ListaEnteroRomano;

        private void Inicializar()
        {
            _ListaEnteroRomano = new List<ParEnteroRomano>()
            {
                new ParEnteroRomano()
                {
 //...1000
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.M),
                    RepresentacionRomana = TipoNumeroRomano.M.ToString()

                },

                new ParEnteroRomano()
                {
 //...900
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.CM),
                    RepresentacionRomana = TipoNumeroRomano.CM.ToString()

                },

                new ParEnteroRomano()
                {
 //...500
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.D),
                    RepresentacionRomana = TipoNumeroRomano.D.ToString()

                },

                new ParEnteroRomano()
                {
 //...400           
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.CD),
                    RepresentacionRomana = TipoNumeroRomano.CD.ToString()

                },

                new ParEnteroRomano()
                {
 //...100
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.C),
                    RepresentacionRomana = TipoNumeroRomano.C.ToString()

                },

                new ParEnteroRomano()
                {
 //...90
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.XC),
                    RepresentacionRomana = TipoNumeroRomano.XC.ToString()

                },

                new ParEnteroRomano()
                {
 //...50
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.L),
                    RepresentacionRomana = TipoNumeroRomano.L.ToString()

                },

                new ParEnteroRomano()
                {
 //...40
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.XL),
                    RepresentacionRomana = TipoNumeroRomano.XL.ToString()


                },

                new ParEnteroRomano()
                {
 //...10
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.X),
                    RepresentacionRomana = TipoNumeroRomano.X.ToString()

                },

                new ParEnteroRomano()
                {
 //...9
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.IX),
                    RepresentacionRomana = TipoNumeroRomano.IX.ToString()

                },

                new ParEnteroRomano()
                {
 //...5
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.V),
                    RepresentacionRomana = TipoNumeroRomano.V.ToString()

                },

                new ParEnteroRomano()
                {
 //...4
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.IV),
                    RepresentacionRomana = TipoNumeroRomano.IV.ToString()

                },

                new ParEnteroRomano()
                {
 //...1
                    ValorEntero = Convert.ToInt32(TipoNumeroRomano.I),
                    RepresentacionRomana = TipoNumeroRomano.I.ToString()

                }


            };


        }

        public EnteroARomano()
        {
            Inicializar();
        }

        public string ConvertirEnteroARomano(int numero)
        {
            if (numero < 1 || numero > 3000)
            {
                throw new IndexOutOfRangeException("El numero se encuentra fuera del rango esperado(1 - 3000).");
            }

            var builder = new StringBuilder();

            foreach (var par in _ListaEnteroRomano)
            {
                while (numero >= par.ValorEntero)
                {
                    builder.Append(par.RepresentacionRomana);
                    numero -= par.ValorEntero;
                }

            }

            return builder.ToString();
        }

        
    }
}