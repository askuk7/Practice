using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class RandomGenrator : IPractise
    {
        public void Test()
        {
            Random random = new Random();
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.NextDouble());
            }


        }
    }
}
