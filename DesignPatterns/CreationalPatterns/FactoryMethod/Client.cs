using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class Client
    {
        public string FactoryMethod()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("App: Launched with the ConcreteCreator1.\r\n");
            sb.Append(ClientCode(new ConcreteCreator1()));
            sb.Append("\r\nApp: Launched with the ConcreteCreator2.");
            sb.Append(ClientCode(new ConcreteCreator1()));

            return sb.ToString();
        }

        public string ClientCode(Creator creator)
        {
            return "Client: I'm not aware of the creator's class," + "but it still works.\n" + creator.SomeOperation();
        }
    }
}
