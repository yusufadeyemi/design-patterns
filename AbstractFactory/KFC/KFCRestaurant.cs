using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.KFC
{
    internal class KFCRestaurant : IRestuarant
    {
        public IBurger GetBurger()
        {
            return new KFCBurger();
        }

        public IRice GetRice()
        {
            return new KFCRice();
        }
    }
}
