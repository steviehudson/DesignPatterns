using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod() => new ConcreteProduct2();
    }
}