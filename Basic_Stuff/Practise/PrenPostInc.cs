using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class PrenPostInc:IPractise
    {
        public void Test()
        {
            int x = 7;
            int y = 20;
            int z;
            Console.WriteLine(x++);
            Console.WriteLine("{0},{1},{2}",y++,y++,y++);
            Console.WriteLine(z = ++x + y++);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
