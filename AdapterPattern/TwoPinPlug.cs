using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class TwoPinPlug
    {
        public  string Live { get; }
        public string  Neutral { get; }
        public TwoPinPlug(string live, string neutral)
        {
             Live = live;
            Neutral = neutral;
        }
    }
}
