using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class ParamTest : IPractise
    {
        public void Test()
        {
            printParamNumber(1, 2, 3, 4);
        }

        private void printParamNumber(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
