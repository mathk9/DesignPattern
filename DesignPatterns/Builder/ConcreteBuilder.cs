using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Builder;

namespace DesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product;
        public string str = "";

        // Construtor
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            str += "A";
        }

        public void BuildPartB()
        {
            str += "B";
        }

        public void BuildPartC()
        {
            str += "C";
        }

        public Product GetProduct()
        {
            Product result = this._product;
;

            this.Reset();

            return result;
        }


    }
}
