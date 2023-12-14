using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class LunchTime
    {
        private readonly IRestuarant restuarant;
        public LunchTime(IRestuarant restuarant) {
            this.restuarant = restuarant;
        }

        public void GetRice()
        {
            Console.WriteLine($"Placing order for rice : {restuarant.GetRice().GetRiceName()}");
        }

        public void GetBurger()
        {
            Console.WriteLine($"Placing order for burger : {restuarant.GetBurger().GetBurgerName()}");
        }
    }
}
