using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{

    class Test
    {
        static int a;
        static int b, c;

        static Test()
        {
            a = 10;
        }
        public Test()
        {
            b = 20;
        }
        public static void write()
        {
            Console.WriteLine(a + "\t" + b + "\t" + c);
        }
        //public void write2()
        //{
        //    Console.WriteLine(a + "\t" + b + "\t" + c);
        //}
    }

}
