using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.KFC
{
    internal class KFCRice : IRice
    {
        public string GetRiceName()
        {
            return "KFC Rice with crispy chicken";
        }
    }
}
