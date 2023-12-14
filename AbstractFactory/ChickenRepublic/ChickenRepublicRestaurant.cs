using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ChickenRepublic
{
    internal class ChickenRepublicRestaurant : IRestuarant
    {
        public IBurger GetBurger()
        {
            return new ChickenRepublicBurger();
        }

        public IRice GetRice()
        {
            return new ChickenRepublicRice();
        }
    }
}
