using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    internal class mytype : Imytype //--> implement
    {
        public int Id { get; set; }
        public void myfun(int x)
        {
            Console.WriteLine($"hello route : x={x}, id ={Id}");

        }
    }
}
