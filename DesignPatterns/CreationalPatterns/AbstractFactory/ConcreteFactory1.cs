using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ConcreteProductA1();
        
        public IAbstractProductB CreateProductB() => new ConcreteProductB1();
    }
}
