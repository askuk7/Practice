using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class NumberRev : IPractise
    {
        public void Test()
        {
            int Number = 6745;
            char[] nArr = Number.ToString().ToCharArray();

            Console.WriteLine(new string(nArr.Reverse().ToArray()));

            int rNUmber=default(Int32);
            while (Number > 0)
            {
                int remainder = Number % 10;
                rNUmber = (rNUmber * 10)+remainder;
                Number = Number / 10;
            }

            Console.WriteLine(rNUmber);

            string check = "hello";

            check.Reverse();

            Console.WriteLine(check[2]);            
           
            
        }
    }
}
