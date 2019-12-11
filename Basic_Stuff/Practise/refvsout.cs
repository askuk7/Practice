using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class refvsout:IPractise
    {
        public void Test()
        {
            int val1 = 0; //must be initialized 
            int val2; //optional

            Example1(ref val1);
            Console.WriteLine(val1); // val1=1

            Example2(out val2);
            Console.WriteLine(val2); // val2=2
        }

        static void Example1(ref int value) //called method
        {
            value = 1;
        }
        static void Example2(out int value) //called method
        {
            value = 2; //must be initialized 
        }
    }
}
