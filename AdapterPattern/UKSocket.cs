using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class UKSocket
    {
        /// <summary>
        /// the red for live current
        /// </summary>
        private readonly string _live;
        /// <summary>
        /// the black cable
        /// </summary>
        private readonly string _neutral;
        /// <summary>
        /// The green cable for earthing
        /// </summary>
        private readonly string? _earth;

        public UKSocket(string live, string neutral, string? earth)
        {
            this._live = live;
            this._neutral = neutral;
            this._earth = earth;
        }
        public UKSocket(ThreePinPlug threePinPlug):this(threePinPlug.Live, threePinPlug.Neutral, threePinPlug.Earth)
        {
        }
        public UKSocket(ThreePortSocketAdapter adapter): this(adapter.threePinPlug)
        {
        }

        public void SwitchOn()
        {
            Console.WriteLine($"{_live} is connected. {_neutral} is connected. {_earth} is connected ");
        }
    }
}
