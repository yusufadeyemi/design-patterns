using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ThreePinPlug
    {
        public string Live;
        public string Neutral;
        public string? Earth;
        public ThreePinPlug(string live, string neutral):this(live, neutral, null) {
        }
        public ThreePinPlug(string live, string neutral, string? earth)
        {
            Live = live;
            Neutral = neutral;
            Earth = earth;
        }
    }
}
