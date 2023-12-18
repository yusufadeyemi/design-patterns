using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ThreePortSocketAdapter
    {
        public ThreePinPlug threePinPlug { get; set; }

       public ThreePortSocketAdapter(TwoPinPlug twoPinPlug)
        {
            threePinPlug = new ThreePinPlug(twoPinPlug.Live, twoPinPlug.Neutral);

        }
    }
}
