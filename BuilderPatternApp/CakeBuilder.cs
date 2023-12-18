using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp
{
    internal class CakeBuilder
    {
        private Cake _cake = new Cake();

        public CakeBuilder AddChocolote()
        {
            _cake.AddFlavor("Chocolate");
            return this;
        }
        public CakeBuilder AddStrawberry()
        {
            _cake.AddFlavor("Strawberry");
            return this;
        }

        public CakeBuilder AddSprinkles()
        {
            _cake.AddFlavor("Sprinkles");
            return this;
        }
        public CakeBuilder AddButterCream()
        {
            _cake.AddFlavor("ButterCream");
            return this;
        }

        public CakeBuilder AddFlowers()
        {
            _cake.AddFlavor("Flowers");
            return this;
        }

        public Cake Build()
        {
            return _cake;
        }
    }
}
