using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Product
    {

        public int EscolheImagem(string str)
        {
            var texto = new EscreveStr();
            //str = texto.Texto(a, b, c);
            var diretor = new Director();

            if (str.Contains("A") && !str.Contains("B") && !str.Contains("C")) //a
            {
                return 0;
            }
            else if (!str.Contains("A") && str.Contains("B") && !str.Contains("C")) //b
            {
                return 1;
            }
            else if (!str.Contains("A") && !str.Contains("B") && str.Contains("C")) //c
            {
                return 2;
            }
            else if (str.Contains("A") && str.Contains("B") && !str.Contains("C")) //ab
            {
                return 3;
            }
            else if (str.Contains("A") && !str.Contains("B") && str.Contains("C")) //ac
            {
                return 4;
            }
            else if (!str.Contains("A") && str.Contains("B") && str.Contains("C")) //bc
            {
                return 5;
            }
            else if (str.Contains("A") && str.Contains("B") && str.Contains("C")) //abc
            {
                return 6;
            }
            else
            {
                return 7;
            }

        }

                                
        }

    }

