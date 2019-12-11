using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Practise
{
    static class EM 
    {
        public static void NewMethod(this MainFunction obj)
        {
            Console.WriteLine("New Method of existing mainFunction");
        }

        public static string toCsv(this IEnumerable<long> obj)
        {
            return string.Join(",",obj);
        }
       
    }

}
