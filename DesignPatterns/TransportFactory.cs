using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal static class TransportFactory
    {
        public static ITransport? CreateTransport(string type)
        {
            if (type == "sea")
            {
                return new Ship();
            }
            else if (type == "road-heavy" )
            {
                return new Truck();
            }
            else if (type == "road-light")
            {
                return new Truck();
            }
            else if (type == "air")
            {
                return new Aeroplane();
            }
            else
                return null;
        }
    }
}
