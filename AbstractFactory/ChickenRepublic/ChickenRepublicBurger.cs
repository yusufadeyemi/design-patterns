using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ChickenRepublic
{
    internal class ChickenRepublicBurger : IBurger
    {
        public string GetBurgerName()
        {
            return "Chicken Republic Burger with chicken and Cheese";
        }
    }
}
