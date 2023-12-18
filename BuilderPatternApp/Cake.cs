using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp
{
    internal class Cake
    {
        private List<string> _contents = new List<string>();

        public void AddFlavor(string flavor)
        {
            _contents.Add(flavor);
        }
        public string GetContentAsString()
        {
            return string.Join("|", _contents);
        }
    }
}
