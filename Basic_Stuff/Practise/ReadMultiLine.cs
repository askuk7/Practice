using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class  ReadMultiLine:IPractise
    {
        public void Test()
        {
            string line = "";
            while (line != null)
            {
                line = Console.ReadLine();
                Console.WriteLine(line);
            }
            
        }
        
    }
    
}
