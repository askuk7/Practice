using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Binary2Int : IPractise
    {
        public void Test()
        {
            string s = "100";
            int number = Convert.ToInt32(s, 2);
            Console.WriteLine(number);

            int Number2 = 8;

            string s2 = Convert.ToString(Number2, 2);
            Console.WriteLine(s2);

        }
    }
}
