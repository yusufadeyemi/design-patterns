using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ChickenRepublic
{
    internal class ChickenRepublicRice : IRice
    {
        public string GetRiceName()
        {
            return "Chicken Republic Rice with crispy chicken";
        }
    }
}
