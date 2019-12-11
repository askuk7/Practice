using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Prime : IPractise
    {
        public void Test()
        {
            int tCase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(2);
            if (tCase > 2)
            {
                for (int i = 3; i < tCase; i = i + 2)
                {
                    if (IsPrime(i))
                        Console.WriteLine(i);
                }
            }

        }
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
