using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class ObjectReferenceEqual:IPractise
    {
        public void Test()
        {
            string s1 = "Somthing";
            string s2 = "Somthing";
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            Console.ReadKey();
        }
    }
}
