using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Builder;

namespace DesignPatterns.Builder
{
    public class Director
    {
        public IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        
        public void _A()
        {
            this._builder.BuildPartA();
        }
        public void _B()
        {
            this._builder.BuildPartB();
        }
        public void _C()
        {
            this._builder.BuildPartC();
        }
        
    }
}
