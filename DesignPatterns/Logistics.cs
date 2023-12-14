using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Logistics
    {

        public void DispatchMessage(Package package)
        {
           
            string? typeofTransport = null;
            if(package.WeightInKg <= 10)
            {
                typeofTransport = "road-light";
            }
            else if (package.WeightInKg >= 11 && package.WeightInKg <=99)
            {
                typeofTransport = "road-heavy";
            }
            else if(package.WeightInKg >= 100 && package.WeightInKg <= 500)
            {
                typeofTransport = "air";
            }
            else
            {
                typeofTransport = "sea";
            }
            ITransport? transport = TransportFactory.CreateTransport(typeofTransport);
            transport?.Deliver(package.Name);
        }
      
    }

}
