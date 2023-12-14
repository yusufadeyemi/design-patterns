using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    internal class Counter
    {
        private static Counter? instance;
        public int NoOfVisitor { get; private set; }
        private Counter() { }
        public void IncrementCounter()
        {
            NoOfVisitor++;
        }
       

        public static Counter GetInstance() { 
            if(instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }
       
    }
}
