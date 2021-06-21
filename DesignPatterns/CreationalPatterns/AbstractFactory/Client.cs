using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Client
    {
        public string AbstractFactory()
        { 
            StringBuilder sb = new StringBuilder();

            sb.Append("Client: Testing client code with the first factory type...\r\n");
            sb.Append(ClientMethod(new ConcreteFactory1()));
            sb.Append("\r\nClient: Testing the same client code with the second factory type...\r\n");
            sb.Append(ClientMethod(new ConcreteFactory2()));

            return sb.ToString();
        }

        private string ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            return productB.UsefulFunctionB() + productB.AnotherUsefulFunctionB(productA);
        }
    }
}

