using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.KFC
{
    internal class KFCBurger : IBurger
    {
        public string GetBurgerName()
        {
            return "KFC Burger with beef and Cheese";
        }
    }
}
