using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    internal interface Iseries
    {
        public int current { get; set; }
        public void getnext();
        public void reset()
        { 
        
        current = 0;
        }
    }
}
