using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    internal interface Imytype
    {
        /// 1- signature for property
        public int Id { get; set; }

        ///2-signature for method
        public void myfun(int x);


        ///3- default implemented method {c# 8.0 feature  (. net core 3.1  2019)}
        public void print()
        {
            Console.WriteLine("hello default implemented method from interface");

        }
    }
}
