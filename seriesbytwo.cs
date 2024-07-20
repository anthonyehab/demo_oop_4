using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    internal class seriesbytwo : Iseries
    {
        public int current {get;set;}
        public void getnext()
        {
            current += 2;
        }

      
    }
}
