using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Truck : ITransport
    {
        public void Deliver(string message)
        {
            Console.WriteLine($"Truck Delivering {message}");
        }
    }
}
