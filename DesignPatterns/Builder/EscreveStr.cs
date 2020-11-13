using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class EscreveStr
    {
        public string Texto(bool a, bool b, bool c)
        {
            Product produto = new Product();
            Director diretor = new Director();
            var builder = new ConcreteBuilder();
            diretor.Builder = builder;
            string str = "";

            if (a)
            {
                str += "A";
                
            }
            if (b)
            {
                str += "B";                
            }
            if (c)
            {
                str += "C";
            }            
            return str;
        }
    }
}
